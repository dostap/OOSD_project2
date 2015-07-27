namespace MOHB_TeamProject
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.btnSuppliersForm = new System.Windows.Forms.Button();
            this.btnProductsForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPackagesForm = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSuppliersForm
            // 
            this.btnSuppliersForm.BackColor = System.Drawing.Color.White;
            this.btnSuppliersForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliersForm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSuppliersForm.Image = ((System.Drawing.Image)(resources.GetObject("btnSuppliersForm.Image")));
            this.btnSuppliersForm.Location = new System.Drawing.Point(138, 251);
            this.btnSuppliersForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuppliersForm.Name = "btnSuppliersForm";
            this.btnSuppliersForm.Size = new System.Drawing.Size(147, 160);
            this.btnSuppliersForm.TabIndex = 0;
            this.btnSuppliersForm.Text = "Suppliers";
            this.btnSuppliersForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuppliersForm.UseVisualStyleBackColor = false;
            this.btnSuppliersForm.Click += new System.EventHandler(this.btnSuppliersForm_Click);
            // 
            // btnProductsForm
            // 
            this.btnProductsForm.BackColor = System.Drawing.Color.White;
            this.btnProductsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductsForm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnProductsForm.Image = ((System.Drawing.Image)(resources.GetObject("btnProductsForm.Image")));
            this.btnProductsForm.Location = new System.Drawing.Point(392, 251);
            this.btnProductsForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductsForm.Name = "btnProductsForm";
            this.btnProductsForm.Size = new System.Drawing.Size(147, 160);
            this.btnProductsForm.TabIndex = 1;
            this.btnProductsForm.Text = "Products";
            this.btnProductsForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductsForm.UseVisualStyleBackColor = false;
            this.btnProductsForm.Click += new System.EventHandler(this.btnProductsForm_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(848, 491);
            this.label1.TabIndex = 2;
            // 
            // btnPackagesForm
            // 
            this.btnPackagesForm.BackColor = System.Drawing.Color.White;
            this.btnPackagesForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackagesForm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnPackagesForm.Image = ((System.Drawing.Image)(resources.GetObject("btnPackagesForm.Image")));
            this.btnPackagesForm.Location = new System.Drawing.Point(646, 251);
            this.btnPackagesForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnPackagesForm.Name = "btnPackagesForm";
            this.btnPackagesForm.Size = new System.Drawing.Size(147, 160);
            this.btnPackagesForm.TabIndex = 2;
            this.btnPackagesForm.Text = "Packages";
            this.btnPackagesForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPackagesForm.UseVisualStyleBackColor = false;
            this.btnPackagesForm.Click += new System.EventHandler(this.btnPackagesForm_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(424, 63);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(83, 85);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 9;
            this.pbxLogo.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(931, 569);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.btnPackagesForm);
            this.Controls.Add(this.btnProductsForm);
            this.Controls.Add(this.btnSuppliersForm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainMenu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSuppliersForm;
        private System.Windows.Forms.Button btnProductsForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPackagesForm;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}