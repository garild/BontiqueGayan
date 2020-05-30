using ComponentFactory.Krypton.Toolkit;
using Database;
using SkyReg.Common;

namespace SkyReg.Forms.RegisterForm
{
    public partial class FrmRegistration : KryptonForm
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, System.EventArgs e)
        {
            if(!Txt_ConfirmPassword.Text.Equals(Txt_Password.Text,System.StringComparison.Ordinal))
            {
                KryptonMessageBox.Show("Hasła się nie zgadzają, spróbuj ponownie !");
                return;
            }

            var hashedPasword = Txt_Password.Text.EncryptString();

            var user = new Users
            {
                Login = Txt_Login.Text.Trim(),
                Name = Txt_Name.Text.Trim(),
                HashedPassword = hashedPasword
            };
        }

        private void btn_Close_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
