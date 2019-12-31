using CarRental.BLL;
using CarRental.DTO;
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
    public partial class FormCarList : Form
    {
        CarController _cc;
        CarListFilter filter;
        public FormCarList()
        {
            InitializeComponent();
            _cc = new CarController();
            filter = new CarListFilter();
        }
        private void ListLoad(CarListFilter filter=null)
        {
            List<CarDTO> car = new List<CarDTO>();
            if (filter!=null)
            {
                 car = _cc.GetAllCar(filter);
            }
            else
            {
                car = _cc.GetAllCar();
            }
            
            lstArac.DataSource = null;
            lstArac.DisplayMember = "Plate";
            lstArac.ValueMember = "Id";
            lstArac.DataSource = car;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region Validation
            if (lstArac.SelectedIndex == -1)
            {
                MessageBox.Show("Önce bir kayıt seçmeniz gerekmektedir.");
                return;
            }
            #endregion

            var car = (CarDTO)lstArac.SelectedItem;
            FormCarUpdate frm = new FormCarUpdate(car);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
        }

        private void lstArac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            
            filter.AllCar = true;
            filter.Rented = false;
            filter.Deleted = false;
            ListLoad(filter);
        }

        private void cbRent_CheckedChanged(object sender, EventArgs e)
        {
            filter.AllCar = false;
            filter.Rented = true;
            filter.Deleted = false;
        }

        private void cbFree_CheckedChanged(object sender, EventArgs e)
        {
            filter.AllCar = false;
            filter.Rented = false;
            filter.Deleted = true;
        }
    }
}
