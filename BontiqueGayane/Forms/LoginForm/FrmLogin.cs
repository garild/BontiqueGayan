﻿using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using SkyReg.Extensions;
using System.Xml;
using SkyReg.Forms.DatabaseConfiguration;
using SkyReg.Common.Extensions;
using SkyReg.Common;
using Database;
using SkyReg.Forms.RegisterForm;

namespace SkyReg.MainForm
{
    public partial class FrmLogin : KryptonForm
    {
        private ErrorProvider validateControl = new ErrorProvider();
        private BaseModel UserConfig { get; set; }
        private bool IsDbExists = false;

        public FrmLogin()
        {
            InitializeComponent();
            LoadSettings();
            AllowDbConfig();
        }

        private void AllowDbConfig()
        {
            if (Txt_Login.Text.ToLower() == "@ps")
                if (Txt_Password.Text.ToLower() == "barev")
                    btnDatabaseCfg.Visible = true;
                else
                    btnDatabaseCfg.Visible = false;
        }

        private bool ValidateControls()
        {
            bool result = true;
            validateControl.Clear();
            validateControl.BlinkRate = 250;
            if (!SkyRegUser.IsDbExists)
            {
                KryptonMessageBox.Show("Nie znaleziono pliku kofiguracyjnego do bazy danych. Proszę skofigurować base SQL!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = false;
            }
            if (!Txt_Login.Text.HasValue())
            {
                validateControl.SetError(Txt_Login, "!");
                result = false;
            }
            if (!Txt_Password.Text.HasValue())
            {
                validateControl.SetError(Txt_Password, "!");
                result = false;
            }

            return result;
        }

        private void LoadSettings()
        {
            try
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
                }

                if (File.Exists(SkyRegUser.UserConfigFile))
                {
                    using (StreamReader tr2 = new StreamReader(SkyRegUser.UserConfigFile, Encoding.GetEncoding("windows-1250")))
                    {
                        XmlSerializer deserializerUser = new XmlSerializer(typeof(BaseModel));
                        UserConfig = (BaseModel)deserializerUser.Deserialize(tr2);

                        if (UserConfig != null)
                            Txt_Login.Text = UserConfig.Login;
                    };
                }

            }

            catch (Exception)
            {
                KryptonMessageBox.Show("Wystąpił błąd podczas wczytywania pliku z ustawieniami", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Cancel;
            }

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void LogIn()
        {
            string login = Txt_Login.Text.ToLower();
            string password = Txt_Password.Text;

            try
            {
                if (ValidateControls())
                {
                    var user = new Users
                    {
                        Id = 1,
                        Login = "Garibo"
                    };

                    if (user != null)
                    {
                        SkyRegUser.UserLogin = user.Login;
                        SkyRegUser.UserId = user.Id;
                        SaveUserConfig(user);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        KryptonMessageBox.Show("Podany login lub hasło nie są prawidłowe", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message.ToString(), "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void SaveUserConfig(Users user)
        {
            string saveFile = SkyRegUser.GlobalPathFile + @"\UserConfig.xml";
            CreateSkyregFolder();

            var userConfig = new BaseModel();
            using (StreamWriter TW = new StreamWriter(saveFile, false, Encoding.GetEncoding("windows-1250")))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(BaseModel));
                userConfig.Login = user.Login;
                userConfig.UserId = user.Id;
                serializer.Serialize(TW, userConfig);
            }

        }

        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Login.Text))
                Txt_Login.Focus();
            else
                Txt_Password.Focus();
        }

        private void Txt_Pasword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LogIn();
        }

        private void CheckDatabaseConfig()
        {
            if (!File.Exists(SkyRegUser.DatabaseConfigFile))
            {
                IsDbExists = false;
                KryptonMessageBox.Show("Nie znaleziono pliku kofiguracyjnego do bazy danych. Proszę skofigurować base SQL!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                IsDbExists = true;

        }
        private void CreateSkyregFolder()
        {
            if (!Directory.Exists(SkyRegUser.GlobalPathFile))
            {
                Directory.CreateDirectory(SkyRegUser.GlobalPathFile);
            }
        }

        private void btnDatabaseCfg_Click(object sender, EventArgs e)
        {
            frmDataBaseConfig = FormsOpened<FrmDataBaseConfig>.IsShowDialog(frmDataBaseConfig);
            frmDataBaseConfig.ShowDialog();
        }

        private FrmDataBaseConfig frmDataBaseConfig = null;
        private FrmRegistration frmRegistration = null;

        private void RegisterUser_Click(object sender, EventArgs e)
        {
            frmRegistration = FormsOpened<FrmRegistration>.IsShowDialog(frmRegistration);
            frmRegistration.ShowDialog();
        }
    }
}