namespace CarRentalUI
{
    partial class FormModelList
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
            this.lstModel = new System.Windows.Forms.ListBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.lbBrand = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstModel
            // 
            this.lstModel.FormattingEnabled = true;
            this.lstModel.Location = new System.Drawing.Point(12, 50);
            this.lstModel.Name = "lstModel";
            this.lstModel.Size = new System.Drawing.Size(363, 147);
            this.lstModel.TabIndex = 0;
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(94, 18);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(177, 21);
            this.cmbBrand.TabIndex = 1;
            this.cmbBrand.SelectedIndexChanged += new System.EventHandler(this.cmbBrand_SelectedIndexChanged);
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.Location = new System.Drawing.Point(9, 26);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(54, 13);
            this.lbBrand.TabIndex = 2;
            this.lbBrand.Text = "Markalar :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(287, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 27);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(295, 203);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(80, 27);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // FormModelList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 235);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbBrand);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.lstModel);
            this.Name = "FormModelList";
            this.Text = "FormModelList";
            this.Load += new System.EventHandler(this.FormModelList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstModel;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label lbBrand;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSil;
    }
}