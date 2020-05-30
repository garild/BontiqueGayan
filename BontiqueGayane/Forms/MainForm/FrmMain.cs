using ComponentFactory.Krypton.Toolkit;
using System;

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
            tstrVersion.Text = String.Format("{0}  ", "");
            tstrComputerName.Text = "";
            tstrLoggedUser.Text = "";
        }

        private void outlookBar_ButtonClicked(object sender, EventArgs e)
        {
            switch (outlookBar.Buttons[outlookBar.SelectedIndex].BuddyPage1)
            {
                //case "Settings":
                //    FrmGlobalSettings = FormsOpened<FrmGlobalSettings>.IsOpened(FrmGlobalSettings);
                //    FrmGlobalSettings.MdiParent = this;
                //    FrmGlobalSettings.WindowState = FormWindowState.Maximized;
                //    FrmGlobalSettings.FormClosed += FrmGlobalSettings_FormClosed;
                //    FrmGlobalSettings.Show();
                //    FrmGlobalSettings.BringToFront();
                //    FrmGlobalSettings.Activate();
                //    break;
            }
        }
    }
}
