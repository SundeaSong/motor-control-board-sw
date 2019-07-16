namespace WindowsFormsApp
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tESTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyTeachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.截图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectState = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tprogress = new System.Windows.Forms.ToolStripProgressBar();
            this.tTimeNow = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CBVarPort = new System.Windows.Forms.ComboBox();
            this.labAvailPort = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Net = new System.Windows.Forms.Button();
            this.OpenPath = new System.Windows.Forms.Button();
            this.Calc = new System.Windows.Forms.Button();
            this.Screenshot = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.Server_con = new System.Windows.Forms.Button();
            this.DrawBoard = new System.Windows.Forms.Button();
            this.Savefile = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_InitParament = new System.Windows.Forms.Button();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.btn_DWload = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.Axis4Homestatus = new System.Windows.Forms.Label();
            this.Axis3Homestatus = new System.Windows.Forms.Label();
            this.Axis2Homestatus = new System.Windows.Forms.Label();
            this.Axis1Homestatus = new System.Windows.Forms.Label();
            this.btn_Axis4Gohome = new System.Windows.Forms.Button();
            this.btn_Axis4Emgstop = new System.Windows.Forms.Button();
            this.btn_Axis4AbsMotion = new System.Windows.Forms.Button();
            this.btn_Axis4RelMotion = new System.Windows.Forms.Button();
            this.Axis4TargetPostion = new System.Windows.Forms.TextBox();
            this.Axis4Motionstatus = new System.Windows.Forms.Label();
            this.Axis4CurrentPosition = new System.Windows.Forms.TextBox();
            this.btn_Axis3Gohome = new System.Windows.Forms.Button();
            this.btn_Axis3Emgstop = new System.Windows.Forms.Button();
            this.btn_Axis3AbsMotion = new System.Windows.Forms.Button();
            this.btn_Axis3RelMotion = new System.Windows.Forms.Button();
            this.Axis3TargetPostion = new System.Windows.Forms.TextBox();
            this.Axis3Motionstatus = new System.Windows.Forms.Label();
            this.Axis3CurrentPosition = new System.Windows.Forms.TextBox();
            this.btn_Axis2Gohome = new System.Windows.Forms.Button();
            this.btn_Axis2Emgstop = new System.Windows.Forms.Button();
            this.btn_Axis2AbsMotion = new System.Windows.Forms.Button();
            this.btn_Axis2RelMotion = new System.Windows.Forms.Button();
            this.Axis2TargetPostion = new System.Windows.Forms.TextBox();
            this.Axis2Motionstatus = new System.Windows.Forms.Label();
            this.Axis2CurrentPosition = new System.Windows.Forms.TextBox();
            this.btn_Axis1Gohome = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Axis1Emgstop = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Axis1AbsMotion = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Axis1RelMotion = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Axis1TargetPostion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Axis1Motionstatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Axis1CurrentPosition = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chk_EnablePWM = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.Btn_updatePwm = new System.Windows.Forms.Button();
            this.txt_DutyCH2 = new System.Windows.Forms.TextBox();
            this.txt_DutyCH1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Frequency = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chk_X14 = new System.Windows.Forms.CheckBox();
            this.chk_X13 = new System.Windows.Forms.CheckBox();
            this.chk_Y8 = new System.Windows.Forms.CheckBox();
            this.chk_Y7 = new System.Windows.Forms.CheckBox();
            this.chk_Y6 = new System.Windows.Forms.CheckBox();
            this.chk_Y5 = new System.Windows.Forms.CheckBox();
            this.chk_Y4 = new System.Windows.Forms.CheckBox();
            this.chk_Y3 = new System.Windows.Forms.CheckBox();
            this.chk_Y2 = new System.Windows.Forms.CheckBox();
            this.chk_Y1 = new System.Windows.Forms.CheckBox();
            this.chk_X12 = new System.Windows.Forms.CheckBox();
            this.chk_X11 = new System.Windows.Forms.CheckBox();
            this.chk_X10 = new System.Windows.Forms.CheckBox();
            this.chk_X9 = new System.Windows.Forms.CheckBox();
            this.chk_X8 = new System.Windows.Forms.CheckBox();
            this.chk_X7 = new System.Windows.Forms.CheckBox();
            this.chk_X6 = new System.Windows.Forms.CheckBox();
            this.chk_X5 = new System.Windows.Forms.CheckBox();
            this.chk_X4 = new System.Windows.Forms.CheckBox();
            this.chk_X3 = new System.Windows.Forms.CheckBox();
            this.chk_X2 = new System.Windows.Forms.CheckBox();
            this.chk_X1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EditGridview = new System.Windows.Forms.DataGridView();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Axis1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Axis2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Axis3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Axis4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogList = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.截图ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1146, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.文件ToolStripMenuItem.Text = "File(F)";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tESTToolStripMenuItem,
            this.eDITToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.easyTeachToolStripMenuItem});
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.视图ToolStripMenuItem.Text = "View(V)";
            // 
            // tESTToolStripMenuItem
            // 
            this.tESTToolStripMenuItem.Name = "tESTToolStripMenuItem";
            this.tESTToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.tESTToolStripMenuItem.Text = "Show Console";
            this.tESTToolStripMenuItem.Click += new System.EventHandler(this.tESTToolStripMenuItem_Click);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.eDITToolStripMenuItem.Text = "Hide Console";
            this.eDITToolStripMenuItem.Click += new System.EventHandler(this.eDITToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.debugToolStripMenuItem.Text = "Debug";
            this.debugToolStripMenuItem.Click += new System.EventHandler(this.debugToolStripMenuItem_Click);
            // 
            // easyTeachToolStripMenuItem
            // 
            this.easyTeachToolStripMenuItem.Name = "easyTeachToolStripMenuItem";
            this.easyTeachToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.easyTeachToolStripMenuItem.Text = "Easy Teach";
            this.easyTeachToolStripMenuItem.Click += new System.EventHandler(this.easyTeachToolStripMenuItem_Click);
            // 
            // 截图ToolStripMenuItem
            // 
            this.截图ToolStripMenuItem.Name = "截图ToolStripMenuItem";
            this.截图ToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.截图ToolStripMenuItem.Text = "Screen(S)";
            this.截图ToolStripMenuItem.Click += new System.EventHandler(this.截图ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.帮助ToolStripMenuItem.Text = "Help(H)";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.关于ToolStripMenuItem.Text = "About(A)";
            // 
            // ConnectState
            // 
            this.ConnectState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ConnectState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConnectState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConnectState.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConnectState.Location = new System.Drawing.Point(8, 28);
            this.ConnectState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConnectState.Name = "ConnectState";
            this.ConnectState.Size = new System.Drawing.Size(86, 48);
            this.ConnectState.TabIndex = 7;
            this.ConnectState.Text = "Connect";
            this.ConnectState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.tprogress,
            this.tTimeNow,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 748);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1146, 26);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Lime;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(52, 21);
            this.toolStripStatusLabel1.Text = "Normal";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(60, 21);
            this.toolStripStatusLabel2.Text = "Progress";
            // 
            // tprogress
            // 
            this.tprogress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tprogress.Name = "tprogress";
            this.tprogress.Size = new System.Drawing.Size(100, 20);
            // 
            // tTimeNow
            // 
            this.tTimeNow.Name = "tTimeNow";
            this.tTimeNow.Size = new System.Drawing.Size(126, 21);
            this.tTimeNow.Text = "2015-09-19 12:00:00";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(237, 21);
            this.toolStripStatusLabel3.Text = "Snail.KunShan Myzy Technology Co.,Ltd";
            this.toolStripStatusLabel3.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // CBVarPort
            // 
            this.CBVarPort.FormattingEnabled = true;
            this.CBVarPort.Location = new System.Drawing.Point(684, 45);
            this.CBVarPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CBVarPort.Name = "CBVarPort";
            this.CBVarPort.Size = new System.Drawing.Size(116, 20);
            this.CBVarPort.TabIndex = 26;
            // 
            // labAvailPort
            // 
            this.labAvailPort.AutoSize = true;
            this.labAvailPort.Location = new System.Drawing.Point(607, 50);
            this.labAvailPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAvailPort.Name = "labAvailPort";
            this.labAvailPort.Size = new System.Drawing.Size(71, 12);
            this.labAvailPort.TabIndex = 28;
            this.labAvailPort.Text = "Avail Port:";
            this.labAvailPort.Click += new System.EventHandler(this.labAvailPort_Click);
            this.labAvailPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labAvailPort_MouseDown);
            this.labAvailPort.MouseLeave += new System.EventHandler(this.labAvailPort_MouseLeave);
            this.labAvailPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labAvailPort_MouseUp);
            // 
            // Net
            // 
            this.Net.Image = ((System.Drawing.Image)(resources.GetObject("Net.Image")));
            this.Net.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Net.Location = new System.Drawing.Point(384, 28);
            this.Net.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Net.Name = "Net";
            this.Net.Size = new System.Drawing.Size(50, 48);
            this.Net.TabIndex = 1;
            this.Net.Text = "Net";
            this.Net.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Net.UseVisualStyleBackColor = true;
            this.Net.Click += new System.EventHandler(this.Net_Click);
            // 
            // OpenPath
            // 
            this.OpenPath.Image = ((System.Drawing.Image)(resources.GetObject("OpenPath.Image")));
            this.OpenPath.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.OpenPath.Location = new System.Drawing.Point(102, 28);
            this.OpenPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OpenPath.Name = "OpenPath";
            this.OpenPath.Size = new System.Drawing.Size(54, 48);
            this.OpenPath.TabIndex = 2;
            this.OpenPath.Text = "Path";
            this.OpenPath.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OpenPath.UseVisualStyleBackColor = true;
            this.OpenPath.Click += new System.EventHandler(this.OpenPath_Click);
            // 
            // Calc
            // 
            this.Calc.Image = ((System.Drawing.Image)(resources.GetObject("Calc.Image")));
            this.Calc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Calc.Location = new System.Drawing.Point(268, 28);
            this.Calc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(58, 48);
            this.Calc.TabIndex = 3;
            this.Calc.Text = "Calc";
            this.Calc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // Screenshot
            // 
            this.Screenshot.Image = ((System.Drawing.Image)(resources.GetObject("Screenshot.Image")));
            this.Screenshot.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Screenshot.Location = new System.Drawing.Point(329, 28);
            this.Screenshot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Screenshot.Name = "Screenshot";
            this.Screenshot.Size = new System.Drawing.Size(53, 48);
            this.Screenshot.TabIndex = 4;
            this.Screenshot.Text = "Screen";
            this.Screenshot.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Screenshot.UseVisualStyleBackColor = true;
            this.Screenshot.Click += new System.EventHandler(this.Screenshot_Click);
            // 
            // Admin
            // 
            this.Admin.Image = ((System.Drawing.Image)(resources.GetObject("Admin.Image")));
            this.Admin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Admin.Location = new System.Drawing.Point(436, 28);
            this.Admin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(52, 48);
            this.Admin.TabIndex = 5;
            this.Admin.Text = "Task";
            this.Admin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // Server_con
            // 
            this.Server_con.Image = ((System.Drawing.Image)(resources.GetObject("Server_con.Image")));
            this.Server_con.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Server_con.Location = new System.Drawing.Point(838, 28);
            this.Server_con.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Server_con.Name = "Server_con";
            this.Server_con.Size = new System.Drawing.Size(84, 48);
            this.Server_con.TabIndex = 10;
            this.Server_con.Text = "Connect";
            this.Server_con.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Server_con.UseVisualStyleBackColor = true;
            this.Server_con.Click += new System.EventHandler(this.Server_con_Click);
            // 
            // DrawBoard
            // 
            this.DrawBoard.Image = ((System.Drawing.Image)(resources.GetObject("DrawBoard.Image")));
            this.DrawBoard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DrawBoard.Location = new System.Drawing.Point(212, 28);
            this.DrawBoard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DrawBoard.Name = "DrawBoard";
            this.DrawBoard.Size = new System.Drawing.Size(52, 48);
            this.DrawBoard.TabIndex = 14;
            this.DrawBoard.Text = "Draw";
            this.DrawBoard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DrawBoard.UseVisualStyleBackColor = true;
            this.DrawBoard.Click += new System.EventHandler(this.DrawBoard_Click);
            // 
            // Savefile
            // 
            this.Savefile.Image = ((System.Drawing.Image)(resources.GetObject("Savefile.Image")));
            this.Savefile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Savefile.Location = new System.Drawing.Point(157, 28);
            this.Savefile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Savefile.Name = "Savefile";
            this.Savefile.Size = new System.Drawing.Size(54, 48);
            this.Savefile.TabIndex = 21;
            this.Savefile.Text = "Save";
            this.Savefile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Savefile.UseVisualStyleBackColor = true;
            this.Savefile.Click += new System.EventHandler(this.Savefile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(4, 75);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(1087, 579);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_InitParament);
            this.groupBox3.Controls.Add(this.btn_Upload);
            this.groupBox3.Controls.Add(this.btn_DWload);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.Axis4Homestatus);
            this.groupBox3.Controls.Add(this.Axis3Homestatus);
            this.groupBox3.Controls.Add(this.Axis2Homestatus);
            this.groupBox3.Controls.Add(this.Axis1Homestatus);
            this.groupBox3.Controls.Add(this.btn_Axis4Gohome);
            this.groupBox3.Controls.Add(this.btn_Axis4Emgstop);
            this.groupBox3.Controls.Add(this.btn_Axis4AbsMotion);
            this.groupBox3.Controls.Add(this.btn_Axis4RelMotion);
            this.groupBox3.Controls.Add(this.Axis4TargetPostion);
            this.groupBox3.Controls.Add(this.Axis4Motionstatus);
            this.groupBox3.Controls.Add(this.Axis4CurrentPosition);
            this.groupBox3.Controls.Add(this.btn_Axis3Gohome);
            this.groupBox3.Controls.Add(this.btn_Axis3Emgstop);
            this.groupBox3.Controls.Add(this.btn_Axis3AbsMotion);
            this.groupBox3.Controls.Add(this.btn_Axis3RelMotion);
            this.groupBox3.Controls.Add(this.Axis3TargetPostion);
            this.groupBox3.Controls.Add(this.Axis3Motionstatus);
            this.groupBox3.Controls.Add(this.Axis3CurrentPosition);
            this.groupBox3.Controls.Add(this.btn_Axis2Gohome);
            this.groupBox3.Controls.Add(this.btn_Axis2Emgstop);
            this.groupBox3.Controls.Add(this.btn_Axis2AbsMotion);
            this.groupBox3.Controls.Add(this.btn_Axis2RelMotion);
            this.groupBox3.Controls.Add(this.Axis2TargetPostion);
            this.groupBox3.Controls.Add(this.Axis2Motionstatus);
            this.groupBox3.Controls.Add(this.Axis2CurrentPosition);
            this.groupBox3.Controls.Add(this.btn_Axis1Gohome);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btn_Axis1Emgstop);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btn_Axis1AbsMotion);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btn_Axis1RelMotion);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.Axis1TargetPostion);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.Axis1Motionstatus);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Axis1CurrentPosition);
            this.groupBox3.Location = new System.Drawing.Point(16, 329);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(748, 243);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motion control";
            // 
            // btn_InitParament
            // 
            this.btn_InitParament.Location = new System.Drawing.Point(619, 115);
            this.btn_InitParament.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_InitParament.Name = "btn_InitParament";
            this.btn_InitParament.Size = new System.Drawing.Size(83, 35);
            this.btn_InitParament.TabIndex = 89;
            this.btn_InitParament.Text = "Init Parament";
            this.btn_InitParament.UseVisualStyleBackColor = true;
            this.btn_InitParament.Visible = false;
            this.btn_InitParament.Click += new System.EventHandler(this.btn_InitParament_Click);
            // 
            // btn_Upload
            // 
            this.btn_Upload.Location = new System.Drawing.Point(619, 38);
            this.btn_Upload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(83, 55);
            this.btn_Upload.TabIndex = 88;
            this.btn_Upload.Text = "Up load";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // btn_DWload
            // 
            this.btn_DWload.Location = new System.Drawing.Point(619, 174);
            this.btn_DWload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_DWload.Name = "btn_DWload";
            this.btn_DWload.Size = new System.Drawing.Size(83, 55);
            this.btn_DWload.TabIndex = 87;
            this.btn_DWload.Text = "Down load";
            this.btn_DWload.UseVisualStyleBackColor = true;
            this.btn_DWload.Click += new System.EventHandler(this.btn_DWload_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 182);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 12);
            this.label19.TabIndex = 86;
            this.label19.Text = "home status:";
            // 
            // Axis4Homestatus
            // 
            this.Axis4Homestatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Axis4Homestatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Axis4Homestatus.Location = new System.Drawing.Point(478, 174);
            this.Axis4Homestatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Axis4Homestatus.Name = "Axis4Homestatus";
            this.Axis4Homestatus.Size = new System.Drawing.Size(88, 24);
            this.Axis4Homestatus.TabIndex = 3;
            this.Axis4Homestatus.Text = "status";
            this.Axis4Homestatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Axis3Homestatus
            // 
            this.Axis3Homestatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Axis3Homestatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Axis3Homestatus.Location = new System.Drawing.Point(373, 174);
            this.Axis3Homestatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Axis3Homestatus.Name = "Axis3Homestatus";
            this.Axis3Homestatus.Size = new System.Drawing.Size(88, 24);
            this.Axis3Homestatus.TabIndex = 2;
            this.Axis3Homestatus.Text = "status";
            this.Axis3Homestatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Axis2Homestatus
            // 
            this.Axis2Homestatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Axis2Homestatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Axis2Homestatus.Location = new System.Drawing.Point(270, 174);
            this.Axis2Homestatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Axis2Homestatus.Name = "Axis2Homestatus";
            this.Axis2Homestatus.Size = new System.Drawing.Size(88, 24);
            this.Axis2Homestatus.TabIndex = 1;
            this.Axis2Homestatus.Text = "status";
            this.Axis2Homestatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Axis1Homestatus
            // 
            this.Axis1Homestatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Axis1Homestatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Axis1Homestatus.Location = new System.Drawing.Point(166, 174);
            this.Axis1Homestatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Axis1Homestatus.Name = "Axis1Homestatus";
            this.Axis1Homestatus.Size = new System.Drawing.Size(88, 24);
            this.Axis1Homestatus.TabIndex = 0;
            this.Axis1Homestatus.Text = "status";
            this.Axis1Homestatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Axis4Gohome
            // 
            this.btn_Axis4Gohome.Location = new System.Drawing.Point(478, 204);
            this.btn_Axis4Gohome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Axis4Gohome.Name = "btn_Axis4Gohome";
            this.btn_Axis4Gohome.Size = new System.Drawing.Size(88, 36);
            this.btn_Axis4Gohome.TabIndex = 3;
            this.btn_Axis4Gohome.Text = "Go Home";
            this.btn_Axis4Gohome.UseVisualStyleBackColor = true;
            // 
            // btn_Axis4Emgstop
            // 
            this.btn_Axis4Emgstop.Location = new System.Drawing.Point(478, 132);
            this.btn_Axis4Emgstop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Axis4Emgstop.Name = "btn_Axis4Emgstop";
            this.btn_Axis4Emgstop.Size = new System.Drawing.Size(88, 36);
            this.btn_Axis4Emgstop.TabIndex = 3;
            this.btn_Axis4Emgstop.Text = "Stop";
            this.btn_Axis4Emgstop.UseVisualStyleBackColor = true;
            // 
            // btn_Axis4AbsMotion
            // 
            this.btn_Axis4AbsMotion.Location = new System.Drawing.Point(522, 95);
            this.btn_Axis4AbsMotion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Axis4AbsMotion.Name = "btn_Axis4AbsMotion";
            this.btn_Axis4AbsMotion.Size = new System.Drawing.Size(42, 34);
            this.btn_Axis4AbsMotion.TabIndex = 3;
            this.btn_Axis4AbsMotion.Text = "Go";
            this.btn_Axis4AbsMotion.UseVisualStyleBackColor = true;
            // 
            // btn_Axis4RelMotion
            // 
            this.btn_Axis4RelMotion.Location = new System.Drawing.Point(478, 95);
            this.btn_Axis4RelMotion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Axis4RelMotion.Name = "btn_Axis4RelMotion";
            this.btn_Axis4RelMotion.Size = new System.Drawing.Size(42, 34);
            this.btn_Axis4RelMotion.TabIndex = 3;
            this.btn_Axis4RelMotion.Text = "Go";
            this.btn_Axis4RelMotion.UseVisualStyleBackColor = true;
            // 
            // Axis4TargetPostion
            // 
            this.Axis4TargetPostion.Location = new System.Drawing.Point(478, 66);
            this.Axis4TargetPostion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Axis4TargetPostion.Name = "Axis4TargetPostion";
            this.Axis4TargetPostion.Size = new System.Drawing.Size(87, 21);
            this.Axis4TargetPostion.TabIndex = 3;
            // 
            // Axis4Motionstatus
            // 
            this.Axis4Motionstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Axis4Motionstatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Axis4Motionstatus.Location = new System.Drawing.Point(478, 36);
            this.Axis4Motionstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Axis4Motionstatus.Name = "Axis4Motionstatus";
            this.Axis4Motionstatus.Size = new System.Drawing.Size(88, 24);
            this.Axis4Motionstatus.TabIndex = 3;
            this.Axis4Motionstatus.Text = "status";
            this.Axis4Motionstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Axis4CurrentPosition
            // 
            this.Axis4CurrentPosition.Location = new System.Drawing.Point(478, 12);
            this.Axis4CurrentPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Axis4CurrentPosition.Name = "Axis4CurrentPosition";
            this.Axis4CurrentPosition.Size = new System.Drawing.Size(87, 21);
            this.Axis4CurrentPosition.TabIndex = 3;
            // 
            // btn_Axis3Gohome
            // 
            this.btn_Axis3Gohome.Location = new System.Drawing.Point(373, 204);
            this.btn_Axis3Gohome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Axis3Gohome.Name = "btn_Axis3Gohome";
            this.btn_Axis3Gohome.Size = new System.Drawing.Size(88, 36);
            this.btn_Axis3Gohome.TabIndex = 2;
            this.btn_Axis3Gohome.Text = "Go Home";
            this.btn_Axis3Gohome.UseVisualStyleBackColor = true;
            // 
            // btn_Axis3Emgstop
            // 
            this.btn_Axis3Emgstop.Location = new System.Drawing.Point(373, 132);
            this.btn_Axis3Emgstop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Axis3Emgstop.Name = "btn_Axis3Emgstop";
            this.btn_Axis3Emgstop.Size = new System.Drawing.Size(88, 36);
            this.btn_Axis3Emgstop.TabIndex = 2;
            this.btn_Axis3Emgstop.Text = "Stop";
            this.btn_Axis3Emgstop.UseVisualStyleBackColor = true;
            // 
            // btn_Axis3AbsMotion
            // 
            this.btn_Axis3AbsMotion.Location = new System.Drawing.Point(418, 95);
            this.btn_Axis3AbsMotion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Axis3AbsMotion.Name = "btn_Axis3AbsMotion";
            this.btn_Axis3AbsMotion.Size = new System.Drawing.Size(42, 34);
            this.btn_Axis3AbsMotion.TabIndex = 2;
            this.btn_Axis3AbsMotion.Text = "Go";
            this.btn_Axis3AbsMotion.UseVisualStyleBackColor = true;
            // 
            // btn_Axis3RelMotion
            // 
            this.btn_Axis3RelMotion.Location = new System.Drawing.Point(373, 95);
            this.btn_Axis3RelMotion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Axis3RelMotion.Name = "btn_Axis3RelMotion";
            this.btn_Axis3RelMotion.Size = new System.Drawing.Size(42, 34);
            this.btn_Axis3RelMotion.TabIndex = 2;
            this.btn_Axis3RelMotion.Text = "Go";
            this.btn_Axis3RelMotion.UseVisualStyleBackColor = true;
            // 
            // Axis3TargetPostion
            // 
            this.Axis3TargetPostion.Location = new System.Drawing.Point(373, 66);
            this.Axis3TargetPostion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Axis3TargetPostion.Name = "Axis3TargetPostion";
            this.Axis3TargetPostion.Size = new System.Drawing.Size(87, 21);
            this.Axis3TargetPostion.TabIndex = 2;
            // 
            // Axis3Motionstatus
            // 
            this.Axis3Motionstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Axis3Motionstatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Axis3Motionstatus.Location = new System.Drawing.Point(373, 36);
            this.Axis3Motionstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Axis3Motionstatus.Name = "Axis3Motionstatus";
            this.Axis3Motionstatus.Size = new System.Drawing.Size(88, 24);
            this.Axis3Motionstatus.TabIndex = 2;
            this.Axis3Motionstatus.Text = "status";
            this.Axis3Motionstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Axis3CurrentPosition
            // 
            this.Axis3CurrentPosition.Location = new System.Drawing.Point(373, 12);
            this.Axis3CurrentPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Axis3CurrentPosition.Name = "Axis3CurrentPosition";
            this.Axis3CurrentPosition.Size = new System.Drawing.Size(87, 21);
            this.Axis3CurrentPosition.TabIndex = 2;
            // 
            // btn_Axis2Gohome
            // 
            this.btn_Axis2Gohome.Location = new System.Drawing.Point(270, 204);
            this.btn_Axis2Gohome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Axis2Gohome.Name = "btn_Axis2Gohome";
            this.btn_Axis2Gohome.Size = new System.Drawing.Size(88, 36);
            this.btn_Axis2Gohome.TabIndex = 1;
            this.btn_Axis2Gohome.Text = "Go Home";
            this.btn_Axis2Gohome.UseVisualStyleBackColor = true;
            // 
            // btn_Axis2Emgstop
            // 
            this.btn_Axis2Emgstop.Location = new System.Drawing.Point(270, 132);
            this.btn_Axis2Emgstop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Axis2Emgstop.Name = "btn_Axis2Emgstop";
            this.btn_Axis2Emgstop.Size = new System.Drawing.Size(88, 36);
            this.btn_Axis2Emgstop.TabIndex = 1;
            this.btn_Axis2Emgstop.Text = "Stop";
            this.btn_Axis2Emgstop.UseVisualStyleBackColor = true;
            // 
            // btn_Axis2AbsMotion
            // 
            this.btn_Axis2AbsMotion.Location = new System.Drawing.Point(316, 95);
            this.btn_Axis2AbsMotion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Axis2AbsMotion.Name = "btn_Axis2AbsMotion";
            this.btn_Axis2AbsMotion.Size = new System.Drawing.Size(42, 34);
            this.btn_Axis2AbsMotion.TabIndex = 1;
            this.btn_Axis2AbsMotion.Text = "Go";
            this.btn_Axis2AbsMotion.UseVisualStyleBackColor = true;
            // 
            // btn_Axis2RelMotion
            // 
            this.btn_Axis2RelMotion.Location = new System.Drawing.Point(270, 95);
            this.btn_Axis2RelMotion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Axis2RelMotion.Name = "btn_Axis2RelMotion";
            this.btn_Axis2RelMotion.Size = new System.Drawing.Size(42, 34);
            this.btn_Axis2RelMotion.TabIndex = 1;
            this.btn_Axis2RelMotion.Text = "Go";
            this.btn_Axis2RelMotion.UseVisualStyleBackColor = true;
            // 
            // Axis2TargetPostion
            // 
            this.Axis2TargetPostion.Location = new System.Drawing.Point(270, 66);
            this.Axis2TargetPostion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Axis2TargetPostion.Name = "Axis2TargetPostion";
            this.Axis2TargetPostion.Size = new System.Drawing.Size(87, 21);
            this.Axis2TargetPostion.TabIndex = 1;
            // 
            // Axis2Motionstatus
            // 
            this.Axis2Motionstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Axis2Motionstatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Axis2Motionstatus.Location = new System.Drawing.Point(270, 36);
            this.Axis2Motionstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Axis2Motionstatus.Name = "Axis2Motionstatus";
            this.Axis2Motionstatus.Size = new System.Drawing.Size(88, 24);
            this.Axis2Motionstatus.TabIndex = 1;
            this.Axis2Motionstatus.Text = "status";
            this.Axis2Motionstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Axis2CurrentPosition
            // 
            this.Axis2CurrentPosition.Location = new System.Drawing.Point(270, 12);
            this.Axis2CurrentPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Axis2CurrentPosition.Name = "Axis2CurrentPosition";
            this.Axis2CurrentPosition.Size = new System.Drawing.Size(87, 21);
            this.Axis2CurrentPosition.TabIndex = 1;
            // 
            // btn_Axis1Gohome
            // 
            this.btn_Axis1Gohome.Location = new System.Drawing.Point(166, 204);
            this.btn_Axis1Gohome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Axis1Gohome.Name = "btn_Axis1Gohome";
            this.btn_Axis1Gohome.Size = new System.Drawing.Size(88, 36);
            this.btn_Axis1Gohome.TabIndex = 0;
            this.btn_Axis1Gohome.Text = "Go Home";
            this.btn_Axis1Gohome.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 214);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 59;
            this.label10.Text = "Go home:";
            // 
            // btn_Axis1Emgstop
            // 
            this.btn_Axis1Emgstop.Location = new System.Drawing.Point(166, 132);
            this.btn_Axis1Emgstop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Axis1Emgstop.Name = "btn_Axis1Emgstop";
            this.btn_Axis1Emgstop.Size = new System.Drawing.Size(88, 36);
            this.btn_Axis1Emgstop.TabIndex = 0;
            this.btn_Axis1Emgstop.Text = "Stop";
            this.btn_Axis1Emgstop.UseVisualStyleBackColor = true;
            this.btn_Axis1Emgstop.Click += new System.EventHandler(this.btn_Axis1Emgstop_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 148);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 12);
            this.label11.TabIndex = 57;
            this.label11.Text = "Emergency stop:";
            // 
            // btn_Axis1AbsMotion
            // 
            this.btn_Axis1AbsMotion.Location = new System.Drawing.Point(210, 95);
            this.btn_Axis1AbsMotion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Axis1AbsMotion.Name = "btn_Axis1AbsMotion";
            this.btn_Axis1AbsMotion.Size = new System.Drawing.Size(42, 34);
            this.btn_Axis1AbsMotion.TabIndex = 0;
            this.btn_Axis1AbsMotion.Text = "Go";
            this.btn_Axis1AbsMotion.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 12);
            this.label9.TabIndex = 55;
            this.label9.Text = "relative /Absolute";
            // 
            // btn_Axis1RelMotion
            // 
            this.btn_Axis1RelMotion.Location = new System.Drawing.Point(166, 95);
            this.btn_Axis1RelMotion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Axis1RelMotion.Name = "btn_Axis1RelMotion";
            this.btn_Axis1RelMotion.Size = new System.Drawing.Size(42, 34);
            this.btn_Axis1RelMotion.TabIndex = 0;
            this.btn_Axis1RelMotion.Text = "Go";
            this.btn_Axis1RelMotion.UseVisualStyleBackColor = true;
            this.btn_Axis1RelMotion.Click += new System.EventHandler(this.btn_Axis1RelMotion_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 12);
            this.label8.TabIndex = 53;
            this.label8.Text = "Target position:";
            // 
            // Axis1TargetPostion
            // 
            this.Axis1TargetPostion.Location = new System.Drawing.Point(166, 66);
            this.Axis1TargetPostion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Axis1TargetPostion.Name = "Axis1TargetPostion";
            this.Axis1TargetPostion.Size = new System.Drawing.Size(87, 21);
            this.Axis1TargetPostion.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 51;
            this.label7.Text = "Motion status:";
            // 
            // Axis1Motionstatus
            // 
            this.Axis1Motionstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Axis1Motionstatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Axis1Motionstatus.Location = new System.Drawing.Point(166, 36);
            this.Axis1Motionstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Axis1Motionstatus.Name = "Axis1Motionstatus";
            this.Axis1Motionstatus.Size = new System.Drawing.Size(88, 24);
            this.Axis1Motionstatus.TabIndex = 0;
            this.Axis1Motionstatus.Text = "status";
            this.Axis1Motionstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 12);
            this.label5.TabIndex = 49;
            this.label5.Text = "Current position:";
            // 
            // Axis1CurrentPosition
            // 
            this.Axis1CurrentPosition.Location = new System.Drawing.Point(166, 12);
            this.Axis1CurrentPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Axis1CurrentPosition.Name = "Axis1CurrentPosition";
            this.Axis1CurrentPosition.Size = new System.Drawing.Size(87, 21);
            this.Axis1CurrentPosition.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chk_EnablePWM);
            this.groupBox7.Controls.Add(this.label22);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.Btn_updatePwm);
            this.groupBox7.Controls.Add(this.txt_DutyCH2);
            this.groupBox7.Controls.Add(this.txt_DutyCH1);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.txt_Frequency);
            this.groupBox7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox7.Location = new System.Drawing.Point(770, 350);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox7.Size = new System.Drawing.Size(308, 222);
            this.groupBox7.TabIndex = 32;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "PWM Setting";
            // 
            // chk_EnablePWM
            // 
            this.chk_EnablePWM.Location = new System.Drawing.Point(38, 151);
            this.chk_EnablePWM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_EnablePWM.Name = "chk_EnablePWM";
            this.chk_EnablePWM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_EnablePWM.Size = new System.Drawing.Size(124, 24);
            this.chk_EnablePWM.TabIndex = 12;
            this.chk_EnablePWM.Text = "Enable PWM";
            this.chk_EnablePWM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_EnablePWM.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(227, 54);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 12);
            this.label22.TabIndex = 11;
            this.label22.Text = "Hz (1-320)k";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(228, 123);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 12);
            this.label21.TabIndex = 10;
            this.label21.Text = "% (0-100)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(228, 90);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 12);
            this.label20.TabIndex = 9;
            this.label20.Text = "% (0-100)";
            // 
            // Btn_updatePwm
            // 
            this.Btn_updatePwm.Location = new System.Drawing.Point(97, 181);
            this.Btn_updatePwm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_updatePwm.Name = "Btn_updatePwm";
            this.Btn_updatePwm.Size = new System.Drawing.Size(125, 36);
            this.Btn_updatePwm.TabIndex = 8;
            this.Btn_updatePwm.Text = "Update Setting";
            this.Btn_updatePwm.UseVisualStyleBackColor = true;
            this.Btn_updatePwm.Click += new System.EventHandler(this.Btn_updatePwm_Click);
            // 
            // txt_DutyCH2
            // 
            this.txt_DutyCH2.Location = new System.Drawing.Point(142, 114);
            this.txt_DutyCH2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_DutyCH2.Name = "txt_DutyCH2";
            this.txt_DutyCH2.Size = new System.Drawing.Size(80, 21);
            this.txt_DutyCH2.TabIndex = 7;
            this.txt_DutyCH2.Text = "0";
            // 
            // txt_DutyCH1
            // 
            this.txt_DutyCH1.Location = new System.Drawing.Point(142, 81);
            this.txt_DutyCH1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_DutyCH1.Name = "txt_DutyCH1";
            this.txt_DutyCH1.Size = new System.Drawing.Size(80, 21);
            this.txt_DutyCH1.TabIndex = 6;
            this.txt_DutyCH1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Duty cycle(CH2)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Duty cycle(CH1)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Frequency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 2;
            // 
            // txt_Frequency
            // 
            this.txt_Frequency.Location = new System.Drawing.Point(142, 46);
            this.txt_Frequency.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Frequency.Name = "txt_Frequency";
            this.txt_Frequency.Size = new System.Drawing.Size(80, 21);
            this.txt_Frequency.TabIndex = 1;
            this.txt_Frequency.Text = "0";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chk_X14);
            this.groupBox6.Controls.Add(this.chk_X13);
            this.groupBox6.Controls.Add(this.chk_Y8);
            this.groupBox6.Controls.Add(this.chk_Y7);
            this.groupBox6.Controls.Add(this.chk_Y6);
            this.groupBox6.Controls.Add(this.chk_Y5);
            this.groupBox6.Controls.Add(this.chk_Y4);
            this.groupBox6.Controls.Add(this.chk_Y3);
            this.groupBox6.Controls.Add(this.chk_Y2);
            this.groupBox6.Controls.Add(this.chk_Y1);
            this.groupBox6.Controls.Add(this.chk_X12);
            this.groupBox6.Controls.Add(this.chk_X11);
            this.groupBox6.Controls.Add(this.chk_X10);
            this.groupBox6.Controls.Add(this.chk_X9);
            this.groupBox6.Controls.Add(this.chk_X8);
            this.groupBox6.Controls.Add(this.chk_X7);
            this.groupBox6.Controls.Add(this.chk_X6);
            this.groupBox6.Controls.Add(this.chk_X5);
            this.groupBox6.Controls.Add(this.chk_X4);
            this.groupBox6.Controls.Add(this.chk_X3);
            this.groupBox6.Controls.Add(this.chk_X2);
            this.groupBox6.Controls.Add(this.chk_X1);
            this.groupBox6.Location = new System.Drawing.Point(769, 10);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Size = new System.Drawing.Size(308, 319);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Port Status";
            // 
            // chk_X14
            // 
            this.chk_X14.AutoSize = true;
            this.chk_X14.Location = new System.Drawing.Point(16, 293);
            this.chk_X14.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_X14.Name = "chk_X14";
            this.chk_X14.Size = new System.Drawing.Size(78, 16);
            this.chk_X14.TabIndex = 14;
            this.chk_X14.Text = "X14 Reset";
            this.chk_X14.UseVisualStyleBackColor = true;
            // 
            // chk_X13
            // 
            this.chk_X13.AutoSize = true;
            this.chk_X13.Location = new System.Drawing.Point(16, 272);
            this.chk_X13.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_X13.Name = "chk_X13";
            this.chk_X13.Size = new System.Drawing.Size(78, 16);
            this.chk_X13.TabIndex = 13;
            this.chk_X13.Text = "X13 Estop";
            this.chk_X13.UseVisualStyleBackColor = true;
            // 
            // chk_Y8
            // 
            this.chk_Y8.AutoSize = true;
            this.chk_Y8.Location = new System.Drawing.Point(184, 185);
            this.chk_Y8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_Y8.Name = "chk_Y8";
            this.chk_Y8.Size = new System.Drawing.Size(42, 16);
            this.chk_Y8.TabIndex = 7;
            this.chk_Y8.Text = "Y04";
            this.chk_Y8.UseVisualStyleBackColor = true;
            // 
            // chk_Y7
            // 
            this.chk_Y7.AutoSize = true;
            this.chk_Y7.Location = new System.Drawing.Point(184, 163);
            this.chk_Y7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_Y7.Name = "chk_Y7";
            this.chk_Y7.Size = new System.Drawing.Size(42, 16);
            this.chk_Y7.TabIndex = 6;
            this.chk_Y7.Text = "Y03";
            this.chk_Y7.UseVisualStyleBackColor = true;
            // 
            // chk_Y6
            // 
            this.chk_Y6.AutoSize = true;
            this.chk_Y6.Location = new System.Drawing.Point(184, 141);
            this.chk_Y6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_Y6.Name = "chk_Y6";
            this.chk_Y6.Size = new System.Drawing.Size(42, 16);
            this.chk_Y6.TabIndex = 5;
            this.chk_Y6.Text = "Y02";
            this.chk_Y6.UseVisualStyleBackColor = true;
            // 
            // chk_Y5
            // 
            this.chk_Y5.AutoSize = true;
            this.chk_Y5.Location = new System.Drawing.Point(184, 119);
            this.chk_Y5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_Y5.Name = "chk_Y5";
            this.chk_Y5.Size = new System.Drawing.Size(42, 16);
            this.chk_Y5.TabIndex = 4;
            this.chk_Y5.Text = "Y01";
            this.chk_Y5.UseVisualStyleBackColor = true;
            // 
            // chk_Y4
            // 
            this.chk_Y4.AutoSize = true;
            this.chk_Y4.Location = new System.Drawing.Point(185, 86);
            this.chk_Y4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_Y4.Name = "chk_Y4";
            this.chk_Y4.Size = new System.Drawing.Size(120, 16);
            this.chk_Y4.TabIndex = 3;
            this.chk_Y4.Text = "E04 Axis4 Enable";
            this.chk_Y4.UseVisualStyleBackColor = true;
            // 
            // chk_Y3
            // 
            this.chk_Y3.AutoSize = true;
            this.chk_Y3.Location = new System.Drawing.Point(185, 64);
            this.chk_Y3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_Y3.Name = "chk_Y3";
            this.chk_Y3.Size = new System.Drawing.Size(120, 16);
            this.chk_Y3.TabIndex = 2;
            this.chk_Y3.Text = "E03 Axis3 Enable";
            this.chk_Y3.UseVisualStyleBackColor = true;
            // 
            // chk_Y2
            // 
            this.chk_Y2.AutoSize = true;
            this.chk_Y2.Location = new System.Drawing.Point(185, 42);
            this.chk_Y2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_Y2.Name = "chk_Y2";
            this.chk_Y2.Size = new System.Drawing.Size(120, 16);
            this.chk_Y2.TabIndex = 1;
            this.chk_Y2.Text = "E02 Axis2 Enable";
            this.chk_Y2.UseVisualStyleBackColor = true;
            // 
            // chk_Y1
            // 
            this.chk_Y1.AutoSize = true;
            this.chk_Y1.Location = new System.Drawing.Point(185, 20);
            this.chk_Y1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_Y1.Name = "chk_Y1";
            this.chk_Y1.Size = new System.Drawing.Size(120, 16);
            this.chk_Y1.TabIndex = 0;
            this.chk_Y1.Text = "E01 Axis1 Enable";
            this.chk_Y1.UseVisualStyleBackColor = true;
            // 
            // chk_X12
            // 
            this.chk_X12.AutoSize = true;
            this.chk_X12.Location = new System.Drawing.Point(16, 251);
            this.chk_X12.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_X12.Name = "chk_X12";
            this.chk_X12.Size = new System.Drawing.Size(42, 16);
            this.chk_X12.TabIndex = 11;
            this.chk_X12.Text = "X12";
            this.chk_X12.UseVisualStyleBackColor = true;
            // 
            // chk_X11
            // 
            this.chk_X11.AutoSize = true;
            this.chk_X11.Location = new System.Drawing.Point(16, 230);
            this.chk_X11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_X11.Name = "chk_X11";
            this.chk_X11.Size = new System.Drawing.Size(48, 16);
            this.chk_X11.TabIndex = 10;
            this.chk_X11.Text = "X11 ";
            this.chk_X11.UseVisualStyleBackColor = true;
            // 
            // chk_X10
            // 
            this.chk_X10.AutoSize = true;
            this.chk_X10.Location = new System.Drawing.Point(16, 209);
            this.chk_X10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_X10.Name = "chk_X10";
            this.chk_X10.Size = new System.Drawing.Size(42, 16);
            this.chk_X10.TabIndex = 9;
            this.chk_X10.Text = "X10";
            this.chk_X10.UseVisualStyleBackColor = true;
            // 
            // chk_X9
            // 
            this.chk_X9.AutoSize = true;
            this.chk_X9.Location = new System.Drawing.Point(16, 188);
            this.chk_X9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_X9.Name = "chk_X9";
            this.chk_X9.Size = new System.Drawing.Size(42, 16);
            this.chk_X9.TabIndex = 8;
            this.chk_X9.Text = "X09";
            this.chk_X9.UseVisualStyleBackColor = true;
            // 
            // chk_X8
            // 
            this.chk_X8.AutoSize = true;
            this.chk_X8.Location = new System.Drawing.Point(16, 167);
            this.chk_X8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_X8.Name = "chk_X8";
            this.chk_X8.Size = new System.Drawing.Size(42, 16);
            this.chk_X8.TabIndex = 7;
            this.chk_X8.Text = "X08";
            this.chk_X8.UseVisualStyleBackColor = true;
            // 
            // chk_X7
            // 
            this.chk_X7.AutoSize = true;
            this.chk_X7.Location = new System.Drawing.Point(16, 146);
            this.chk_X7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_X7.Name = "chk_X7";
            this.chk_X7.Size = new System.Drawing.Size(42, 16);
            this.chk_X7.TabIndex = 6;
            this.chk_X7.Text = "X07";
            this.chk_X7.UseVisualStyleBackColor = true;
            // 
            // chk_X6
            // 
            this.chk_X6.AutoSize = true;
            this.chk_X6.Location = new System.Drawing.Point(16, 125);
            this.chk_X6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_X6.Name = "chk_X6";
            this.chk_X6.Size = new System.Drawing.Size(42, 16);
            this.chk_X6.TabIndex = 5;
            this.chk_X6.Text = "X06";
            this.chk_X6.UseVisualStyleBackColor = true;
            // 
            // chk_X5
            // 
            this.chk_X5.AutoSize = true;
            this.chk_X5.Location = new System.Drawing.Point(16, 104);
            this.chk_X5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_X5.Name = "chk_X5";
            this.chk_X5.Size = new System.Drawing.Size(42, 16);
            this.chk_X5.TabIndex = 4;
            this.chk_X5.Text = "X05";
            this.chk_X5.UseVisualStyleBackColor = false;
            // 
            // chk_X4
            // 
            this.chk_X4.AutoSize = true;
            this.chk_X4.Location = new System.Drawing.Point(16, 83);
            this.chk_X4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_X4.Name = "chk_X4";
            this.chk_X4.Size = new System.Drawing.Size(42, 16);
            this.chk_X4.TabIndex = 3;
            this.chk_X4.Text = "X04";
            this.chk_X4.UseVisualStyleBackColor = true;
            // 
            // chk_X3
            // 
            this.chk_X3.AutoSize = true;
            this.chk_X3.Location = new System.Drawing.Point(16, 62);
            this.chk_X3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_X3.Name = "chk_X3";
            this.chk_X3.Size = new System.Drawing.Size(42, 16);
            this.chk_X3.TabIndex = 2;
            this.chk_X3.Text = "X03";
            this.chk_X3.UseVisualStyleBackColor = true;
            // 
            // chk_X2
            // 
            this.chk_X2.AutoSize = true;
            this.chk_X2.Location = new System.Drawing.Point(16, 41);
            this.chk_X2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_X2.Name = "chk_X2";
            this.chk_X2.Size = new System.Drawing.Size(42, 16);
            this.chk_X2.TabIndex = 1;
            this.chk_X2.Text = "X02";
            this.chk_X2.UseVisualStyleBackColor = true;
            // 
            // chk_X1
            // 
            this.chk_X1.AutoSize = true;
            this.chk_X1.Location = new System.Drawing.Point(16, 20);
            this.chk_X1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chk_X1.Name = "chk_X1";
            this.chk_X1.Size = new System.Drawing.Size(42, 16);
            this.chk_X1.TabIndex = 0;
            this.chk_X1.Text = "X01";
            this.chk_X1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EditGridview);
            this.groupBox1.Location = new System.Drawing.Point(14, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(748, 319);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Axis Setting";
            // 
            // EditGridview
            // 
            this.EditGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CName,
            this.Axis1,
            this.Axis2,
            this.Axis3,
            this.Axis4,
            this.Desc});
            this.EditGridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditGridview.Location = new System.Drawing.Point(4, 17);
            this.EditGridview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditGridview.Name = "EditGridview";
            this.EditGridview.RowTemplate.Height = 40;
            this.EditGridview.Size = new System.Drawing.Size(740, 299);
            this.EditGridview.TabIndex = 5;
            this.EditGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditGridview_CellContentClick);
            this.EditGridview.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditGridview_CellValueChanged);
            this.EditGridview.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.EditGridview_RowPostPaint);
            // 
            // CName
            // 
            this.CName.HeaderText = "Name";
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            this.CName.Width = 150;
            // 
            // Axis1
            // 
            this.Axis1.HeaderText = "Axis 1";
            this.Axis1.Name = "Axis1";
            // 
            // Axis2
            // 
            this.Axis2.HeaderText = "Axis 2";
            this.Axis2.Name = "Axis2";
            this.Axis2.ReadOnly = true;
            // 
            // Axis3
            // 
            this.Axis3.HeaderText = "Axis 3";
            this.Axis3.Name = "Axis3";
            // 
            // Axis4
            // 
            this.Axis4.HeaderText = "Axis 4";
            this.Axis4.Name = "Axis4";
            // 
            // Desc
            // 
            this.Desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Desc.HeaderText = "Describe";
            this.Desc.Name = "Desc";
            // 
            // LogList
            // 
            this.LogList.FormattingEnabled = true;
            this.LogList.ItemHeight = 12;
            this.LogList.Location = new System.Drawing.Point(4, 660);
            this.LogList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LogList.Name = "LogList";
            this.LogList.Size = new System.Drawing.Size(1088, 160);
            this.LogList.TabIndex = 33;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1146, 774);
            this.Controls.Add(this.LogList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labAvailPort);
            this.Controls.Add(this.CBVarPort);
            this.Controls.Add(this.Savefile);
            this.Controls.Add(this.DrawBoard);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Server_con);
            this.Controls.Add(this.ConnectState);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Screenshot);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.OpenPath);
            this.Controls.Add(this.Net);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motor Control board debug software V2.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 截图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
 //       private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ConnectState;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tESTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar tprogress;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tTimeNow;
        private System.Windows.Forms.ComboBox CBVarPort;
        private System.Windows.Forms.Label labAvailPort;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Net;
        private System.Windows.Forms.Button OpenPath;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.Button Screenshot;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Button Server_con;
        private System.Windows.Forms.Button DrawBoard;
        private System.Windows.Forms.Button Savefile;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button Btn_updatePwm;
        private System.Windows.Forms.TextBox txt_DutyCH2;
        private System.Windows.Forms.TextBox txt_DutyCH1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Frequency;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chk_Y8;
        private System.Windows.Forms.CheckBox chk_Y7;
        private System.Windows.Forms.CheckBox chk_Y6;
        private System.Windows.Forms.CheckBox chk_Y5;
        private System.Windows.Forms.CheckBox chk_Y4;
        private System.Windows.Forms.CheckBox chk_Y3;
        private System.Windows.Forms.CheckBox chk_Y2;
        private System.Windows.Forms.CheckBox chk_Y1;
        private System.Windows.Forms.CheckBox chk_X12;
        private System.Windows.Forms.CheckBox chk_X11;
        private System.Windows.Forms.CheckBox chk_X10;
        private System.Windows.Forms.CheckBox chk_X9;
        private System.Windows.Forms.CheckBox chk_X8;
        private System.Windows.Forms.CheckBox chk_X7;
        private System.Windows.Forms.CheckBox chk_X6;
        private System.Windows.Forms.CheckBox chk_X5;
        private System.Windows.Forms.CheckBox chk_X4;
        private System.Windows.Forms.CheckBox chk_X3;
        private System.Windows.Forms.CheckBox chk_X2;
        private System.Windows.Forms.CheckBox chk_X1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView EditGridview;
        private System.Windows.Forms.ListBox LogList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Button btn_DWload;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label Axis4Homestatus;
        private System.Windows.Forms.Label Axis3Homestatus;
        private System.Windows.Forms.Label Axis2Homestatus;
        private System.Windows.Forms.Label Axis1Homestatus;
        private System.Windows.Forms.Button btn_Axis4Gohome;
        private System.Windows.Forms.Button btn_Axis4Emgstop;
        private System.Windows.Forms.Button btn_Axis4AbsMotion;
        private System.Windows.Forms.Button btn_Axis4RelMotion;
        private System.Windows.Forms.TextBox Axis4TargetPostion;
        private System.Windows.Forms.Label Axis4Motionstatus;
        private System.Windows.Forms.TextBox Axis4CurrentPosition;
        private System.Windows.Forms.Button btn_Axis3Gohome;
        private System.Windows.Forms.Button btn_Axis3Emgstop;
        private System.Windows.Forms.Button btn_Axis3AbsMotion;
        private System.Windows.Forms.Button btn_Axis3RelMotion;
        private System.Windows.Forms.TextBox Axis3TargetPostion;
        private System.Windows.Forms.Label Axis3Motionstatus;
        private System.Windows.Forms.TextBox Axis3CurrentPosition;
        private System.Windows.Forms.Button btn_Axis2Gohome;
        private System.Windows.Forms.Button btn_Axis2Emgstop;
        private System.Windows.Forms.Button btn_Axis2AbsMotion;
        private System.Windows.Forms.Button btn_Axis2RelMotion;
        private System.Windows.Forms.TextBox Axis2TargetPostion;
        private System.Windows.Forms.Label Axis2Motionstatus;
        private System.Windows.Forms.TextBox Axis2CurrentPosition;
        private System.Windows.Forms.Button btn_Axis1Gohome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Axis1Emgstop;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Axis1AbsMotion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Axis1RelMotion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Axis1TargetPostion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Axis1Motionstatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Axis1CurrentPosition;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox chk_EnablePWM;
        private System.Windows.Forms.Button btn_InitParament;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Axis1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Axis2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Axis3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Axis4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyTeachToolStripMenuItem;
        private System.Windows.Forms.CheckBox chk_X14;
        private System.Windows.Forms.CheckBox chk_X13;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}

