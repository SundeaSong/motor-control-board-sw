using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using CsvFile;


namespace WindowsFormsApp
{
    public partial class FormList : Form
    {
        public FormList()
        {
            InitializeComponent();
        }

        public DataTable UserListDT;
        private Button[] btn_Axis_MoveP;
        private Button[] btn_Axis_MoveN;
        private Button[] btn_AxisTeach;
        private ComboBox[] CB_TAPosition;

        private void FormList_Load(object sender, EventArgs e)
        {

            btn_Axis_MoveP = new Button[4];
            btn_Axis_MoveP[0] = btn_Axis1_MoveP;
            btn_Axis_MoveP[1] = btn_Axis2_MoveP;
            btn_Axis_MoveP[2] = btn_Axis3_MoveP;
            btn_Axis_MoveP[3] = btn_Axis4_MoveP;
            for (int i = 0; i < 4; i++)
            {
                btn_Axis_MoveP[i].Click += new EventHandler(btn_RelMotionP_click);          //用代码动态连接事件
            }

            btn_Axis_MoveN = new Button[4];
            btn_Axis_MoveN[0] = btn_Axis1_MoveN;
            btn_Axis_MoveN[1] = btn_Axis2_MoveN;
            btn_Axis_MoveN[2] = btn_Axis3_MoveN;
            btn_Axis_MoveN[3] = btn_Axis4_MoveN;
            for (int i = 0; i < 4; i++)
            {
                btn_Axis_MoveN[i].Click += new EventHandler(btn_RelMotionN_click);          //用代码动态连接事件
            }


            btn_AxisTeach = new Button[4];
            btn_AxisTeach[0] = btn_Axis1Teach;
            btn_AxisTeach[1] = btn_Axis2Teach;
            btn_AxisTeach[2] = btn_Axis3Teach;
            btn_AxisTeach[3] = btn_Axis4Teach;
            for (int i = 0; i < 4; i++)
            {
                btn_AxisTeach[i].Click += new EventHandler(btn_AxisTeach_Click);          //用代码动态连接事件
            }


            CB_TAPosition = new ComboBox[5];
            CB_TAPosition[0] = CB_TA1Position;
            CB_TAPosition[1] = CB_TA2Position;
            CB_TAPosition[2] = CB_TA3Position;
            CB_TAPosition[3] = CB_TA4Position;
            CB_TAPosition[4] = CB_TA5Position;

            CB_Step.Items.Clear();
            CB_Step.Items.Add("1");
            CB_Step.Items.Add("10");
            CB_Step.Items.Add("100");
            CB_Step.Items.Add("1000");
            CB_Step.SelectedIndex = 2;



            UserListDT = new DataTable();
            UserListDT.Columns.Add("Num", System.Type.GetType("System.String"));
            UserListDT.Columns.Add("Function", System.Type.GetType("System.String"));            

            UserListDT.Columns.Add("Follow", System.Type.GetType("System.String"));
            UserListDT.Columns.Add("Axis", System.Type.GetType("System.String"));
            UserListDT.Columns.Add("Speed(%)", System.Type.GetType("System.String"));
            UserListDT.Columns.Add("Position", System.Type.GetType("System.String"));
            UserListDT.Columns.Add("Delay(ms)", System.Type.GetType("System.String"));
            UserListDT.Columns.Add("Next", System.Type.GetType("System.String"));
            UserListDT.Columns.Add("Describe", System.Type.GetType("System.String"));

            LoadGridView();
        }


        //显示方式
        private void SetDataGridViewStyle()
        {
            DataGridViewTextBoxColumn column0 = new DataGridViewTextBoxColumn();
            column0.Name = "Num";
            column0.DataPropertyName = "Num";//对应数据源的字段
            column0.HeaderText = "Num";
            column0.FillWeight = 5;
            this.EditGridview.Columns.Add(column0);

            DataGridViewComboBoxColumn column1 = new DataGridViewComboBoxColumn();
            column1.Name = "Function";
            column1.DataSource = GetFunctionData();//GetFunctionData,ListData

            column1.DataPropertyName = "Function";//对应数据源的字段
            column1.HeaderText = "Function";
            column1.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            column1.ValueMember = "Index"; //"Value";
            column1.DisplayMember = "Fun";//下拉框显示内容  
            
            column1.FillWeight = 15;
            this.EditGridview.Columns.Add(column1);

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "Follow";
            column2.DataPropertyName = "Follow";//对应数据源的字段
            column2.HeaderText = "Follow";
            column2.FillWeight = 10;
            this.EditGridview.Columns.Add(column2);

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "Axis";
            column3.DataPropertyName = "Axis";//对应数据源的字段
            column3.HeaderText = "Axis";
            column3.FillWeight = 10;
            this.EditGridview.Columns.Add(column3);

            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.Name = "Speed(%)";
            column4.DataPropertyName = "Speed(%)";//对应数据源的字段
            column4.HeaderText = "Speed(%)";
            column4.FillWeight = 10;
            this.EditGridview.Columns.Add(column4);

            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.Name = "Position";
            column5.DataPropertyName = "Position";//对应数据源的字段
            column5.HeaderText = "Position";
            column5.FillWeight = 15;
            this.EditGridview.Columns.Add(column5);

            DataGridViewTextBoxColumn column6 = new DataGridViewTextBoxColumn();
            column6.Name = "Delay(ms)";
            column6.DataPropertyName = "Delay(ms)";//对应数据源的字段
            column6.HeaderText = "Delay(ms)";
            column6.FillWeight = 10;
            this.EditGridview.Columns.Add(column6);

            DataGridViewTextBoxColumn column7 = new DataGridViewTextBoxColumn();
            column7.Name = "Next";
            column7.DataPropertyName = "Next";//对应数据源的字段
            column7.HeaderText = "Next";
            column7.FillWeight = 10;
            this.EditGridview.Columns.Add(column7);

            DataGridViewTextBoxColumn column8 = new DataGridViewTextBoxColumn();
            column8.Name = "Describe";
            column8.DataPropertyName = "Describe";//对应数据源的字段
            column8.HeaderText = "Describe";
            column8.FillWeight = 15;
            this.EditGridview.Columns.Add(column8);
 
        }

        private DataTable GetFunctionData()
        {
            DataTable dt = new DataTable();
            DataColumn col = new DataColumn("Index", Type.GetType("System.String")) { Unique = true };
            dt.Columns.Add(col);
            col = new DataColumn("Fun", Type.GetType("System.String"));//学院名称
            dt.Columns.Add(col);

            dt.Rows.Add("0","NULL");
            dt.Rows.Add("1","GOHOME");
            dt.Rows.Add("2","M_ABS");
            dt.Rows.Add("3","M_REL");
            dt.Rows.Add("4","ESTOP");
            dt.Rows.Add("5","OUTPUT");
            dt.Rows.Add("6","PWM");

            return dt;
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

            this.EditGridview.AllowUserToAddRows = false;        //不自动添加新行

            SetDataGridViewStyle();

            this.EditGridview.DataSource = UserListDT;

            this.EditGridview.Columns["Num"].FillWeight = 5;
            this.EditGridview.Columns["Function"].FillWeight = 15;

            this.EditGridview.Columns["Follow"].FillWeight = 10;
            this.EditGridview.Columns["Axis"].FillWeight = 10;
            this.EditGridview.Columns["Speed(%)"].FillWeight = 10;
            this.EditGridview.Columns["Position"].FillWeight = 15;
            this.EditGridview.Columns["Delay(ms)"].FillWeight = 10;
            this.EditGridview.Columns["Next"].FillWeight = 10;
            this.EditGridview.Columns["Describe"].FillWeight = 15;

            this.EditGridview.Columns["Num"].ReadOnly = true;

            this.EditGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; //DataGridViewAutoSizeColumnsMode.Fill;

            this.EditGridview.Columns["Num"].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.EditGridview.Columns["Function"].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.EditGridview.Columns["Follow"].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.EditGridview.Columns["Axis"].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.EditGridview.Columns["Speed(%)"].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.EditGridview.Columns["Position"].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.EditGridview.Columns["Delay(ms)"].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.EditGridview.Columns["Next"].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.EditGridview.Columns["Describe"].SortMode = DataGridViewColumnSortMode.NotSortable;

            UserListDT.BeginLoadData();


            for (int i = 0; i < 64; i++)
            {
                //DataRow dr = PIDParamentDT.NewRow();             
                //dr["Name"] = "PID";
                //dr["Value"] = "123";
                //dr["Desc"] = "Setpid";
                //PIDParamentDT.Rows.Add(dr);
                UserListDT.Rows.Add();
                CB_TAPosition[0].Items.Add("N" + (i + 1));
                CB_TAPosition[1].Items.Add("N" + (i + 1));
                CB_TAPosition[2].Items.Add("N" + (i + 1));
                CB_TAPosition[3].Items.Add("N" + (i + 1));
                CB_TAPosition[4].Items.Add("N" + (i + 1));

                UserListDT.Rows[i]["Num"] = UserListDT.Rows.Count.ToString();
                UserListDT.Rows[i]["Function"] = "0";
                UserListDT.Rows[i]["Follow"] = "0";
                UserListDT.Rows[i]["Axis"] = "";
                UserListDT.Rows[i]["Speed(%)"] = "100";
                UserListDT.Rows[i]["Position"] = "";
                UserListDT.Rows[i]["Delay(ms)"] = "20";
                UserListDT.Rows[i]["Next"] = "0";
                UserListDT.Rows[i]["Describe"] = "***";
            }

            UserListDT.EndLoadData();

        }

        private void btn_Import_Click(object sender, EventArgs e)
        { 
             string resultFile;
             OpenFileDialog openFileDialog1 = new OpenFileDialog();
             openFileDialog1.InitialDirectory = Application.StartupPath + @"\Config";
             openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
             openFileDialog1.RestoreDirectory = true;
             if (openFileDialog1.ShowDialog() == DialogResult.OK)
             {
                 resultFile = openFileDialog1.FileName;
                 CsvFiles csv = new CsvFiles();
                 UserListDT.BeginLoadData();
                 UserListDT = csv.OpenCSV(resultFile);
                 EditGridview.DataSource = UserListDT;
                 UserListDT.EndLoadData();
             }         
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Application.StartupPath + @"\Config";
            saveFileDialog1.Filter = "csv files (*.csv)|*.csv|All files(*.*)|*>**";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                CsvFiles csv = new CsvFiles();
                //  csv.SaveCSV(UserListDT, Application.StartupPath + @"\Config" + @"\Userlist.csv");
                csv.SaveCSV(UserListDT, saveFileDialog1.FileName);  
            }

        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            try
            {
                pbar_Download.Minimum = 0;
                pbar_Download.Maximum = 63;

                FormMain fm = (FormMain)this.Owner;

                for (int row = 0; row < 64; row++)
                {
                    pbar_Download.Value = row;
                    Int16 adrss = (Int16)(3000 + (row * 16)); ;
                    Int16 len = 16;
                    UInt16[] r_buff = new UInt16[len];              //申请数组空间
                    Int16 ret = fm.Read_Regedit(adrss, len, ref r_buff);
                    if (ret == 0)
                    {
                        Int32 Num = (Int32)(r_buff[0] & 0xff);

                        Int32 Function = 0;
                        Int32 Follow = 0;
                        Int32 AxisN = 0;
                        Int32 Speed = 0;
                        Int32 Position = 0;
                        Int32 Delay = 0;
                        Int32 Next = 0;

                        string Describ = "";

                        if (Num < 65)
                        {
                            Follow = (Int32)((r_buff[0] & 0xff00) >> 8);
                            Next = (Int32)(r_buff[1] & 0xff);

                            AxisN = (Int32)(r_buff[2] & 0xff);
                            Function = (Int32)((r_buff[2] & 0xff00) >> 8);
                            if (Function > 3) Function = 0;
                            Speed = (Int32)(r_buff[3] & 0xff);

                            Position = (Int32)(r_buff[5] << 16);
                            Position = r_buff[4] + Position;

                            Delay = (Int32)r_buff[6];

                            byte[] bytstr = new byte[8];
                            for (int i = 0; i < 4; i++)
                            {
                                bytstr[i * 2] = (byte)((r_buff[12 + i] & 0xff00) >> 8);
                                bytstr[(i * 2) + 1] = (byte)(r_buff[12 + i] & 0x00ff);
                            }

                            isString(bytstr, out Describ);
                        }
                        else
                        {

                        }
                        // UserListDT.Rows[row]["Num"] = Num.ToString();
                        UserListDT.Rows[row]["Function"] = Function.ToString();
                        UserListDT.Rows[row]["Follow"] = Follow.ToString();
                        UserListDT.Rows[row]["Axis"] = AxisN.ToString();
                        UserListDT.Rows[row]["Speed(%)"] = Speed.ToString();
                        UserListDT.Rows[row]["Position"] = Position.ToString();
                        UserListDT.Rows[row]["Delay(ms)"] = Delay.ToString();
                        UserListDT.Rows[row]["Next"] = Next.ToString();
                        UserListDT.Rows[row]["Describe"] = Describ;

                    }
                }
                MessageBox.Show("up load ok!");
                pbar_Download.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            pbar_Download.Minimum = 0;
            pbar_Download.Maximum = 63;
            for (UInt16 i = 0; i < 64; i++)
            {
                SaveRowData(i);
                pbar_Download.Value = i;
                Thread.Sleep(10);
            }
            MessageBox.Show("Down load ok!");
            pbar_Download.Value = 0;
          
        }

        private Int16 SaveRowData(UInt16 row)
        {
            FormMain fm = (FormMain)this.Owner;

            UInt16 r_RowNum = row;
            Int16 adrss = (Int16)(3000 + (r_RowNum * 16));
            Int16 len = 16;
            UInt16[] w_buff = new UInt16[len];              //申请数组空间

            int Num = 0;
            if (isNumberic(UserListDT.Rows[row][0].ToString(), out Num) == false)
            { Num = 0; UserListDT.Rows[row][0] = "0"; }

            Int32 Function = 0;
            if (isNumberic(UserListDT.Rows[row][1].ToString(), out Function) == false)
            { Function = 0; UserListDT.Rows[row][1] = "0"; }

            Int32 Follow = 0;
            if (isNumberic(UserListDT.Rows[row][2].ToString(), out Follow) == false)
            { Follow = 0; UserListDT.Rows[row][2] = "0"; }

            Int32 AxisN = 0;
            if (isNumberic(UserListDT.Rows[row][3].ToString(), out AxisN) == false)
            { AxisN = 0; UserListDT.Rows[row][3] = "0"; }

            Int32 Speed = 0;
            if (isNumberic(UserListDT.Rows[row][4].ToString(), out Speed) == false)
            { Speed = 0; UserListDT.Rows[row][4] = "0"; }

            Int32 Position = 0;
            if (isNumberic(UserListDT.Rows[row][5].ToString(), out Position) == false)
            { Position = 0; UserListDT.Rows[row][5] = "0"; }

            Int32 Delay = 0;
            if (isNumberic(UserListDT.Rows[row][6].ToString(), out Delay) == false)
            { Delay = 0; UserListDT.Rows[row][6] = "0"; }

            Int32 Next = 0;
            if (isNumberic(UserListDT.Rows[row][7].ToString(), out Next) == false)
            { Next = 0; UserListDT.Rows[row][7] = "0"; }

            w_buff[0] = (UInt16)(Follow << 8 | Num);
            w_buff[1] = (UInt16)Next;
            w_buff[2] = (UInt16)(Function << 8 | AxisN);
            w_buff[3] = (UInt16)Speed;
            w_buff[4] = (UInt16)(Position & 0xffff);
            w_buff[5] = (UInt16)(Position >> 16);
            w_buff[6] = (UInt16)Delay;
            w_buff[7] = 0;

            string strdes = UserListDT.Rows[row]["Describe"].ToString();
            strdes = strdes + "        ";//8个空格

            strdes = strdes.Substring(0, 8);//不够补空格

            byte[] bytearry = System.Text.Encoding.Default.GetBytes(strdes);

            for (int i = 0; i < 4; i++)
            {
                w_buff[12+i] = (ushort)((bytearry[i * 2]<<8) | bytearry[(i * 2) + 1]);
            }

            Int16 result = fm.Write_Regedit(adrss, len, w_buff);  //写入目标位置
            Thread.Sleep(10);

            adrss = 2250;
            len = 2;
            w_buff = new UInt16[len];              //申请数组空间

            w_buff[0] = 1; //使能写入
            w_buff[1] = (UInt16)r_RowNum; //写入的行号
            fm.DisplayLog(1, "* Download User list");
            result = fm.Write_Regedit(adrss, len, w_buff);  //写入目标位置
            fm.DisplayLog(1, "* Write data[ " + result + " ]");

            return result;
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

        protected bool isString(byte[] bytstr, out string str)
        {

            str = "";   //result 定义为out 用来输出值
            try
            {
                 str = System.Text.Encoding.Default.GetString(bytstr);

                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btn_AxisTeach_Click(object sender, EventArgs e)
        {
            Button btn = (Button)(sender); // 获取index
            try
            {
                int axis = (Int32)btn.TabIndex;

                Int32 row = CB_TAPosition[axis].SelectedIndex;

                Int32 Follow = 0;
                Int32 Next = 0;

                Int32 AxisN = axis + 1;
                Int32 Function = 2; //rel mode
                Int32 Speed = 100;

                FormMain fm = (FormMain)this.Owner;
                string Position = fm.txt_CurrentPosition[axis].Text;              

                Int32 Delay = 20;

                string Describ = "**";

               // UserListDT.Rows[row]["Num"] = Num.ToString();
                UserListDT.Rows[row]["Function"] = Function.ToString();
                UserListDT.Rows[row]["Follow"] = Follow.ToString();
                UserListDT.Rows[row]["Axis"] = AxisN.ToString();
                UserListDT.Rows[row]["Speed(%)"] = Speed.ToString();
                UserListDT.Rows[row]["Position"] = Position.ToString();
                UserListDT.Rows[row]["Delay(ms)"] = Delay.ToString();
                UserListDT.Rows[row]["Next"] = Next.ToString();
                UserListDT.Rows[row]["Describe"] = Describ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
        }




        private void btn_RelMotionP_click(object sender, EventArgs e)
        {
            Button btn = (Button)(sender); // 获取index
            try
            {
                Int16 AxisNum = (Int16)btn.TabIndex;

                FormMain fm = (FormMain)this.Owner;

                Int16 adrss = (Int16)(2000 + AxisNum * 60 + 34);
                Int16 w_Len = 4;

                UInt16[] w_buff = new UInt16[4];   //申请数组空间
                w_buff[0] = 1;
                w_buff[1] = 0;

                Int32 position = Convert.ToInt32(CB_Step.Text);

                w_buff[2] = (UInt16)(position & 0xffff);
                w_buff[3] = (UInt16)(position >> 16);

                Int16 ret = fm.Write_Regedit(adrss, (short)w_Len, w_buff);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
        }


        private void btn_RelMotionN_click(object sender, EventArgs e)
        {
            Button btn = (Button)(sender); // 获取index
            try
            {
                Int16 AxisNum = (Int16)btn.TabIndex;

                FormMain fm = (FormMain)this.Owner;

                Int16 adrss = (Int16)(2000 + AxisNum * 60 + 34);
                Int16 w_Len = 4;

                UInt16[] w_buff = new UInt16[4];   //申请数组空间
                w_buff[0] = 1;
                w_buff[1] = 0;

                Int32 position = Convert.ToInt32(CB_Step.Text) * -1;

                w_buff[2] = (UInt16)(position & 0xffff);
                w_buff[3] = (UInt16)(position >> 16);

                Int16 ret = fm.Write_Regedit(adrss, (short)w_Len, w_buff);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
        }

        private void btn_MoveNum_Click(object sender, EventArgs e)
        {
                FormMain fm = (FormMain)this.Owner;

                Int16 adrss = (Int16)(2000 + 260);
                Int16 w_Len = 1;
                UInt16[] w_buff = new UInt16[1];   //申请数组空间

                w_buff[0] = (ushort)(CB_TA5Position.SelectedIndex+1); //Convert.ToInt32(CB_Step.Text);

                Int16 ret = fm.Write_Regedit(adrss, (short)w_Len, w_buff);

                this.timer_ReadRunStatus.Interval = 200;
                this.timer_ReadRunStatus.Enabled = true;
                this.timer_ReadRunStatus.Start();
        }

        private void btn_StopMove_Click(object sender, EventArgs e)
        {
            this.timer_ReadRunStatus.Stop();
            FormMain fm = (FormMain)this.Owner;

            Int16 adrss = (Int16)(2000 + 261);
            Int16 w_Len = 1;
            UInt16[] w_buff = new UInt16[1];   //申请数组空间
            w_buff[0] = 1;
            Int16 ret = fm.Write_Regedit(adrss, (short)w_Len, w_buff);
        }

        private void EditGridview_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 1) && (e.RowIndex > -1))
            {
                //dt.Rows.Add("0", "NULL");
                //dt.Rows.Add("1", "GOHOME");
                //dt.Rows.Add("2", "M_ABS");
                //dt.Rows.Add("3", "M_REL");
                //dt.Rows.Add("4", "ESTOP");
                //dt.Rows.Add("5", "OUTPUT");
                //dt.Rows.Add("6", "PWM");
                switch (UserListDT.Rows[e.RowIndex]["Function"].ToString())
                {
                    case "0":
                        break;
                    case "1":
                        MessageBox.Show("在[axis]栏输入轴号，其他参数不使用");
                        break;
                    case "2":                       
                        break;
                    case "3":
                        MessageBox.Show("在[axis]栏输入轴号，其他参数不使用");
                        break;
                    case "4":
                        MessageBox.Show("在[axis]栏输入轴号，其他参数不使用");
                        break;
                    case "5":
                        MessageBox.Show("在[axis]栏输入输出端口（1-8），[Position]栏输入值（0或1），其他参数不使用");
                        break;
                    case "6":
                        MessageBox.Show("在[axis]栏输入输出通道（1或2），[Speed]栏输入占空比（0-100），[Position]栏输入频率，其他参数不使用");
                        break;
                }

            }
            if ((e.RowIndex > -1) && (e.ColumnIndex > 0))
            {
                //Int16 AxisNum = (Int16)(e.ColumnIndex - 1);
                UInt16 RowNum = (UInt16)e.RowIndex;

                SaveRowData(RowNum);
            }
        }

        private void EditGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }


        private void timer_ReadRunStatus_Tick(object sender, EventArgs e)
        {
            FormMain fm = (FormMain)this.Owner;

            Int16 adrss = (Int16)(2000 + 260); ;
            Int16 len = 1;
            UInt16[] r_buff = new UInt16[len];              //申请数组空间
            Int16 ret = fm.Read_Regedit(adrss, len, ref r_buff);
            if (ret == 0)
            {
                if (r_buff[0] == 0)
                {
                    foreach (DataGridViewRow row in EditGridview.Rows)
                    {
                        row.Selected = false;
                    }
                }
                else
                {
                    Int32 runrow = r_buff[0] & 0x00ff;
                    Int32 runstatus = r_buff[0] & 0xff00;
                    if (runrow < 65)
                    {
                        foreach (DataGridViewRow row in EditGridview.Rows)
                        {
                            row.Selected = false;
                        }
                        this.EditGridview.Rows[runrow - 1].Selected = true;
                    }

                    if (runstatus != 0xff00)
                    {
                        btn_StopMove.BackColor = Color.Red;
                    }
                    else
                    {
                        btn_StopMove.BackColor = SystemColors.Control;
                    }
                }


            }
        }

        private void FormList_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.timer_ReadRunStatus.Enabled = false;
            this.timer_ReadRunStatus.Stop();
        }

    }
}
