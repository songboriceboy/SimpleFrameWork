using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
namespace BlogDownloader
{
    static class Program
    {
        public static string DouYueHanBlogDownVersion = "2.6";
        private static Mutex mutex = null;
        private static void GlobalMutex()
        {
            // 是否第一次创建mutex
            bool newMutexCreated = false;
            string mutexName = "Global\\" + "DouYueHanBlogDownloader";//系统名称，Global为全局，表示即使通过通过虚拟桌面连接过来，也只是允许运行一次
            try
            {
                mutex = new Mutex(false, mutexName, out newMutexCreated);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                System.Threading.Thread.Sleep(1000);
                Environment.Exit(1);
            }

            // 第一次创建mutex
            if (newMutexCreated)
            {
                Console.WriteLine("程序已启动");
                //todo:此处为要执行的任务
            }
            else
            {
                //MessageBox.Show("另一个窗口已在运行，不能重复运行。");
                //System.Threading.Thread.Sleep(1000);
                //Environment.Exit(1);//退出程序
            }


        }
        //static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        //{
        //    MessageBox.Show(e.Exception.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    throw new Exception("The method or operation is not implemented.");
        //}

        //static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        //{
        //    MessageBox.Show("CurrentDomain_UnhandledException", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    throw new Exception("The method or operation is not implemented.");
        //}
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            GlobalMutex();
            //AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            //Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Main());
        }
    }
}
