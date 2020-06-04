using ComponentFactory.Krypton.Toolkit;
using Newtonsoft.Json;
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

            Txt_DatabaseName.Text = ConfigSettings.DataBaseName;
            Txt_ServerName.Text = ConfigSettings.ServerName;
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

            SaveConfig();

            DatabaseDeploy.Deploy(ConfigSettings.DatabaseConnectionString,_dackPackFilePath, ConfigSettings.DataBaseName);

            KryptonMessageBox.Show("Plik konfiguracyjny został zapisany!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrEmpty(Txt_Login.Text))
            {
                validateControl.SetError(Txt_Login, "!");
                result = false;
            }
            if (string.IsNullOrEmpty(Txt_Password.Text))
            {
                validateControl.SetError(Txt_Password, "!");
                result = false;
            }

            return result;
        }

        private void SaveConfig()
        {
            using (TextWriter TW = new StreamWriter(GlobalApplicationSettings.DatabaseConfigFile, false, Encoding.GetEncoding("windows-1250")))
            {
                ConfigSettings.DataBaseName = Txt_DatabaseName.Text.Trim();
                ConfigSettings.ServerName = Txt_ServerName.Text.Trim();
                ConfigSettings.User = Txt_Login.Text.Trim();
                ConfigSettings.Password = Txt_Password.Text.Trim();

                var connectionString = DatabaseFactory.CreateConnectionString(ConfigSettings);

                ConfigSettings.DatabaseConnectionString = connectionString;

                ConfigSettings.Password = Txt_Password.Text.Trim().EncryptString();
                TW.Write(JsonConvert.SerializeObject(ConfigSettings));
                TW.Close();
            }

        }

        #endregion
    }
}
