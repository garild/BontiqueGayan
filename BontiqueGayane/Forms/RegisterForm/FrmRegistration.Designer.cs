namespace SkyReg.Forms.RegisterForm
{
    partial class FrmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistration));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kryptonPanelEx2 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanelEx();
            this.btn_Save = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.btn_Close = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.kryptonBorderedLabel1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel();
            this.kryptonBorderedLabel2 = new ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel();
            this.Txt_Login = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            this.Txt_Name = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            this.kryptonPanelEx1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanelEx();
            this.kryptonBorderedLabel3 = new ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel();
            this.Txt_Password = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            this.kryptonBorderedLabel4 = new ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel();
            this.Txt_ConfirmPassword = new ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.kryptonPanelEx2.SuspendLayout();
            this.kryptonPanelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(253, 234);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // kryptonPanelEx2
            // 
            this.kryptonPanelEx2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kryptonPanelEx2.Controls.Add(this.btn_Close);
            this.kryptonPanelEx2.Controls.Add(this.btn_Save);
            this.kryptonPanelEx2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanelEx2.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanelEx2.GradientToogleColours = false;
            this.kryptonPanelEx2.GradientUseBlend = false;
            this.kryptonPanelEx2.Image = null;
            this.kryptonPanelEx2.ImageLocation = new System.Drawing.Point(4, 4);
            this.kryptonPanelEx2.Location = new System.Drawing.Point(0, 271);
            this.kryptonPanelEx2.Name = "kryptonPanelEx2";
            this.kryptonPanelEx2.PersistentColours = false;
            this.kryptonPanelEx2.Size = new System.Drawing.Size(495, 38);
            this.kryptonPanelEx2.TabIndex = 25;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(204, 7);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(109, 26);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Values.Image = global::BoutiqueShopp.Properties.Resources.iconfinder_Apply_132742;
            this.btn_Save.Values.Text = "Zapisz";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom2;
            this.btn_Close.Location = new System.Drawing.Point(343, 7);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_Close.Size = new System.Drawing.Size(117, 26);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Values.Image = global::BoutiqueShopp.Properties.Resources.iconfinder_Delete_132746;
            this.btn_Close.Values.Text = "Zamknij";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // kryptonBorderedLabel1
            // 
            this.kryptonBorderedLabel1.BackColor = System.Drawing.Color.Transparent;
            this.kryptonBorderedLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.kryptonBorderedLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonBorderedLabel1.Location = new System.Drawing.Point(238, 26);
            this.kryptonBorderedLabel1.Name = "kryptonBorderedLabel1";
            this.kryptonBorderedLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office365Black;
            this.kryptonBorderedLabel1.Size = new System.Drawing.Size(47, 22);
            this.kryptonBorderedLabel1.TabIndex = 26;
            this.kryptonBorderedLabel1.Values.Text = "Imię:";
            // 
            // kryptonBorderedLabel2
            // 
            this.kryptonBorderedLabel2.BackColor = System.Drawing.Color.Transparent;
            this.kryptonBorderedLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.kryptonBorderedLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonBorderedLabel2.Location = new System.Drawing.Point(238, 76);
            this.kryptonBorderedLabel2.Name = "kryptonBorderedLabel2";
            this.kryptonBorderedLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.kryptonBorderedLabel2.Size = new System.Drawing.Size(54, 22);
            this.kryptonBorderedLabel2.TabIndex = 26;
            this.kryptonBorderedLabel2.Values.Text = "Login:";
            // 
            // Txt_Login
            // 
            this.Txt_Login.DrawPrompt = true;
            this.Txt_Login.FocusSelect = true;
            this.Txt_Login.Location = new System.Drawing.Point(293, 50);
            this.Txt_Login.Name = "Txt_Login";
            this.Txt_Login.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.Txt_Login.PromptText = "";
            this.Txt_Login.PromptTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Txt_Login.Size = new System.Drawing.Size(143, 20);
            this.Txt_Login.TabIndex = 0;
            // 
            // Txt_Name
            // 
            this.Txt_Name.DrawPrompt = true;
            this.Txt_Name.FocusSelect = true;
            this.Txt_Name.Location = new System.Drawing.Point(293, 105);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.Txt_Name.PromptText = "";
            this.Txt_Name.PromptTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Txt_Name.Size = new System.Drawing.Size(143, 20);
            this.Txt_Name.TabIndex = 1;
            // 
            // kryptonPanelEx1
            // 
            this.kryptonPanelEx1.Controls.Add(this.Txt_ConfirmPassword);
            this.kryptonPanelEx1.Controls.Add(this.Txt_Password);
            this.kryptonPanelEx1.Controls.Add(this.kryptonBorderedLabel4);
            this.kryptonPanelEx1.Controls.Add(this.Txt_Name);
            this.kryptonPanelEx1.Controls.Add(this.kryptonBorderedLabel3);
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
            this.kryptonPanelEx1.Size = new System.Drawing.Size(495, 309);
            this.kryptonPanelEx1.TabIndex = 2;
            // 
            // kryptonBorderedLabel3
            // 
            this.kryptonBorderedLabel3.BackColor = System.Drawing.Color.Transparent;
            this.kryptonBorderedLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.kryptonBorderedLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonBorderedLabel3.Location = new System.Drawing.Point(233, 131);
            this.kryptonBorderedLabel3.Name = "kryptonBorderedLabel3";
            this.kryptonBorderedLabel3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.kryptonBorderedLabel3.Size = new System.Drawing.Size(54, 22);
            this.kryptonBorderedLabel3.TabIndex = 26;
            this.kryptonBorderedLabel3.Values.Text = "Hasło:";
            // 
            // Txt_Password
            // 
            this.Txt_Password.DrawPrompt = true;
            this.Txt_Password.FocusSelect = true;
            this.Txt_Password.Location = new System.Drawing.Point(293, 154);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.Txt_Password.PromptText = "";
            this.Txt_Password.PromptTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Txt_Password.Size = new System.Drawing.Size(143, 20);
            this.Txt_Password.TabIndex = 2;
            // 
            // kryptonBorderedLabel4
            // 
            this.kryptonBorderedLabel4.BackColor = System.Drawing.Color.Transparent;
            this.kryptonBorderedLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.kryptonBorderedLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonBorderedLabel4.Location = new System.Drawing.Point(233, 180);
            this.kryptonBorderedLabel4.Name = "kryptonBorderedLabel4";
            this.kryptonBorderedLabel4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.kryptonBorderedLabel4.Size = new System.Drawing.Size(100, 22);
            this.kryptonBorderedLabel4.TabIndex = 26;
            this.kryptonBorderedLabel4.Values.Text = "Powtórz hasło:";
            // 
            // Txt_ConfirmPassword
            // 
            this.Txt_ConfirmPassword.DrawPrompt = true;
            this.Txt_ConfirmPassword.FocusSelect = true;
            this.Txt_ConfirmPassword.Location = new System.Drawing.Point(293, 208);
            this.Txt_ConfirmPassword.Name = "Txt_ConfirmPassword";
            this.Txt_ConfirmPassword.PasswordChar = '*';
            this.Txt_ConfirmPassword.PromptForeColour = System.Drawing.SystemColors.GrayText;
            this.Txt_ConfirmPassword.PromptText = "";
            this.Txt_ConfirmPassword.PromptTypeface = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Txt_ConfirmPassword.Size = new System.Drawing.Size(143, 20);
            this.Txt_ConfirmPassword.TabIndex = 3;
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 309);
            this.Controls.Add(this.kryptonPanelEx1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistration";
            this.Text = "Rejestracja użytkownika";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.kryptonPanelEx2.ResumeLayout(false);
            this.kryptonPanelEx1.ResumeLayout(false);
            this.kryptonPanelEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanelEx kryptonPanelEx2;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton btn_Close;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton btn_Save;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel kryptonBorderedLabel1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel kryptonBorderedLabel2;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox Txt_Login;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox Txt_Name;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanelEx kryptonPanelEx1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox Txt_ConfirmPassword;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonPromptTextBox Txt_Password;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel kryptonBorderedLabel4;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonBorderedLabel kryptonBorderedLabel3;
    }
}