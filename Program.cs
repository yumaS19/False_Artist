using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace False_Artist
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>

        private static ApplicationContext mainApplicationContext;

        [STAThread]
        static void Main()
        {
            mainApplicationContext = new ApplicationContext();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainApplicationContext.MainForm = new start();
            Application.Run(mainApplicationContext);
        }
        static public void GameStart(int player)
        {
            mainApplicationContext.MainForm = new main(player);
            mainApplicationContext.MainForm.Show();
        }
    }
}
