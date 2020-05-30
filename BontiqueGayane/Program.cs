using SkyReg.MainForm;
using System;
using System.Windows.Forms;
using SkyReg.Common.Extensions;
using SkyReg.Forms.SplashScreen;
using ComponentFactory.Krypton.Toolkit;

namespace SkyReg
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static bool hasRestart = false;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            try
            {
                _splashScreen = FormsOpened<SplashScreen>.IsOpened(_splashScreen);
                _splashScreen.WindowState = FormWindowState.Normal;
                _splashScreen.StartPosition = FormStartPosition.CenterScreen;

                if (_splashScreen.ShowDialog() == DialogResult.OK)
                {
                    FrmLogin frm = new FrmLogin();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        frm.Close();
                        _frmMain = FormsOpened<FrmMain>.IsOpened(_frmMain);
                        Application.Run(_frmMain);
                    }
                    else
                        Application.Exit();
                }

            }
            catch (Exception ex)
            {
                _splashScreen.Close();
                KryptonMessageBox.Show("Wystąpił błąd, treść : " + ex.Message, "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Application.Exit();
            }

        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            KryptonMessageBox.Show($"Wystąpił błąd w {nameof(Program)}, treść : {(e.ExceptionObject as Exception).Message}");
            Application.Exit();
        }

        public static FrmMain _frmMain = null;
        public static SplashScreen _splashScreen = null;
    }
}
