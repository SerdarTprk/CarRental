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
            this.cbFree = new System.Windows.Forms.CheckBox();
            this.cbRent = new System.Windows.Forms.CheckBox();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstArac = new System.Windows.Forms.ListBox();
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
            // cbFree
            // 
            this.cbFree.AutoSize = true;
            this.cbFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbFree.Location = new System.Drawing.Point(19, 137);
            this.cbFree.Name = "cbFree";
            this.cbFree.Size = new System.Drawing.Size(56, 21);
            this.cbFree.TabIndex = 15;
            this.cbFree.Text = "Free";
            this.cbFree.UseVisualStyleBackColor = true;
            this.cbFree.CheckedChanged += new System.EventHandler(this.cbFree_CheckedChanged);
            // 
            // cbRent
            // 
            this.cbRent.AutoSize = true;
            this.cbRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbRent.Location = new System.Drawing.Point(19, 87);
            this.cbRent.Name = "cbRent";
            this.cbRent.Size = new System.Drawing.Size(73, 21);
            this.cbRent.TabIndex = 14;
            this.cbRent.Text = "Rented";
            this.cbRent.UseVisualStyleBackColor = true;
            this.cbRent.CheckedChanged += new System.EventHandler(this.cbRent_CheckedChanged);
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbAll.Location = new System.Drawing.Point(19, 36);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(92, 21);
            this.cbAll.TabIndex = 13;
            this.cbAll.Text = "All Vehicle";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
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
            // FormCarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 416);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.cbFree);
            this.Controls.Add(this.cbRent);
            this.Controls.Add(this.cbAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstArac);
            this.Name = "FormCarList";
            this.Text = "FormCarList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.CheckBox cbFree;
        private System.Windows.Forms.CheckBox cbRent;
        private System.Windows.Forms.CheckBox cbAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstArac;
    }
}