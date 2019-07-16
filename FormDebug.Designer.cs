namespace WindowsFormsApp
{
    partial class FormDebug
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
            this.btn_Read = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Adress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Len = new System.Windows.Forms.TextBox();
            this.txt_Data = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Write = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(313, 137);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(123, 40);
            this.btn_Read.TabIndex = 0;
            this.btn_Read.Text = "Read";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adress:";
            // 
            // txt_Adress
            // 
            this.txt_Adress.Location = new System.Drawing.Point(136, 75);
            this.txt_Adress.Name = "txt_Adress";
            this.txt_Adress.Size = new System.Drawing.Size(115, 35);
            this.txt_Adress.TabIndex = 2;
            this.txt_Adress.Text = "2230";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Len:";
            // 
            // txt_Len
            // 
            this.txt_Len.Location = new System.Drawing.Point(136, 142);
            this.txt_Len.Name = "txt_Len";
            this.txt_Len.Size = new System.Drawing.Size(115, 35);
            this.txt_Len.TabIndex = 4;
            this.txt_Len.Text = "1";
            // 
            // txt_Data
            // 
            this.txt_Data.Location = new System.Drawing.Point(136, 221);
            this.txt_Data.Multiline = true;
            this.txt_Data.Name = "txt_Data";
            this.txt_Data.Size = new System.Drawing.Size(473, 243);
            this.txt_Data.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data:";
            // 
            // btn_Write
            // 
            this.btn_Write.Location = new System.Drawing.Point(476, 137);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(123, 40);
            this.btn_Write.TabIndex = 7;
            this.btn_Write.Text = "Write";
            this.btn_Write.UseVisualStyleBackColor = true;
            this.btn_Write.Click += new System.EventHandler(this.btn_Write_Click);
            // 
            // FormDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 601);
            this.Controls.Add(this.btn_Write);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Data);
            this.Controls.Add(this.txt_Len);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Adress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Read);
            this.Name = "FormDebug";
            this.Text = "FormDebug";
            this.Load += new System.EventHandler(this.FormDebug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Adress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Len;
        private System.Windows.Forms.TextBox txt_Data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Write;
    }
}