namespace BoutiqueShopp.Forms.Products
{
    partial class FrmCustomerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonPanelEx3 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanelEx();
            this.kryptonLabel3 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonLabel();
            this.kryptonLabel2 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonLabel();
            this.kryptonLabel1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonLabel();
            this.txt_LastName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_Name = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_Nick = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_DeleteCustomer = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.btn_AddCustomer = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.btn_Search = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.kryptonPanelEx1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanelEx();
            this.CustomerDataGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.kryptonPanelEx3.SuspendLayout();
            this.kryptonPanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanelEx3
            // 
            this.kryptonPanelEx3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kryptonPanelEx3.Controls.Add(this.kryptonLabel3);
            this.kryptonPanelEx3.Controls.Add(this.kryptonLabel2);
            this.kryptonPanelEx3.Controls.Add(this.kryptonLabel1);
            this.kryptonPanelEx3.Controls.Add(this.txt_LastName);
            this.kryptonPanelEx3.Controls.Add(this.txt_Name);
            this.kryptonPanelEx3.Controls.Add(this.txt_Nick);
            this.kryptonPanelEx3.Controls.Add(this.btn_DeleteCustomer);
            this.kryptonPanelEx3.Controls.Add(this.btn_AddCustomer);
            this.kryptonPanelEx3.Controls.Add(this.btn_Search);
            this.kryptonPanelEx3.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanelEx3.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanelEx3.GradientToogleColours = false;
            this.kryptonPanelEx3.GradientUseBlend = false;
            this.kryptonPanelEx3.Image = null;
            this.kryptonPanelEx3.ImageLocation = new System.Drawing.Point(4, 4);
            this.kryptonPanelEx3.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelEx3.Name = "kryptonPanelEx3";
            this.kryptonPanelEx3.PersistentColours = false;
            this.kryptonPanelEx3.Size = new System.Drawing.Size(234, 568);
            this.kryptonPanelEx3.TabIndex = 29;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.AutoSize = true;
            this.kryptonLabel3.BackColor = System.Drawing.Color.Transparent;
            this.kryptonLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonLabel3.Location = new System.Drawing.Point(9, 110);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(56, 13);
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Text = "Nazwisko:";
            this.kryptonLabel3.UseAlternateForeColour = false;
            this.kryptonLabel3.UseKryptonFont = false;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.AutoSize = true;
            this.kryptonLabel2.BackColor = System.Drawing.Color.Transparent;
            this.kryptonLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonLabel2.Location = new System.Drawing.Point(11, 63);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(29, 13);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Text = "Imię:";
            this.kryptonLabel2.UseAlternateForeColour = false;
            this.kryptonLabel2.UseKryptonFont = false;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.AutoSize = true;
            this.kryptonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.kryptonLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonLabel1.Location = new System.Drawing.Point(11, 21);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(32, 13);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Text = "Nick:";
            this.kryptonLabel1.UseAlternateForeColour = false;
            this.kryptonLabel1.UseKryptonFont = false;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(34, 129);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(167, 23);
            this.txt_LastName.TabIndex = 1;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(36, 82);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(167, 23);
            this.txt_Name.TabIndex = 1;
            // 
            // txt_Nick
            // 
            this.txt_Nick.Location = new System.Drawing.Point(36, 39);
            this.txt_Nick.Name = "txt_Nick";
            this.txt_Nick.Size = new System.Drawing.Size(167, 23);
            this.txt_Nick.TabIndex = 1;
            // 
            // btn_DeleteCustomer
            // 
            this.btn_DeleteCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeleteCustomer.Location = new System.Drawing.Point(119, 196);
            this.btn_DeleteCustomer.Name = "btn_DeleteCustomer";
            this.btn_DeleteCustomer.Size = new System.Drawing.Size(82, 23);
            this.btn_DeleteCustomer.TabIndex = 0;
            this.btn_DeleteCustomer.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteCustomer.Values.Image")));
            this.btn_DeleteCustomer.Values.Text = "Usuń";
            this.btn_DeleteCustomer.Click += new System.EventHandler(this.btn_DeleteCustomer_Click);
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddCustomer.Location = new System.Drawing.Point(34, 196);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(82, 23);
            this.btn_AddCustomer.TabIndex = 0;
            this.btn_AddCustomer.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddCustomer.Values.Image")));
            this.btn_AddCustomer.Values.Text = "Dodaj";
            this.btn_AddCustomer.Click += new System.EventHandler(this.btn_AddCustomer_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Location = new System.Drawing.Point(34, 167);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(167, 23);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Values.Image")));
            this.btn_Search.Values.Text = "Szukaj";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // kryptonPanelEx1
            // 
            this.kryptonPanelEx1.Controls.Add(this.CustomerDataGrid);
            this.kryptonPanelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelEx1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanelEx1.GradientToogleColours = false;
            this.kryptonPanelEx1.GradientUseBlend = false;
            this.kryptonPanelEx1.Image = null;
            this.kryptonPanelEx1.ImageLocation = new System.Drawing.Point(4, 4);
            this.kryptonPanelEx1.Location = new System.Drawing.Point(234, 0);
            this.kryptonPanelEx1.Name = "kryptonPanelEx1";
            this.kryptonPanelEx1.PersistentColours = false;
            this.kryptonPanelEx1.Size = new System.Drawing.Size(807, 568);
            this.kryptonPanelEx1.TabIndex = 30;
            // 
            // CustomerDataGrid
            // 
            this.CustomerDataGrid.AllowUserToAddRows = false;
            this.CustomerDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerDataGrid.AutoGenerateColumns = false;
            this.CustomerDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CustomerDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CustomerName,
            this.LastName,
            this.Nick,
            this.CustomerAddress});
            this.CustomerDataGrid.DataSource = this.customerDtoBindingSource;
            this.CustomerDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerDataGrid.Location = new System.Drawing.Point(0, 0);
            this.CustomerDataGrid.MultiSelect = false;
            this.CustomerDataGrid.Name = "CustomerDataGrid";
            this.CustomerDataGrid.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.CustomerDataGrid.ReadOnly = true;
            this.CustomerDataGrid.RowHeadersWidth = 50;
            this.CustomerDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CustomerDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.CustomerDataGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerDataGrid.Size = new System.Drawing.Size(807, 568);
            this.CustomerDataGrid.TabIndex = 30;
            this.CustomerDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDataGrid_CellContentClick);
            this.CustomerDataGrid.SelectionChanged += new System.EventHandler(this.CustomerDataGrid_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "Name";
            this.CustomerName.HeaderText = "Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Nick
            // 
            this.Nick.DataPropertyName = "Nick";
            this.Nick.HeaderText = "Nick";
            this.Nick.Name = "Nick";
            this.Nick.ReadOnly = true;
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.DataPropertyName = "Address";
            this.CustomerAddress.HeaderText = "Address";
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.ReadOnly = true;
            // 
            // customerDtoBindingSource
            // 
            this.customerDtoBindingSource.DataSource = typeof(BoutiqueShopp.Infrastructure.DTO.CustomerDto);
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.DataPropertyName = "ActionButton";
            this.dataGridViewLinkColumn1.HeaderText = "Operacje";
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.ReadOnly = true;
            this.dataGridViewLinkColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn1.Text = "Edytuj";
            this.dataGridViewLinkColumn1.Width = 150;
            // 
            // FrmCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 568);
            this.Controls.Add(this.kryptonPanelEx1);
            this.Controls.Add(this.kryptonPanelEx3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCustomerList";
            this.Text = "Formularz - List klientów";
            this.kryptonPanelEx3.ResumeLayout(false);
            this.kryptonPanelEx3.PerformLayout();
            this.kryptonPanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanelEx kryptonPanelEx3;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanelEx kryptonPanelEx1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonLabel kryptonLabel3;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonLabel kryptonLabel2;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_LastName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Name;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Nick;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton btn_Search;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton btn_DeleteCustomer;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton btn_AddCustomer;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView CustomerDataGrid;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.BindingSource customerDtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nick;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAddress;
    }
}