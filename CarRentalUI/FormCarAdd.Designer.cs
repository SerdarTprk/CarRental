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
            this.lblModel = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.lblPlate = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblCarClass = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblKaskoTarihi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDailyPrice = new System.Windows.Forms.TextBox();
            this.cmbCarClass = new System.Windows.Forms.ComboBox();
            this.cmbFuelType = new System.Windows.Forms.ComboBox();
            this.cmbLicenceType = new System.Windows.Forms.ComboBox();
            this.lblLicenceType = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtSilindirHac = new System.Windows.Forms.TextBox();
            this.txtMotorkapas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpsigorta = new System.Windows.Forms.DateTimePicker();
            this.dtpkasko = new System.Windows.Forms.DateTimePicker();
            this.dtpSatinAlmaTar = new System.Windows.Forms.DateTimePicker();
            this.lblSatinAlmatar = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Sigorta Tarihi : ";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblModel.Location = new System.Drawing.Point(312, 29);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(49, 16);
            this.lblModel.TabIndex = 35;
            this.lblModel.Text = "Model:";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCapacity.Location = new System.Drawing.Point(29, 133);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(93, 16);
            this.lblCapacity.TabIndex = 31;
            this.lblCapacity.Text = "Silindir Hacmi:";
            // 
            // txtPlate
            // 
            this.txtPlate.Location = new System.Drawing.Point(164, 57);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(121, 20);
            this.txtPlate.TabIndex = 30;
            // 
            // lblPlate
            // 
            this.lblPlate.AutoSize = true;
            this.lblPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlate.Location = new System.Drawing.Point(29, 61);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(42, 16);
            this.lblPlate.TabIndex = 29;
            this.lblPlate.Text = "Plate:";
            this.lblPlate.Click += new System.EventHandler(this.LblPlate_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(481, 275);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 28;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // lblCarClass
            // 
            this.lblCarClass.AutoSize = true;
            this.lblCarClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCarClass.Location = new System.Drawing.Point(312, 167);
            this.lblCarClass.Name = "lblCarClass";
            this.lblCarClass.Size = new System.Drawing.Size(68, 16);
            this.lblCarClass.TabIndex = 40;
            this.lblCarClass.Text = "Araç Tipi :";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFuel.Location = new System.Drawing.Point(312, 128);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(77, 16);
            this.lblFuel.TabIndex = 42;
            this.lblFuel.Text = "Benzin Tipi:";
            // 
            // lblKaskoTarihi
            // 
            this.lblKaskoTarihi.AutoSize = true;
            this.lblKaskoTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKaskoTarihi.Location = new System.Drawing.Point(312, 207);
            this.lblKaskoTarihi.Name = "lblKaskoTarihi";
            this.lblKaskoTarihi.Size = new System.Drawing.Size(86, 16);
            this.lblKaskoTarihi.TabIndex = 44;
            this.lblKaskoTarihi.Text = "Kasko Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(312, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Günlük Ücreti:";
            // 
            // txtDailyPrice
            // 
            this.txtDailyPrice.Location = new System.Drawing.Point(436, 56);
            this.txtDailyPrice.Name = "txtDailyPrice";
            this.txtDailyPrice.Size = new System.Drawing.Size(120, 20);
            this.txtDailyPrice.TabIndex = 45;
            // 
            // cmbCarClass
            // 
            this.cmbCarClass.FormattingEnabled = true;
            this.cmbCarClass.Location = new System.Drawing.Point(435, 163);
            this.cmbCarClass.Name = "cmbCarClass";
            this.cmbCarClass.Size = new System.Drawing.Size(121, 21);
            this.cmbCarClass.TabIndex = 47;
            // 
            // cmbFuelType
            // 
            this.cmbFuelType.FormattingEnabled = true;
            this.cmbFuelType.Location = new System.Drawing.Point(435, 126);
            this.cmbFuelType.Name = "cmbFuelType";
            this.cmbFuelType.Size = new System.Drawing.Size(121, 21);
            this.cmbFuelType.TabIndex = 48;
            // 
            // cmbLicenceType
            // 
            this.cmbLicenceType.FormattingEnabled = true;
            this.cmbLicenceType.Location = new System.Drawing.Point(435, 90);
            this.cmbLicenceType.Name = "cmbLicenceType";
            this.cmbLicenceType.Size = new System.Drawing.Size(121, 21);
            this.cmbLicenceType.TabIndex = 50;
            // 
            // lblLicenceType
            // 
            this.lblLicenceType.AutoSize = true;
            this.lblLicenceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLicenceType.Location = new System.Drawing.Point(312, 90);
            this.lblLicenceType.Name = "lblLicenceType";
            this.lblLicenceType.Size = new System.Drawing.Size(76, 16);
            this.lblLicenceType.TabIndex = 49;
            this.lblLicenceType.Text = "Lisans Tipi:";
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(164, 90);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 21);
            this.cmbColor.TabIndex = 51;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblColor.Location = new System.Drawing.Point(29, 95);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(46, 16);
            this.lblColor.TabIndex = 52;
            this.lblColor.Text = "Renk :";
            // 
            // txtSilindirHac
            // 
            this.txtSilindirHac.Location = new System.Drawing.Point(165, 129);
            this.txtSilindirHac.Name = "txtSilindirHac";
            this.txtSilindirHac.Size = new System.Drawing.Size(120, 20);
            this.txtSilindirHac.TabIndex = 53;
            // 
            // txtMotorkapas
            // 
            this.txtMotorkapas.Location = new System.Drawing.Point(164, 168);
            this.txtMotorkapas.Name = "txtMotorkapas";
            this.txtMotorkapas.Size = new System.Drawing.Size(121, 20);
            this.txtMotorkapas.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Motor Kapasitesi :";
            // 
            // dtpsigorta
            // 
            this.dtpsigorta.Location = new System.Drawing.Point(147, 204);
            this.dtpsigorta.Name = "dtpsigorta";
            this.dtpsigorta.Size = new System.Drawing.Size(138, 20);
            this.dtpsigorta.TabIndex = 56;
            // 
            // dtpkasko
            // 
            this.dtpkasko.Location = new System.Drawing.Point(418, 207);
            this.dtpkasko.Name = "dtpkasko";
            this.dtpkasko.Size = new System.Drawing.Size(138, 20);
            this.dtpkasko.TabIndex = 57;
            // 
            // dtpSatinAlmaTar
            // 
            this.dtpSatinAlmaTar.Location = new System.Drawing.Point(147, 241);
            this.dtpSatinAlmaTar.Name = "dtpSatinAlmaTar";
            this.dtpSatinAlmaTar.Size = new System.Drawing.Size(138, 20);
            this.dtpSatinAlmaTar.TabIndex = 59;
            // 
            // lblSatinAlmatar
            // 
            this.lblSatinAlmatar.AutoSize = true;
            this.lblSatinAlmatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatinAlmatar.Location = new System.Drawing.Point(29, 245);
            this.lblSatinAlmatar.Name = "lblSatinAlmatar";
            this.lblSatinAlmatar.Size = new System.Drawing.Size(112, 16);
            this.lblSatinAlmatar.TabIndex = 58;
            this.lblSatinAlmatar.Text = "Satın Alma Tarihi:";
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(435, 28);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(121, 21);
            this.cmbModel.TabIndex = 60;
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(164, 28);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(121, 21);
            this.cmbBrand.TabIndex = 61;
            this.cmbBrand.SelectedIndexChanged += new System.EventHandler(this.CmbBrand_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Brand :";
            this.label3.Click += new System.EventHandler(this.LblPlate_Click);
            // 
            // FormCarAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 310);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.dtpSatinAlmaTar);
            this.Controls.Add(this.lblSatinAlmatar);
            this.Controls.Add(this.dtpkasko);
            this.Controls.Add(this.dtpsigorta);
            this.Controls.Add(this.txtMotorkapas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSilindirHac);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbLicenceType);
            this.Controls.Add(this.lblLicenceType);
            this.Controls.Add(this.cmbFuelType);
            this.Controls.Add(this.cmbCarClass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDailyPrice);
            this.Controls.Add(this.lblKaskoTarihi);
            this.Controls.Add(this.lblFuel);
            this.Controls.Add(this.lblCarClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.txtPlate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPlate);
            this.Controls.Add(this.btnKaydet);
            this.Name = "FormCarAdd";
            this.Load += new System.EventHandler(this.FormCarAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblCarClass;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblKaskoTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDailyPrice;
        private System.Windows.Forms.ComboBox cmbCarClass;
        private System.Windows.Forms.ComboBox cmbFuelType;
        private System.Windows.Forms.ComboBox cmbLicenceType;
        private System.Windows.Forms.Label lblLicenceType;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtSilindirHac;
        private System.Windows.Forms.TextBox txtMotorkapas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpsigorta;
        private System.Windows.Forms.DateTimePicker dtpkasko;
        private System.Windows.Forms.DateTimePicker dtpSatinAlmaTar;
        private System.Windows.Forms.Label lblSatinAlmatar;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label label3;
    }
}