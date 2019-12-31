namespace CarRentalUI
{
    partial class FormCustomerList
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
            this.listCustomer = new System.Windows.Forms.ListBox();
            this.lblmusteri = new System.Windows.Forms.Label();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listCustomer
            // 
            this.listCustomer.FormattingEnabled = true;
            this.listCustomer.Location = new System.Drawing.Point(46, 54);
            this.listCustomer.Name = "listCustomer";
            this.listCustomer.Size = new System.Drawing.Size(201, 303);
            this.listCustomer.TabIndex = 0;
            this.listCustomer.SelectedIndexChanged += new System.EventHandler(this.ListCustomer_SelectedIndexChanged);
            // 
            // lblmusteri
            // 
            this.lblmusteri.AutoSize = true;
            this.lblmusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmusteri.Location = new System.Drawing.Point(43, 21);
            this.lblmusteri.Name = "lblmusteri";
            this.lblmusteri.Size = new System.Drawing.Size(76, 16);
            this.lblmusteri.TabIndex = 1;
            this.lblmusteri.Text = "Müşteriler";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(277, 310);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(75, 23);
            this.btnguncelle.TabIndex = 2;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.Btnguncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(277, 269);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // FormCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 372);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.lblmusteri);
            this.Controls.Add(this.listCustomer);
            this.Name = "FormCustomerList";
            this.Text = "FormCustomerList";
            this.Load += new System.EventHandler(this.FormCustomerList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCustomer;
        private System.Windows.Forms.Label lblmusteri;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnSil;
    }
}