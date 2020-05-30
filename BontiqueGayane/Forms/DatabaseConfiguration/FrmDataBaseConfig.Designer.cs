namespace SkyReg.Forms.DatabaseConfiguration
{
    partial class FrmDataBaseConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDataBaseConfig));
            this.Btn_Login = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanelEx1 = new AC.ExtendedRenderer.Toolkit.KryptonPanelEx();
            this.Btn_Close = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cMSDatabase = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDatabaseCfg = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterUser = new System.Windows.Forms.ToolStripMenuItem();
            this.StyleManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kryptonPanelEx2 = new AC.ExtendedRenderer.Toolkit.KryptonPanelEx();
            this.kryptonPanelEx1.SuspendLayout();
            this.cMSDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.kryptonPanelEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(206, 6);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.Btn_Login.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Btn_Login.Size = new System.Drawing.Size(93, 25);
            this.Btn_Login.TabIndex = 0;
            this.Btn_Login.Values.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Login.Values.Image")));
            this.Btn_Login.Values.Text = "Zaloguj się";
            // 
            // kryptonPanelEx1
            // 
            this.kryptonPanelEx1.Controls.Add(this.Btn_Close);
            this.kryptonPanelEx1.Controls.Add(this.Btn_Login);
            this.kryptonPanelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanelEx1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanelEx1.GradientToogleColors = false;
            this.kryptonPanelEx1.GradientUseBlend = false;
            this.kryptonPanelEx1.Image = null;
            this.kryptonPanelEx1.ImageLocation = new System.Drawing.Point(4, 4);
            this.kryptonPanelEx1.Location = new System.Drawing.Point(0, 213);
            this.kryptonPanelEx1.Name = "kryptonPanelEx1";
            this.kryptonPanelEx1.PersistentColors = false;
            this.kryptonPanelEx1.Size = new System.Drawing.Size(536, 37);
            this.kryptonPanelEx1.TabIndex = 2;
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(305, 6);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.Btn_Close.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Btn_Close.Size = new System.Drawing.Size(92, 25);
            this.Btn_Close.TabIndex = 1;
            this.Btn_Close.Values.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Close.Values.Image")));
            this.Btn_Close.Values.Text = "Zamknij";
            // 
            // cMSDatabase
            // 
            this.cMSDatabase.DropShadowEnabled = false;
            this.cMSDatabase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cMSDatabase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDatabaseCfg,
            this.RegisterUser});
            this.cMSDatabase.Name = "contextMenuStrip1";
            this.cMSDatabase.Size = new System.Drawing.Size(173, 48);
            // 
            // btnDatabaseCfg
            // 
            this.btnDatabaseCfg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDatabaseCfg.Image = ((System.Drawing.Image)(resources.GetObject("btnDatabaseCfg.Image")));
            this.btnDatabaseCfg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDatabaseCfg.Name = "btnDatabaseCfg";
            this.btnDatabaseCfg.Size = new System.Drawing.Size(172, 22);
            this.btnDatabaseCfg.Text = "Konfiguracja bazy";
            // 
            // RegisterUser
            // 
            this.RegisterUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.RegisterUser.Image = ((System.Drawing.Image)(resources.GetObject("RegisterUser.Image")));
            this.RegisterUser.Name = "RegisterUser";
            this.RegisterUser.Size = new System.Drawing.Size(172, 22);
            this.RegisterUser.Text = "Zarejestruj się!";
            // 
            // StyleManager
            // 
            this.StyleManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Black;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.ContextMenuStrip = this.cMSDatabase;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // kryptonPanelEx2
            // 
            this.kryptonPanelEx2.Controls.Add(this.pictureBox2);
            this.kryptonPanelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelEx2.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanelEx2.GradientToogleColors = false;
            this.kryptonPanelEx2.GradientUseBlend = false;
            this.kryptonPanelEx2.Image = null;
            this.kryptonPanelEx2.ImageLocation = new System.Drawing.Point(4, 4);
            this.kryptonPanelEx2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelEx2.Name = "kryptonPanelEx2";
            this.kryptonPanelEx2.PersistentColors = false;
            this.kryptonPanelEx2.Size = new System.Drawing.Size(536, 250);
            this.kryptonPanelEx2.TabIndex = 3;
            // 
            // FrmDataBaseConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 250);
            this.Controls.Add(this.kryptonPanelEx1);
            this.Controls.Add(this.kryptonPanelEx2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDataBaseConfig";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generowanie bazy";
            this.kryptonPanelEx1.ResumeLayout(false);
            this.cMSDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.kryptonPanelEx2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Login;
        private AC.ExtendedRenderer.Toolkit.KryptonPanelEx kryptonPanelEx1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_Close;
        private System.Windows.Forms.ContextMenuStrip cMSDatabase;
        private System.Windows.Forms.ToolStripMenuItem btnDatabaseCfg;
        private System.Windows.Forms.ToolStripMenuItem RegisterUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private AC.ExtendedRenderer.Toolkit.KryptonPanelEx kryptonPanelEx2;
        private ComponentFactory.Krypton.Toolkit.KryptonManager StyleManager;
    }
}