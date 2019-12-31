using CarRental.BLL;
using CarRental.DTO;
using CarRentalEnums;
using Framework.Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRental.UI
{
    public partial class FormCarAdd : Form
    {
        CarController _cc;
        BrandController _bc;
        ModelController _mc;
        public FormCarAdd()
        {
            InitializeComponent();
            _cc = new CarController();
            _bc = new BrandController();
            _mc = new ModelController();
        }

        private void FormCarAdd_Load(object sender, EventArgs e)
        {
            List<BrandDTO> brandList = _bc.BrandListele();
            
            cmbBrand.DisplayMember = "BrandName";
            cmbBrand.ValueMember = "Id";
            cmbBrand.DataSource = brandList;
        
            cmbCarClass.Yukle<CarClassEnum>();
            cmbColor.Yukle<CarColorEnum>();
            cmbFuelType.Yukle<FuelTypeEnum>();
            cmbLicenceType.Yukle<DriverLicenceTypeEnum>();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
          
            var dto = new CarDTO()
            {
                Id = Guid.NewGuid(),
                Plate = txtPlate.Text,
                CarClassEnum = (CarClassEnum)cmbCarClass.SelectedItem,
                EngineCapacity = txtSilindirHac.Text,
                CylindeerVolume = txtSilindirHac.Text,
                DailyPrice = txtDailyPrice.Text,
                DriverLicenceType = (DriverLicenceTypeEnum)cmbLicenceType.SelectedItem,
                InsuranceExpiryDate = dtpsigorta.Value,
                InspectionExpiryDate = dtpkasko.Value,
                CarColorEnum = (CarColorEnum)cmbColor.SelectedItem,
                DateOfPurchase = dtpSatinAlmaTar.Value,
                FuelType = (FuelTypeEnum)cmbFuelType.SelectedItem,
                IsRented = false,
                ModelId = (Guid)cmbModel.SelectedValue 
            };
            var result = _cc.CarAdd(dto);
            result.NotificationShow();
            if (result.State == ResultState.Success)
            {
                txtPlate.Text = "";
                dtpkasko.Value = DateTime.Today;
                dtpSatinAlmaTar.Value = DateTime.Today;
                dtpsigorta.Value = DateTime.Today;
            }

           


        }

        

        private void LblPlate_Click(object sender, EventArgs e)
        {

        }

        private void CmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ModelDTO> modelList = _mc.ModelList((Guid)cmbBrand.SelectedValue);

            cmbModel.DisplayMember = "ModelName";
            cmbModel.ValueMember = "Id";
            cmbModel.DataSource = modelList;
        }
    }
}
