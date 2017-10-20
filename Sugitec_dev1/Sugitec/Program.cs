using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sugitec
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (frmLogin frm = new frmLogin())
            {
                DialogResult Ret = frm.ShowDialog();
                if (Ret != DialogResult.OK )
                {
                    return;
                }
            }

            Application.Run(new Sugitec.frmMenu01());
        }
    }
}
