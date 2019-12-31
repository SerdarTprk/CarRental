namespace CarRental.UI
{
    partial class FormCarList
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
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstArac = new System.Windows.Forms.ListBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbRented = new System.Windows.Forms.RadioButton();
            this.rbDeleted = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(492, 381);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(158, 381);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 20;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(155, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Araçlar ";
            // 
            // lstArac
            // 
            this.lstArac.FormattingEnabled = true;
            this.lstArac.Location = new System.Drawing.Point(158, 36);
            this.lstArac.Name = "lstArac";
            this.lstArac.Size = new System.Drawing.Size(409, 329);
            this.lstArac.TabIndex = 11;
            this.lstArac.SelectedIndexChanged += new System.EventHandler(this.lstArac_SelectedIndexChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(19, 64);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(55, 17);
            this.rbAll.TabIndex = 22;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All Car";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbRented
            // 
            this.rbRented.AutoSize = true;
            this.rbRented.Location = new System.Drawing.Point(19, 114);
            this.rbRented.Name = "rbRented";
            this.rbRented.Size = new System.Drawing.Size(79, 17);
            this.rbRented.TabIndex = 23;
            this.rbRented.TabStop = true;
            this.rbRented.Text = "Rented Car";
            this.rbRented.UseVisualStyleBackColor = true;
            this.rbRented.CheckedChanged += new System.EventHandler(this.rbRented_CheckedChanged);
            // 
            // rbDeleted
            // 
            this.rbDeleted.AutoSize = true;
            this.rbDeleted.Location = new System.Drawing.Point(19, 164);
            this.rbDeleted.Name = "rbDeleted";
            this.rbDeleted.Size = new System.Drawing.Size(81, 17);
            this.rbDeleted.TabIndex = 24;
            this.rbDeleted.TabStop = true;
            this.rbDeleted.Text = "Deleted Car";
            this.rbDeleted.UseVisualStyleBackColor = true;
            this.rbDeleted.CheckedChanged += new System.EventHandler(this.rbDeleted_CheckedChanged);
            // 
            // FormCarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 416);
            this.Controls.Add(this.rbDeleted);
            this.Controls.Add(this.rbRented);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstArac);
            this.Name = "FormCarList";
            this.Text = "FormCarList";
            this.Load += new System.EventHandler(this.FormCarList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstArac;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbRented;
        private System.Windows.Forms.RadioButton rbDeleted;
    }
}