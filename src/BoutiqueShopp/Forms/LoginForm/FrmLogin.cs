using ComponentFactory.Krypton.Toolkit;
using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using SkyReg.Extensions;
using SkyReg.Forms.DatabaseConfiguration;
using SkyReg.Common.Extensions;
using SkyReg.Common;
using Database;
using SkyReg.Forms.RegisterForm;
using BoutiqueShopp.Domain;
using Autofac;
using BoutiqueShopp.Infrastructure.Providers.DatabaseConfig;
using Newtonsoft.Json;

namespace SkyReg.MainForm
{
    public partial class FrmLogin : KryptonForm
    {
        private ErrorProvider validateControl = new ErrorProvider();
        private BaseModel UserConfig { get; set; }

        private FrmDataBaseConfig frmDataBaseConfig = null;
        private FrmRegistration frmRegistration = null;
        private readonly IUserRepository _userRepository;

        public FrmLogin(IContainer container)
        {
            InitializeComponent();
            LoadUserSettings();
            _userRepository = container.Resolve<IUserRepository>();
        }

        private void LoadUserSettings()
        {
            var user = ApplicationConfigsProvider.ProviderUserConfig();
            if(user != default)
            {
                GlobalApplicationSettings.UserId = user.UserId;
                GlobalApplicationSettings.UserLogin = Txt_Login.Text = user.Login;
            }
        }

        private void AllowDbConfig()
        {
            if (Txt_Login.Text.ToLower() == "Admin")
                if (Txt_Password.Text.ToLower() == "SP33dMy$QL")
                    btnDatabaseCfg.Enabled = true;
                else
                    btnDatabaseCfg.Enabled = false;
        }

        private bool ValidateControls()
        {
            bool result = true;
            validateControl.Clear();
            validateControl.BlinkRate = 250;
            if (!GlobalApplicationSettings.IsDbExists)
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
                    var userExist = _userRepository.Find(login, password.EncryptString());
                    if (userExist != null)
                    {
                        GlobalApplicationSettings.UserLogin = userExist.Login;
                        GlobalApplicationSettings.UserId = userExist.Id;
                        SaveUserConfig(userExist);
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
            string saveFile = GlobalApplicationSettings.GlobalPathFile + @"\UserConfig.json";
            CreateSkyregFolder();

            var userConfig = new BaseModel();
            using (StreamWriter TW = new StreamWriter(saveFile, false, Encoding.GetEncoding("windows-1250")))
            {
                userConfig.Login = user.Login;
                userConfig.UserId = user.Id;
                TW.Write(JsonConvert.SerializeObject(userConfig));
            }

        }

        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Login.Text))
                Txt_Login.Focus();
            else
                Txt_Password.Focus();
        }

        private void Txt_Pasword_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_Login.PerformClick();
        }

        private void CreateSkyregFolder()
        {
            if (!Directory.Exists(GlobalApplicationSettings.GlobalPathFile))
            {
                Directory.CreateDirectory(GlobalApplicationSettings.GlobalPathFile);
            }
        }

        private void btnDatabaseCfg_Click(object sender, EventArgs e)
        {
            frmDataBaseConfig = FormsOpened<FrmDataBaseConfig>.IsShowDialog(frmDataBaseConfig);
            frmDataBaseConfig.ShowDialog();
        }

        private void RegisterUser_Click(object sender, EventArgs e)
        {
            frmRegistration = FormsOpened<FrmRegistration>.IsShowDialog(frmRegistration, _userRepository);
            frmRegistration.ShowDialog();
        }
    }
}
