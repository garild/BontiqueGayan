using ComponentFactory.Krypton.Toolkit;
using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
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
        private LoggedUser UserConfig { get; set; }

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
            if (user != default)
            {
                GlobalApplicationSettings.User = user;
                Txt_Login.Text = user.Login;
            }
        }

        private void AllowDbConfig()
        {
            if (Txt_Login.Text.ToLower() == "admin" && Txt_Password.Text == "SP33dMy$QL")
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
            string login = Txt_Login.Text.TrimToLower();
            string password = Txt_Password.Text;

            try
            {
                if (ValidateControls())
                {
                    var user = _userRepository.Find(login, password.EncryptString());
                    if (user != null)
                    {
                        GlobalApplicationSettings.User = new LoggedUser { Id = user.Id, Login = user.Login };
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

        private void SaveUserConfig(User user)
        {
            string saveFile = GlobalApplicationSettings.GlobalPathFile + @"\UserConfig.json";
            CreateSkyregFolder();

            var userConfig = new LoggedUser();
            using (StreamWriter TW = new StreamWriter(saveFile, false, Encoding.GetEncoding("windows-1250")))
            {
                userConfig.Login = user.Login;
                userConfig.Id = user.Id;
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
            FormsOpened<FrmDataBaseConfig>.OpenForm(frmDataBaseConfig);
        }

        private void RegisterUser_Click(object sender, EventArgs e)
        {
            FormsOpened<FrmRegistration>.OpenForm(frmRegistration, _userRepository);
        }

        private void cMSDatabase_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            AllowDbConfig();
        }
    }
}
