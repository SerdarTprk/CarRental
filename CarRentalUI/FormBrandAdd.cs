using CarRental.BLL;
using CarRental.DTO;
using Framework.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalUI
{
    public partial class FormBrandAdd : Form
    {
        BrandController _bc;
        public static Event1 BranAdded;
        public FormBrandAdd()
        {
            InitializeComponent();
            _bc = new BrandController();
            BranAdded += ListLoad;
        }

        private void FormBrandAdd_Load(object sender, EventArgs e)
        {
            ListLoad();
        }

        public void ListLoad()
        {
            List<BrandDTO> brand = _bc.BrandListele();
            lstBrand.DisplayMember = "BrandName";
            lstBrand.ValueMember = "Id";
            lstBrand.DataSource = brand;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }
        private void Ekle()
        {
            string message = "";
            if (string.IsNullOrWhiteSpace(txtBrand.Text))
            {
                message += "Marka adı boş geçilemez \n";
            }


            if (message != "")
            {
                MessageBox.Show(message);
                return;
            }
            //dto map
            var dto = new BrandDTO()
            {
                BrandName = txtBrand.Text
            };
            //bll şut
            var result = _bc.AddBrand(dto);
            //gelen cevaba göre mesaj ve işlem.
            result.NotificationShow();

            if (result.State == ResultState.Success)
            {
                txtBrand.Text = "";
                BranAdded.Raise();
                
            }
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            #region Validation
            if (lstBrand.SelectedIndex == -1)
            {
                MessageBox.Show("Önce bir kayıt seçmeniz gerekmektedir.");
                return;
            }
            #endregion

            var brand = (BrandDTO)lstBrand.SelectedItem;

            ServiceResult result = _bc.DeleteBrand(brand);
            result.NotificationShow();
            if (result.State == ResultState.Success)
            {
                ListLoad();
            }
        }
    }
}
