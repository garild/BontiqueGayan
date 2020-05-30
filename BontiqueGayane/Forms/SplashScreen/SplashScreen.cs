using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Threading;
using SkyReg.Common;
using ComponentFactory.Krypton.Toolkit;

namespace SkyReg.Forms.SplashScreen
{
    public partial class SplashScreen : KryptonForm
    {
        private int blockProgerss => 25;
        private object _lock = new object();
        private BackgroundWorker bgw = new BackgroundWorker();
        
        public SplashScreen()
        {
            InitializeComponent();

            SkyRegUser.GlobalPathFile = Environment.GetFolderPath((Environment.SpecialFolder.LocalApplicationData)) + @"\BoutiqueShop";
            SkyRegUser.DatabaseConfigFile = string.Format("{0}\\DatabaseConfig.xml", SkyRegUser.GlobalPathFile);
            SkyRegUser.UserConfigFile = string.Format("{0}\\UserConfig.xml", SkyRegUser.GlobalPathFile);
            SkyRegUser.LocalMachineName = Environment.MachineName;
            Version curVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            Text_AppVersion.Text = $"wersja {curVersion}";
            SkyRegUser.AppVer = Text_AppVersion.Text;

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
            try
            {
                bgw.ReportProgress(25);

                Thread.Sleep(850);

                CreateFolder();
                bgw.ReportProgress(75);

                if (File.Exists(SkyRegUser.DatabaseConfigFile))
                {
                    using (TextReader tr = new StreamReader(SkyRegUser.DatabaseConfigFile))
                    {
                        XmlDocument doc = new XmlDocument();
                        doc.Load(SkyRegUser.DatabaseConfigFile);
                        XmlSerializer deserializer;

                        //odczyt ustawień z nowej wersji pliku
                        var ConfigSettings = new DatabaseAccess();
                        deserializer = new XmlSerializer(ConfigSettings.GetType());
                        ConfigSettings = ((DatabaseAccess)deserializer.Deserialize(tr));
                        tr.Close();
                        new DatabaseConfig(ConfigSettings);
                        SkyRegUser.IsDbExists = true;
                    }
                }

                bgw.ReportProgress(100);
                Thread.Sleep(100);
            }

            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message);
                this.DialogResult = DialogResult.Cancel;
            }

        }

        private void CreateFolder()
        {
            if (!Directory.Exists(SkyRegUser.GlobalPathFile))
            {
                Directory.CreateDirectory(SkyRegUser.GlobalPathFile);

            }
           
        }

    }
}
