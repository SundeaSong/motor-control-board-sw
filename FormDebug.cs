using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormDebug : Form
    {
         
        public FormDebug()
        {
            InitializeComponent();
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            FormMain fm = (FormMain)this.Owner;

            fm.DisplayLog(1, "* read");

            Int16 adrss = Convert.ToInt16(txt_Adress.Text);
            Int16 len = Convert.ToInt16(txt_Len.Text);
            UInt16[] r_buff = new UInt16[len];              //申请数组空间
            Int16 ret = fm.Read_Regedit(adrss, len, ref r_buff);
            if (ret == 0)
            {
                txt_Data.Text = "";
                for (int i = 0; i < len; i++)
                {
                    txt_Data.Text += Convert.ToString(r_buff[i], 16).ToUpper().PadLeft(4,'0') +" ";
                }
            }
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            try
            {
                String[] Splitstr = null;
                FormMain fm = (FormMain)this.Owner;
                string txt = txt_Data.Text;
                Splitstr = txt.Split(' ');
                Int32 spt_len = Splitstr.Length;
                UInt16 w_len = 0;
                if (spt_len > 0)
                {
                    UInt16[] w_buff = new UInt16[spt_len];   //申请数组空间
                    for (int i = 0; i < spt_len; i++)
                    {
                        if (Splitstr[i] != "")
                        {
                            w_buff[i] = Convert.ToUInt16(Splitstr[i], 16);
                            w_len++;
                        }
                    }
                    Int16 adrss = Convert.ToInt16(txt_Adress.Text);
                    txt_Len.Text = w_len.ToString();
                    Int16 ret = fm.Write_Regedit(adrss, (short)w_len, w_buff);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }

        }

        private void FormDebug_Load(object sender, EventArgs e)
        {

        }
    }
}
