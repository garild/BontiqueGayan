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
            this.cMSDatabase = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDatabaseCfg = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterUser = new System.Windows.Forms.ToolStripMenuItem();
            this.StyleManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanelEx1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanelEx();
            this.Txt_ServerName = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            this.btn_FileDialog = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.kryptonBorderedLabel4 = new ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel();
            this.Txt_DatabaseName = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            this.kryptonBorderedLabel1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kryptonPanelEx2 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanelEx();
            this.btn_Close = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.btn_Generate = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.DatabaseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.cMSDatabase.SuspendLayout();
            this.kryptonPanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.kryptonPanelEx2.SuspendLayout();
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
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(0, 0);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.TabIndex = 0;
            // 
            // kryptonPanelEx1
            // 
            this.kryptonPanelEx1.Controls.Add(this.Txt_ServerName);
            this.kryptonPanelEx1.Controls.Add(this.btn_FileDialog);
            this.kryptonPanelEx1.Controls.Add(this.kryptonBorderedLabel4);
            this.kryptonPanelEx1.Controls.Add(this.Txt_DatabaseName);
            this.kryptonPanelEx1.Controls.Add(this.kryptonBorderedLabel1);
            this.kryptonPanelEx1.Controls.Add(this.pictureBox2);
            this.kryptonPanelEx1.Controls.Add(this.kryptonPanelEx2);
            this.kryptonPanelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelEx1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanelEx1.GradientToogleColours = false;
            this.kryptonPanelEx1.GradientUseBlend = false;
            this.kryptonPanelEx1.Image = null;
            this.kryptonPanelEx1.ImageLocation = new System.Drawing.Point(4, 4);
            this.kryptonPanelEx1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelEx1.Name = "kryptonPanelEx1";
            this.kryptonPanelEx1.PersistentColours = false;
            this.kryptonPanelEx1.Size = new System.Drawing.Size(536, 250);
            this.kryptonPanelEx1.TabIndex = 1;
            // 
            // Txt_ServerName
            // 
            this.Txt_ServerName.DrawPrompt = true;
            this.Txt_ServerName.FocusSelect = true;
            this.Txt_ServerName.Location = new System.Drawing.Point(292, 134);
            this.Txt_ServerName.Name = "Txt_ServerName";
            this.Txt_ServerName.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.Txt_ServerName.PromptText = "";
            this.Txt_ServerName.PromptTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Txt_ServerName.Size = new System.Drawing.Size(204, 20);
            this.Txt_ServerName.TabIndex = 30;
            // 
            // btn_FileDialog
            // 
            this.btn_FileDialog.Location = new System.Drawing.Point(292, 171);
            this.btn_FileDialog.Name = "btn_FileDialog";
            this.btn_FileDialog.Size = new System.Drawing.Size(204, 26);
            this.btn_FileDialog.TabIndex = 0;
            this.btn_FileDialog.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_FileDialog.Values.Image")));
            this.btn_FileDialog.Values.Text = "Plik dabzy danych";
            this.btn_FileDialog.Click += new System.EventHandler(this.btn_FileDialog_Click);
            // 
            // kryptonBorderedLabel4
            // 
            this.kryptonBorderedLabel4.BackColor = System.Drawing.Color.Transparent;
            this.kryptonBorderedLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.kryptonBorderedLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonBorderedLabel4.Location = new System.Drawing.Point(230, 106);
            this.kryptonBorderedLabel4.Name = "kryptonBorderedLabel4";
            this.kryptonBorderedLabel4.Size = new System.Drawing.Size(106, 22);
            this.kryptonBorderedLabel4.TabIndex = 28;
            this.kryptonBorderedLabel4.Values.Text = "Nazwa Serwera:";
            // 
            // Txt_DatabaseName
            // 
            this.Txt_DatabaseName.DrawPrompt = true;
            this.Txt_DatabaseName.FocusSelect = true;
            this.Txt_DatabaseName.Location = new System.Drawing.Point(292, 80);
            this.Txt_DatabaseName.Name = "Txt_DatabaseName";
            this.Txt_DatabaseName.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.Txt_DatabaseName.PromptText = "";
            this.Txt_DatabaseName.PromptTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Txt_DatabaseName.Size = new System.Drawing.Size(204, 20);
            this.Txt_DatabaseName.TabIndex = 31;
            this.Txt_DatabaseName.Text = "BoutiqueShopp";
            // 
            // kryptonBorderedLabel1
            // 
            this.kryptonBorderedLabel1.BackColor = System.Drawing.Color.Transparent;
            this.kryptonBorderedLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.kryptonBorderedLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonBorderedLabel1.Location = new System.Drawing.Point(230, 52);
            this.kryptonBorderedLabel1.Name = "kryptonBorderedLabel1";
            this.kryptonBorderedLabel1.Size = new System.Drawing.Size(88, 22);
            this.kryptonBorderedLabel1.TabIndex = 29;
            this.kryptonBorderedLabel1.Values.Text = "Nazwa Bazy:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.ContextMenuStrip = this.cMSDatabase;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // kryptonPanelEx2
            // 
            this.kryptonPanelEx2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kryptonPanelEx2.Controls.Add(this.btn_Close);
            this.kryptonPanelEx2.Controls.Add(this.btn_Generate);
            this.kryptonPanelEx2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanelEx2.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanelEx2.GradientToogleColours = false;
            this.kryptonPanelEx2.GradientUseBlend = false;
            this.kryptonPanelEx2.Image = null;
            this.kryptonPanelEx2.ImageLocation = new System.Drawing.Point(4, 4);
            this.kryptonPanelEx2.Location = new System.Drawing.Point(0, 212);
            this.kryptonPanelEx2.Name = "kryptonPanelEx2";
            this.kryptonPanelEx2.PersistentColours = false;
            this.kryptonPanelEx2.Size = new System.Drawing.Size(536, 38);
            this.kryptonPanelEx2.TabIndex = 26;
            // 
            // btn_Close
            // 
            this.btn_Close.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom2;
            this.btn_Close.Location = new System.Drawing.Point(406, 7);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_Close.Size = new System.Drawing.Size(117, 26);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Values.Image = global::BoutiqueShopp.Properties.Resources.iconfinder_Delete_132746;
            this.btn_Close.Values.Text = "Zamknij";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(291, 7);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(109, 26);
            this.btn_Generate.TabIndex = 0;
            this.btn_Generate.Values.Image = global::BoutiqueShopp.Properties.Resources.iconfinder_Apply_132742;
            this.btn_Generate.Values.Text = "Generuj";
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // DatabaseFileDialog
            // 
            this.DatabaseFileDialog.FileName = "DatabaseFileDialog";
            // 
            // FrmDataBaseConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 250);
            this.Controls.Add(this.kryptonPanelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDataBaseConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generowanie bazy";
            this.cMSDatabase.ResumeLayout(false);
            this.kryptonPanelEx1.ResumeLayout(false);
            this.kryptonPanelEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.kryptonPanelEx2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cMSDatabase;
        private System.Windows.Forms.ToolStripMenuItem btnDatabaseCfg;
        private System.Windows.Forms.ToolStripMenuItem RegisterUser;
        public ComponentFactory.Krypton.Toolkit.KryptonManager StyleManager;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanelEx kryptonPanelEx1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanelEx kryptonPanelEx2;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton btn_Close;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton btn_Generate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox Txt_ServerName;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel kryptonBorderedLabel4;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox Txt_DatabaseName;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel kryptonBorderedLabel1;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton btn_FileDialog;
        private System.Windows.Forms.OpenFileDialog DatabaseFileDialog;
    }
}