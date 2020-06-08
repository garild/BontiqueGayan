using SkyReg.MainForm;
using System;
using System.Windows.Forms;
using SkyReg.Common.Extensions;
using SkyReg.Forms.SplashScreen;
using ComponentFactory.Krypton.Toolkit;
using Autofac;
using System.Reflection;
using BoutiqueShopp.Infrastructure.DI;
using BoutiqueShopp.Domain;
using SkyReg.Forms.DatabaseConfiguration;

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
            AppDomain.CurrentDomain.FirstChanceException += CurrentDomain_FirstChanceException;
            try
            {
                _splashScreen = new SplashScreen();
                _splashScreen.WindowState = FormWindowState.Normal;
                _splashScreen.StartPosition = FormStartPosition.CenterScreen;

                if (_splashScreen.ShowDialog() == DialogResult.OK)
                {
                    if (!_splashScreen.DatabaseExists)
                         FormsOpened<FrmDataBaseConfig>.OpenForm(frmDataBaseConfig);

                    var container = BuildContainer();

                    var frm = new FrmLogin(container);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        frm.Close();
                        _frmMain = new FrmMain(container);

                        using (var scope = container.BeginLifetimeScope())
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

        private static void CurrentDomain_FirstChanceException(object sender, System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs e)
        {
            KryptonMessageBox.Show($"Wystąpił błąd w {nameof(Program)}, treść : {e.Exception.Message}");
            Application.Exit();
        }

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterServices();

            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(executingAssembly)
                .AsSelf()
                .AsImplementedInterfaces();

            return builder.Build();
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            KryptonMessageBox.Show($"Wystąpił błąd w {nameof(Program)}, treść : {(e.ExceptionObject as Exception).Message}");
            Application.Exit();
        }

        public static FrmMain _frmMain = null;
        private static FrmDataBaseConfig frmDataBaseConfig = null;
        public static SplashScreen _splashScreen = null;
    }
}
