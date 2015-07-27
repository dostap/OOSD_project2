namespace MOHB_TeamProject
{
    partial class frmPackage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPackage));
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.lblPkgName = new System.Windows.Forms.Label();
            this.txtPackageId = new System.Windows.Forms.TextBox();
            this.lblPackageID = new System.Windows.Forms.Label();
            this.gbxPackage = new System.Windows.Forms.GroupBox();
            this.txtPkgAgencyCommission = new System.Windows.Forms.TextBox();
            this.lblPkgAgencyCommission = new System.Windows.Forms.Label();
            this.txtPkgBasePrice = new System.Windows.Forms.TextBox();
            this.lblPkgBasePrice = new System.Windows.Forms.Label();
            this.txtPkgDesc = new System.Windows.Forms.TextBox();
            this.lblPkgDesc = new System.Windows.Forms.Label();
            this.txtPkgEndDate = new System.Windows.Forms.TextBox();
            this.lblPkgEndDate = new System.Windows.Forms.Label();
            this.txtPkgStartDate = new System.Windows.Forms.TextBox();
            this.lblPkgStartDate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbxChangeButtons = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.gbxSuppliersProducts = new System.Windows.Forms.GroupBox();
            this.cbxSuppliers = new System.Windows.Forms.ComboBox();
            this.cbxProducts = new System.Windows.Forms.ComboBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAcceptProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lstSuppliersProducts = new System.Windows.Forms.ListBox();
            this.gbxPackage.SuspendLayout();
            this.gbxChangeButtons.SuspendLayout();
            this.gbxSuppliersProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPkgName
            // 
            this.txtPkgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPkgName.Location = new System.Drawing.Point(249, 64);
            this.txtPkgName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.Size = new System.Drawing.Size(337, 28);
            this.txtPkgName.TabIndex = 2;
            this.txtPkgName.Tag = "Package Name";
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgName.ForeColor = System.Drawing.Color.Navy;
            this.lblPkgName.Location = new System.Drawing.Point(20, 68);
            this.lblPkgName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(151, 24);
            this.lblPkgName.TabIndex = 10;
            this.lblPkgName.Text = "Package Name";
            this.lblPkgName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPackageId
            // 
            this.txtPackageId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPackageId.Location = new System.Drawing.Point(249, 23);
            this.txtPackageId.Margin = new System.Windows.Forms.Padding(4);
            this.txtPackageId.Name = "txtPackageId";
            this.txtPackageId.Size = new System.Drawing.Size(228, 28);
            this.txtPackageId.TabIndex = 0;
            this.txtPackageId.Tag = "Package ID";
            this.txtPackageId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPackageId_KeyPress);
            // 
            // lblPackageID
            // 
            this.lblPackageID.AutoSize = true;
            this.lblPackageID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageID.ForeColor = System.Drawing.Color.Navy;
            this.lblPackageID.Location = new System.Drawing.Point(20, 27);
            this.lblPackageID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPackageID.Name = "lblPackageID";
            this.lblPackageID.Size = new System.Drawing.Size(115, 24);
            this.lblPackageID.TabIndex = 9;
            this.lblPackageID.Text = "Package ID";
            this.lblPackageID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxPackage
            // 
            this.gbxPackage.Controls.Add(this.txtPkgAgencyCommission);
            this.gbxPackage.Controls.Add(this.lblPkgAgencyCommission);
            this.gbxPackage.Controls.Add(this.txtPkgBasePrice);
            this.gbxPackage.Controls.Add(this.lblPkgBasePrice);
            this.gbxPackage.Controls.Add(this.txtPkgDesc);
            this.gbxPackage.Controls.Add(this.lblPkgDesc);
            this.gbxPackage.Controls.Add(this.txtPkgEndDate);
            this.gbxPackage.Controls.Add(this.lblPkgEndDate);
            this.gbxPackage.Controls.Add(this.txtPkgStartDate);
            this.gbxPackage.Controls.Add(this.lblPkgStartDate);
            this.gbxPackage.Controls.Add(this.btnSearch);
            this.gbxPackage.Controls.Add(this.txtPkgName);
            this.gbxPackage.Controls.Add(this.lblPackageID);
            this.gbxPackage.Controls.Add(this.lblPkgName);
            this.gbxPackage.Controls.Add(this.txtPackageId);
            this.gbxPackage.Location = new System.Drawing.Point(33, 27);
            this.gbxPackage.Margin = new System.Windows.Forms.Padding(4);
            this.gbxPackage.Name = "gbxPackage";
            this.gbxPackage.Padding = new System.Windows.Forms.Padding(4);
            this.gbxPackage.Size = new System.Drawing.Size(614, 313);
            this.gbxPackage.TabIndex = 0;
            this.gbxPackage.TabStop = false;
            // 
            // txtPkgAgencyCommission
            // 
            this.txtPkgAgencyCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgAgencyCommission.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPkgAgencyCommission.Location = new System.Drawing.Point(249, 267);
            this.txtPkgAgencyCommission.Margin = new System.Windows.Forms.Padding(4);
            this.txtPkgAgencyCommission.Name = "txtPkgAgencyCommission";
            this.txtPkgAgencyCommission.Size = new System.Drawing.Size(337, 28);
            this.txtPkgAgencyCommission.TabIndex = 8;
            this.txtPkgAgencyCommission.Tag = "Agency Commission";
            // 
            // lblPkgAgencyCommission
            // 
            this.lblPkgAgencyCommission.AutoSize = true;
            this.lblPkgAgencyCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgAgencyCommission.ForeColor = System.Drawing.Color.Navy;
            this.lblPkgAgencyCommission.Location = new System.Drawing.Point(20, 271);
            this.lblPkgAgencyCommission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkgAgencyCommission.Name = "lblPkgAgencyCommission";
            this.lblPkgAgencyCommission.Size = new System.Drawing.Size(201, 24);
            this.lblPkgAgencyCommission.TabIndex = 15;
            this.lblPkgAgencyCommission.Text = "Agency Commission";
            this.lblPkgAgencyCommission.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPkgBasePrice
            // 
            this.txtPkgBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgBasePrice.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPkgBasePrice.Location = new System.Drawing.Point(249, 226);
            this.txtPkgBasePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPkgBasePrice.Name = "txtPkgBasePrice";
            this.txtPkgBasePrice.Size = new System.Drawing.Size(337, 28);
            this.txtPkgBasePrice.TabIndex = 7;
            this.txtPkgBasePrice.Tag = "Base Price";
            // 
            // lblPkgBasePrice
            // 
            this.lblPkgBasePrice.AutoSize = true;
            this.lblPkgBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgBasePrice.ForeColor = System.Drawing.Color.Navy;
            this.lblPkgBasePrice.Location = new System.Drawing.Point(20, 230);
            this.lblPkgBasePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkgBasePrice.Name = "lblPkgBasePrice";
            this.lblPkgBasePrice.Size = new System.Drawing.Size(110, 24);
            this.lblPkgBasePrice.TabIndex = 14;
            this.lblPkgBasePrice.Text = "Base Price";
            this.lblPkgBasePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgDesc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPkgDesc.Location = new System.Drawing.Point(249, 186);
            this.txtPkgDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.Size = new System.Drawing.Size(337, 28);
            this.txtPkgDesc.TabIndex = 6;
            this.txtPkgDesc.Tag = "Description";
            // 
            // lblPkgDesc
            // 
            this.lblPkgDesc.AutoSize = true;
            this.lblPkgDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgDesc.ForeColor = System.Drawing.Color.Navy;
            this.lblPkgDesc.Location = new System.Drawing.Point(20, 190);
            this.lblPkgDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkgDesc.Name = "lblPkgDesc";
            this.lblPkgDesc.Size = new System.Drawing.Size(115, 24);
            this.lblPkgDesc.TabIndex = 13;
            this.lblPkgDesc.Text = "Description";
            this.lblPkgDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPkgEndDate
            // 
            this.txtPkgEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgEndDate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPkgEndDate.Location = new System.Drawing.Point(249, 145);
            this.txtPkgEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtPkgEndDate.Name = "txtPkgEndDate";
            this.txtPkgEndDate.Size = new System.Drawing.Size(337, 28);
            this.txtPkgEndDate.TabIndex = 5;
            this.txtPkgEndDate.Tag = "End Date";
            // 
            // lblPkgEndDate
            // 
            this.lblPkgEndDate.AutoSize = true;
            this.lblPkgEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgEndDate.ForeColor = System.Drawing.Color.Navy;
            this.lblPkgEndDate.Location = new System.Drawing.Point(20, 149);
            this.lblPkgEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkgEndDate.Name = "lblPkgEndDate";
            this.lblPkgEndDate.Size = new System.Drawing.Size(96, 24);
            this.lblPkgEndDate.TabIndex = 12;
            this.lblPkgEndDate.Text = "End Date";
            this.lblPkgEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPkgStartDate
            // 
            this.txtPkgStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgStartDate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPkgStartDate.Location = new System.Drawing.Point(249, 105);
            this.txtPkgStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtPkgStartDate.Name = "txtPkgStartDate";
            this.txtPkgStartDate.Size = new System.Drawing.Size(337, 28);
            this.txtPkgStartDate.TabIndex = 4;
            this.txtPkgStartDate.Tag = "Start Date";
            // 
            // lblPkgStartDate
            // 
            this.lblPkgStartDate.AutoSize = true;
            this.lblPkgStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgStartDate.ForeColor = System.Drawing.Color.Navy;
            this.lblPkgStartDate.Location = new System.Drawing.Point(20, 108);
            this.lblPkgStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkgStartDate.Name = "lblPkgStartDate";
            this.lblPkgStartDate.Size = new System.Drawing.Size(99, 24);
            this.lblPkgStartDate.TabIndex = 11;
            this.lblPkgStartDate.Text = "Start Date";
            this.lblPkgStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(490, 23);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbxChangeButtons
            // 
            this.gbxChangeButtons.Controls.Add(this.btnDelete);
            this.gbxChangeButtons.Controls.Add(this.btnModify);
            this.gbxChangeButtons.Controls.Add(this.btnAdd);
            this.gbxChangeButtons.Location = new System.Drawing.Point(655, 27);
            this.gbxChangeButtons.Margin = new System.Windows.Forms.Padding(4);
            this.gbxChangeButtons.Name = "gbxChangeButtons";
            this.gbxChangeButtons.Padding = new System.Windows.Forms.Padding(4);
            this.gbxChangeButtons.Size = new System.Drawing.Size(153, 164);
            this.gbxChangeButtons.TabIndex = 1;
            this.gbxChangeButtons.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.Location = new System.Drawing.Point(32, 113);
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
            this.btnModify.Location = new System.Drawing.Point(32, 69);
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
            this.btnAdd.Location = new System.Drawing.Point(32, 25);
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
            this.btnMainMenu.Location = new System.Drawing.Point(360, 709);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(125, 32);
            this.btnMainMenu.TabIndex = 2;
            this.btnMainMenu.Text = "MainMenu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // gbxSuppliersProducts
            // 
            this.gbxSuppliersProducts.Controls.Add(this.cbxSuppliers);
            this.gbxSuppliersProducts.Controls.Add(this.cbxProducts);
            this.gbxSuppliersProducts.Controls.Add(this.btnDeleteProduct);
            this.gbxSuppliersProducts.Controls.Add(this.btnAcceptProduct);
            this.gbxSuppliersProducts.Controls.Add(this.btnAddProduct);
            this.gbxSuppliersProducts.Controls.Add(this.lstSuppliersProducts);
            this.gbxSuppliersProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSuppliersProducts.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gbxSuppliersProducts.Location = new System.Drawing.Point(33, 347);
            this.gbxSuppliersProducts.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSuppliersProducts.Name = "gbxSuppliersProducts";
            this.gbxSuppliersProducts.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSuppliersProducts.Size = new System.Drawing.Size(775, 348);
            this.gbxSuppliersProducts.TabIndex = 2;
            this.gbxSuppliersProducts.TabStop = false;
            this.gbxSuppliersProducts.Text = "Suppliers-Products";
            // 
            // cbxSuppliers
            // 
            this.cbxSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSuppliers.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbxSuppliers.FormattingEnabled = true;
            this.cbxSuppliers.Location = new System.Drawing.Point(232, 67);
            this.cbxSuppliers.Name = "cbxSuppliers";
            this.cbxSuppliers.Size = new System.Drawing.Size(236, 26);
            this.cbxSuppliers.TabIndex = 2;
            this.cbxSuppliers.Tag = "Supplier";
            this.cbxSuppliers.Visible = false;
            // 
            // cbxProducts
            // 
            this.cbxProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProducts.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbxProducts.FormattingEnabled = true;
            this.cbxProducts.Location = new System.Drawing.Point(24, 67);
            this.cbxProducts.Name = "cbxProducts";
            this.cbxProducts.Size = new System.Drawing.Size(202, 26);
            this.cbxProducts.TabIndex = 1;
            this.cbxProducts.Tag = "Product";
            this.cbxProducts.Visible = false;
            this.cbxProducts.SelectionChangeCommitted += new System.EventHandler(this.cbxProducts_SelectionChangeCommitted);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteProduct.Location = new System.Drawing.Point(606, 28);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(146, 32);
            this.btnDeleteProduct.TabIndex = 4;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAcceptProduct
            // 
            this.btnAcceptProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAcceptProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptProduct.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAcceptProduct.Location = new System.Drawing.Point(475, 63);
            this.btnAcceptProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcceptProduct.Name = "btnAcceptProduct";
            this.btnAcceptProduct.Size = new System.Drawing.Size(80, 32);
            this.btnAcceptProduct.TabIndex = 3;
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
            this.btnAddProduct.Location = new System.Drawing.Point(24, 28);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(121, 32);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lstSuppliersProducts
            // 
            this.lstSuppliersProducts.BackColor = System.Drawing.Color.SteelBlue;
            this.lstSuppliersProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSuppliersProducts.ForeColor = System.Drawing.Color.White;
            this.lstSuppliersProducts.FormattingEnabled = true;
            this.lstSuppliersProducts.ItemHeight = 22;
            this.lstSuppliersProducts.Location = new System.Drawing.Point(24, 103);
            this.lstSuppliersProducts.Margin = new System.Windows.Forms.Padding(4);
            this.lstSuppliersProducts.Name = "lstSuppliersProducts";
            this.lstSuppliersProducts.Size = new System.Drawing.Size(728, 224);
            this.lstSuppliersProducts.TabIndex = 5;
            // 
            // frmPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(844, 754);
            this.Controls.Add(this.gbxSuppliersProducts);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.gbxChangeButtons);
            this.Controls.Add(this.gbxPackage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPackage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Packages";
            this.Activated += new System.EventHandler(this.frmPackages_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPackages_FormClosed);
            this.gbxPackage.ResumeLayout(false);
            this.gbxPackage.PerformLayout();
            this.gbxChangeButtons.ResumeLayout(false);
            this.gbxSuppliersProducts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.Label lblPkgName;
        private System.Windows.Forms.TextBox txtPackageId;
        private System.Windows.Forms.Label lblPackageID;
        private System.Windows.Forms.GroupBox gbxPackage;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbxChangeButtons;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.GroupBox gbxSuppliersProducts;
        private System.Windows.Forms.ListBox lstSuppliersProducts;
        private System.Windows.Forms.TextBox txtPkgAgencyCommission;
        private System.Windows.Forms.Label lblPkgAgencyCommission;
        private System.Windows.Forms.TextBox txtPkgBasePrice;
        private System.Windows.Forms.Label lblPkgBasePrice;
        private System.Windows.Forms.TextBox txtPkgDesc;
        private System.Windows.Forms.Label lblPkgDesc;
        private System.Windows.Forms.TextBox txtPkgEndDate;
        private System.Windows.Forms.Label lblPkgEndDate;
        private System.Windows.Forms.TextBox txtPkgStartDate;
        private System.Windows.Forms.Label lblPkgStartDate;
        private System.Windows.Forms.ComboBox cbxProducts;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnAcceptProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox cbxSuppliers;
    }
}