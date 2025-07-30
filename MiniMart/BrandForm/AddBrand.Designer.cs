namespace MiniMart.BrandForm
{
    partial class AddBrand
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
            this.lblBrandTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.cbBrandStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateBrand = new System.Windows.Forms.Button();
            this.btnAddBrand = new System.Windows.Forms.Button();
            this.btnBrandCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBrandTitle
            // 
            this.lblBrandTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrandTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBrandTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandTitle.Location = new System.Drawing.Point(2, 0);
            this.lblBrandTitle.Name = "lblBrandTitle";
            this.lblBrandTitle.Size = new System.Drawing.Size(499, 50);
            this.lblBrandTitle.TabIndex = 0;
            this.lblBrandTitle.Text = "Add Brand";
            this.lblBrandTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brand Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(216, 96);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(145, 20);
            this.txtBrandName.TabIndex = 2;
            // 
            // cbBrandStatus
            // 
            this.cbBrandStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrandStatus.FormattingEnabled = true;
            this.cbBrandStatus.Location = new System.Drawing.Point(216, 131);
            this.cbBrandStatus.Name = "cbBrandStatus";
            this.cbBrandStatus.Size = new System.Drawing.Size(145, 21);
            this.cbBrandStatus.TabIndex = 3;
            // 
            // btnUpdateBrand
            // 
            this.btnUpdateBrand.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateBrand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdateBrand.Location = new System.Drawing.Point(307, 195);
            this.btnUpdateBrand.Name = "btnUpdateBrand";
            this.btnUpdateBrand.Size = new System.Drawing.Size(95, 31);
            this.btnUpdateBrand.TabIndex = 5;
            this.btnUpdateBrand.Text = "Update Brand";
            this.btnUpdateBrand.UseVisualStyleBackColor = false;
            this.btnUpdateBrand.Click += new System.EventHandler(this.btnUpdateBrand_Click);
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.BackColor = System.Drawing.Color.Green;
            this.btnAddBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBrand.ForeColor = System.Drawing.Color.White;
            this.btnAddBrand.Location = new System.Drawing.Point(210, 194);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(91, 31);
            this.btnAddBrand.TabIndex = 6;
            this.btnAddBrand.Text = "Add Brand";
            this.btnAddBrand.UseVisualStyleBackColor = false;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // btnBrandCancel
            // 
            this.btnBrandCancel.BackColor = System.Drawing.Color.Red;
            this.btnBrandCancel.ForeColor = System.Drawing.Color.White;
            this.btnBrandCancel.Location = new System.Drawing.Point(77, 194);
            this.btnBrandCancel.Name = "btnBrandCancel";
            this.btnBrandCancel.Size = new System.Drawing.Size(72, 31);
            this.btnBrandCancel.TabIndex = 7;
            this.btnBrandCancel.Text = "Cancel";
            this.btnBrandCancel.UseVisualStyleBackColor = false;
            this.btnBrandCancel.Click += new System.EventHandler(this.btnCategoryCancel_Click);
            // 
            // AddBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 260);
            this.Controls.Add(this.btnUpdateBrand);
            this.Controls.Add(this.btnAddBrand);
            this.Controls.Add(this.btnBrandCancel);
            this.Controls.Add(this.cbBrandStatus);
            this.Controls.Add(this.txtBrandName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBrandTitle);
            this.MaximizeBox = false;
            this.Name = "AddBrand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBrand";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddBrand_FormClosing);
            this.Load += new System.EventHandler(this.AddBrand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrandTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.ComboBox cbBrandStatus;
        private System.Windows.Forms.Button btnUpdateBrand;
        private System.Windows.Forms.Button btnAddBrand;
        private System.Windows.Forms.Button btnBrandCancel;
    }
}