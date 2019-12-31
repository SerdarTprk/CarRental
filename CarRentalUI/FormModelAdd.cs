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
    public partial class FormModelAdd : Form
    {
        BrandController _bc;
        ModelController _mc;
        public static event Event1 ModelAdded;
        public FormModelAdd()
        {
            InitializeComponent();
            _bc = new BrandController();
            _mc = new ModelController();
        }

        private void FormModelAdd_Load(object sender, EventArgs e)
        {
            ListLoad();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            ModelDTO dto = new ModelDTO()
            {
                Id = Guid.NewGuid(),
                ModelName = txtModel.Text,
                ModelYear = dtpModelYear.Value,
                BrandId = (Guid)cmbBrand.SelectedValue,
                
            };
            var result = _mc.ModelAdd(dto);
            result.NotificationShow();
            if (result.State == ResultState.Success)
            {
                txtModel.Text = "";
                dtpModelYear.Value = DateTime.Today;
                ModelAdded.Raise();

            }
            

            
        }
        private void ListLoad()
        {
            List<BrandDTO> brandList = _bc.BrandListele();
            cmbBrand.DataSource = brandList;
            cmbBrand.DisplayMember = "BrandName";
            cmbBrand.ValueMember = "Id";
        }
    }
}

