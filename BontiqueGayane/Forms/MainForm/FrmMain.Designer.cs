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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
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
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonUACElevatedButton1 = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.kryptonUACElevatedButton3 = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.kryptonUACElevatedButton4 = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.kryptonUACElevatedButton2 = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.kryptonUACElevatedButton4);
            this.panel1.Controls.Add(this.kryptonUACElevatedButton3);
            this.panel1.Controls.Add(this.kryptonUACElevatedButton2);
            this.panel1.Controls.Add(this.kryptonUACElevatedButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 789);
            this.panel1.TabIndex = 3;
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Black;
            // 
            // kryptonUACElevatedButton1
            // 
            this.kryptonUACElevatedButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.kryptonUACElevatedButton1.Location = new System.Drawing.Point(0, 1);
            this.kryptonUACElevatedButton1.Name = "kryptonUACElevatedButton1";
            this.kryptonUACElevatedButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonUACElevatedButton1.Size = new System.Drawing.Size(247, 70);
            this.kryptonUACElevatedButton1.TabIndex = 5;
            this.kryptonUACElevatedButton1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonUACElevatedButton1.Values.Image")));
            this.kryptonUACElevatedButton1.Values.Text = "kryptonUACElevatedButton1";
            // 
            // kryptonUACElevatedButton3
            // 
            this.kryptonUACElevatedButton3.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.kryptonUACElevatedButton3.Location = new System.Drawing.Point(0, 134);
            this.kryptonUACElevatedButton3.Name = "kryptonUACElevatedButton3";
            this.kryptonUACElevatedButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonUACElevatedButton3.Size = new System.Drawing.Size(247, 70);
            this.kryptonUACElevatedButton3.TabIndex = 5;
            this.kryptonUACElevatedButton3.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonUACElevatedButton3.Values.Image")));
            this.kryptonUACElevatedButton3.Values.Text = "kryptonUACElevatedButton1";
            // 
            // kryptonUACElevatedButton4
            // 
            this.kryptonUACElevatedButton4.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.kryptonUACElevatedButton4.Location = new System.Drawing.Point(0, 200);
            this.kryptonUACElevatedButton4.Name = "kryptonUACElevatedButton4";
            this.kryptonUACElevatedButton4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonUACElevatedButton4.Size = new System.Drawing.Size(247, 70);
            this.kryptonUACElevatedButton4.TabIndex = 5;
            this.kryptonUACElevatedButton4.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonUACElevatedButton4.Values.Image")));
            this.kryptonUACElevatedButton4.Values.Text = "kryptonUACElevatedButton1";
            // 
            // kryptonUACElevatedButton2
            // 
            this.kryptonUACElevatedButton2.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.kryptonUACElevatedButton2.Location = new System.Drawing.Point(0, 68);
            this.kryptonUACElevatedButton2.Name = "kryptonUACElevatedButton2";
            this.kryptonUACElevatedButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonUACElevatedButton2.Size = new System.Drawing.Size(247, 70);
            this.kryptonUACElevatedButton2.TabIndex = 5;
            this.kryptonUACElevatedButton2.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonUACElevatedButton2.Values.Image")));
            this.kryptonUACElevatedButton2.Values.Text = "kryptonUACElevatedButton1";
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
        public ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton kryptonUACElevatedButton1;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton kryptonUACElevatedButton4;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton kryptonUACElevatedButton3;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton kryptonUACElevatedButton2;
    }
}

