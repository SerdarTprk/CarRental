namespace CarRentalUI
{
    partial class FormBrandAdd
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
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstBrand = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(8, 18);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(61, 13);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "Marka Adı :";
        
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(75, 15);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(255, 20);
            this.txtBrand.TabIndex = 1;
           
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(346, 12);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstBrand
            // 
            this.lstBrand.FormattingEnabled = true;
            this.lstBrand.HorizontalScrollbar = true;
            this.lstBrand.Location = new System.Drawing.Point(12, 53);
            this.lstBrand.Name = "lstBrand";
            this.lstBrand.Size = new System.Drawing.Size(409, 134);
            this.lstBrand.TabIndex = 3;

            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(346, 193);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // FormBrandAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 219);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstBrand);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblBrand);
            this.Name = "FormBrandAdd";
            this.Text = "FormBrandAdd";
            this.Load += new System.EventHandler(this.FormBrandAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstBrand;
        private System.Windows.Forms.Button btnDelete;
    }
}