using CarRentalUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental.UI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void MüşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void KullanıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void KullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserAdd frm = new FormUserAdd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void AraçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCarAdd frm = new FormCarAdd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void KullanıcıEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormUserAdd frm = new FormUserAdd();
            frm.MdiParent = this;
            frm.Show();

        }

        private void MüşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomerAdd frm = new FormCustomerAdd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void markaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBrandAdd frm = new FormBrandAdd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void modelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModelAdd frm = new FormModelAdd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void AraçListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCarList frm = new FormCarList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void AraçGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCarUpdate frm = new FormCarUpdate();
            frm.MdiParent = this;
            frm.Show();           
        }

        private void KullanıcıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void MüşterileriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomerList frm = new FormCustomerList();
            frm.MdiParent = this;
            frm.Show();
        }

    

        private void AraçListeleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormCarList frm = new FormCarList();
            frm.MdiParent = this;
            frm.Show();

        }

        private void modelListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModelList frm = new FormModelList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kullanıcıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserList frm = new FormUserList();
            frm.MdiParent = this;
            frm.Show();
        }

        //private void AraçListeleToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FormCarList frm = new FormCarList();
        //    frm.MdiParent = this;
        //    frm.Show();
        //}

    }
}
