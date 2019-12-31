namespace CarRental.UI
{
    partial class FormCarAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.lblPlate = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblCarClass = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblKaskoTarihi = new System.Windows.Forms.Label();
            this.txtKaskoTarihi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDailyPrice = new System.Windows.Forms.TextBox();
            this.cmbCarClass = new System.Windows.Forms.ComboBox();
            this.cmbFuelType = new System.Windows.Forms.ComboBox();
            this.cmbLicenceType = new System.Windows.Forms.ComboBox();
            this.lblLicenceType = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Sigorta Tarihi : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 37;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(138, 126);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(121, 20);
            this.txtModel.TabIndex = 36;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModel.Location = new System.Drawing.Point(64, 129);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(49, 16);
            this.lblModel.TabIndex = 35;
            this.lblModel.Text = "Model:";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(138, 90);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(121, 20);
            this.txtBrand.TabIndex = 34;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBrand.Location = new System.Drawing.Point(64, 94);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(47, 16);
            this.lblBrand.TabIndex = 33;
            this.lblBrand.Text = "Brand:";
            // 
            // nudCapacity
            // 
            this.nudCapacity.Location = new System.Drawing.Point(139, 59);
            this.nudCapacity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(120, 20);
            this.nudCapacity.TabIndex = 32;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCapacity.Location = new System.Drawing.Point(64, 61);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(64, 16);
            this.lblCapacity.TabIndex = 31;
            this.lblCapacity.Text = "Capacity:";
            // 
            // txtPlate
            // 
            this.txtPlate.Location = new System.Drawing.Point(138, 28);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(121, 20);
            this.txtPlate.TabIndex = 30;
            // 
            // lblPlate
            // 
            this.lblPlate.AutoSize = true;
            this.lblPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlate.Location = new System.Drawing.Point(64, 32);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(42, 16);
            this.lblPlate.TabIndex = 29;
            this.lblPlate.Text = "Plate:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(429, 259);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 28;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // lblCarClass
            // 
            this.lblCarClass.AutoSize = true;
            this.lblCarClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCarClass.Location = new System.Drawing.Point(291, 133);
            this.lblCarClass.Name = "lblCarClass";
            this.lblCarClass.Size = new System.Drawing.Size(68, 16);
            this.lblCarClass.TabIndex = 40;
            this.lblCarClass.Text = "Araç Tipi :";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFuel.Location = new System.Drawing.Point(282, 99);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(77, 16);
            this.lblFuel.TabIndex = 42;
            this.lblFuel.Text = "Benzin Tipi:";
            // 
            // lblKaskoTarihi
            // 
            this.lblKaskoTarihi.AutoSize = true;
            this.lblKaskoTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKaskoTarihi.Location = new System.Drawing.Point(282, 166);
            this.lblKaskoTarihi.Name = "lblKaskoTarihi";
            this.lblKaskoTarihi.Size = new System.Drawing.Size(86, 16);
            this.lblKaskoTarihi.TabIndex = 44;
            this.lblKaskoTarihi.Text = "Kasko Tarihi:";
            // 
            // txtKaskoTarihi
            // 
            this.txtKaskoTarihi.Location = new System.Drawing.Point(384, 165);
            this.txtKaskoTarihi.Name = "txtKaskoTarihi";
            this.txtKaskoTarihi.Size = new System.Drawing.Size(120, 20);
            this.txtKaskoTarihi.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(283, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Günlük Ücreti:";
            // 
            // txtDailyPrice
            // 
            this.txtDailyPrice.Location = new System.Drawing.Point(386, 27);
            this.txtDailyPrice.Name = "txtDailyPrice";
            this.txtDailyPrice.Size = new System.Drawing.Size(120, 20);
            this.txtDailyPrice.TabIndex = 45;
            // 
            // cmbCarClass
            // 
            this.cmbCarClass.FormattingEnabled = true;
            this.cmbCarClass.Location = new System.Drawing.Point(384, 128);
            this.cmbCarClass.Name = "cmbCarClass";
            this.cmbCarClass.Size = new System.Drawing.Size(121, 21);
            this.cmbCarClass.TabIndex = 47;
            // 
            // cmbFuelType
            // 
            this.cmbFuelType.FormattingEnabled = true;
            this.cmbFuelType.Location = new System.Drawing.Point(385, 94);
            this.cmbFuelType.Name = "cmbFuelType";
            this.cmbFuelType.Size = new System.Drawing.Size(121, 21);
            this.cmbFuelType.TabIndex = 48;
            // 
            // cmbLicenceType
            // 
            this.cmbLicenceType.FormattingEnabled = true;
            this.cmbLicenceType.Location = new System.Drawing.Point(386, 61);
            this.cmbLicenceType.Name = "cmbLicenceType";
            this.cmbLicenceType.Size = new System.Drawing.Size(121, 21);
            this.cmbLicenceType.TabIndex = 50;
            // 
            // lblLicenceType
            // 
            this.lblLicenceType.AutoSize = true;
            this.lblLicenceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLicenceType.Location = new System.Drawing.Point(293, 66);
            this.lblLicenceType.Name = "lblLicenceType";
            this.lblLicenceType.Size = new System.Drawing.Size(76, 16);
            this.lblLicenceType.TabIndex = 49;
            this.lblLicenceType.Text = "Lisans Tipi:";
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(139, 202);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 21);
            this.cmbColor.TabIndex = 51;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblColor.Location = new System.Drawing.Point(62, 207);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(46, 16);
            this.lblColor.TabIndex = 52;
            this.lblColor.Text = "Renk :";
            // 
            // FormCarAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 310);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbLicenceType);
            this.Controls.Add(this.lblLicenceType);
            this.Controls.Add(this.cmbFuelType);
            this.Controls.Add(this.cmbCarClass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDailyPrice);
            this.Controls.Add(this.lblKaskoTarihi);
            this.Controls.Add(this.txtKaskoTarihi);
            this.Controls.Add(this.lblFuel);
            this.Controls.Add(this.lblCarClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.nudCapacity);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.txtPlate);
            this.Controls.Add(this.lblPlate);
            this.Controls.Add(this.btnKaydet);
            this.Name = "FormCarAdd";
            this.Text = "FormCarAdd";
            this.Load += new System.EventHandler(this.FormCarAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblCarClass;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblKaskoTarihi;
        private System.Windows.Forms.TextBox txtKaskoTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDailyPrice;
        private System.Windows.Forms.ComboBox cmbCarClass;
        private System.Windows.Forms.ComboBox cmbFuelType;
        private System.Windows.Forms.ComboBox cmbLicenceType;
        private System.Windows.Forms.Label lblLicenceType;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label lblColor;
    }
}