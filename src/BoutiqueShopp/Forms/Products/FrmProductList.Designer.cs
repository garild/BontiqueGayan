namespace BoutiqueShopp.Forms.Products
{
    partial class FrmProductList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CustomerDataGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.kryptonLabel2 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonLabel();
            this.kryptonLabel1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonLabel();
            this.txt_Name = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txt_Nick = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_DeleteCustomer = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.btn_AddCustomer = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.kryptonPanelEx1 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanelEx();
            this.ProductDataGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btn_Search = new KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton();
            this.kryptonPanelEx3 = new ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanelEx();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.productDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.kryptonPanelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGrid)).BeginInit();
            this.kryptonPanelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerDataGrid
            // 
            this.CustomerDataGrid.AllowUserToAddRows = false;
            this.CustomerDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.CustomerDataGrid.Size = new System.Drawing.Size(1267, 481);
            this.CustomerDataGrid.TabIndex = 31;
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AllowUserToAddRows = false;
            this.kryptonDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kryptonDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.kryptonDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.kryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDataGridView1.MultiSelect = false;
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.RowHeadersWidth = 50;
            this.kryptonDataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kryptonDataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.kryptonDataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(1267, 481);
            this.kryptonDataGridView1.TabIndex = 32;
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
            // kryptonLabel2
            // 
            this.kryptonLabel2.AutoSize = true;
            this.kryptonLabel2.BackColor = System.Drawing.Color.Transparent;
            this.kryptonLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonLabel2.Location = new System.Drawing.Point(11, 69);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(43, 13);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Text = "Nazwa:";
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
            this.kryptonLabel1.Size = new System.Drawing.Size(29, 13);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Text = "Kod:";
            this.kryptonLabel1.UseAlternateForeColour = false;
            this.kryptonLabel1.UseKryptonFont = false;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(36, 88);
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
            this.btn_DeleteCustomer.Location = new System.Drawing.Point(121, 156);
            this.btn_DeleteCustomer.Name = "btn_DeleteCustomer";
            this.btn_DeleteCustomer.Size = new System.Drawing.Size(82, 23);
            this.btn_DeleteCustomer.TabIndex = 0;
            this.btn_DeleteCustomer.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteCustomer.Values.Image")));
            this.btn_DeleteCustomer.Values.Text = "Usuń";
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddCustomer.Location = new System.Drawing.Point(36, 156);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(82, 23);
            this.btn_AddCustomer.TabIndex = 0;
            this.btn_AddCustomer.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddCustomer.Values.Image")));
            this.btn_AddCustomer.Values.Text = "Dodaj";
            this.btn_AddCustomer.Click += new System.EventHandler(this.btn_AddCustomer_Click);
            // 
            // kryptonPanelEx1
            // 
            this.kryptonPanelEx1.Controls.Add(this.ProductDataGrid);
            this.kryptonPanelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelEx1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.kryptonPanelEx1.GradientToogleColours = false;
            this.kryptonPanelEx1.GradientUseBlend = false;
            this.kryptonPanelEx1.Image = null;
            this.kryptonPanelEx1.ImageLocation = new System.Drawing.Point(4, 4);
            this.kryptonPanelEx1.Location = new System.Drawing.Point(234, 0);
            this.kryptonPanelEx1.Name = "kryptonPanelEx1";
            this.kryptonPanelEx1.PersistentColours = false;
            this.kryptonPanelEx1.Size = new System.Drawing.Size(1033, 481);
            this.kryptonPanelEx1.TabIndex = 34;
            // 
            // ProductDataGrid
            // 
            this.ProductDataGrid.AllowUserToAddRows = false;
            this.ProductDataGrid.AllowUserToDeleteRows = false;
            this.ProductDataGrid.AllowUserToResizeColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ProductDataGrid.AutoGenerateColumns = false;
            this.ProductDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProductDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductCategory,
            this.ProductQuantity,
            this.ProductName,
            this.ProductCode,
            this.ProductDescription,
            this.ProductSize,
            this.ProductColor,
            this.ProductImage});
            this.ProductDataGrid.DataSource = this.productDTOBindingSource;
            this.ProductDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductDataGrid.Location = new System.Drawing.Point(0, 0);
            this.ProductDataGrid.MultiSelect = false;
            this.ProductDataGrid.Name = "ProductDataGrid";
            this.ProductDataGrid.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.ProductDataGrid.ReadOnly = true;
            this.ProductDataGrid.RowHeadersWidth = 50;
            this.ProductDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProductDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.ProductDataGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDataGrid.Size = new System.Drawing.Size(1033, 481);
            this.ProductDataGrid.StandardTab = true;
            this.ProductDataGrid.TabIndex = 30;
            // 
            // btn_Search
            // 
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Location = new System.Drawing.Point(36, 127);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(167, 23);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Values.Image")));
            this.btn_Search.Values.Text = "Szukaj";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // kryptonPanelEx3
            // 
            this.kryptonPanelEx3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kryptonPanelEx3.Controls.Add(this.kryptonLabel2);
            this.kryptonPanelEx3.Controls.Add(this.kryptonLabel1);
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
            this.kryptonPanelEx3.Size = new System.Drawing.Size(234, 481);
            this.kryptonPanelEx3.TabIndex = 33;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "Id";
            this.ProductId.HeaderText = "Id";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Visible = false;
            // 
            // ProductCategory
            // 
            this.ProductCategory.DataPropertyName = "Category";
            this.ProductCategory.HeaderText = "Category";
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.ReadOnly = true;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.DataPropertyName = "Quantity";
            this.ProductQuantity.HeaderText = "Quantity";
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "Name";
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "Code";
            this.ProductCode.HeaderText = "Code";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            // 
            // ProductDescription
            // 
            this.ProductDescription.DataPropertyName = "Description";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDescription.DefaultCellStyle = dataGridViewCellStyle4;
            this.ProductDescription.HeaderText = "Description";
            this.ProductDescription.MinimumWidth = 100;
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.ReadOnly = true;
            // 
            // ProductSize
            // 
            this.ProductSize.DataPropertyName = "Size";
            this.ProductSize.HeaderText = "Size";
            this.ProductSize.Name = "ProductSize";
            this.ProductSize.ReadOnly = true;
            // 
            // ProductColor
            // 
            this.ProductColor.DataPropertyName = "Color";
            this.ProductColor.HeaderText = "Color";
            this.ProductColor.Name = "ProductColor";
            this.ProductColor.ReadOnly = true;
            // 
            // ProductImage
            // 
            this.ProductImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ProductImage.DataPropertyName = "Image";
            this.ProductImage.FillWeight = 150F;
            this.ProductImage.HeaderText = "Image";
            this.ProductImage.MinimumWidth = 200;
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.ReadOnly = true;
            this.ProductImage.Width = 200;
            // 
            // productDTOBindingSource
            // 
            this.productDTOBindingSource.DataSource = typeof(BoutiqueShopp.Infrastructure.DTO.ProductDTO);
            // 
            // FrmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 481);
            this.Controls.Add(this.kryptonPanelEx1);
            this.Controls.Add(this.kryptonPanelEx3);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Controls.Add(this.CustomerDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProductList";
            this.Text = "Formularz - Lista Produktów";
            this.TextExtra = "!";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.kryptonPanelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGrid)).EndInit();
            this.kryptonPanelEx3.ResumeLayout(false);
            this.kryptonPanelEx3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView CustomerDataGrid;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonLabel kryptonLabel2;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Name;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Nick;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton btn_DeleteCustomer;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton btn_AddCustomer;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanelEx kryptonPanelEx1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView ProductDataGrid;
        private KryptonExtendedToolkit.ExtendedToolkit.Controls.KryptonUACElevatedButton btn_Search;
        private ExtendedControls.ExtendedToolkit.Controls.KryptonControls.KryptonPanelEx kryptonPanelEx3;
        private System.Windows.Forms.BindingSource productDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductColor;
        private System.Windows.Forms.DataGridViewImageColumn ProductImage;
    }
}