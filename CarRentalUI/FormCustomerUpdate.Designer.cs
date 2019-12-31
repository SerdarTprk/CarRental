namespace CarRentalUI
{
    partial class FormCustomerUpdate
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbLicenceType = new System.Windows.Forms.ComboBox();
            this.lblDriverLicence = new System.Windows.Forms.Label();
            this.txtTcKimlik = new System.Windows.Forms.TextBox();
            this.lblTcKimlik = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lbladres = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.lblmail = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.lblad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(394, 192);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // cmbLicenceType
            // 
            this.cmbLicenceType.FormattingEnabled = true;
            this.cmbLicenceType.Location = new System.Drawing.Point(351, 135);
            this.cmbLicenceType.Name = "cmbLicenceType";
            this.cmbLicenceType.Size = new System.Drawing.Size(118, 21);
            this.cmbLicenceType.TabIndex = 28;
            // 
            // lblDriverLicence
            // 
            this.lblDriverLicence.AutoSize = true;
            this.lblDriverLicence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDriverLicence.Location = new System.Drawing.Point(266, 135);
            this.lblDriverLicence.Name = "lblDriverLicence";
            this.lblDriverLicence.Size = new System.Drawing.Size(69, 15);
            this.lblDriverLicence.TabIndex = 27;
            this.lblDriverLicence.Text = "Lisans Tipi:";
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(118, 34);
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(100, 20);
            this.txtTcKimlik.TabIndex = 26;
            // 
            // lblTcKimlik
            // 
            this.lblTcKimlik.AutoSize = true;
            this.lblTcKimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTcKimlik.Location = new System.Drawing.Point(24, 39);
            this.lblTcKimlik.Name = "lblTcKimlik";
            this.lblTcKimlik.Size = new System.Drawing.Size(62, 15);
            this.lblTcKimlik.TabIndex = 25;
            this.lblTcKimlik.Text = "TC Kimlik:";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(351, 84);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(100, 20);
            this.txtaddress.TabIndex = 24;
            // 
            // lbladres
            // 
            this.lbladres.AutoSize = true;
            this.lbladres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladres.Location = new System.Drawing.Point(272, 89);
            this.lbladres.Name = "lbladres";
            this.lbladres.Size = new System.Drawing.Size(41, 15);
            this.lbladres.TabIndex = 23;
            this.lbladres.Text = "Adres:";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(351, 34);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(100, 20);
            this.txtphone.TabIndex = 22;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.Location = new System.Drawing.Point(272, 36);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(51, 15);
            this.lblTelefon.TabIndex = 21;
            this.lblTelefon.Text = "Telefon:";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(118, 172);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(100, 20);
            this.txtmail.TabIndex = 20;
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmail.Location = new System.Drawing.Point(39, 179);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(45, 15);
            this.lblmail.TabIndex = 19;
            this.lblmail.Text = "E mail:";
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(118, 130);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(100, 20);
            this.txtlastname.TabIndex = 18;
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoyad.Location = new System.Drawing.Point(39, 131);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(47, 15);
            this.lblsoyad.TabIndex = 17;
            this.lblsoyad.Text = "Soyadı:";
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(118, 79);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(100, 20);
            this.txtfirstname.TabIndex = 16;
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblad.Location = new System.Drawing.Point(57, 85);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(27, 15);
            this.lblad.TabIndex = 15;
            this.lblad.Text = "Adı:";
            // 
            // FormCustomerUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 236);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbLicenceType);
            this.Controls.Add(this.lblDriverLicence);
            this.Controls.Add(this.txtTcKimlik);
            this.Controls.Add(this.lblTcKimlik);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.lbladres);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.lblad);
            this.Name = "FormCustomerUpdate";
            this.Text = "FormCustomerUpdate";
            this.Load += new System.EventHandler(this.FormCustomerUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbLicenceType;
        private System.Windows.Forms.Label lblDriverLicence;
        private System.Windows.Forms.TextBox txtTcKimlik;
        private System.Windows.Forms.Label lblTcKimlik;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lbladres;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label lblad;
    }
}