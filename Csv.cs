using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Data;                  //使用DataTable类
using System.Data.SqlClient;
using System.Windows.Forms;         //窗体类

namespace CsvFile
{
        public class CsvFiles
        {
            /// <summary>
            /// 将DataTable中数据写入到CSV文件中
            /// </summary>
            /// <param name="dt">提供保存数据的DataTable</param>
            /// <param name="fileName">CSV的文件路径</param>
            /// 
            public  void SaveTXT(ListBox liststr, string fullPath) //文本型
            {
                FileInfo fi = new FileInfo(fullPath);
                if (!fi.Directory.Exists)
                {
                    fi.Directory.Create();
                }
                FileStream fs = new FileStream(fullPath, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                //StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
                StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.ASCII);

                for (int i = 0; i < liststr.Items.Count; i++)
                {
                     sw.WriteLine(liststr.Items[i].ToString());                 //写出各行数据
                }

                sw.Close();
                fs.Close();
 
            // //  System.Diagnostics.Process.Start("explorer.exe", Common.PATH_LANG);
           }

            //public void SaveCSV(ListView lv, string fullPath)
            //{
            //    try
            //    {
            //        FileInfo fi = new FileInfo(fullPath);
            //        if (!fi.Directory.Exists)
            //        {
            //            fi.Directory.Create();
            //        }
            //        FileStream fs = new FileStream(fullPath, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            //        StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.ASCII);
            //        string wstr;
            //        wstr = "";
            //        if (lv.Columns.Count > 12)
            //        {
            //            wstr =lv.Columns[0].Text.Trim().ToString();
            //            for (int k = 1; k < 13; k++)     //lv.Columns.Count
            //            {
            //                wstr = wstr + ","+lv.Columns[k].Text.Trim().ToString();
            //            }
            //            sw.WriteLine(wstr);


            //            for (int i = 0; i < lv.Items.Count; i++)
            //            {
            //                wstr = lv.Items[i].SubItems[0].Text.Trim();
            //                for (int j = 1; j < 13; j++)  //lv.Columns.Count
            //                {
            //                    wstr = wstr +","+ lv.Items[i].SubItems[j].Text.Trim();
            //                }
            //                sw.WriteLine(wstr);
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Listview format error!");
            //        }
            //        sw.Close();
            //        fs.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}


            public void SaveCSV(DataTable dt, string fullPath)
            {
                int countColumns = dt.Columns.Count;
                int countRows = dt.Rows.Count;
                try
                {
                    FileInfo fi = new FileInfo(fullPath);
                    if (!fi.Directory.Exists)
                    {
                        fi.Directory.Create();
                    }
                    FileStream fs = new FileStream(fullPath, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
                    string wstr;
                    wstr = "";
                    if ((countColumns >1) &&(countRows>1))
                    {
                        wstr = dt.Columns[0].ColumnName;

                        for (int k = 1; k < countColumns; k++)
                        {
                            wstr = wstr + "," + dt.Columns[k].ColumnName;
                        }
                        sw.WriteLine(wstr);

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            wstr = dt.Rows[i][0].ToString();

                            for (int k = 1; k < countColumns; k++)   
                            {
                                wstr = wstr + "," + dt.Rows[i][k].ToString();
                            }
                            sw.WriteLine(wstr);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Listview format error!");
                    }
                    sw.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            /// <summary>
            /// 将CSV文件的数据读取到DataTable中
            /// </summary>
            /// <param name="fileName">CSV文件路径</param>
            /// <returns>返回读取了CSV数据的DataTable</returns>
            /// 
            public DataTable OpenCSV(string filePath)                //static
            {
                try
                {
                    String strLine;
                    String[] split = null;
                    DataTable table = new DataTable();
                    DataRow row = null;
                    StreamReader sr = new StreamReader(filePath,  System.Text.Encoding.Default);         //创建与数据源对应的数据列 
                    strLine = sr.ReadLine();
                    split = strLine.Split(',');

                    int i = 0;
                    foreach (String colname in split)
                    {

                        table.Columns.Add(colname, System.Type.GetType("System.String"));
                        i++;
                        if (i > 15) break;
                    }

                    //将数据填入数据表 
                    int j = 0;
                    while ((strLine = sr.ReadLine()) != null)
                    {
                        j = 0;
                        row = table.NewRow();
                        split = strLine.Split(',');
                        foreach (String colname in split)
                        {
                            row[j] = colname;
                            j++;
                            if (j > 15) break;
                        }
                        table.Rows.Add(row);
                    }
                    sr.Close();
                    return table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return null;
            }
    }
}
