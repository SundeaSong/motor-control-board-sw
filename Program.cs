using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;//使用DllImport需要这个头文件

namespace WindowsFormsApp
{
    static class Program
    {
        public static System.Threading.Mutex Run;
        [DllImport("user32.dll")]
        private static extern void SetProcessDPIAware();
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]

        static void Main()
        {
            bool noRun = false;

            Run = new System.Threading.Mutex(true, "Motor Control board debug software V2.0", out noRun);

            if (noRun)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
                //Application.Run(new FormList());
            }
            else
            {
                MessageBox.Show("本程序已运行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Environment.Exit(0);     //退出任务管理器

            }
        }
    }
}
