namespace WindowsFormsApp
{
    partial class FormList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EditGridview = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Function = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Follow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Axis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Next = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Describe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.btn_Download = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_Axis1_MoveP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_TA1Position = new System.Windows.Forms.ComboBox();
            this.btn_Axis1Teach = new System.Windows.Forms.Button();
            this.btn_Axis1_MoveN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CB_TA2Position = new System.Windows.Forms.ComboBox();
            this.btn_Axis2Teach = new System.Windows.Forms.Button();
            this.btn_Axis2_MoveN = new System.Windows.Forms.Button();
            this.btn_Axis2_MoveP = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CB_TA3Position = new System.Windows.Forms.ComboBox();
            this.btn_Axis3Teach = new System.Windows.Forms.Button();
            this.btn_Axis3_MoveN = new System.Windows.Forms.Button();
            this.btn_Axis3_MoveP = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CB_TA4Position = new System.Windows.Forms.ComboBox();
            this.btn_Axis4Teach = new System.Windows.Forms.Button();
            this.btn_Axis4_MoveN = new System.Windows.Forms.Button();
            this.btn_Axis4_MoveP = new System.Windows.Forms.Button();
            this.CB_Step = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbar_Download = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_MoveNum = new System.Windows.Forms.Button();
            this.CB_TA5Position = new System.Windows.Forms.ComboBox();
            this.btn_StopMove = new System.Windows.Forms.Button();
            this.timer_ReadRunStatus = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EditGridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditGridview
            // 
            this.EditGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Function,
            this.Follow,
            this.Axis,
            this.Position,
            this.Speed,
            this.Delay,
            this.Next,
            this.Describe});
            this.EditGridview.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditGridview.Location = new System.Drawing.Point(0, 0);
            this.EditGridview.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.EditGridview.Name = "EditGridview";
            this.EditGridview.RowTemplate.Height = 40;
            this.EditGridview.Size = new System.Drawing.Size(1264, 552);
            this.EditGridview.TabIndex = 6;
            this.EditGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditGridview_CellContentClick);
            this.EditGridview.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditGridview_CellValueChanged);
            // 
            // Num
            // 
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // Function
            // 
            this.Function.HeaderText = "Function";
            this.Function.Items.AddRange(new object[] {
            "GO HOME",
            "M_ABS",
            "M_REL"});
            this.Function.Name = "Function";
            this.Function.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Function.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Follow
            // 
            this.Follow.HeaderText = "Follow";
            this.Follow.Name = "Follow";
            // 
            // Axis
            // 
            this.Axis.HeaderText = "Axis";
            this.Axis.Name = "Axis";
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            // 
            // Speed
            // 
            this.Speed.HeaderText = "Speed(%)";
            this.Speed.Name = "Speed";
            // 
            // Delay
            // 
            this.Delay.HeaderText = "Delay(ms)";
            this.Delay.Name = "Delay";
            // 
            // Next
            // 
            this.Next.HeaderText = "Next";
            this.Next.Name = "Next";
            // 
            // Describe
            // 
            this.Describe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Describe.HeaderText = "Describe";
            this.Describe.Name = "Describe";
            // 
            // btn_Upload
            // 
            this.btn_Upload.Location = new System.Drawing.Point(972, 583);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(122, 64);
            this.btn_Upload.TabIndex = 7;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(1100, 583);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(122, 64);
            this.btn_Download.TabIndex = 8;
            this.btn_Download.Text = "DownLoad";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(30, 583);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(122, 64);
            this.btn_Import.TabIndex = 9;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(170, 583);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(122, 64);
            this.btn_Export.TabIndex = 10;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_Axis1_MoveP
            // 
            this.btn_Axis1_MoveP.Location = new System.Drawing.Point(34, 77);
            this.btn_Axis1_MoveP.Name = "btn_Axis1_MoveP";
            this.btn_Axis1_MoveP.Size = new System.Drawing.Size(77, 51);
            this.btn_Axis1_MoveP.TabIndex = 0;
            this.btn_Axis1_MoveP.Text = "<";
            this.btn_Axis1_MoveP.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_TA1Position);
            this.groupBox1.Controls.Add(this.btn_Axis1Teach);
            this.groupBox1.Controls.Add(this.btn_Axis1_MoveN);
            this.groupBox1.Controls.Add(this.btn_Axis1_MoveP);
            this.groupBox1.Location = new System.Drawing.Point(30, 679);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 274);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Axis1";
            // 
            // CB_TA1Position
            // 
            this.CB_TA1Position.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB_TA1Position.FormattingEnabled = true;
            this.CB_TA1Position.Location = new System.Drawing.Point(23, 200);
            this.CB_TA1Position.Name = "CB_TA1Position";
            this.CB_TA1Position.Size = new System.Drawing.Size(121, 32);
            this.CB_TA1Position.TabIndex = 14;
            // 
            // btn_Axis1Teach
            // 
            this.btn_Axis1Teach.Location = new System.Drawing.Point(164, 197);
            this.btn_Axis1Teach.Name = "btn_Axis1Teach";
            this.btn_Axis1Teach.Size = new System.Drawing.Size(98, 44);
            this.btn_Axis1Teach.TabIndex = 0;
            this.btn_Axis1Teach.Text = "Teach";
            this.btn_Axis1Teach.UseVisualStyleBackColor = true;
            // 
            // btn_Axis1_MoveN
            // 
            this.btn_Axis1_MoveN.Location = new System.Drawing.Point(150, 77);
            this.btn_Axis1_MoveN.Name = "btn_Axis1_MoveN";
            this.btn_Axis1_MoveN.Size = new System.Drawing.Size(77, 51);
            this.btn_Axis1_MoveN.TabIndex = 0;
            this.btn_Axis1_MoveN.Text = ">";
            this.btn_Axis1_MoveN.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CB_TA2Position);
            this.groupBox2.Controls.Add(this.btn_Axis2Teach);
            this.groupBox2.Controls.Add(this.btn_Axis2_MoveN);
            this.groupBox2.Controls.Add(this.btn_Axis2_MoveP);
            this.groupBox2.Location = new System.Drawing.Point(344, 679);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 274);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Axis2";
            // 
            // CB_TA2Position
            // 
            this.CB_TA2Position.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB_TA2Position.FormattingEnabled = true;
            this.CB_TA2Position.Location = new System.Drawing.Point(16, 200);
            this.CB_TA2Position.Name = "CB_TA2Position";
            this.CB_TA2Position.Size = new System.Drawing.Size(121, 41);
            this.CB_TA2Position.TabIndex = 15;
            // 
            // btn_Axis2Teach
            // 
            this.btn_Axis2Teach.Location = new System.Drawing.Point(168, 200);
            this.btn_Axis2Teach.Name = "btn_Axis2Teach";
            this.btn_Axis2Teach.Size = new System.Drawing.Size(98, 41);
            this.btn_Axis2Teach.TabIndex = 1;
            this.btn_Axis2Teach.Text = "Teach";
            this.btn_Axis2Teach.UseVisualStyleBackColor = true;
            // 
            // btn_Axis2_MoveN
            // 
            this.btn_Axis2_MoveN.Location = new System.Drawing.Point(150, 77);
            this.btn_Axis2_MoveN.Name = "btn_Axis2_MoveN";
            this.btn_Axis2_MoveN.Size = new System.Drawing.Size(77, 51);
            this.btn_Axis2_MoveN.TabIndex = 1;
            this.btn_Axis2_MoveN.Text = ">";
            this.btn_Axis2_MoveN.UseVisualStyleBackColor = true;
            // 
            // btn_Axis2_MoveP
            // 
            this.btn_Axis2_MoveP.Location = new System.Drawing.Point(34, 77);
            this.btn_Axis2_MoveP.Name = "btn_Axis2_MoveP";
            this.btn_Axis2_MoveP.Size = new System.Drawing.Size(77, 51);
            this.btn_Axis2_MoveP.TabIndex = 1;
            this.btn_Axis2_MoveP.Text = "<";
            this.btn_Axis2_MoveP.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CB_TA3Position);
            this.groupBox3.Controls.Add(this.btn_Axis3Teach);
            this.groupBox3.Controls.Add(this.btn_Axis3_MoveN);
            this.groupBox3.Controls.Add(this.btn_Axis3_MoveP);
            this.groupBox3.Location = new System.Drawing.Point(664, 679);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 274);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Axis3";
            // 
            // CB_TA3Position
            // 
            this.CB_TA3Position.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB_TA3Position.FormattingEnabled = true;
            this.CB_TA3Position.Location = new System.Drawing.Point(22, 203);
            this.CB_TA3Position.Name = "CB_TA3Position";
            this.CB_TA3Position.Size = new System.Drawing.Size(121, 41);
            this.CB_TA3Position.TabIndex = 15;
            // 
            // btn_Axis3Teach
            // 
            this.btn_Axis3Teach.Location = new System.Drawing.Point(168, 200);
            this.btn_Axis3Teach.Name = "btn_Axis3Teach";
            this.btn_Axis3Teach.Size = new System.Drawing.Size(98, 44);
            this.btn_Axis3Teach.TabIndex = 2;
            this.btn_Axis3Teach.Text = "Teach";
            this.btn_Axis3Teach.UseVisualStyleBackColor = true;
            // 
            // btn_Axis3_MoveN
            // 
            this.btn_Axis3_MoveN.Location = new System.Drawing.Point(150, 77);
            this.btn_Axis3_MoveN.Name = "btn_Axis3_MoveN";
            this.btn_Axis3_MoveN.Size = new System.Drawing.Size(77, 51);
            this.btn_Axis3_MoveN.TabIndex = 2;
            this.btn_Axis3_MoveN.Text = ">";
            this.btn_Axis3_MoveN.UseVisualStyleBackColor = true;
            // 
            // btn_Axis3_MoveP
            // 
            this.btn_Axis3_MoveP.Location = new System.Drawing.Point(34, 77);
            this.btn_Axis3_MoveP.Name = "btn_Axis3_MoveP";
            this.btn_Axis3_MoveP.Size = new System.Drawing.Size(77, 51);
            this.btn_Axis3_MoveP.TabIndex = 2;
            this.btn_Axis3_MoveP.Text = "<";
            this.btn_Axis3_MoveP.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CB_TA4Position);
            this.groupBox4.Controls.Add(this.btn_Axis4Teach);
            this.groupBox4.Controls.Add(this.btn_Axis4_MoveN);
            this.groupBox4.Controls.Add(this.btn_Axis4_MoveP);
            this.groupBox4.Location = new System.Drawing.Point(972, 679);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 274);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Axis4";
            // 
            // CB_TA4Position
            // 
            this.CB_TA4Position.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB_TA4Position.FormattingEnabled = true;
            this.CB_TA4Position.Location = new System.Drawing.Point(23, 203);
            this.CB_TA4Position.Name = "CB_TA4Position";
            this.CB_TA4Position.Size = new System.Drawing.Size(121, 41);
            this.CB_TA4Position.TabIndex = 15;
            // 
            // btn_Axis4Teach
            // 
            this.btn_Axis4Teach.Location = new System.Drawing.Point(168, 200);
            this.btn_Axis4Teach.Name = "btn_Axis4Teach";
            this.btn_Axis4Teach.Size = new System.Drawing.Size(98, 44);
            this.btn_Axis4Teach.TabIndex = 3;
            this.btn_Axis4Teach.Text = "Teach";
            this.btn_Axis4Teach.UseVisualStyleBackColor = true;
            // 
            // btn_Axis4_MoveN
            // 
            this.btn_Axis4_MoveN.Location = new System.Drawing.Point(150, 77);
            this.btn_Axis4_MoveN.Name = "btn_Axis4_MoveN";
            this.btn_Axis4_MoveN.Size = new System.Drawing.Size(77, 51);
            this.btn_Axis4_MoveN.TabIndex = 3;
            this.btn_Axis4_MoveN.Text = ">";
            this.btn_Axis4_MoveN.UseVisualStyleBackColor = true;
            // 
            // btn_Axis4_MoveP
            // 
            this.btn_Axis4_MoveP.Location = new System.Drawing.Point(34, 77);
            this.btn_Axis4_MoveP.Name = "btn_Axis4_MoveP";
            this.btn_Axis4_MoveP.Size = new System.Drawing.Size(77, 51);
            this.btn_Axis4_MoveP.TabIndex = 3;
            this.btn_Axis4_MoveP.Text = "<";
            this.btn_Axis4_MoveP.UseVisualStyleBackColor = true;
            // 
            // CB_Step
            // 
            this.CB_Step.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB_Step.FormattingEnabled = true;
            this.CB_Step.Location = new System.Drawing.Point(480, 593);
            this.CB_Step.Name = "CB_Step";
            this.CB_Step.Size = new System.Drawing.Size(121, 41);
            this.CB_Step.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 603);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Step:";
            // 
            // pbar_Download
            // 
            this.pbar_Download.Location = new System.Drawing.Point(832, 993);
            this.pbar_Download.Name = "pbar_Download";
            this.pbar_Download.Size = new System.Drawing.Size(376, 23);
            this.pbar_Download.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(724, 992);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Process";
            // 
            // btn_MoveNum
            // 
            this.btn_MoveNum.Location = new System.Drawing.Point(194, 986);
            this.btn_MoveNum.Name = "btn_MoveNum";
            this.btn_MoveNum.Size = new System.Drawing.Size(98, 46);
            this.btn_MoveNum.TabIndex = 20;
            this.btn_MoveNum.Text = "Move";
            this.btn_MoveNum.UseVisualStyleBackColor = true;
            this.btn_MoveNum.Click += new System.EventHandler(this.btn_MoveNum_Click);
            // 
            // CB_TA5Position
            // 
            this.CB_TA5Position.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB_TA5Position.FormattingEnabled = true;
            this.CB_TA5Position.Location = new System.Drawing.Point(53, 994);
            this.CB_TA5Position.Name = "CB_TA5Position";
            this.CB_TA5Position.Size = new System.Drawing.Size(121, 32);
            this.CB_TA5Position.TabIndex = 4;
            // 
            // btn_StopMove
            // 
            this.btn_StopMove.Location = new System.Drawing.Point(323, 986);
            this.btn_StopMove.Name = "btn_StopMove";
            this.btn_StopMove.Size = new System.Drawing.Size(98, 46);
            this.btn_StopMove.TabIndex = 21;
            this.btn_StopMove.Text = "STOP";
            this.btn_StopMove.UseVisualStyleBackColor = true;
            this.btn_StopMove.Click += new System.EventHandler(this.btn_StopMove_Click);
            // 
            // timer_ReadRunStatus
            // 
            this.timer_ReadRunStatus.Tick += new System.EventHandler(this.timer_ReadRunStatus_Tick);
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 1051);
            this.Controls.Add(this.btn_StopMove);
            this.Controls.Add(this.CB_TA5Position);
            this.Controls.Add(this.btn_MoveNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbar_Download);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Step);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.EditGridview);
            this.Name = "FormList";
            this.Text = "FormList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormList_FormClosing);
            this.Load += new System.EventHandler(this.FormList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EditGridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EditGridview;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_Axis1_MoveP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Axis1_MoveN;
        private System.Windows.Forms.Button btn_Axis1Teach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Axis2Teach;
        private System.Windows.Forms.Button btn_Axis2_MoveN;
        private System.Windows.Forms.Button btn_Axis2_MoveP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Axis3Teach;
        private System.Windows.Forms.Button btn_Axis3_MoveN;
        private System.Windows.Forms.Button btn_Axis3_MoveP;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Axis4Teach;
        private System.Windows.Forms.Button btn_Axis4_MoveN;
        private System.Windows.Forms.Button btn_Axis4_MoveP;
        private System.Windows.Forms.ComboBox CB_TA1Position;
        private System.Windows.Forms.ComboBox CB_TA2Position;
        private System.Windows.Forms.ComboBox CB_TA3Position;
        private System.Windows.Forms.ComboBox CB_TA4Position;
        private System.Windows.Forms.ComboBox CB_Step;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbar_Download;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewComboBoxColumn Function;
        private System.Windows.Forms.DataGridViewTextBoxColumn Follow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Axis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Next;
        private System.Windows.Forms.DataGridViewTextBoxColumn Describe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_MoveNum;
        private System.Windows.Forms.ComboBox CB_TA5Position;
        private System.Windows.Forms.Button btn_StopMove;
        private System.Windows.Forms.Timer timer_ReadRunStatus;
    }
}