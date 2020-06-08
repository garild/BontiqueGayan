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

        private FrmCustomerList CustomerList;
        private FrmProductList ProductList;

        private readonly IUserRepository _userRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IProductRepository _productRepository;
        public FrmMain(IContainer container)
        {
            InitializeComponent();
            LoadStatusBarSettings();

            _userRepository = container.Resolve<IUserRepository>();
            _customerRepository = container.Resolve<ICustomerRepository>();
            _productRepository = container.Resolve<IProductRepository>();
        }

        private void LoadStatusBarSettings()
        {
            tstrVersion.Text = string.Format("{0}  ", GlobalApplicationSettings.AppVer);
            tstrComputerName.Text = Environment.MachineName;
            tstrLoggedUser.Text = GlobalApplicationSettings.User.Login;
        }

        private void btn_CustomerList_Click(object sender, EventArgs e)
        {
            CustomerList = FormsOpened<FrmCustomerList>.OpenMDIForm(CustomerList, this, _customerRepository);
        }

        private void CustomerList_FormClosed(object sender, FormClosedEventArgs e)
        {
            CustomerList = null;
        }
    

        private void btn_Products_Click(object sender, EventArgs e)
        {
            ProductList = FormsOpened<FrmProductList>.OpenMDIForm(ProductList, this, _productRepository);
        }
    }
}
