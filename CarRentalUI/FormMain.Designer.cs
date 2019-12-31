namespace CarRental.UI
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.araçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelListelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterileriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstMusteriGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçToolStripMenuItem,
            this.kullanıcıToolStripMenuItem,
            this.müşteriToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(490, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // araçToolStripMenuItem
            // 
            this.araçToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçEkleToolStripMenuItem,
            this.araçListeleToolStripMenuItem,
            this.araçGüncelleToolStripMenuItem,
            this.markaEkleToolStripMenuItem,
            this.modelEkleToolStripMenuItem,
            this.modelListelemeToolStripMenuItem});
            this.araçToolStripMenuItem.Name = "araçToolStripMenuItem";
            this.araçToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.araçToolStripMenuItem.Text = "Araç";
            // 
            // araçEkleToolStripMenuItem
            // 
            this.araçEkleToolStripMenuItem.Name = "araçEkleToolStripMenuItem";
            this.araçEkleToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.araçEkleToolStripMenuItem.Text = "Araç Ekle";
            this.araçEkleToolStripMenuItem.Click += new System.EventHandler(this.AraçEkleToolStripMenuItem_Click);
            // 
            // araçListeleToolStripMenuItem
            // 
            this.araçListeleToolStripMenuItem.Name = "araçListeleToolStripMenuItem";
            this.araçListeleToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.araçListeleToolStripMenuItem.Text = "Araç Listele";
            this.araçListeleToolStripMenuItem.Click += new System.EventHandler(this.AraçListeleToolStripMenuItem_Click_1);
            // 
            // araçGüncelleToolStripMenuItem
            // 
            this.araçGüncelleToolStripMenuItem.Name = "araçGüncelleToolStripMenuItem";
            this.araçGüncelleToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.araçGüncelleToolStripMenuItem.Text = "Araç Güncelle";
            this.araçGüncelleToolStripMenuItem.Click += new System.EventHandler(this.AraçGüncelleToolStripMenuItem_Click);
            // 
            // markaEkleToolStripMenuItem
            // 
            this.markaEkleToolStripMenuItem.Name = "markaEkleToolStripMenuItem";
            this.markaEkleToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.markaEkleToolStripMenuItem.Text = "Marka Ekle";
            this.markaEkleToolStripMenuItem.Click += new System.EventHandler(this.markaEkleToolStripMenuItem_Click);
            // 
            // modelEkleToolStripMenuItem
            // 
            this.modelEkleToolStripMenuItem.Name = "modelEkleToolStripMenuItem";
            this.modelEkleToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.modelEkleToolStripMenuItem.Text = "Model Ekle";
            this.modelEkleToolStripMenuItem.Click += new System.EventHandler(this.modelEkleToolStripMenuItem_Click);
            // 
            // modelListelemeToolStripMenuItem
            // 
            this.modelListelemeToolStripMenuItem.Name = "modelListelemeToolStripMenuItem";
            this.modelListelemeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.modelListelemeToolStripMenuItem.Text = "Model Listeleme";
            this.modelListelemeToolStripMenuItem.Click += new System.EventHandler(this.modelListelemeToolStripMenuItem_Click);
            // 
            // kullanıcıToolStripMenuItem
            // 
            this.kullanıcıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıEkleToolStripMenuItem,
            this.kullanıcıGüncelleToolStripMenuItem});
            this.kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            this.kullanıcıToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.kullanıcıToolStripMenuItem.Text = "Kullanıcı";
            this.kullanıcıToolStripMenuItem.Click += new System.EventHandler(this.KullanıcıToolStripMenuItem_Click);
            // 
            // kullanıcıEkleToolStripMenuItem
            // 
            this.kullanıcıEkleToolStripMenuItem.Name = "kullanıcıEkleToolStripMenuItem";
            this.kullanıcıEkleToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.kullanıcıEkleToolStripMenuItem.Text = "Kullanıcı Ekle";
            this.kullanıcıEkleToolStripMenuItem.Click += new System.EventHandler(this.KullanıcıEkleToolStripMenuItem_Click);
            // 
            // kullanıcıGüncelleToolStripMenuItem
            // 
            this.kullanıcıGüncelleToolStripMenuItem.Name = "kullanıcıGüncelleToolStripMenuItem";
            this.kullanıcıGüncelleToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.kullanıcıGüncelleToolStripMenuItem.Text = "Kullanıcı Güncelle";
            this.kullanıcıGüncelleToolStripMenuItem.Click += new System.EventHandler(this.KullanıcıGüncelleToolStripMenuItem_Click);
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEkleToolStripMenuItem,
            this.müşterileriListeleToolStripMenuItem,
            this.mstMusteriGuncelle});
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.müşteriToolStripMenuItem.Text = "Müşteri";
            this.müşteriToolStripMenuItem.Click += new System.EventHandler(this.MüşteriToolStripMenuItem_Click);
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            this.müşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.MüşteriEkleToolStripMenuItem_Click);
            // 
            // müşterileriListeleToolStripMenuItem
            // 
            this.müşterileriListeleToolStripMenuItem.Name = "müşterileriListeleToolStripMenuItem";
            this.müşterileriListeleToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.müşterileriListeleToolStripMenuItem.Text = "Müşterileri Listele";
            this.müşterileriListeleToolStripMenuItem.Click += new System.EventHandler(this.MüşterileriListeleToolStripMenuItem_Click);
            // 
            // mstMusteriGuncelle
            // 
            this.mstMusteriGuncelle.Name = "mstMusteriGuncelle";
            this.mstMusteriGuncelle.Size = new System.Drawing.Size(179, 22);
            this.mstMusteriGuncelle.Text = "Müşterileri Güncelle";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıEkleToolStripMenuItem1,
            this.kullanıcıListeleToolStripMenuItem,
            this.şifreDeğiştirToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.userToolStripMenuItem.Text = "Ayarlar";
            // 
            // kullanıcıEkleToolStripMenuItem1
            // 
            this.kullanıcıEkleToolStripMenuItem1.Name = "kullanıcıEkleToolStripMenuItem1";
            this.kullanıcıEkleToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.kullanıcıEkleToolStripMenuItem1.Text = "Kullanıcı Ekle";
            this.kullanıcıEkleToolStripMenuItem1.Click += new System.EventHandler(this.KullanıcıEkleToolStripMenuItem1_Click);
            // 
            // kullanıcıListeleToolStripMenuItem
            // 
            this.kullanıcıListeleToolStripMenuItem.Name = "kullanıcıListeleToolStripMenuItem";
            this.kullanıcıListeleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kullanıcıListeleToolStripMenuItem.Text = "Kullanıcı Listele";
            this.kullanıcıListeleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıListeleToolStripMenuItem_Click);
            // 
            // şifreDeğiştirToolStripMenuItem
            // 
            this.şifreDeğiştirToolStripMenuItem.Name = "şifreDeğiştirToolStripMenuItem";
            this.şifreDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.şifreDeğiştirToolStripMenuItem.Text = "Şifre Değiştir";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 442);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem araçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterileriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıEkleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelListelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mstMusteriGuncelle;
    }
}