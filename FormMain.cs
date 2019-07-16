using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkinSharp;
using System.Threading;
using System.Diagnostics;                   //使用DEBUG输出行
using System.IO;                            //调用系统文件目录
using System.IO.Ports;

using ForGeneralUse;                        //引用其他类的命名空间
using System.Runtime.InteropServices;


using IniFile;
using CsvFile;                              //自定义文件类


namespace WindowsFormsApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
  
        //线程间传递参数使用
        public struct CommandStructDef//定义结构体是成员一定加public 
        {
            public Int16 flag;
            public Int16 ID;
            public Int16 Strads;
            public Int16 Len;
            public UInt16[] Buff;
        }
        public CommandStructDef csd;
        //声明定义一个写结构体

        //声明一个线程
        Thread Threadcycletask;        //需要引入System.Threading命名空间

        private CheckBox[] CHK_INPUT;
        private CheckBox[] CHK_OUTPUT;
        private UInt16 HomeSenCtrl;
        public TextBox[] txt_CurrentPosition;
        private Label[] lab_Motionstatus;
        private TextBox[] txt_TargetPosition;
        private Button[] btn_RelMotion;
        private Button[] btn_AbsMotion;
        private Button[] btn_Emgstop;
        private Label[] lab_Homestatus;
        private Button[] btn_Gohome;

        public DataTable AxisParamentDT;     //所有的窗体类的数据都以数据表传递
        


        private void Form1_Load(object sender, EventArgs e)
        {
            ConsoleShow.Init();
            DisplayLog(1, "* Motor Control board debug software V2.0");

            Initalldata();

            AxisParamentDT = new DataTable();
            AxisParamentDT.Columns.Add("Name", System.Type.GetType("System.String"));
            AxisParamentDT.Columns.Add("Axis1", System.Type.GetType("System.String"));
            AxisParamentDT.Columns.Add("Axis2", System.Type.GetType("System.String"));
            AxisParamentDT.Columns.Add("Axis3", System.Type.GetType("System.String"));
            AxisParamentDT.Columns.Add("Axis4", System.Type.GetType("System.String"));
            AxisParamentDT.Columns.Add("Describe", System.Type.GetType("System.String"));

            LoadGridView();

            string path;
            path = Application.StartupPath + @"\Log";                   //初始化文件夹
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                DisplayLog(1,"* Create " + path);
            }
            path = Application.StartupPath + @"\Config";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Debug.WriteLine("Create " + path);
            }
            path = Application.StartupPath + @"\Screenshot";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                DisplayLog(1, "Create " + path);
            }

            OpenUseSerialPort();//打开可用串口

            Threadcycletask = new Thread(CycleTask);
            Threadcycletask.IsBackground = true;                                 //设置为背景线程，主线程一旦推出，该线程也不等待而立即结束
            Threadcycletask.Start();                                             //运行委托

        }

        /// <summary>
        /// 多线程 循环任务1 查询是否有数据接收完成
        /// </summary>
        ///

        void CycleTask()            //此任务负责 循环读取当前状态
        {
            while (true)
            {
                this.tTimeNow.Text = DateTime.Now.ToString();
                Thread.Sleep(300);   //线程延时100ms

                //*****************读取Axis1状态信息**********************************/
                UInt16[] Axis1state = new UInt16[8];
                Int16 result1 = mc.ReadPLC(0x01, 0x03, 2046, 4, ref Axis1state);
                DisplayLog(0, "* Loop Axis1 state [ " + result1 + " ]");

                UInt16[] Axis2state = new UInt16[8];
                Int16 result2 = mc.ReadPLC(0x01, 0x03, 2046 + 60, 4, ref Axis2state);
                DisplayLog(0, "* Loop Axis2 state [ " + result2 + " ]");

                UInt16[] Axis3state = new UInt16[8];
                Int16 result3 = mc.ReadPLC(0x01, 0x03, 2046 + 120, 4, ref Axis3state);
                DisplayLog(0, "* Loop Axis3 state [ " + result3 + " ]");

                UInt16[] Axis4state = new UInt16[8];
                Int16 result4 = mc.ReadPLC(0x01, 0x03, 2046 + 180, 4, ref Axis4state);
                DisplayLog(0, "* Loop Axis4 state [ " + result4 + " ]");

                UInt16[] InputStatus = new UInt16[1];
                result4 = mc.ReadPLC(0x01, 0x03, 2242, 1, ref InputStatus);
                DisplayLog(0, "* Loop read input state [ " + result4 + " ]");

                if ((result1 == 0)&&(result2 == 0)&&(result3 == 0)&&(result4 == 0))
                {
                    this.Invoke((EventHandler)delegate          //委托更新显示
                    {
                        //if ((Axis1state[1] & 0xff) == 0)    //home status
                        //{
                        //    r_AxisSenStatus |= 0x0200;
                        //CHK_INPUT[0].BackColor = Color.OrangeRed;
                        //}
                        if ((Axis1state[0] & 0xff) >0 )      //h limit
                        {
                            CHK_INPUT[1].BackColor = Color.OrangeRed;
                        }
                        else
                        {
                            CHK_INPUT[1].BackColor = this.BackColor;
                        }
                        if ((Axis1state[0]&0xff00) >0)    //l limit
                        {
                            CHK_INPUT[2].BackColor = Color.OrangeRed;
                        }
                        else
                        {
                            CHK_INPUT[2].BackColor = this.BackColor;
                        }
                        //axis2
                        if ((Axis2state[0] & 0xff) >0)      //h limit
                        {
                            CHK_INPUT[4].BackColor = Color.OrangeRed;
                        }
                        else
                        {
                            CHK_INPUT[4].BackColor = this.BackColor;
                        }
                        if ((Axis2state[0] & 0xff00) >0)    //l limit
                        {
                            CHK_INPUT[5].BackColor = Color.OrangeRed;
                        }
                        else
                        {
                            CHK_INPUT[5].BackColor = this.BackColor;
                        }
                        //axis3
                        if ((Axis3state[0] & 0xff) >0)      //h limit
                        {
                            CHK_INPUT[7].BackColor = Color.OrangeRed;
                        }
                        else
                        {
                            CHK_INPUT[7].BackColor = this.BackColor;
                        }
                        if ((Axis3state[0] & 0xff00) >0)    //l limit
                        {
                            CHK_INPUT[8].BackColor = Color.OrangeRed;
                        }
                        else
                        {
                            CHK_INPUT[8].BackColor = this.BackColor;
                        }
                        //axis4
                        
                        if ((Axis4state[0] & 0xff) >0)      //h limit
                        {
                            CHK_INPUT[10].BackColor = Color.OrangeRed;
                        }
                        else
                        {
                            CHK_INPUT[10].BackColor = this.BackColor;
                        }
                        if ((Axis4state[0] & 0xff00) >0)    //l limit
                        {
                            CHK_INPUT[11].BackColor = Color.OrangeRed;
                        }
                        else
                        {
                            CHK_INPUT[11].BackColor = this.BackColor;
                        }

                        DisplayX_INStatus(HomeSenCtrl,InputStatus[0]);

                        /*************** Axis1 ****************************************/
                        if ((Axis1state[1] & 0xff) == 0)//home status
                        {
                            lab_Homestatus[0].BackColor = Color.Yellow;
                        }
                        else
                        {
                            lab_Homestatus[0].Text = (Axis1state[1] & 0xff).ToString();
                            lab_Homestatus[0].BackColor = Color.Lime;
                        }
                        int Motstatus = (Axis1state[1] & 0xff00) >> 8;//motor status
                        if ( Motstatus == 0)
                        {
                            lab_Motionstatus[0].BackColor = Color.Yellow;
                            lab_Motionstatus[0].Text = "Stop";         
                        }
                        else if (Motstatus == 1)
                        {
                            lab_Motionstatus[0].BackColor = Color.Lime;
                            lab_Motionstatus[0].Text = "Accel";
                        }
                        else if (Motstatus == 2)
                        {
                            lab_Motionstatus[0].BackColor = Color.Lime;
                            lab_Motionstatus[0].Text = "Decel";
                        }
                        else if (Motstatus == 3)
                        {
                            lab_Motionstatus[0].BackColor = Color.Lime;
                            lab_Motionstatus[0].Text = "Run";
                        }

                        Int32 cPosition = (Int32)Axis1state[3] << 16;
                        cPosition = Axis1state[2] + cPosition;
                        txt_CurrentPosition[0].Text = cPosition.ToString();

                        ///*************** Axis2 ****************************************/
                        if ((Axis2state[1] & 0xff) == 0)//home status
                        {
                            lab_Homestatus[1].BackColor = Color.Yellow;
                        }
                        else
                        {
                            lab_Homestatus[1].Text = (Axis2state[1] & 0xff).ToString();
                            lab_Homestatus[1].BackColor = Color.Lime;
                        }
                        Motstatus = (Axis2state[1] & 0xff00) >> 8;//motor status
                        if ( Motstatus == 0)
                        {
                            lab_Motionstatus[1].BackColor = Color.Yellow;
                            lab_Motionstatus[1].Text = "Stop";         
                        }
                        else if (Motstatus == 1)
                        {
                            lab_Motionstatus[1].BackColor = Color.Lime;
                            lab_Motionstatus[1].Text = "Accel";
                        }
                        else if (Motstatus == 2)
                        {
                            lab_Motionstatus[1].BackColor = Color.Lime;
                            lab_Motionstatus[1].Text = "Decel";
                        }
                        else if (Motstatus == 3)
                        {
                            lab_Motionstatus[1].BackColor = Color.Lime;
                            lab_Motionstatus[1].Text = "Run";
                        }

                        cPosition = (Int32)Axis2state[3] << 16;
                        cPosition = Axis2state[2] + cPosition;
                        txt_CurrentPosition[1].Text = cPosition.ToString();

                        ///*************** Axis3 ****************************************/
                        if ((Axis3state[1] & 0xff) == 0)//home status
                        {
                            lab_Homestatus[2].BackColor = Color.Yellow;
                        }
                        else
                        {
                            lab_Homestatus[2].Text = (Axis3state[1] & 0xff).ToString();
                            lab_Homestatus[2].BackColor = Color.Lime;
                        }
                        Motstatus = (Axis3state[1] & 0xff00) >> 8;//motor status
                        if (Motstatus == 0)
                        {
                            lab_Motionstatus[2].BackColor = Color.Yellow;
                            lab_Motionstatus[2].Text = "Stop";
                        }
                        else if (Motstatus == 1)
                        {
                            lab_Motionstatus[2].BackColor = Color.Lime;
                            lab_Motionstatus[2].Text = "Accel";
                        }
                        else if (Motstatus == 2)
                        {
                            lab_Motionstatus[2].BackColor = Color.Lime;
                            lab_Motionstatus[2].Text = "Decel";
                        }
                        else if (Motstatus == 3)
                        {
                            lab_Motionstatus[2].BackColor = Color.Lime;
                            lab_Motionstatus[2].Text = "Run";
                        }

                        cPosition = (Int32)Axis3state[3] << 16;
                        cPosition = Axis3state[2] + cPosition;
                        txt_CurrentPosition[2].Text = cPosition.ToString();

                        ///*************** Axis4 ****************************************/

                        if ((Axis4state[1] & 0xff) == 0)//home status
                        {
                            lab_Homestatus[3].BackColor = Color.Yellow;
                        }
                        else
                        {
                            lab_Homestatus[3].Text = (Axis4state[1] & 0xff).ToString();
                            lab_Homestatus[3].BackColor = Color.Lime;
                        }
                        Motstatus = (Axis4state[1] & 0xff00) >> 8;//motor status
                        if (Motstatus == 0)
                        {
                            lab_Motionstatus[3].BackColor = Color.Yellow;
                            lab_Motionstatus[3].Text = "Stop";
                        }
                        else if (Motstatus == 1)
                        {
                            lab_Motionstatus[3].BackColor = Color.Lime;
                            lab_Motionstatus[3].Text = "Accel";
                        }
                        else if (Motstatus == 2)
                        {
                            lab_Motionstatus[3].BackColor = Color.Lime;
                            lab_Motionstatus[3].Text = "Decel";
                        }
                        else if (Motstatus == 3)
                        {
                            lab_Motionstatus[3].BackColor = Color.Lime;
                            lab_Motionstatus[3].Text = "Run";
                        }

                        cPosition = (Int32)Axis4state[3] << 16;
                        cPosition = Axis4state[2] + cPosition;
                        txt_CurrentPosition[3].Text = cPosition.ToString();              
                        
                        //Int32 Value = Cstate[2];
                        //for (int i = 0; i < 12; i++)            //16位数组，后四位空
                        //{
                        //    if (Value % 2 == 1)
                        //        CHK_INPUT[i].Checked = true;
                        //    else
                        //        CHK_INPUT[i].Checked = false;
                        //    Value /= 2;
                        //}
                        //Value = Cstate[4];
                        //for (int i = 0; i < 8; i++)
                        //{
                        //    if (Value % 2 == 1)
                        //        CHK_OUTPUT[i].Checked = true;
                        //    else
                        //        CHK_OUTPUT[i].Checked = false;
                        //    Value /= 2;
                        //}
                    });
                }

                //***************************************************************/
            }
        }
        private void DisplayX_INStatus(UInt16 ctrl, UInt16 InX_Value)
        {
            UInt16 Value = InX_Value;

            for (int i = 0; i < 14; i++)            //16位数组，后2位空
            {
                if (Value % 2 == 1)
                    CHK_INPUT[i].Checked = true;
                else
                    CHK_INPUT[i].Checked = false;
                Value /= 2;
            }

        }

        void Initalldata()
        {
                
            CHK_OUTPUT = new CheckBox[16];       
            csd.ID = 0;
            csd.Strads = 0;
            csd.Len = 0;
            csd.Buff = new UInt16[100];

            CHK_INPUT = new CheckBox[16];
            CHK_INPUT[0] = chk_X1;
            CHK_INPUT[1] = chk_X2;
            CHK_INPUT[2] = chk_X3;
            CHK_INPUT[3] = chk_X4;

            CHK_INPUT[4] = chk_X5;
            CHK_INPUT[5] = chk_X6;
            CHK_INPUT[6] = chk_X7;
            CHK_INPUT[7] = chk_X8;

            CHK_INPUT[8] = chk_X9;
            CHK_INPUT[9] = chk_X10;
            CHK_INPUT[10] = chk_X11;
            CHK_INPUT[11] = chk_X12;
            CHK_INPUT[12] = chk_X13;
            CHK_INPUT[13] = chk_X14;

            for (int i = 0; i < 14; i++)        //不可界面触发，只读
            {
                CHK_INPUT[i].Enabled = false;
            }
            CHK_OUTPUT = new CheckBox[16];
            CHK_OUTPUT[0] = chk_Y1;
            CHK_OUTPUT[1] = chk_Y2;
            CHK_OUTPUT[2] = chk_Y3;
            CHK_OUTPUT[3] = chk_Y4;

            CHK_OUTPUT[4] = chk_Y5;
            CHK_OUTPUT[5] = chk_Y6;
            CHK_OUTPUT[6] = chk_Y7;
            CHK_OUTPUT[7] = chk_Y8;

            for (int i = 0; i < 8; i++)
            {
                CHK_OUTPUT[i].Click += new EventHandler(chk_outputs_click);          //用代码动态连接事件
            }

            txt_CurrentPosition = new TextBox[4];
            txt_CurrentPosition[0] = Axis1CurrentPosition;
            txt_CurrentPosition[1] = Axis2CurrentPosition;
            txt_CurrentPosition[2] = Axis3CurrentPosition;
            txt_CurrentPosition[3] = Axis4CurrentPosition;

            lab_Motionstatus = new Label[4];
            lab_Motionstatus[0] = Axis1Motionstatus;
            lab_Motionstatus[1] = Axis2Motionstatus;
            lab_Motionstatus[2] = Axis3Motionstatus;
            lab_Motionstatus[3] = Axis4Motionstatus;

            txt_TargetPosition = new TextBox[4];
            txt_TargetPosition[0] = Axis1TargetPostion;
            txt_TargetPosition[1] = Axis2TargetPostion;
            txt_TargetPosition[2] = Axis3TargetPostion;
            txt_TargetPosition[3] = Axis4TargetPostion;

            for (int i = 0; i < 4; i++)
            {
                txt_TargetPosition[i].Text = "0";
            }
            btn_RelMotion = new Button[4];
            btn_RelMotion[0] = btn_Axis1RelMotion;
            btn_RelMotion[1] = btn_Axis2RelMotion;
            btn_RelMotion[2] = btn_Axis3RelMotion;
            btn_RelMotion[3] = btn_Axis4RelMotion;
            for (int i = 0; i < 4; i++)
            {
                btn_RelMotion[i].Click += new EventHandler(btn_RelMotion_click);          //用代码动态连接事件
            }

            btn_AbsMotion = new Button[4];
            btn_AbsMotion[0] = btn_Axis1AbsMotion;
            btn_AbsMotion[1] = btn_Axis2AbsMotion;
            btn_AbsMotion[2] = btn_Axis3AbsMotion;
            btn_AbsMotion[3] = btn_Axis4AbsMotion;
            for (int i = 0; i < 4; i++)
            {
                btn_AbsMotion[i].Click += new EventHandler(btn_AbsMotion_click);          //用代码动态连接事件
            }

            btn_Emgstop = new Button[4];
            btn_Emgstop[0] = btn_Axis1Emgstop;
            btn_Emgstop[1] = btn_Axis2Emgstop;
            btn_Emgstop[2] = btn_Axis3Emgstop;
            btn_Emgstop[3] = btn_Axis4Emgstop;
            for (int i = 0; i < 4; i++)
            {
                btn_Emgstop[i].Click += new EventHandler(btn_Emgstop_click);            //用代码动态连接事件
            }

            lab_Homestatus = new Label[4];
            lab_Homestatus[0] = Axis1Homestatus;
            lab_Homestatus[1] = Axis2Homestatus;
            lab_Homestatus[2] = Axis3Homestatus;
            lab_Homestatus[3] = Axis4Homestatus;

            btn_Gohome = new Button[4];
            btn_Gohome[0] = btn_Axis1Gohome;
            btn_Gohome[1] = btn_Axis2Gohome;
            btn_Gohome[2] = btn_Axis3Gohome;
            btn_Gohome[3] = btn_Axis4Gohome;
            for (int i = 0; i < 4; i++)
            {
                btn_Gohome[i].Click += new EventHandler(btn_Gohome_click);            //用代码动态连接事件
            }

        }

        private void btn_RelMotion_click(object sender, EventArgs e)
        {
            Button btn = (Button)(sender); // 获取index
            try
            {
                Int16 AxisNum = (Int16)btn.TabIndex;

                DisplayLog(1, "* Axis" + AxisNum + " relmotion");
                CommandStructDef c;
                c.Buff = new UInt16[6];      //申请数组空间

                c.ID = 1;
                c.Strads =(Int16)( 2000 + AxisNum * 60 + 34);

                c.Len = 4;
                c.Buff[0] = 1;
                c.Buff[1] = 0;

                Int32 position = Convert.ToInt32(txt_TargetPosition[AxisNum].Text);
                c.Buff[2] = (UInt16)(position & 0xffff);
                c.Buff[3] = (UInt16)(position >> 16);

                Int16 result = mc.WritePLC(c.ID, 0x10, c.Strads, c.Len, c.Buff);  //写入目标位置
                DisplayLog(1, "* Write to Driverboard command [ " + result + " ]");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
        }
        private void btn_AbsMotion_click(object sender, EventArgs e)
        {
            Button btn = (Button)(sender); // 获取index
            try
            {
                Int16 AxisNum = (Int16)btn.TabIndex;
                DisplayLog(1, "* Axis" + AxisNum + " abbmotion");
                CommandStructDef c;
                c.Buff = new UInt16[4];      //申请数组空间

                c.ID = 1;
                c.Strads = (Int16)(2000 + AxisNum * 60 + 35);
                c.Len = 3;
                c.Buff[0] = 1;

                Int32 position = Convert.ToInt32(txt_TargetPosition[AxisNum].Text);
                c.Buff[1] = (UInt16)(position & 0xffff);
                c.Buff[2] = (UInt16)(position >> 16);

                Int16 result = mc.WritePLC(c.ID, 0x10, c.Strads, c.Len, c.Buff);    //写入目标位置
                DisplayLog(1, "* Write to Driverboard command [ " + result + " ]");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
        }
        private void btn_Emgstop_click(object sender, EventArgs e)
        {
            Button btn = (Button)(sender); // 获取index
            try
            {         
                Int16 AxisNum = (Int16)btn.TabIndex;
                DisplayLog(1, "* Axis" + AxisNum + " Emgstop");
                CommandStructDef c;
                c.Buff = new UInt16[1];      //申请数组空间

                c.ID = 1;
                c.Strads = (Int16)(2000 + AxisNum * 60 + 33);
                c.Len = 1;

                //if (btn_Emgstop[AxisNum].BackColor == Color.Red)
                //{
                //    c.Buff[0] = 0;
                //    btn_Emgstop[AxisNum].BackColor = SystemColors.Control;
                //}
                //else
                //{
                //    c.Buff[0] = 1;
                //    btn_Emgstop[AxisNum].BackColor = Color.Red;
                //}
                c.Buff[0] = 1;  //边沿信号，自动清0
                Int16 result = mc.WritePLC(c.ID, 0x10, c.Strads, c.Len, c.Buff);  //写入目标位置
                DisplayLog(1, "* Write to Driverboard command [ " + result + " ]");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
        }

        private void btn_Gohome_click(object sender, EventArgs e)
        {
            Button btn = (Button)(sender); // 获取index
            try
            {
                Int16 AxisNum = (Int16)btn.TabIndex;
                DisplayLog(1, "* Axis" + AxisNum+" gohome");
                CommandStructDef c;
                c.Buff = new UInt16[1];      //申请数组空间

                c.ID = 1;
                c.Strads = (Int16)(2000 + AxisNum * 60 + 32);
                c.Len = 1;
                c.Buff[0] = 1;
                Int16 result = mc.WritePLC(c.ID, 0x10, c.Strads, c.Len, c.Buff);  //写入目标位置
                DisplayLog(1, "* Write to Driverboard command[ " + result + " ]");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
        }

        private void chk_outputs_click(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)(sender); // 获取index
            try
            {
                if (csd.flag == 0)        //判断在空闲状态
                {
                    UInt16 OutputStatus = 0;

                    for (int i = 0; i < 8; i++)
                    {
                        if (CHK_OUTPUT[i].Checked == true)
                        {
                            OutputStatus |= (UInt16)(1 << i);
                        }
                    }
                    DisplayLog(1, "* Output status: 0x" + OutputStatus.ToString("04X"));
                    CommandStructDef c;
                    c.Buff = new UInt16[1];      //申请数组空间

                    c.ID = 1;
                    c.Strads = 2243;
                    c.Len = 1;
                    c.Buff[0] = OutputStatus;
                    Int16 result = mc.WritePLC(c.ID, 0x10, c.Strads, c.Len, c.Buff);  //写入目标位置
                    DisplayLog(1, "* Write to Driverboard command [ " + result + " ]");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            } 
        }
        private void Btn_updatePwm_Click(object sender, EventArgs e)
        {

            CommandStructDef c;
            c.Buff = new UInt16[10];      //申请数组空间

            c.ID = 1;
            c.Strads = 2244;
            c.Len = 5;
            Int32 fre = Convert.ToInt32(txt_Frequency.Text);
            c.Buff[0] = (UInt16)(fre & 0xffff);
            c.Buff[1] = (UInt16)(fre>>16);

            Int32 duty1 = Convert.ToInt32(txt_DutyCH1.Text);
            c.Buff[2] = (UInt16)(duty1 & 0xff);

            Int32 duty2 = Convert.ToInt32(txt_DutyCH2.Text);
            c.Buff[3] = (UInt16)(duty2 & 0xff);

            if (chk_EnablePWM.Checked == true)
            {
                c.Buff[4] = 1;
            }
            else
            {
                c.Buff[4] = 0;
            }
            c.Buff[5] = 1;      //更新pwm参数
            DisplayLog(1, "* PWM status Frequency:" + fre.ToString() + ",Duty1:" + duty1 + ",Duty2:" + duty2 + ",Enable:" + c.Buff[4]);
            Int16 result = mc.WritePLC(c.ID, 0x10, c.Strads, c.Len, c.Buff);  //写入目标位置
            DisplayLog(1, "* Write to Driverboard command [ " + result + " ]");

        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            //*****************读取Axis参数信息***************************/
            //LoadGridView();
            this.EditGridview.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;// Color.LightSteelBlue; 
            UInt16[] Cstate = new UInt16[40];
            tprogress.Minimum = 0;
            tprogress.Maximum = 4;
            for (int i = 0; i < 4; i++)
            {
                tprogress.Value = i;
                Int16 result = mc.ReadPLC(0x01, 0x03, (short)(2000+(i*60)), 32, ref Cstate);
                DisplayLog(1, "* read to Driverboard Axis parament [ " + result + " ]");

                if (result == 0)
                {
                    AxisParamentDT.BeginLoadData();
                    for (int row = 0; row < 19; row++)
                    {
                        Int32 val = 0;
                        switch (row)
                        {
                            case 0://加速度
                            case 1:
                            case 2:
                            case 3:
                                val = Cstate[row * 2] + (Cstate[row * 2 + 1] << 16);
                                AxisParamentDT.Rows[row][i+1] = val.ToString();
                                break;
                            case 4://正向限位电平
                            case 5:
                                val = Cstate[4+ row];
                                AxisParamentDT.Rows[row][i+1] = val.ToString();
                                break;
                            case 6://正向软极限
                            case 7:
                                val = Cstate[(row-1) * 2] + (Cstate[(row-1) * 2 + 1] << 16);
                                AxisParamentDT.Rows[row][i+1] = val.ToString();
                                break;
                            case 8://使能软极限
                            case 9:
                                val = (short)Cstate[6+ row];
                                AxisParamentDT.Rows[row][i+1] = val.ToString();
                                break;
                            case 10://零点偏移
                            case 11:
                            case 12:
                            case 13:
                                val = Cstate[(row-2) * 2] + (Cstate[(row-2) * 2 + 1] << 16);
                                AxisParamentDT.Rows[row][i+1] = val.ToString();
                                break;
                            case 14://home设置
                            case 15:
                                val = (short)Cstate[10 + row];
                                AxisParamentDT.Rows[row][i + 1] = val.ToString();
                                break;
                            case 16:
                            case 17:
                            case 18:
                                val = Cstate[(row-2) * 2] + (Cstate[(row-2) * 2 + 1] << 16);
                                AxisParamentDT.Rows[row][i+1] = val.ToString();
                                break;
                            default: return;
                        }
                    }
                    AxisParamentDT.EndLoadData();
                }
                tprogress.Value = 4;
            }
            HomeSenCtrl = SenSetVal();
          
        }
        private UInt16 SenSetVal()
        {
            UInt16 val =0;
            if (AxisParamentDT.Rows[15]["Axis1"].ToString() == "0")
            {
              
                CHK_INPUT[0].Text = "X01 UserList N1";
                CHK_INPUT[1].Text = "X02 UserList N2";
                CHK_INPUT[2].Text = "X03 UserList N3";
            }
            else
            {
                val |= 0x01;
                CHK_INPUT[0].Text = "X01 Axis1 home";
                CHK_INPUT[1].Text = "X02 Axis1 Positive";
                CHK_INPUT[2].Text = "X03 Axis1 Negative";
            }
            if (AxisParamentDT.Rows[15]["Axis2"].ToString() == "0")
            {

                CHK_INPUT[3].Text = "X04 UserList N4";
                CHK_INPUT[4].Text = "X05 UserList N5";
                CHK_INPUT[5].Text = "X06 UserList N6";
            }
            else
            {
                val |= 0x02;
                CHK_INPUT[3].Text = "X04 Axis2 home";
                CHK_INPUT[4].Text = "X05 Axis2 Positive";
                CHK_INPUT[5].Text = "X06 Axis2 Negative";
            }
            if (AxisParamentDT.Rows[15]["Axis3"].ToString() == "0")
            {

                CHK_INPUT[6].Text = "X07 UserList N7";
                CHK_INPUT[7].Text = "X08 UserList N8";
                CHK_INPUT[8].Text = "X09 UserList N9";
            }
            else
            {
                val |= 0x04;
                CHK_INPUT[6].Text = "X07 Axis3 home";
                CHK_INPUT[7].Text = "X08 Axis3 Positive";
                CHK_INPUT[8].Text = "X09 Axis3 Negative";
            }
            if (AxisParamentDT.Rows[15]["Axis4"].ToString() == "0")
            {

                CHK_INPUT[9].Text = "X10 UserList N10";
                CHK_INPUT[10].Text = "X11 UserList N11";
                CHK_INPUT[11].Text = "X12 UserList N12";
            }
            else
            {
                val |= 0x08;
                CHK_INPUT[9].Text = "X10 Axis4 home";
                CHK_INPUT[10].Text = "X11 Axis4 Positive";
                CHK_INPUT[11].Text = "X12 Axis4 Negative";
            }
            return val;
        }

        private void btn_DWload_Click(object sender, EventArgs e)
        {
            tprogress.Minimum = 0;
            tprogress.Maximum = 4;
            for (short i = 1; i < 5; i++)
            {
                tprogress.Value = i;
                SaveAxisPara(i);
            }

            CommandStructDef c;
            c.Buff = new UInt16[1];      //申请数组空间

            c.ID = 1;
            c.Strads = 2241;
            c.Len = 1;
            c.Buff[0] = 1;
            DisplayLog(1, "* Download all axis parament");
            Int16 result = mc.WritePLC(c.ID, 0x10, c.Strads, c.Len, c.Buff);  //写入目标位置
            DisplayLog(1, "* Write to Driverboard parament [ " + result + " ]");

            //for (int i = 0; i < EditGridview.RowCount; i++)
            //{
            //    EditGridview.Rows[i].DefaultCellStyle.BackColor = (i % 2 == 0) ? Color.Blue : Color.White;
            //}
        }



        /*****************加载Gridview**************************************/
        private void LoadGridView()
        {
            this.EditGridview.Rows.Clear();                     //清空源数据
            this.EditGridview.Columns.Clear();
            this.EditGridview.RowHeadersWidth = 50;
            this.EditGridview.ColumnHeadersHeight = 150;
            this.EditGridview.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;// Color.LightSteelBlue; 
            //EditGridview.Columns[1].Frozen = true; //列冻结
            //EditGridview.AllowUserToOrderColumns = true;

            this.EditGridview.AllowUserToAddRows = true;        //不自动添加新行
            this.EditGridview.DataSource = AxisParamentDT;
            //this.EditGridview.Columns["Name"].Width = 120;
            //this.EditGridview.Columns["Axis1"].Width = 100;
            //this.EditGridview.Columns["Axis2"].Width = 100;
            //this.EditGridview.Columns["Axis3"].Width = 100;
            //this.EditGridview.Columns["Axis4"].Width = 100;
            //this.EditGridview.Columns["Describe"].Width = 300;

            this.EditGridview.Columns["Name"].FillWeight = 20;
            this.EditGridview.Columns["Axis1"].FillWeight = 10;
            this.EditGridview.Columns["Axis2"].FillWeight = 10;
            this.EditGridview.Columns["Axis3"].FillWeight = 10;
            this.EditGridview.Columns["Axis4"].FillWeight = 10;
            this.EditGridview.Columns["Describe"].FillWeight = 40;

            this.EditGridview.Columns["Name"].ReadOnly = true;
            this.EditGridview.Columns["Describe"].ReadOnly = true;
            
            this.EditGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; //DataGridViewAutoSizeColumnsMode.Fill;

            this.EditGridview.Columns["Name"].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.EditGridview.Columns["Axis1"].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.EditGridview.Columns["Axis2"].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.EditGridview.Columns["Axis3"].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.EditGridview.Columns["Axis4"].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.EditGridview.Columns["Describe"].SortMode = DataGridViewColumnSortMode.NotSortable;

            AxisParamentDT.BeginLoadData();


            for (int i = 0; i < 19; i++)
            {
                //DataRow dr = PIDParamentDT.NewRow();             
                //dr["Name"] = "PID";
                //dr["Value"] = "123";
                //dr["Desc"] = "Setpid";
                //PIDParamentDT.Rows.Add(dr);
                AxisParamentDT.Rows.Add();
            }
            AxisParamentDT.Rows[0]["Name"] = "accel";
            AxisParamentDT.Rows[0]["Axis1"] = "";
            AxisParamentDT.Rows[0]["Axis2"] = "";
            AxisParamentDT.Rows[0]["Axis3"] = "";
            AxisParamentDT.Rows[0]["Axis4"] = "";
            AxisParamentDT.Rows[0]["Describe"] = "运行加速度 设置范围[0-90 0000]";

            AxisParamentDT.Rows[1]["Name"] = "decel";
            AxisParamentDT.Rows[1]["Axis1"] = "";
            AxisParamentDT.Rows[1]["Axis2"] = "";
            AxisParamentDT.Rows[1]["Axis3"] = "";
            AxisParamentDT.Rows[1]["Axis4"] = "";
            AxisParamentDT.Rows[1]["Describe"] = "运行减速度 设置范围[0-90 0000]";

            AxisParamentDT.Rows[2]["Name"] = "speed";
            AxisParamentDT.Rows[2]["Axis1"] = "";
            AxisParamentDT.Rows[2]["Axis2"] = "";
            AxisParamentDT.Rows[2]["Axis3"] = "";
            AxisParamentDT.Rows[2]["Axis4"] = "";
            AxisParamentDT.Rows[2]["Describe"] = "运行速度 设置范围[0-90 0000]";

            AxisParamentDT.Rows[3]["Name"] = "stpdecel";
            AxisParamentDT.Rows[3]["Axis1"] = "";
            AxisParamentDT.Rows[3]["Axis2"] = "";
            AxisParamentDT.Rows[3]["Axis3"] = "";
            AxisParamentDT.Rows[3]["Axis4"] = "";
            AxisParamentDT.Rows[3]["Describe"] = "急停减速度 设置范围[0-90 0000]";

            AxisParamentDT.Rows[4]["Name"] = "LmtSnsPos";
            AxisParamentDT.Rows[4]["Axis1"] = "";
            AxisParamentDT.Rows[4]["Axis2"] = "";
            AxisParamentDT.Rows[4]["Axis3"] = "";
            AxisParamentDT.Rows[4]["Axis4"] = "";
            AxisParamentDT.Rows[4]["Describe"] = "正限位有效电平 设置范围[0] 低电平[1]高电平";

            AxisParamentDT.Rows[5]["Name"] = "LmtSnsNeg";
            AxisParamentDT.Rows[5]["Axis1"] = "";
            AxisParamentDT.Rows[5]["Axis2"] = "";
            AxisParamentDT.Rows[5]["Axis3"] = "";
            AxisParamentDT.Rows[5]["Axis4"] = "";
            AxisParamentDT.Rows[5]["Describe"] = "负限位有效电平 设置范围[0] 低电平[1]高电平";

            AxisParamentDT.Rows[6]["Name"] = "softLmtPos";
            AxisParamentDT.Rows[6]["Axis1"] = "";
            AxisParamentDT.Rows[6]["Axis2"] = "";
            AxisParamentDT.Rows[6]["Axis3"] = "";
            AxisParamentDT.Rows[6]["Axis4"] = "";
            AxisParamentDT.Rows[6]["Describe"] = "正向软限位 设置范围[0-300 00000]";

            AxisParamentDT.Rows[7]["Name"] = "SoftLmtNeg";
            AxisParamentDT.Rows[7]["Axis1"] = "";
            AxisParamentDT.Rows[7]["Axis2"] = "";
            AxisParamentDT.Rows[7]["Axis3"] = "";
            AxisParamentDT.Rows[7]["Axis4"] = "";
            AxisParamentDT.Rows[7]["Describe"] = "反向软限位 设置范围[0-300 00000]";

            AxisParamentDT.Rows[8]["Name"] = "EnsoftLmt";
            AxisParamentDT.Rows[8]["Axis1"] = "";
            AxisParamentDT.Rows[8]["Axis2"] = "";
            AxisParamentDT.Rows[8]["Axis3"] = "";
            AxisParamentDT.Rows[8]["Axis4"] = "";
            AxisParamentDT.Rows[8]["Describe"] = "使能软极限 使能[1] 禁用[0]";

            AxisParamentDT.Rows[9]["Name"] = "zeroDir";
            AxisParamentDT.Rows[9]["Axis1"] = "";
            AxisParamentDT.Rows[9]["Axis2"] = "";
            AxisParamentDT.Rows[9]["Axis3"] = "";
            AxisParamentDT.Rows[9]["Axis4"] = "";
            AxisParamentDT.Rows[9]["Describe"] = "回零搜索方向 反向[-1] 正向[1]";

            AxisParamentDT.Rows[10]["Name"] = "zerooffset";
            AxisParamentDT.Rows[10]["Axis1"] = "";
            AxisParamentDT.Rows[10]["Axis2"] = "";
            AxisParamentDT.Rows[10]["Axis3"] = "";
            AxisParamentDT.Rows[10]["Axis4"] = "";
            AxisParamentDT.Rows[10]["Describe"] = "零点偏移值 设置范围[0-30 00000]";

            AxisParamentDT.Rows[11]["Name"] = "homeFastSpeed";
            AxisParamentDT.Rows[11]["Axis1"] = "";
            AxisParamentDT.Rows[11]["Axis2"] = "";
            AxisParamentDT.Rows[11]["Axis3"] = "";
            AxisParamentDT.Rows[11]["Axis4"] = "";
            AxisParamentDT.Rows[11]["Describe"] = "回零快速搜索速度 设置范围[0-90 0000]";

            AxisParamentDT.Rows[12]["Name"] = "homeSlowSpeed";
            AxisParamentDT.Rows[12]["Axis1"] = "";
            AxisParamentDT.Rows[12]["Axis2"] = "";
            AxisParamentDT.Rows[12]["Axis3"] = "";
            AxisParamentDT.Rows[12]["Axis4"] = "";
            AxisParamentDT.Rows[12]["Describe"] = "回零慢速搜索速度 设置范围[0-10 0000]";

            AxisParamentDT.Rows[13]["Name"] = "zeroBackDistance";
            AxisParamentDT.Rows[13]["Axis1"] = "";
            AxisParamentDT.Rows[13]["Axis2"] = "";
            AxisParamentDT.Rows[13]["Axis3"] = "";
            AxisParamentDT.Rows[13]["Axis4"] = "";
            AxisParamentDT.Rows[13]["Describe"] = "回零回退距离 设置范围[0-300000] 必须大于homesensor挡板宽度";

            AxisParamentDT.Rows[14]["Name"] = "AutoGohome";
            AxisParamentDT.Rows[14]["Axis1"] = "";
            AxisParamentDT.Rows[14]["Axis2"] = "";
            AxisParamentDT.Rows[14]["Axis3"] = "";
            AxisParamentDT.Rows[14]["Axis4"] = "";
            AxisParamentDT.Rows[14]["Describe"] = "上电自动回原点 使能[1] 禁用[0]";

            AxisParamentDT.Rows[15]["Name"] = "HomeSenS";
            AxisParamentDT.Rows[15]["Axis1"] = "";
            AxisParamentDT.Rows[15]["Axis2"] = "";
            AxisParamentDT.Rows[15]["Axis3"] = "";
            AxisParamentDT.Rows[15]["Axis4"] = "";
            AxisParamentDT.Rows[15]["Describe"] = "传感器数量 2线[2] 3线[3] 将IO做普通输入口[0]";         

            AxisParamentDT.Rows[16]["Name"] = "Reserve1 ";
            AxisParamentDT.Rows[16]["Axis1"] = "";
            AxisParamentDT.Rows[16]["Axis2"] = "";
            AxisParamentDT.Rows[16]["Axis3"] = "";
            AxisParamentDT.Rows[16]["Axis4"] = "";
            AxisParamentDT.Rows[16]["Describe"] = "预留1";

            AxisParamentDT.Rows[17]["Name"] = "Reserve2";
            AxisParamentDT.Rows[17]["Axis1"] = "";
            AxisParamentDT.Rows[17]["Axis2"] = "";
            AxisParamentDT.Rows[17]["Axis3"] = "";
            AxisParamentDT.Rows[17]["Axis4"] = "";
            AxisParamentDT.Rows[17]["Describe"] = "预留2";

            AxisParamentDT.Rows[18]["Name"] = "Reserve3";
            AxisParamentDT.Rows[18]["Axis1"] = "";
            AxisParamentDT.Rows[18]["Axis2"] = "";
            AxisParamentDT.Rows[18]["Axis3"] = "";
            AxisParamentDT.Rows[18]["Axis4"] = "";
            AxisParamentDT.Rows[18]["Describe"] = "预留3";

            AxisParamentDT.EndLoadData();

        }


        ////数据长度：1
        //private void chkMSCs_click(object sender, EventArgs e)
        //{
        //    CheckBox chk = (CheckBox)(sender); // 获取index
        //    Int32 index = chk.TabIndex;

        //    CommandStructDef c;
        //    c.Buff = new Int16[1];      //申请数组空间
        //    c.Buff[0] = 0;
        //    for (int i = 0; i < 16; i++)
        //    {
        //        if (chkMSCs[i].Checked == true)
        //        {
        //            c.Buff[0] |= (Int16)(1 << i);
        //        }
        //    }
        //    c.ID = 1;
        //    c.Strads = 3061;
        //    c.Len = 1;
        //    Int16 result = mc.WritePLC(c.ID, 0x10, c.Strads, c.Len, c.Buff);  //写入目标位置
        //    DisplayLog(1,"* Write to MPLC I/O State control [ " + result + " ]");
        //}
       

        private static string portName;                 //当前可用端口
        public const int Baudrate = 115200;
        ModbusClient mc = new ModbusClient(100, 100);
        /// <summary>
        /// 打开可用的串口
        /// </summary>
        private void OpenUseSerialPort()
        {

            if (ConnectState.BackColor != Color.Lime)
            {
                //"0403", "6001" USB转232
                //"067B", "2303" USB转485
                //"0986", "0320" PLC端口
                //portName = FormMain.GetPortNameFormVidPid("0986", "0320");
                List<string> availport;
                availport = GetPortNameFormVidPid("0403", "6001");
                //portName = GetPortNameFormVidPid("067B", "2303");
                if (availport != null)
                {
                    string[] port = availport.ToArray();
                    CBVarPort.Items.AddRange(port);
                }
                else
                {
                    CBVarPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());  //获取所有串口设备
                    DisplayLog(1, "NO find Correspond poet!");
                    return;
                }
                if (CBVarPort.Items.Count > 0)
                {
                    CBVarPort.SelectedIndex = 0;

                    if (mc.IsOpen == false)
                    {
                        try
                        {
                            portName = CBVarPort.Items[0].ToString();
                            Debug.WriteLine("Use port:" + portName);

                            bool isOpen = mc.Open(portName, Baudrate, 8, System.IO.Ports.Parity.None, System.IO.Ports.StopBits.One, 200, 200);
                            if (!isOpen)
                            {
                                //MessageBox.Show("串口打开失败");
                                Console.ForegroundColor = ConsoleColor.Red;
                                DisplayLog(1,"* Open port fail");
                                Console.ForegroundColor = ConsoleColor.Green;

                            }
                            else
                            {
                                //串口打开成功，modbus协议初始化成功,打开定时器
                                //MessageBox.Show("串口打开成功");
                                ConnectState.Text = "Connect";
                                ConnectState.BackColor = Color.Lime;
                                DisplayLog(1,"* Open port ok");
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Open port error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ConnectState.Text = "NULL";
                            ConnectState.BackColor = Color.Yellow;
                            Console.ForegroundColor = ConsoleColor.Red;
                            DisplayLog(1,"* Open port error");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("NO Use Serialport", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Console.ForegroundColor = ConsoleColor.Red;
                    DisplayLog(1,"* No available port");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
            else
            {
                mc.Close();
                ConnectState.Text = "NULL";
                ConnectState.BackColor = Color.Yellow;
                DisplayLog(1,"* Port close");
            }
        }


        /// <summary>
        /// 通过vid，pid获得串口设备号
        /// </summary>
        /// <param name="vid">vid</param>
        /// <param name="pid">pid</param>
        /// <returns>串口号</returns>
        public static List<string> GetPortNameFormVidPid(string vid, string pid)
        {
            Guid myGUID = Guid.Empty;

            //string enumerator = "USB";
            string enumerator = "FTDIBUS";
            List<string> AvailPort = new List<string>(16);
            try
            {
                IntPtr hDevInfo = HardWareLib.SetupDiGetClassDevs(ref myGUID, enumerator, IntPtr.Zero, HardWareLib.DIGCF_ALLCLASSES | HardWareLib.DIGCF_PRESENT);
                if (hDevInfo.ToInt32() == HardWareLib.INVALID_HANDLE_VALUE)
                {
                    throw new Exception("没有该类设备");
                }
                HardWareLib.SP_DEVINFO_DATA deviceInfoData;//想避免在api中使用ref，就把structure映射成类
                deviceInfoData = new HardWareLib.SP_DEVINFO_DATA();
                deviceInfoData.cbSize = 28;//如果要使用SP_DEVINFO_DATA，一定要给该项赋值28=16+4+4+4
                deviceInfoData.devInst = 0;
                deviceInfoData.classGuid = System.Guid.Empty;
                deviceInfoData.reserved = 0;
                UInt32 i;
                StringBuilder property = new StringBuilder(HardWareLib.MAX_DEV_LEN);

                for (i = 0; HardWareLib.SetupDiEnumDeviceInfo(hDevInfo, i, deviceInfoData); i++)
                {
                    //       Console.Write(deviceInfoData.classGuid.ToString());
                    //       HardWareOperation.SetupDiGetDeviceInstanceId(hDevInfo, deviceInfoData, porperty, (uint)porperty.Capacity, 0);
                    HardWareLib.SetupDiGetDeviceRegistryProperty(hDevInfo, deviceInfoData, (uint)HardWareLib.SPDRP_.SPDRP_CLASS, 0, property, (uint)property.Capacity, IntPtr.Zero);

                    if (property.ToString().ToLower() != "ports") continue;//首先看看是不是串口设备（有些USB设备不是串口设备）

                    HardWareLib.SetupDiGetDeviceRegistryProperty(hDevInfo, deviceInfoData, (uint)HardWareLib.SPDRP_.SPDRP_HARDWAREID, 0, property, (uint)property.Capacity, IntPtr.Zero);

                    if (!(property.ToString().ToLower().Contains(vid.ToLower()) && property.ToString().ToLower().Contains(pid.ToLower()))) continue;//找到对应于vid&pid的设备

                    HardWareLib.SetupDiGetDeviceRegistryProperty(hDevInfo, deviceInfoData, (uint)HardWareLib.SPDRP_.SPDRP_FRIENDLYNAME, 0, property, (uint)property.Capacity, IntPtr.Zero);
                    //                     break;     //查询到一个就退出
                    string friendlyName = property.ToString();
                    char[] separatorMark = { '(', ')' };
                    string[] strList1 = friendlyName.Split(separatorMark);
                    if (strList1[1].Substring(0, 3) == "COM")
                    {
                        AvailPort.Add(strList1[1]);
                    }    
                }

                HardWareLib.SetupDiDestroyDeviceInfoList(hDevInfo);//记得用完释放相关内存
                //string friendlyName = property.ToString();
                //char[] separatorMark = { '(', ')' };
                //string[] strList1 = friendlyName.Split(separatorMark);
                //if (strList1[1].Substring(0, 3) == "COM")
                //{
                //    return strList1[1];
                //}
                //return null;
                if (AvailPort.Count > 0)
                {
                    return AvailPort;
                }
                else

                    return null;

            }
            catch (Exception ex)
            {
                //        MessageBox.Show(ex.Message);
                return null;
            }
        }
        //**********************************************************************************************
        //初始化连接串口
        //**********************************************************************************************


        /******************************************************************************************/
        //工具栏按钮事件
        /******************************************************************************************/
        private void OpenPath_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            System.Diagnostics.Process.Start("explorer.exe", path);
        }

        private void Savefile_Click(object sender, EventArgs e)
        {
            CsvFiles csv = new CsvFiles();
            csv.SaveCSV(AxisParamentDT, Application.StartupPath + @"\Config" + @"\Config.par");
        }
        private void DrawBoard_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void Net_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ncpa.cpl");
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("taskmgr.exe");
        }

        private void Screenshot_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\Screenshot\" + DateTime.Now.ToString("yyyy_MM_dd HH_mm_ss") + ".bmp";
            //指定路径
            try
            {
                Bitmap bit = new Bitmap(this.Width, this.Height);
                Graphics g = Graphics.FromImage(bit);
                g.CopyFromScreen(this.Location, new Point(0, 0), bit.Size);
                //SaveFileDialog saveFileDialog = new SaveFileDialog();         //自定义路径
                //saveFileDialog.Filter = "bmp|*.bmp|jpg|*.jpg|gif|*.gif";
                //if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
                //{
                //    bit.Save(saveFileDialog.FileName);
                //}
                //g.Dispose();
                bit.Save(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure exit the application?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {             
                e.Cancel = false;
                if (mc.IsOpen == true)
                {
                    mc.Close();
                }
                Threadcycletask.Abort();

                CsvFiles csv = new CsvFiles();
                string path = Application.StartupPath + @"\LOG\" + DateTime.Now.ToString("yyyy_MM_dd HH_mm_ss") + ".txt";
                csv.SaveTXT(LogList, path);
            }
            else
            {
                e.Cancel = true;
            }  
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
               // System.Environment.Exit(0);     //退出任务管理器
        }

        private void tESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //11
            ConsoleShow.Visible(true, Console.Title);
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            ConsoleShow.Visible(false, Console.Title);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string resultFile;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Application.StartupPath + @"\Config";
            openFileDialog1.Filter = "parament files (*.par)|*.par|All files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                resultFile = openFileDialog1.FileName;
                CsvFiles csv = new CsvFiles();
                AxisParamentDT.BeginLoadData();
                AxisParamentDT = csv.OpenCSV(resultFile);
                EditGridview.DataSource = AxisParamentDT;
                AxisParamentDT.EndLoadData();
                HomeSenCtrl = SenSetVal();
            }  
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string FileName = DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss");
            //ConsoleShow.SaveTXT( Application.StartupPath + @"\Log\"+FileName+".txt");

            CsvFiles csv = new CsvFiles();
            csv.SaveCSV(AxisParamentDT, Application.StartupPath + @"\Config" + @"\Config.par");

        }

        private void Server_con_Click(object sender, EventArgs e)
        {
            //if (ConnectState.BackColor != Color.Lime)
            //{
                if (mc.IsOpen == false)
                {
                    try
                    {
                        portName = CBVarPort.Text;
                        Debug.WriteLine("* Manual connect" + portName);

                        bool isOpen = mc.Open(portName, Baudrate, 8, System.IO.Ports.Parity.None, System.IO.Ports.StopBits.One, 200, 200);
                        if (!isOpen)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            DisplayLog(1,"* Open port fail");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            ConnectState.Text = "Connect";
                            ConnectState.BackColor = Color.Lime;
                            DisplayLog(1,"* Open port ok");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Open port error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ConnectState.Text = "NULL";
                        ConnectState.BackColor = Color.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        DisplayLog(1,"* Open port error");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
                else
                {
                    mc.Close();
                    ConnectState.Text = "NULL";
                    ConnectState.BackColor = Color.Yellow;
                    DisplayLog(1,"* Port close");
                }
        //    }
        }



        //private void button11_Click(object sender, EventArgs e)
        //{
        //    //Threadcycletask2.Abort();
        //    ////Threadcycletask.Abort();
        //    //Thread Threadcycletask2;                      //需要引入System.Threading命名空间
        //    //Threadcycletask2 = new Thread( new ThreadStart( CycleTask2));
        //    //Threadcycletask2.Start();

        //}


     
        private void showLogToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hideLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }

        /******************************************************************/
        //显示LOG函数，0 只显示Console 1全部显示
        public void DisplayLog(int grade,string str)
        {
            DateTime Date = DateTime.Now;
            string log = string.Format("{0:G} => ", Date) + str;
            if (grade == 0)
            {
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine(str);

                this.Invoke((EventHandler)delegate      //委托更新显示
                {
                    this.LogList.Items.Add(log);

                    if (LogList.Items.Count > 5)
                    {
                        this.LogList.SelectedIndex = LogList.Items.Count - 1;
                    }
                });
            }
        }

        private void EditGridview_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, this.EditGridview.RowHeadersWidth - 4, e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
            this.EditGridview.RowHeadersDefaultCellStyle.Font, rectangle, this.EditGridview.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
       
        }

        private void EditGridview_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((e.RowIndex > -1) && (e.ColumnIndex > 0))
                {
                    //selrowIndex = EditGridview.CurrentCell.RowIndex;
                    //selcolumnIndex = EditGridview.CurrentCell.ColumnIndex;
                    Int16 AxisNum = (Int16)(e.ColumnIndex - 1);
                    Int16 ParaNUM = (Int16)e.RowIndex;

                    Int32 parament = 0;

                    if (isNumberic(AxisParamentDT.Rows[e.RowIndex][e.ColumnIndex].ToString(), out parament) == false)
                    { 
                        parament = 0;
                        MessageBox.Show("无效的输入，可能包含 #@，。/！;");
                        return;
                    }

                    CommandStructDef c;
                    c.Buff = new UInt16[2];      //申请数组空间
                    c.ID = 1;
                    switch (ParaNUM)
                    {
                        case 0://SPEED
                        case 1:
                        case 2:
                        case 3:
                            c.Strads = (Int16)(2000 + AxisNum * 60 + ParaNUM * 2);
                            c.Len = 2;
                            c.Buff[0] = (UInt16)(parament & 0xFFFF);
                            c.Buff[1] = (UInt16)(parament >> 16);
                            break;
                        case 4://正向限位电平
                        case 5:
                            c.Strads = (Int16)(2004 + AxisNum * 60 + ParaNUM);
                            c.Len = 1;
                            c.Buff[0] = (UInt16)(parament);
                            break;
                        case 6://正向软极限
                        case 7:
                            c.Strads = (Int16)(1998 + AxisNum * 60 + ParaNUM * 2);
                            c.Len = 2;
                            c.Buff[0] = (UInt16)(parament & 0xFFFF);
                            c.Buff[1] = (UInt16)(parament >> 16);
                            break;
                        case 8://使能软极限
                        case 9:
                            c.Strads = (Int16)(2006 + AxisNum * 60 + ParaNUM);
                            c.Len = 1;
                            c.Buff[0] = (UInt16)(parament & 0xFFFF);
                            break;
                        case 10://零点偏移（
                        case 11:
                        case 12:
                        case 13:
                            c.Strads = (Int16)(1996 + AxisNum * 60 + ParaNUM * 2);
                            c.Len = 2;
                            c.Buff[0] = (UInt16)(parament & 0xFFFF);
                            c.Buff[1] = (UInt16)(parament >> 16);
                            break;
                        case 14://homectrl
                        case 15:
                            c.Strads = (Int16)(2010 + AxisNum * 60 + ParaNUM);
                            c.Len = 1;
                            c.Buff[0] = (UInt16)(parament & 0xFFFF);
                            break;
                        case 16:
                        case 17:
                        case 18:
                            c.Strads = (Int16)(1990 + AxisNum * 60 + ParaNUM * 2);
                            c.Len = 2;
                            c.Buff[0] = (UInt16)(parament & 0xFFFF);
                            c.Buff[1] = (UInt16)(parament >> 16);
                            break;
                        default: return;
                    }


                    //c.Buff[0] = (Int16) parament; 
                    Int16 result = mc.WritePLC(c.ID, 0x10, c.Strads, c.Len, c.Buff);  //写入目标位置

                    DisplayLog(1, "* Write to Driverboard Value [ " + result + " ]");
                    if (result == 0)
                    {
                        this.EditGridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Lime;
                    }
                    else
                    {
                        this.EditGridview.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Yellow;
                    }
                    if (ParaNUM == 15)//change home sensor config
                    {
                        HomeSenCtrl = SenSetVal();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
        }

        private void EditGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveAxisPara(Int16 AxisNum)
        {
            // Int16 ParaNUM = (Int16)e.RowIndex;
            CommandStructDef c;
            c.Buff = new UInt16[34];      //申请数组空间
            c.ID = 1;

            c.Strads = (Int16)(2000 + (AxisNum-1) * 60);
            c.Len = 32;

            Int32 parament = 0;

            if (isNumberic(AxisParamentDT.Rows[0][AxisNum].ToString(), out parament) == false)
            { parament = 0; AxisParamentDT.Rows[0][AxisNum] = "0"; }
            c.Buff[0] = (UInt16)(parament & 0xFFFF);
            c.Buff[1] = (UInt16)(parament >> 16);

            if (isNumberic(AxisParamentDT.Rows[1][AxisNum].ToString(), out parament) == false)
            { parament = 0; AxisParamentDT.Rows[1][AxisNum] = "0"; }
            c.Buff[2] = (UInt16)(parament & 0xFFFF);
            c.Buff[3] = (UInt16)(parament >> 16);

            if (isNumberic(AxisParamentDT.Rows[2][AxisNum].ToString(), out parament) == false)
            { parament = 0; AxisParamentDT.Rows[2][AxisNum] = "0"; }
            c.Buff[4] = (UInt16)(parament & 0xFFFF);
            c.Buff[5] = (UInt16)(parament >> 16);

            if (isNumberic(AxisParamentDT.Rows[3][AxisNum].ToString(), out parament) == false)
            { parament = 0; AxisParamentDT.Rows[3][AxisNum] = "0"; }
            c.Buff[6] = (UInt16)(parament & 0xFFFF);
            c.Buff[7] = (UInt16)(parament >> 16);

            if (isNumberic(AxisParamentDT.Rows[4][AxisNum].ToString(), out parament) == false)
            { parament = 0; AxisParamentDT.Rows[4][AxisNum] = "0"; }
            c.Buff[8] = (UInt16)(parament);

            if (isNumberic(AxisParamentDT.Rows[5][AxisNum].ToString(), out parament) == false)
            { parament = 0; AxisParamentDT.Rows[5][AxisNum] = "0"; }
            c.Buff[9] = (UInt16)(parament);

            if (isNumberic(AxisParamentDT.Rows[6][AxisNum].ToString(), out parament) == false)
            { parament = 0; AxisParamentDT.Rows[6][AxisNum] = "0"; }
            c.Buff[10] = (UInt16)(parament & 0xFFFF);
            c.Buff[11] = (UInt16)(parament >> 16);

            if (isNumberic(AxisParamentDT.Rows[7][AxisNum].ToString(), out parament) == false)
            { parament = 0; AxisParamentDT.Rows[7][AxisNum] = "0"; }
            c.Buff[12] = (UInt16)(parament & 0xFFFF);
            c.Buff[13] = (UInt16)(parament >> 16);

            if (isNumberic(AxisParamentDT.Rows[8][AxisNum].ToString(), out parament) == false)
            { parament = 0; AxisParamentDT.Rows[8][AxisNum] = "0"; }
            c.Buff[14] = (UInt16)(parament);

            if (isNumberic(AxisParamentDT.Rows[9][AxisNum].ToString(), out parament) == false)
            { parament = 0; AxisParamentDT.Rows[9][AxisNum] = "0"; }
            c.Buff[15] = (UInt16)(parament);

            //零点偏移        
            if (isNumberic(AxisParamentDT.Rows[10][AxisNum].ToString(), out parament) == false)
            { parament = 0; AxisParamentDT.Rows[10][AxisNum] = "0"; }
            c.Buff[16] = (UInt16)(parament & 0xFFFF);
            c.Buff[17] = (UInt16)(parament >> 16);

            if (isNumberic(AxisParamentDT.Rows[11][AxisNum].ToString(), out parament) == false)
            { parament = 0; AxisParamentDT.Rows[11][AxisNum] = "0"; }
            c.Buff[18] = (UInt16)(parament & 0xFFFF);
            c.Buff[19] = (UInt16)(parament >> 16);

            if (isNumberic(AxisParamentDT.Rows[12][AxisNum].ToString(), out parament) == false)
            { parament = 0; AxisParamentDT.Rows[12][AxisNum] = "0"; }
            c.Buff[20] = (UInt16)(parament & 0xFFFF);
            c.Buff[21] = (UInt16)(parament >> 16);

            if (isNumberic(AxisParamentDT.Rows[13][AxisNum].ToString(), out parament) == false)
            { parament = 0; AxisParamentDT.Rows[13][AxisNum] = "0"; }
            c.Buff[22] = (UInt16)(parament & 0xFFFF);
            c.Buff[23] = (UInt16)(parament >> 16);

            //home
            if (isNumberic(AxisParamentDT.Rows[14][AxisNum].ToString(), out parament) == false)
            { parament = 0; AxisParamentDT.Rows[14][AxisNum] = "0"; }
            c.Buff[24] = (UInt16)(parament);

            if (isNumberic(AxisParamentDT.Rows[15][AxisNum].ToString(), out parament) == false)
            { parament = 0; AxisParamentDT.Rows[15][AxisNum] = "0"; }
            c.Buff[25] = (UInt16)(parament);

            //预留
            if (isNumberic(AxisParamentDT.Rows[16][AxisNum].ToString(), out parament) == false)
            { parament = 0; AxisParamentDT.Rows[16][AxisNum] = "0"; }
            c.Buff[26] = (UInt16)(parament & 0xFFFF);
            c.Buff[27] = (UInt16)(parament >> 16);

            if (isNumberic(AxisParamentDT.Rows[17][AxisNum].ToString(), out parament) == false)
            { parament = 0; AxisParamentDT.Rows[17][AxisNum] = "0"; }
            c.Buff[28] = (UInt16)(parament & 0xFFFF);
            c.Buff[29] = (UInt16)(parament >> 16);

            if (isNumberic(AxisParamentDT.Rows[18][AxisNum].ToString(), out parament) == false)
            { parament = 0; AxisParamentDT.Rows[18][AxisNum] = "0"; }
            c.Buff[30] = (UInt16)(parament & 0xFFFF);
            c.Buff[31] = (UInt16)(parament >> 16);

            Int16 result = mc.WritePLC(c.ID, 0x10, c.Strads, c.Len, c.Buff);  //写入目标位置

        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == (Keys.Control | Keys.Alt)) && (e.KeyCode == Keys.I))     // && (e.Modifiers == Keys.Alt)
            {
                btn_InitParament.Visible = !btn_InitParament.Visible;
            }
        }

        private void btn_InitParament_Click(object sender, EventArgs e)
        {
            DisplayLog(1, "* Init all axis parament");
            CommandStructDef c;
            c.Buff = new UInt16[1];      //申请数组空间

            c.ID = 1;
            c.Strads = 2241;
            c.Len = 1;
            c.Buff[0] = 2;
            Int16 result = mc.WritePLC(c.ID, 0x10, c.Strads, c.Len, c.Buff);  //写入目标位置
            DisplayLog(1, "* Write to Driverboard parament [ " + result + " ]");
        }


        public Int16 Read_Regedit(short StrAdrs,short len,ref ushort[] r_buff)
        {
            Int16 result = mc.ReadPLC(0x01, 0x03, StrAdrs, len, ref r_buff);
            DisplayLog(1, "* Read regedit [ " + result + " ]");

            return result;
        }

        public Int16 Write_Regedit(short StrAdrs, short len, ushort[] w_buff)
        {
            CommandStructDef c;
            c.Buff = new UInt16[len];      //申请数组空间

            c.ID = 1;
            c.Strads = StrAdrs;
            c.Len = len;
            for (int i = 0; i < len;i++ )
                c.Buff[i] = w_buff[i];
            Int16 result = mc.WritePLC(c.ID, 0x10, c.Strads, c.Len, c.Buff);  //写入目标位置
            DisplayLog(1, "* Write regedit [ " + result + " ]");

            return result;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath( Environment.SpecialFolder.Desktop);   //Application.StartupPath + @"\Config";
            saveFileDialog1.Filter = "parament files (*.par)|*.par|All files(*.*)|*>**";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                CsvFiles csv = new CsvFiles();
                csv.SaveCSV(AxisParamentDT, saveFileDialog1.FileName);
            }
        }

        private void labAvailPort_Click(object sender, EventArgs e)
        {
            CBVarPort.Items.Clear();

            List<string> availport;
            availport = GetPortNameFormVidPid("0403", "6001");          //获取指定串口设备
            if (availport != null)
            {
                string[] port = availport.ToArray();
                CBVarPort.Items.AddRange(port);
            }
            else
            {
                CBVarPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());  //获取所有串口设备
                DisplayLog(1, "NO find Correspond poet!");
                return;
            }

        }

        private void labAvailPort_MouseLeave(object sender, EventArgs e)
        {
            labAvailPort.BorderStyle = BorderStyle.None;
        }

        private void labAvailPort_MouseDown(object sender, MouseEventArgs e)
        {
            labAvailPort.BorderStyle = BorderStyle.FixedSingle;
        }

        private void labAvailPort_MouseUp(object sender, MouseEventArgs e)
        {
            labAvailPort.BorderStyle = BorderStyle.None;
        }

        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDebug fd = new FormDebug();
            fd.TopMost = true;
            fd.Show( this);
        }

        private void easyTeachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormList fl = new FormList();
            fl.TopMost = true;
            fl.Show(this);//ShowShowDialog
        }

        private void btn_Axis1RelMotion_Click(object sender, EventArgs e)
        {

        }
        protected bool isNumberic(string message, out int result)
        {
            //判断是否为整数字符串
            //是的话则将其转换为数字并将其设为out类型的输出值、返回true, 否则为false
            result = -1;   //result 定义为out 用来输出值
            try
            {
                //当数字字符串的为是少于4时，以下三种都可以转换，任选一种
                //如果位数超过4的话，请选用Convert.ToInt32() 和int.Parse()

                //result = int.Parse(message);
                //result = Convert.ToInt16(message);
                result = Convert.ToInt32(message);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btn_Axis1Emgstop_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void 截图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\Screenshot\" + DateTime.Now.ToString("yyyy_MM_dd HH_mm_ss") + ".bmp";
            //指定路径
            try
            {
                Bitmap bit = new Bitmap(this.Width, this.Height);
                Graphics g = Graphics.FromImage(bit);
                g.CopyFromScreen(this.Location, new Point(0, 0), bit.Size);
                //SaveFileDialog saveFileDialog = new SaveFileDialog();         //自定义路径
                //saveFileDialog.Filter = "bmp|*.bmp|jpg|*.jpg|gif|*.gif";
                //if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
                //{
                //    bit.Save(saveFileDialog.FileName);
                //}
                //g.Dispose();
                bit.Save(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Application.StartupPath + @"\Config\HELP.pdf");
            }
            catch (Exception ee)
            {
                MessageBox.Show("" + ee);
            }
        }



    }

}

