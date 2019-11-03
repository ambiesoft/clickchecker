using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace clickchecker
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ambiesoft.CppUtils.AmbSetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (FormMain form = new FormMain())
            {
                form.ShowDialog();
            }
        }
    }
}
