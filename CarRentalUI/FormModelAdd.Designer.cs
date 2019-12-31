namespace CarRentalUI
{
    partial class FormModelAdd
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.lblBarand = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.dtpModelYear = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(357, 9);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(86, 12);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(255, 20);
            this.txtModel.TabIndex = 5;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(19, 15);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(60, 13);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model Adı :";
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(86, 38);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(255, 21);
            this.cmbBrand.TabIndex = 8;
            // 
            // lblBarand
            // 
            this.lblBarand.AutoSize = true;
            this.lblBarand.Location = new System.Drawing.Point(20, 46);
            this.lblBarand.Name = "lblBarand";
            this.lblBarand.Size = new System.Drawing.Size(59, 13);
            this.lblBarand.TabIndex = 9;
            this.lblBarand.Text = "Marka Seç";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(357, 38);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;

            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(20, 79);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(65, 13);
            this.lblDateTime.TabIndex = 12;
            this.lblDateTime.Text = "Model Tarihi";
            // 
            // dtpModelYear
            // 
            this.dtpModelYear.Location = new System.Drawing.Point(86, 73);
            this.dtpModelYear.Name = "dtpModelYear";
            this.dtpModelYear.Size = new System.Drawing.Size(200, 20);
            this.dtpModelYear.TabIndex = 13;
            // 
            // FormModelAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 129);
            this.Controls.Add(this.dtpModelYear);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblBarand);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Name = "FormModelAdd";
            this.Text = "FormModelAdd";
            this.Load += new System.EventHandler(this.FormModelAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label lblBarand;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.DateTimePicker dtpModelYear;
    }
}