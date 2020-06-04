using BoutiqueShopp.Forms.Products;
using ComponentFactory.Krypton.Toolkit;
using SkyReg.Common.Extensions;
using System;
using System.Windows.Forms;

namespace SkyReg
{
    public partial class FrmMain : KryptonForm
    {
        public FrmMain()
        {
            InitializeComponent();
            LoadStatusBarSettings();
        }

        private void LoadStatusBarSettings()
        {
            tstrVersion.Text = String.Format("{0}  ", GlobalApplicationSettings.AppVer);
            tstrComputerName.Text = Environment.MachineName;
            tstrLoggedUser.Text = GlobalApplicationSettings.UserLogin;
        }

        private void btn_Products_Click(object sender, EventArgs e)
        {

        }

        private void btn_CustomerList_Click(object sender, EventArgs e)
        {
            CustomerList = FormsOpened<FrmCustomerList>.IsOpened(CustomerList);
            CustomerList.MdiParent = this;
            CustomerList.WindowState = FormWindowState.Maximized;
            CustomerList.FormClosed += CustomerList_FormClosed;
            CustomerList.Show();
            CustomerList.BringToFront();
            CustomerList.Activate();
        }

        private void CustomerList_FormClosed(object sender, FormClosedEventArgs e)
        {
            CustomerList = null;
        }

        private FrmCustomerList CustomerList;
    }
}
