using ComponentFactory.Krypton.Toolkit;
using SkyReg.Common;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace SkyReg.Forms.DatabaseConfiguration
{
    public partial class FrmDataBaseConfig : KryptonForm
    {
        #region Pola Prywatne

        private ErrorProvider validateControl = new ErrorProvider();
        public static DatabaseAccess ConfigSettings = new DatabaseAccess();
        private string _dackPackFilePath = null;
        private OpenFileDialog openFileDialog;
        #endregion

        #region Konstruktor

        public FrmDataBaseConfig()
        {
            InitializeComponent();

            LoadDBSettings();
        }


        #endregion

        #region Zdarzenia

        private void btn_Generate_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(_dackPackFilePath))
            {
                KryptonMessageBox.Show("Wskać plik bazy danych!");
                return;
            }

            ValidateControls();
            
            DatabaseDeploy.Deploy(_dackPackFilePath, ConfigSettings.DataBaseName);

            SaveConfig();
        }

        private void btn_FileDialog_Click(object sender, System.EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            _dackPackFilePath = openFileDialog.FileName;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveCfg_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }


        #endregion

        #region Metody prywatne

        public void LoadDBSettings()
        {
            if (!File.Exists(SkyRegUser.DatabaseConfigFile))
            {
                Directory.CreateDirectory(SkyRegUser.GlobalPathFile);
            }
            if (File.Exists(SkyRegUser.DatabaseConfigFile))
            {
                TextReader tr = new StreamReader(SkyRegUser.DatabaseConfigFile);

                XmlDocument doc = new XmlDocument();
                doc.Load(SkyRegUser.DatabaseConfigFile);
                XmlSerializer deserializer;

                //odczyt ustawień z nowej wersji pliku
                ConfigSettings = new DatabaseAccess();
                deserializer = new XmlSerializer(ConfigSettings.GetType());

                ConfigSettings = ((DatabaseAccess)deserializer.Deserialize(tr));
                Txt_DatabaseName.Text = ConfigSettings.DataBaseName;
                Txt_ServerName.Text = ConfigSettings.ServerName;
                tr.Close();

                new DatabaseConfig(ConfigSettings);
                SkyRegUser.IsDbExists = true;
            }
            else
            {
                Txt_ServerName.Text = Environment.MachineName;
            }
        }

        private bool ValidateControls()
        {
            bool result = true;
            validateControl.Clear();
            validateControl.BlinkRate = 250;
            if (string.IsNullOrEmpty(Txt_ServerName.Text))
            {
                validateControl.SetError(Txt_ServerName, "!");
                result = false;
            }
            if (string.IsNullOrEmpty(Txt_DatabaseName.Text))
            {
                validateControl.SetError(Txt_DatabaseName, "!");
                result = false;
            }

            return result;
        }

        private void SaveConfig()
        {
            using (TextWriter TW = new StreamWriter(SkyRegUser.DatabaseConfigFile, false, Encoding.GetEncoding("windows-1250")))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(DatabaseAccess));
                ConfigSettings.DataBaseName = Txt_DatabaseName.Text.Trim();
                ConfigSettings.ServerName = Txt_ServerName.Text.Trim();

                new DatabaseConfig(ConfigSettings);

                serializer.Serialize(TW, ConfigSettings);
                TW.Close();

                new DatabaseConfig(ConfigSettings);
                SkyRegUser.IsDbExists = true;
                KryptonMessageBox.Show("Plik konfiguracyjny został zapisany!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        #endregion
    }
}
