namespace SkyReg
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            AC.ExtendedRenderer.Navigator.OutlookBarButton outlookBarButton6 = new AC.ExtendedRenderer.Navigator.OutlookBarButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            AC.ExtendedRenderer.Navigator.OutlookBarButton outlookBarButton7 = new AC.ExtendedRenderer.Navigator.OutlookBarButton();
            AC.ExtendedRenderer.Navigator.OutlookBarButton outlookBarButton8 = new AC.ExtendedRenderer.Navigator.OutlookBarButton();
            AC.ExtendedRenderer.Navigator.OutlookBarButton outlookBarButton9 = new AC.ExtendedRenderer.Navigator.OutlookBarButton();
            AC.ExtendedRenderer.Navigator.OutlookBarButton outlookBarButton10 = new AC.ExtendedRenderer.Navigator.OutlookBarButton();
            this.outlookBar = new AC.ExtendedRenderer.Navigator.OutlookBar();
            this.StyleManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstrVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstrLoggedUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstrComputerName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outlookBar
            // 
            this.outlookBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.outlookBar.ButtonColorHoveringBottom = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(177)))));
            this.outlookBar.ButtonColorHoveringTop = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(77)))));
            this.outlookBar.ButtonColorPassiveBottom = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.outlookBar.ButtonColorPassiveTop = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(208)))), ((int)(((byte)(214)))));
            this.outlookBar.ButtonColorSelectedAndHoveringBottom = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(207)))), ((int)(((byte)(100)))));
            this.outlookBar.ButtonColorSelectedAndHoveringTop = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(142)))), ((int)(((byte)(49)))));
            this.outlookBar.ButtonColorSelectedBottom = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(195)))), ((int)(((byte)(108)))));
            this.outlookBar.ButtonColorSelectedTop = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(122)))), ((int)(((byte)(5)))));
            this.outlookBar.ButtonHeight = 40;
            outlookBarButton6.BuddyPage1 = "Products";
            outlookBarButton6.BuddyPage2 = null;
            outlookBarButton6.Image = ((System.Drawing.Icon)(resources.GetObject("outlookBarButton6.Image")));
            outlookBarButton6.Tag1 = null;
            outlookBarButton6.Tag2 = null;
            outlookBarButton6.Text = "Produkty";
            outlookBarButton7.BuddyPage1 = "Moneys";
            outlookBarButton7.BuddyPage2 = null;
            outlookBarButton7.Image = ((System.Drawing.Icon)(resources.GetObject("outlookBarButton7.Image")));
            outlookBarButton7.Tag1 = null;
            outlookBarButton7.Tag2 = null;
            outlookBarButton7.Text = "Finanse";
            outlookBarButton8.BuddyPage1 = "Settings";
            outlookBarButton8.BuddyPage2 = null;
            outlookBarButton8.Image = ((System.Drawing.Icon)(resources.GetObject("outlookBarButton8.Image")));
            outlookBarButton8.Tag1 = null;
            outlookBarButton8.Tag2 = null;
            outlookBarButton8.Text = "Ustawienia";
            outlookBarButton9.BuddyPage1 = "UserList";
            outlookBarButton9.BuddyPage2 = "UserList";
            outlookBarButton9.Image = ((System.Drawing.Icon)(resources.GetObject("outlookBarButton9.Image")));
            outlookBarButton9.Tag1 = null;
            outlookBarButton9.Tag2 = null;
            outlookBarButton9.Text = "Użytkownicy";
            outlookBarButton10.BuddyPage1 = "Customers";
            outlookBarButton10.BuddyPage2 = "Customers";
            outlookBarButton10.Image = ((System.Drawing.Icon)(resources.GetObject("outlookBarButton10.Image")));
            outlookBarButton10.Tag1 = null;
            outlookBarButton10.Tag2 = null;
            outlookBarButton10.Text = "Klienci";
            this.outlookBar.Buttons.Add(outlookBarButton6);
            this.outlookBar.Buttons.Add(outlookBarButton7);
            this.outlookBar.Buttons.Add(outlookBarButton8);
            this.outlookBar.Buttons.Add(outlookBarButton9);
            this.outlookBar.Buttons.Add(outlookBarButton10);
            this.outlookBar.CausesValidation = false;
            this.outlookBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outlookBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.outlookBar.DrawBorders = true;
            this.outlookBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outlookBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.outlookBar.ForeColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.outlookBar.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.outlookBar.Location = new System.Drawing.Point(0, 0);
            this.outlookBar.MinimumSize = new System.Drawing.Size(16, 40);
            this.outlookBar.Name = "outlookBar";
            this.outlookBar.OutlookBarLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(83)))), ((int)(((byte)(92)))));
            this.outlookBar.Padding = new System.Windows.Forms.Padding(12);
            this.outlookBar.Renderer = AC.ExtendedRenderer.Navigator.Renderer.Krypton;
            this.outlookBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.outlookBar.Size = new System.Drawing.Size(247, 200);
            this.outlookBar.TabIndex = 2;
            this.outlookBar.TabStop = false;
            this.outlookBar.Text = "outlookBar";
            this.outlookBar.ButtonClicked += new AC.ExtendedRenderer.Navigator.OutlookBar.ButtonClickedEventHandler(this.outlookBar_ButtonClicked);
            // 
            // StyleManager
            // 
            this.StyleManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Black;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(350, 16);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel3,
            this.tstrVersion,
            this.toolStripStatusLabel7,
            this.tstrLoggedUser,
            this.toolStripStatusLabel5,
            this.tstrComputerName,
            this.toolStripStatusLabel6});
            this.statusStrip1.Location = new System.Drawing.Point(0, 789);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1484, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = " ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel3.Text = " ";
            // 
            // tstrVersion
            // 
            this.tstrVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tstrVersion.Image = ((System.Drawing.Image)(resources.GetObject("tstrVersion.Image")));
            this.tstrVersion.Name = "tstrVersion";
            this.tstrVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tstrVersion.Size = new System.Drawing.Size(61, 17);
            this.tstrVersion.Text = "Wersja";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel7.Text = " ";
            // 
            // tstrLoggedUser
            // 
            this.tstrLoggedUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tstrLoggedUser.Image = ((System.Drawing.Image)(resources.GetObject("tstrLoggedUser.Image")));
            this.tstrLoggedUser.Name = "tstrLoggedUser";
            this.tstrLoggedUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tstrLoggedUser.Size = new System.Drawing.Size(52, 17);
            this.tstrLoggedUser.Text = " User";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel5.Text = " ";
            // 
            // tstrComputerName
            // 
            this.tstrComputerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tstrComputerName.Image = ((System.Drawing.Image)(resources.GetObject("tstrComputerName.Image")));
            this.tstrComputerName.Name = "tstrComputerName";
            this.tstrComputerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tstrComputerName.Size = new System.Drawing.Size(37, 17);
            this.tstrComputerName.Text = "PC";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel6.Text = "   ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.outlookBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 789);
            this.panel1.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1484, 811);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bontique Gayane";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonManager StyleManager;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tstrVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel tstrLoggedUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel tstrComputerName;
        private System.Windows.Forms.Panel panel1;
        public AC.ExtendedRenderer.Navigator.OutlookBar outlookBar;
    }
}

