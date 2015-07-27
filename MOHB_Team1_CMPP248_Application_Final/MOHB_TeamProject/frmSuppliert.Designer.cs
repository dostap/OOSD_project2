namespace MOHB_TeamProject
{
    partial class frmSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplier));
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.gbxSupplier = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.gbxChangeButtons = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.tabSupplierDetails = new System.Windows.Forms.TabControl();
            this.tpgProducts = new System.Windows.Forms.TabPage();
            this.cbxProducts = new System.Windows.Forms.ComboBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAcceptProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tbContacts = new System.Windows.Forms.TabPage();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.gbxSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.gbxChangeButtons.SuspendLayout();
            this.tabSupplierDetails.SuspendLayout();
            this.tpgProducts.SuspendLayout();
            this.tbContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtSupplierName.Location = new System.Drawing.Point(295, 96);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(319, 28);
            this.txtSupplierName.TabIndex = 2;
            this.txtSupplierName.Tag = "Supplier Name";
            this.txtSupplierName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplierName_KeyPress);
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.ForeColor = System.Drawing.Color.Navy;
            this.lblSupplierName.Location = new System.Drawing.Point(79, 100);
            this.lblSupplierName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(149, 24);
            this.lblSupplierName.TabIndex = 5;
            this.lblSupplierName.Text = "Supplier Name";
            this.lblSupplierName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtSupplierId.Location = new System.Drawing.Point(295, 41);
            this.txtSupplierId.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(319, 28);
            this.txtSupplierId.TabIndex = 0;
            this.txtSupplierId.Tag = "Supplier ID";
            this.txtSupplierId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplierId_KeyPress_1);
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierID.ForeColor = System.Drawing.Color.Navy;
            this.lblSupplierID.Location = new System.Drawing.Point(79, 44);
            this.lblSupplierID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(113, 24);
            this.lblSupplierID.TabIndex = 4;
            this.lblSupplierID.Text = "Supplier ID";
            this.lblSupplierID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxSupplier
            // 
            this.gbxSupplier.Controls.Add(this.btnSearchByName);
            this.gbxSupplier.Controls.Add(this.btnSearch);
            this.gbxSupplier.Controls.Add(this.txtSupplierName);
            this.gbxSupplier.Controls.Add(this.lblSupplierID);
            this.gbxSupplier.Controls.Add(this.lblSupplierName);
            this.gbxSupplier.Controls.Add(this.txtSupplierId);
            this.gbxSupplier.Location = new System.Drawing.Point(33, 27);
            this.gbxSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSupplier.Name = "gbxSupplier";
            this.gbxSupplier.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSupplier.Size = new System.Drawing.Size(853, 164);
            this.gbxSupplier.TabIndex = 0;
            this.gbxSupplier.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(651, 41);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(0, 47);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(1037, 373);
            this.dgvProducts.TabIndex = 11;
            // 
            // gbxChangeButtons
            // 
            this.gbxChangeButtons.Controls.Add(this.btnDelete);
            this.gbxChangeButtons.Controls.Add(this.btnModify);
            this.gbxChangeButtons.Controls.Add(this.btnAdd);
            this.gbxChangeButtons.Location = new System.Drawing.Point(895, 27);
            this.gbxChangeButtons.Margin = new System.Windows.Forms.Padding(4);
            this.gbxChangeButtons.Name = "gbxChangeButtons";
            this.gbxChangeButtons.Padding = new System.Windows.Forms.Padding(4);
            this.gbxChangeButtons.Size = new System.Drawing.Size(187, 164);
            this.gbxChangeButtons.TabIndex = 1;
            this.gbxChangeButtons.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.Location = new System.Drawing.Point(49, 113);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnModify.Enabled = false;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnModify.Location = new System.Drawing.Point(49, 69);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(88, 32);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "&Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAdd.Location = new System.Drawing.Point(49, 25);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnMainMenu.Location = new System.Drawing.Point(495, 671);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(125, 32);
            this.btnMainMenu.TabIndex = 2;
            this.btnMainMenu.Text = "MainMenu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // tabSupplierDetails
            // 
            this.tabSupplierDetails.Controls.Add(this.tpgProducts);
            this.tabSupplierDetails.Controls.Add(this.tbContacts);
            this.tabSupplierDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSupplierDetails.Location = new System.Drawing.Point(33, 198);
            this.tabSupplierDetails.Margin = new System.Windows.Forms.Padding(4);
            this.tabSupplierDetails.Name = "tabSupplierDetails";
            this.tabSupplierDetails.SelectedIndex = 0;
            this.tabSupplierDetails.Size = new System.Drawing.Size(1048, 452);
            this.tabSupplierDetails.TabIndex = 2;
            // 
            // tpgProducts
            // 
            this.tpgProducts.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tpgProducts.Controls.Add(this.cbxProducts);
            this.tpgProducts.Controls.Add(this.btnDeleteProduct);
            this.tpgProducts.Controls.Add(this.btnAcceptProduct);
            this.tpgProducts.Controls.Add(this.btnAddProduct);
            this.tpgProducts.Controls.Add(this.dgvProducts);
            this.tpgProducts.Location = new System.Drawing.Point(4, 29);
            this.tpgProducts.Margin = new System.Windows.Forms.Padding(4);
            this.tpgProducts.Name = "tpgProducts";
            this.tpgProducts.Padding = new System.Windows.Forms.Padding(4);
            this.tpgProducts.Size = new System.Drawing.Size(1040, 419);
            this.tpgProducts.TabIndex = 0;
            this.tpgProducts.Text = "Products";
            // 
            // cbxProducts
            // 
            this.cbxProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProducts.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbxProducts.FormattingEnabled = true;
            this.cbxProducts.Location = new System.Drawing.Point(187, 12);
            this.cbxProducts.Name = "cbxProducts";
            this.cbxProducts.Size = new System.Drawing.Size(310, 26);
            this.cbxProducts.TabIndex = 1;
            this.cbxProducts.Visible = false;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteProduct.Location = new System.Drawing.Point(883, 8);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(149, 32);
            this.btnDeleteProduct.TabIndex = 3;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAcceptProduct
            // 
            this.btnAcceptProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAcceptProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptProduct.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAcceptProduct.Location = new System.Drawing.Point(525, 8);
            this.btnAcceptProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcceptProduct.Name = "btnAcceptProduct";
            this.btnAcceptProduct.Size = new System.Drawing.Size(85, 32);
            this.btnAcceptProduct.TabIndex = 2;
            this.btnAcceptProduct.Text = "Accept";
            this.btnAcceptProduct.UseVisualStyleBackColor = false;
            this.btnAcceptProduct.Visible = false;
            this.btnAcceptProduct.Click += new System.EventHandler(this.btnAcceptProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddProduct.Location = new System.Drawing.Point(8, 8);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(132, 32);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tbContacts
            // 
            this.tbContacts.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tbContacts.Controls.Add(this.dgvContacts);
            this.tbContacts.Location = new System.Drawing.Point(4, 29);
            this.tbContacts.Margin = new System.Windows.Forms.Padding(4);
            this.tbContacts.Name = "tbContacts";
            this.tbContacts.Padding = new System.Windows.Forms.Padding(4);
            this.tbContacts.Size = new System.Drawing.Size(1040, 419);
            this.tbContacts.TabIndex = 1;
            this.tbContacts.Text = "Contacts";
            // 
            // dgvContacts
            // 
            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.AllowUserToDeleteRows = false;
            this.dgvContacts.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Location = new System.Drawing.Point(0, 0);
            this.dgvContacts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.Size = new System.Drawing.Size(1037, 420);
            this.dgvContacts.TabIndex = 12;
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByName.ForeColor = System.Drawing.Color.White;
            this.btnSearchByName.Location = new System.Drawing.Point(651, 94);
            this.btnSearchByName.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(129, 30);
            this.btnSearchByName.TabIndex = 3;
            this.btnSearchByName.Text = "&Search";
            this.btnSearchByName.UseVisualStyleBackColor = false;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1116, 722);
            this.Controls.Add(this.tabSupplierDetails);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.gbxChangeButtons);
            this.Controls.Add(this.gbxSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suppliers";
            this.Activated += new System.EventHandler(this.frmSupplier_Activated);
            this.gbxSupplier.ResumeLayout(false);
            this.gbxSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.gbxChangeButtons.ResumeLayout(false);
            this.tabSupplierDetails.ResumeLayout(false);
            this.tpgProducts.ResumeLayout(false);
            this.tbContacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.GroupBox gbxSupplier;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbxChangeButtons;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.TabControl tabSupplierDetails;
        private System.Windows.Forms.TabPage tpgProducts;
        private System.Windows.Forms.TabPage tbContacts;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.ComboBox cbxProducts;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnAcceptProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnSearchByName;
    }
}