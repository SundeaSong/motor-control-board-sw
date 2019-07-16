using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;           //使用DEBUG

namespace WindowsFormsApp
{
   public  class ModbusClient
    {

       //ModbusClient与PLC通信消息包括: 设备地址 设备站点 数据地址 ,plc返回数据是有crc校验的数据
        List<byte> rxbuffer = new List<byte>(255);
        public const int TIMEOUT = 200;                  //ms单位

        public int[,] AnalogArr;
        public int[,] SwitchArr;
        private ArrayList SendArray = new ArrayList();
        private SerialPort SPort = new SerialPort();
        public bool IsOpen = false;
        public string PortName = "";
        public int PortAddr = 1;
        public bool PortFlag = false;
        public int RcvTime = 0;
        public bool isRead = true;

        public ModbusClient()
        { }
       //申请 数字量 开关量个数
        public ModbusClient(int AnalogNum, int SwitchNum)
        {
            AnalogArr = new int[256, AnalogNum];
            SwitchArr = new int[256, SwitchNum];
        }

        //打开 串口号，波特率，数据位，停止位，读超时，写超时
        public bool Open(string portName, int baudRate, int databits, Parity parity, StopBits stopBits, int ReadTimeout, int WriteTimeout)
        {
            try
            {
                if (!SPort.IsOpen)
                {
                    PortName = portName;
                    SPort.PortName = portName;
                    SPort.BaudRate = baudRate;
                    SPort.DataBits = databits;
                    SPort.Parity = parity;
                    SPort.StopBits = stopBits;
                    SPort.ReadTimeout = ReadTimeout;
                    SPort.WriteTimeout = WriteTimeout;
                    SPort.Open();
//                    ThreadPool.QueueUserWorkItem(new WaitCallback(SendMethod));
                }
                IsOpen = true;
                return true;
            }
            catch { return false; }
        }

        //关闭串口
        public bool Close()
        {
            try
            {
                if (SPort.IsOpen)
                    SPort.Close();
                IsOpen = false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        #region 检查CRC校验
        private bool CheckResponse(byte[] response, int Length)
        {
            byte[] CRC = new byte[2];
            GetCRC(response, Length, ref CRC);
            try
            {
                if (CRC[0] == response[Length - 2] && CRC[1] == response[Length - 1])
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region 计算CRC
        private void GetCRC(byte[] message, int Length, ref byte[] CRC)
        {
            ushort CRCFull = 0xFFFF;
            byte CRCHigh = 0xFF, CRCLow = 0xFF;
            char CRCLSB;

            for (int i = 0; i < Length - 2; i++)
            {
                CRCFull = (ushort)(CRCFull ^ message[i]);

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (char)(CRCFull & 0x0001);
                    CRCFull = (ushort)((CRCFull >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                        CRCFull = (ushort)(CRCFull ^ 0xA001);
                }
            }
            CRC[1] = CRCHigh = (byte)((CRCFull >> 8) & 0xFF);
            CRC[0] = CRCLow = (byte)(CRCFull & 0xFF);
        }
        #endregion

        /// <summary>
        /// 向写plc写数据，站号，地址
        /// </summary>
        public Int16 WritePLC(Int16 station, Int16 CommNum, Int16 Startaddress, Int16 RegistNum, UInt16[] Values)
        {
            lock (SPort)        //发送端口需要lock 线程间不能同时调用
            {
                try
                {
                    DateTime Starttime = DateTime.Now;
                    Int16 count = (Int16)(9 + RegistNum * 2);
                    byte[] TxBytes = new byte[count];       //申请 发送数据缓存数量
                    byte[] RxBytes = new byte[count];       //申请 接收数据缓存数量

                    TxBytes[0] = (byte)station;             //站号
                    TxBytes[1] = (byte)CommNum;             //功能码
                    TxBytes[2] = (byte)(Startaddress >> 8); //开始位
                    TxBytes[3] = (byte)(Startaddress & 0xFF);
                    TxBytes[4] = (byte)(RegistNum >> 8);    //数据长度
                    TxBytes[5] = (byte)(RegistNum & 0xFF);
                    TxBytes[6] = (byte)(RegistNum * 2);     //跟随bytes数据长度

                    for (int i = 0; i < RegistNum; i++)
                    {
                        TxBytes[7 + (i * 2)] = (byte)(Values[i] >> 8);
                        TxBytes[8 + (i * 2)] = (byte)(Values[i] & 0xFF);
                    }

                    byte[] CRC = new byte[2];
                    GetCRC(TxBytes, TxBytes.Length, ref CRC);
                    TxBytes[TxBytes.Length - 2] = CRC[0];
                    TxBytes[TxBytes.Length - 1] = CRC[1];

                    SPort.DiscardInBuffer();        //清空缓存
                    SPort.DiscardOutBuffer();
                    SPort.Write(TxBytes, 0, TxBytes.Length);

                    Console.Write("* Send: ");
                    for (int i = 0; i < TxBytes.Length; i++)
                    {
                        Console.Write("{0:X2} ", TxBytes[i]);
                    }
                    Console.WriteLine();

                    rxbuffer.Clear();       //清空缓存
                    int timeout = 0;
                    Console.Write("* Recv: ");
                    do
                    {
                        Thread.Sleep(1);
                        int ReadLength = SPort.BytesToRead;    //记录下缓冲区的字节个数         //SPort.Read(RxBytes, 0, SPort.BytesToRead);

                        if (ReadLength > 0)
                        {
                            byte[] buf = new byte[ReadLength];     //声明一个临时数组存储当前来的串口数据 
                            SPort.Read(buf, 0, ReadLength);        //读取缓冲数据到buf中，同时将这串数据从缓冲区移除 
                            rxbuffer.AddRange(buf);
                            RxBytes = new byte[rxbuffer.Count];              //定义byte[]型数组
                            rxbuffer.CopyTo(0, RxBytes, 0, rxbuffer.Count);  //复制数据

                            for (int i = 0; i < RxBytes.Length; i++)
                            {
                                Console.Write("{0:X2} ", RxBytes[i]);
                            }

                            if (RxBytes.Length == 5)
                            {
                                
                                //for (int i = 0; i < 5; i++)
                                //{
                                //    Console.Write("{0:X2} ", RxBytes[i]);
                                //}
                                Console.WriteLine();

                                if (CheckResponse(RxBytes, RxBytes.Length))      //错误状态 CRC校验ok
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("* Send Command error!");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    return 0x01;
                                }
                            }
                            else if (RxBytes.Length == 8)   //多字节 单字节接收都是正常返回都是8位
                            {
                                //Console.Write("* Recv: ");
                                //for (int i = 0; i < 5; i++)
                                //{
                                //    Console.Write("{0:X2} ", RxBytes[i]);
                                //}
                                Console.WriteLine();
                                if (CheckResponse(RxBytes, RxBytes.Length))      //正常状态 CRC校验ok
                                {
                                    if (RxBytes[1] == TxBytes[1])
                                    {
                                        TimeSpan ts = DateTime.Now - Starttime;
                                        Console.WriteLine("* takes：" + ts.TotalMilliseconds.ToString("0 ms"));
                                        return 0;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("* CRC Check error!");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        return 0x02;
                                    }
                                }
                            }
                        }

                        timeout++;                          //超时检测
                        if (timeout > TIMEOUT)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("* Receive messgae time out!");
                            Console.ForegroundColor = ConsoleColor.Green;
                            return 0x03;
                        }
                    }
                    while (true);

                }
                catch (Exception ex)
                {
                    //  throw;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("* Send message error!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    return 0x04;
                }
            }
        }

       //Console.ForegroundColor = ConsoleColor.Red;
       //Console.WriteLine("* Open port fail");
       //Console.ForegroundColor = ConsoleColor.Green;
        /// <summary>
        /// 读plc数据，站号，地址 读写长度为十六位长度
        /// </summary>
        public Int16 ReadPLC(Int16 station, Int16 CommNum, Int16 Startaddress, Int16 RegistNum, ref UInt16[] Values)
        {
            lock (SPort)
            {
                try
                {
                    DateTime Starttime = DateTime.Now;
                    Int16 count = (Int16)(5 + RegistNum * 2);
                    byte[] TxBytes = new byte[8];           //申请 发送数据缓存数量
                    byte[] RxBytes = new byte[count];       //申请 接收数据缓存数量

                    TxBytes[0] = (byte)station;             //站号
                    TxBytes[1] = (byte)CommNum;             //功能码
                    TxBytes[2] = (byte)(Startaddress >> 8); //开始位
                    TxBytes[3] = (byte)(Startaddress & 0xFF);
                    TxBytes[4] = (byte)(RegistNum >> 8);    //数据长度
                    TxBytes[5] = (byte)(RegistNum & 0xFF);

                    byte[] CRC = new byte[2];
                    GetCRC(TxBytes, TxBytes.Length, ref CRC);
                    TxBytes[TxBytes.Length - 2] = CRC[0];
                    TxBytes[TxBytes.Length - 1] = CRC[1];

                    SPort.DiscardInBuffer();        //清空缓存
                    SPort.DiscardOutBuffer();
                    SPort.Write(TxBytes, 0, TxBytes.Length);

                    Console.Write("* Send: ");
                    for (int i = 0; i < TxBytes.Length; i++)
                    {
                        Console.Write("{0:X2} ", TxBytes[i]);
                    }
                    Console.WriteLine();

                    rxbuffer.Clear();       //清空缓存
                    int timeout = 0;
                    Console.Write("* Recv: ");
                    do
                    {
                        Thread.Sleep(1);
                        int ReadLength = SPort.BytesToRead;    //记录下缓冲区的字节个数         //SPort.Read(RxBytes, 0, SPort.BytesToRead);
                       
                        
                        if (ReadLength > 0)
                        {
                            byte[] buf = new byte[ReadLength];     //声明一个临时数组存储当前来的串口数据 
                            SPort.Read(buf, 0, ReadLength);        //读取缓冲数据到buf中，同时将这串数据从缓冲区移除 
                            rxbuffer.AddRange(buf);
                            RxBytes = new byte[rxbuffer.Count];              //定义byte[]型数组
                            rxbuffer.CopyTo(0, RxBytes, 0, rxbuffer.Count);  //复制数据

                            
                            for (int i = 0; i < RxBytes.Length; i++ )                            
                            {
                                Console.Write("{0:X2} ", RxBytes[i]);
                            }


                            if (RxBytes.Length == 5)
                            {
                                //Console.Write("* Recv: ");
                                //for (int i = 0; i < RxBytes.Length; i++)
                                //{
                                //    Console.Write("{0:X2} ", RxBytes[i]);
                                //}
                                Console.WriteLine();

                                if (CheckResponse(RxBytes, RxBytes.Length))  //错误状态 CRC校验ok
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("* Send Command error!");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    return 0x01;
                                }
                            }
                            else if (RxBytes.Length == count)                 //计算返回的字符数量
                            {
                                //Console.Write("* Recv: ");
                                //for (int i = 0; i < RxBytes.Length; i++)
                                //{
                                //    Console.Write("{0:X2} ", RxBytes[i]);
                                //}
                                Console.WriteLine();

                                if (CheckResponse(RxBytes, RxBytes.Length))   //正常状态 CRC校验ok
                                {
                                    if (RxBytes[1] == TxBytes[1])
                                    {
                                        for (int i = 0; i < RegistNum; i++)
                                        {
                                            Values[i] = (RxBytes[4 + (i * 2)]);//L
                                            Values[i] |= (UInt16)(RxBytes[3 + (i * 2)] << 8);//H
                                        }
                                        TimeSpan ts = DateTime.Now - Starttime;
                                        Console.WriteLine("* takes：" + ts.TotalMilliseconds.ToString("0 ms"));
                                        return 0;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("* CRC Check error!");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        return 0x02;
                                    }
                                }
                            }
                        }

                        timeout++;                          //超时检测
                        if (timeout > TIMEOUT)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("* Receive messgae time out!");
                            Console.ForegroundColor = ConsoleColor.Green;
                            return 0x03;
                        }
                    }
                    while (true);

                }
                catch (Exception ex)
                {
                    //  throw;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("* Send message error!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    return 0x04;
                }
            }
        }
    }
}
