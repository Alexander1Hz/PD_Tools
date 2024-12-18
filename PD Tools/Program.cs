using System;
using System.Windows.Forms;

namespace ImageGeneratorWithUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // 设置应用程序的启动模式为单线程单元模式（UI线程）
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 启动主窗体
            Application.Run(new MainForm());
        }
    }
}
