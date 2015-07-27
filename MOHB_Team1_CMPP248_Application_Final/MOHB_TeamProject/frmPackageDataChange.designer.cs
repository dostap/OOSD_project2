namespace MOHB_TeamProject
{
    partial class frmPackageDataChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPackageDataChange));
            this.lblPackageName = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpPkgEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPkgStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtPkgAgencyCommission = new System.Windows.Forms.TextBox();
            this.lblPkgAgencyCommission = new System.Windows.Forms.Label();
            this.txtPkgBasePrice = new System.Windows.Forms.TextBox();
            this.lblPkgBasePrice = new System.Windows.Forms.Label();
            this.txtPkgDesc = new System.Windows.Forms.TextBox();
            this.lblPkgDesc = new System.Windows.Forms.Label();
            this.lblPkgEndDate = new System.Windows.Forms.Label();
            this.lblPkgStartDate = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblPackageName.ForeColor = System.Drawing.Color.Navy;
            this.lblPackageName.Location = new System.Drawing.Point(20, 57);
            this.lblPackageName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(157, 24);
            this.lblPackageName.TabIndex = 26;
            this.lblPackageName.Text = "Package Name:";
            // 
            // btncancel
            // 
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(324, 441);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(100, 34);
            this.btncancel.TabIndex = 1;
            this.btncancel.Text = "&Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpPkgEndDate);
            this.groupBox1.Controls.Add(this.dtpPkgStartDate);
            this.groupBox1.Controls.Add(this.txtPkgAgencyCommission);
            this.groupBox1.Controls.Add(this.lblPkgAgencyCommission);
            this.groupBox1.Controls.Add(this.txtPkgBasePrice);
            this.groupBox1.Controls.Add(this.lblPkgBasePrice);
            this.groupBox1.Controls.Add(this.txtPkgDesc);
            this.groupBox1.Controls.Add(this.lblPkgDesc);
            this.groupBox1.Controls.Add(this.lblPkgEndDate);
            this.groupBox1.Controls.Add(this.lblPkgStartDate);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.txtPkgName);
            this.groupBox1.Controls.Add(this.lblPackageName);
            this.groupBox1.Location = new System.Drawing.Point(32, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(684, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dtpPkgEndDate
            // 
            this.dtpPkgEndDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpPkgEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.dtpPkgEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPkgEndDate.Location = new System.Drawing.Point(239, 154);
            this.dtpPkgEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpPkgEndDate.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpPkgEndDate.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dtpPkgEndDate.Name = "dtpPkgEndDate";
            this.dtpPkgEndDate.Size = new System.Drawing.Size(315, 28);
            this.dtpPkgEndDate.TabIndex = 2;
            this.dtpPkgEndDate.Tag = "End Date";
            // 
            // dtpPkgStartDate
            // 
            this.dtpPkgStartDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpPkgStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.dtpPkgStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPkgStartDate.Location = new System.Drawing.Point(239, 102);
            this.dtpPkgStartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpPkgStartDate.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpPkgStartDate.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dtpPkgStartDate.Name = "dtpPkgStartDate";
            this.dtpPkgStartDate.Size = new System.Drawing.Size(315, 28);
            this.dtpPkgStartDate.TabIndex = 1;
            this.dtpPkgStartDate.Tag = "Start date";
            // 
            // txtPkgAgencyCommission
            // 
            this.txtPkgAgencyCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgAgencyCommission.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPkgAgencyCommission.Location = new System.Drawing.Point(239, 311);
            this.txtPkgAgencyCommission.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPkgAgencyCommission.Name = "txtPkgAgencyCommission";
            this.txtPkgAgencyCommission.Size = new System.Drawing.Size(315, 28);
            this.txtPkgAgencyCommission.TabIndex = 5;
            this.txtPkgAgencyCommission.Tag = "Agency Commission";
            // 
            // lblPkgAgencyCommission
            // 
            this.lblPkgAgencyCommission.AutoSize = true;
            this.lblPkgAgencyCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgAgencyCommission.ForeColor = System.Drawing.Color.Navy;
            this.lblPkgAgencyCommission.Location = new System.Drawing.Point(20, 315);
            this.lblPkgAgencyCommission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkgAgencyCommission.Name = "lblPkgAgencyCommission";
            this.lblPkgAgencyCommission.Size = new System.Drawing.Size(201, 24);
            this.lblPkgAgencyCommission.TabIndex = 42;
            this.lblPkgAgencyCommission.Text = "Agency Commission";
            this.lblPkgAgencyCommission.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPkgBasePrice
            // 
            this.txtPkgBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgBasePrice.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPkgBasePrice.Location = new System.Drawing.Point(239, 260);
            this.txtPkgBasePrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPkgBasePrice.Name = "txtPkgBasePrice";
            this.txtPkgBasePrice.Size = new System.Drawing.Size(315, 28);
            this.txtPkgBasePrice.TabIndex = 4;
            this.txtPkgBasePrice.Tag = "Base Price";
            // 
            // lblPkgBasePrice
            // 
            this.lblPkgBasePrice.AutoSize = true;
            this.lblPkgBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgBasePrice.ForeColor = System.Drawing.Color.Navy;
            this.lblPkgBasePrice.Location = new System.Drawing.Point(20, 263);
            this.lblPkgBasePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkgBasePrice.Name = "lblPkgBasePrice";
            this.lblPkgBasePrice.Size = new System.Drawing.Size(110, 24);
            this.lblPkgBasePrice.TabIndex = 40;
            this.lblPkgBasePrice.Text = "Base Price";
            this.lblPkgBasePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkgDesc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPkgDesc.Location = new System.Drawing.Point(239, 208);
            this.txtPkgDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.Size = new System.Drawing.Size(315, 28);
            this.txtPkgDesc.TabIndex = 3;
            this.txtPkgDesc.Tag = "Description";
            // 
            // lblPkgDesc
            // 
            this.lblPkgDesc.AutoSize = true;
            this.lblPkgDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgDesc.ForeColor = System.Drawing.Color.Navy;
            this.lblPkgDesc.Location = new System.Drawing.Point(20, 212);
            this.lblPkgDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkgDesc.Name = "lblPkgDesc";
            this.lblPkgDesc.Size = new System.Drawing.Size(115, 24);
            this.lblPkgDesc.TabIndex = 38;
            this.lblPkgDesc.Text = "Description";
            this.lblPkgDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPkgEndDate
            // 
            this.lblPkgEndDate.AutoSize = true;
            this.lblPkgEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPkgEndDate.ForeColor = System.Drawing.Color.Navy;
            this.lblPkgEndDate.Location = new System.Drawing.Point(20, 160);
            this.lblPkgEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkgEndDate.Name = "lblPkgEndDate";
            this.lblPkgEndDate.Size = new System.Drawing.Size(96, 24);
            this.lblPkgEndDate.TabIndex = 36;
            this.lblPkgEndDate.Text = "End Date";
            this.lblPkgEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.lblPkgStartDate.TabIndex = 34;
            this.lblPkgStartDate.Text = "Start Date";
            this.lblPkgStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(575, 52);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(87, 34);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "&Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtPkgName
            // 
            this.txtPkgName.BackColor = System.Drawing.Color.White;
            this.txtPkgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.txtPkgName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtPkgName.Location = new System.Drawing.Point(239, 53);
            this.txtPkgName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.Size = new System.Drawing.Size(315, 28);
            this.txtPkgName.TabIndex = 0;
            this.txtPkgName.Tag = "Package Name";
            // 
            // frmPackageDataChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(748, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmPackageDataChange";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Modify Product";
            this.Load += new System.EventHandler(this.frmPackageDataChange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.Label lblPackageName;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtPkgAgencyCommission;
        private System.Windows.Forms.Label lblPkgAgencyCommission;
        private System.Windows.Forms.TextBox txtPkgBasePrice;
        private System.Windows.Forms.Label lblPkgBasePrice;
        private System.Windows.Forms.TextBox txtPkgDesc;
        private System.Windows.Forms.Label lblPkgDesc;
        private System.Windows.Forms.Label lblPkgEndDate;
        private System.Windows.Forms.Label lblPkgStartDate;
        private System.Windows.Forms.DateTimePicker dtpPkgStartDate;
        private System.Windows.Forms.DateTimePicker dtpPkgEndDate;
    }
}