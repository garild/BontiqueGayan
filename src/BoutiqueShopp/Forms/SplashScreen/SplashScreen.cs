using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using ComponentFactory.Krypton.Toolkit;
using BoutiqueShopp.Infrastructure.Providers.DatabaseConfig;
using SkyReg.Forms.DatabaseConfiguration;
using SkyReg.Common.Extensions;

namespace SkyReg.Forms.SplashScreen
{
    public partial class SplashScreen : KryptonForm
    {
        public bool DatabaseExists = false;
        private object _lock = new object();
        private BackgroundWorker bgw = new BackgroundWorker();
        private FrmDataBaseConfig frmDataBaseConfig = null;
        public SplashScreen()
        {
            InitializeComponent();

            GlobalApplicationSettings.GlobalPathFile = Environment.GetFolderPath((Environment.SpecialFolder.LocalApplicationData)) + @"\BoutiqueShop";
            GlobalApplicationSettings.DatabaseConfigFile = string.Format("{0}\\DatabaseConfig.json", GlobalApplicationSettings.GlobalPathFile);
            GlobalApplicationSettings.UserConfigFile = string.Format("{0}\\UserConfig.json", GlobalApplicationSettings.GlobalPathFile);
            GlobalApplicationSettings.LocalMachineName = Environment.MachineName;
            Version curVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            Text_AppVersion.Text = $"  wersja {curVersion}";
            GlobalApplicationSettings.AppVer = Text_AppVersion.Text;

            StartLoading();
        }

        private void StartLoading()
        {
            try
            {
                bgw.WorkerReportsProgress = true;
                bgw.DoWork += Bgw_DoWork;
                bgw.ProgressChanged += Bgw_ProgressChanged;
                bgw.RunWorkerCompleted += Bgw_RunWorkerCompleted;
                bgw.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message);
                this.DialogResult = DialogResult.Cancel;
            }

        }

        private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            bgw.ReportProgress(25);

            Thread.Sleep(850);

            CreateFolder();
            bgw.ReportProgress(75);

            if (ApplicationConfigsProvider.ProviderDatabaseConfig() == default)
                DatabaseExists = false;

            DatabaseExists = true;

            bgw.ReportProgress(100);
            Thread.Sleep(100);

        }

        private void CreateFolder()
        {
            if (!Directory.Exists(GlobalApplicationSettings.GlobalPathFile))
            {
                Directory.CreateDirectory(GlobalApplicationSettings.GlobalPathFile);

            }

        }

    }
}
