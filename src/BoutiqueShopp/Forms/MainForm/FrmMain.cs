using Autofac;
using BoutiqueShopp.Domain;
using BoutiqueShopp.Forms.Products;
using ComponentFactory.Krypton.Toolkit;
using SkyReg.Common.Extensions;
using System;
using System.Windows.Forms;

namespace SkyReg
{
    public partial class FrmMain : KryptonForm
    {
        private readonly IUserRepository _userRepository;
        private readonly ICustomerRepository _customerRepository;
        public FrmMain(IContainer container)
        {
            InitializeComponent();
            LoadStatusBarSettings();

            _userRepository = container.Resolve<IUserRepository>();
            _customerRepository = container.Resolve<ICustomerRepository>();
        }

        private void LoadStatusBarSettings()
        {
            tstrVersion.Text = String.Format("{0}  ", GlobalApplicationSettings.AppVer);
            tstrComputerName.Text = Environment.MachineName;
            tstrLoggedUser.Text = GlobalApplicationSettings.User.Login;
        }

        private void btn_CustomerList_Click(object sender, EventArgs e)
        {
            FormsOpened<FrmCustomerList>.OpenMDIForm(CustomerList, this, _customerRepository);
        }

        private void CustomerList_FormClosed(object sender, FormClosedEventArgs e)
        {
            CustomerList = null;
        }
       
        private FrmCustomerList CustomerList;

        private void btn_Products_Click(object sender, EventArgs e)
        {

        }
    }
}
