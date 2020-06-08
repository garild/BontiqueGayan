namespace SkyReg.MainForm
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.cMSDatabase = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDatabaseCfg = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterUser = new System.Windows.Forms.ToolStripMenuItem();
            this.StyleManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanelEx1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanelEx();
            this.Txt_Password = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            this.Txt_Login = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            this.kryptonBorderedLabel2 = new ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel();
            this.kryptonBorderedLabel1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel();
            this.kryptonPanelEx2 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanelEx();
            this.btn_Close = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.btn_Login = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cMSDatabase.SuspendLayout();
            this.kryptonPanelEx1.SuspendLayout();
            this.kryptonPanelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.cMSDatabase.Opening += new System.ComponentModel.CancelEventHandler(this.cMSDatabase_Opening);
            // 
            // btnDatabaseCfg
            // 
            this.btnDatabaseCfg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDatabaseCfg.Image = ((System.Drawing.Image)(resources.GetObject("btnDatabaseCfg.Image")));
            this.btnDatabaseCfg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDatabaseCfg.Name = "btnDatabaseCfg";
            this.btnDatabaseCfg.Size = new System.Drawing.Size(172, 22);
            this.btnDatabaseCfg.Text = "Konfiguracja bazy";
            this.btnDatabaseCfg.Click += new System.EventHandler(this.btnDatabaseCfg_Click);
            // 
            // RegisterUser
            // 
            this.RegisterUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.RegisterUser.Image = ((System.Drawing.Image)(resources.GetObject("RegisterUser.Image")));
            this.RegisterUser.Name = "RegisterUser";
            this.RegisterUser.Size = new System.Drawing.Size(172, 22);
            this.RegisterUser.Text = "Zarejestruj się!";
            this.RegisterUser.Click += new System.EventHandler(this.RegisterUser_Click);
            // 
            // StyleManager
            // 
            this.StyleManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Black;
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Black;
            // 
            // kryptonPanelEx1
            // 
            this.kryptonPanelEx1.Controls.Add(this.Txt_Password);
            this.kryptonPanelEx1.Controls.Add(this.Txt_Login);
            this.kryptonPanelEx1.Controls.Add(this.kryptonBorderedLabel2);
            this.kryptonPanelEx1.Controls.Add(this.kryptonBorderedLabel1);
            this.kryptonPanelEx1.Controls.Add(this.kryptonPanelEx2);
            this.kryptonPanelEx1.Controls.Add(this.pictureBox2);
            this.kryptonPanelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelEx1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanelEx1.GradientToogleColours = false;
            this.kryptonPanelEx1.GradientUseBlend = false;
            this.kryptonPanelEx1.Image = null;
            this.kryptonPanelEx1.ImageLocation = new System.Drawing.Point(4, 4);
            this.kryptonPanelEx1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelEx1.Name = "kryptonPanelEx1";
            this.kryptonPanelEx1.PersistentColours = false;
            this.kryptonPanelEx1.Size = new System.Drawing.Size(431, 179);
            this.kryptonPanelEx1.TabIndex = 1;
            // 
            // Txt_Password
            // 
            this.Txt_Password.DrawPrompt = true;
            this.Txt_Password.FocusSelect = true;
            this.Txt_Password.Location = new System.Drawing.Point(257, 74);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.Txt_Password.PromptText = "";
            this.Txt_Password.PromptTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Txt_Password.Size = new System.Drawing.Size(143, 20);
            this.Txt_Password.TabIndex = 1;
            this.Txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Pasword_KeyDown);
            // 
            // Txt_Login
            // 
            this.Txt_Login.DrawPrompt = true;
            this.Txt_Login.FocusSelect = true;
            this.Txt_Login.Location = new System.Drawing.Point(257, 46);
            this.Txt_Login.Name = "Txt_Login";
            this.Txt_Login.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.Txt_Login.PromptText = "";
            this.Txt_Login.PromptTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Txt_Login.Size = new System.Drawing.Size(143, 20);
            this.Txt_Login.TabIndex = 0;
            // 
            // kryptonBorderedLabel2
            // 
            this.kryptonBorderedLabel2.BackColor = System.Drawing.Color.Transparent;
            this.kryptonBorderedLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.kryptonBorderedLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonBorderedLabel2.Location = new System.Drawing.Point(197, 74);
            this.kryptonBorderedLabel2.Name = "kryptonBorderedLabel2";
            this.kryptonBorderedLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.kryptonBorderedLabel2.Size = new System.Drawing.Size(54, 22);
            this.kryptonBorderedLabel2.TabIndex = 26;
            this.kryptonBorderedLabel2.Values.Text = "Hasło:";
            // 
            // kryptonBorderedLabel1
            // 
            this.kryptonBorderedLabel1.BackColor = System.Drawing.Color.Transparent;
            this.kryptonBorderedLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.kryptonBorderedLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonBorderedLabel1.Location = new System.Drawing.Point(197, 46);
            this.kryptonBorderedLabel1.Name = "kryptonBorderedLabel1";
            this.kryptonBorderedLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office365Black;
            this.kryptonBorderedLabel1.Size = new System.Drawing.Size(54, 22);
            this.kryptonBorderedLabel1.TabIndex = 26;
            this.kryptonBorderedLabel1.Values.Text = "Login:";
            // 
            // kryptonPanelEx2
            // 
            this.kryptonPanelEx2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kryptonPanelEx2.Controls.Add(this.btn_Close);
            this.kryptonPanelEx2.Controls.Add(this.btn_Login);
            this.kryptonPanelEx2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanelEx2.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanelEx2.GradientToogleColours = false;
            this.kryptonPanelEx2.GradientUseBlend = false;
            this.kryptonPanelEx2.Image = null;
            this.kryptonPanelEx2.ImageLocation = new System.Drawing.Point(4, 4);
            this.kryptonPanelEx2.Location = new System.Drawing.Point(0, 141);
            this.kryptonPanelEx2.Name = "kryptonPanelEx2";
            this.kryptonPanelEx2.PersistentColours = false;
            this.kryptonPanelEx2.Size = new System.Drawing.Size(431, 38);
            this.kryptonPanelEx2.TabIndex = 25;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(309, 7);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.btn_Close.Size = new System.Drawing.Size(90, 26);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Values.Image = global::BoutiqueShopp.Properties.Resources.iconfinder_Delete_132746;
            this.btn_Close.Values.Text = "Zamknij";
            this.btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(196, 7);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.btn_Login.Size = new System.Drawing.Size(91, 26);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Values.Image = global::BoutiqueShopp.Properties.Resources.iconfinder_Apply_132742;
            this.btn_Login.Values.Text = "Zaloguj się";
            this.btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.ContextMenuStrip = this.cMSDatabase;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 179);
            this.Controls.Add(this.kryptonPanelEx1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.Shown += new System.EventHandler(this.FrmLogin_Shown);
            this.cMSDatabase.ResumeLayout(false);
            this.kryptonPanelEx1.ResumeLayout(false);
            this.kryptonPanelEx1.PerformLayout();
            this.kryptonPanelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonManager StyleManager;
        private System.Windows.Forms.ContextMenuStrip cMSDatabase;
        private System.Windows.Forms.ToolStripMenuItem btnDatabaseCfg;
        private System.Windows.Forms.ToolStripMenuItem RegisterUser;
        public ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanelEx kryptonPanelEx1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanelEx kryptonPanelEx2;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton btn_Close;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton btn_Login;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel kryptonBorderedLabel2;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel kryptonBorderedLabel1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox Txt_Password;
        public ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox Txt_Login;
    }
}