using BoutiqueShopp.Domain;
using ComponentFactory.Krypton.Toolkit;
using Database;
using SkyReg.Common;

namespace SkyReg.Forms.RegisterForm
{
    public partial class FrmRegistration : KryptonForm
    {
        private readonly IUserRepository _userRepository;

        public FrmRegistration(IUserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
        }

        private void btn_Save_Click(object sender, System.EventArgs e)
        {
            if(!Txt_ConfirmPassword.Text.Equals(Txt_Password.Text,System.StringComparison.Ordinal))
            {
                KryptonMessageBox.Show("Hasła się nie zgadzają, spróbuj ponownie !","Rejestracja");
                return;
            }

            var hashedPasword = Txt_Password.Text.EncryptString();

            var user = new Users
            {
                Login = Txt_Login.Text.ToLower().Trim(),
                Name = Txt_Name.Text.ToLower().Trim(),
                HashedPassword = hashedPasword
            };

            GlobalApplicationSettings.UserId = _userRepository.Create(user);
            GlobalApplicationSettings.UserLogin = user.Login;
            
            this.Close();
        }

        private void btn_Close_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
