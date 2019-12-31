using CarRental.BLL;
using CarRental.DTO;
using CarRentalEnums;
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

namespace CarRental.UI
{
    public partial class FormCarUpdate : Form
    {
        CarDTO _dto;
        CarController _cc;
        BrandController _bc;
        ModelController _mc;
        public static event Event1 CarUpdated;
        public FormCarUpdate(CarDTO dto)
        {
            InitializeComponent();
            _dto = dto;
            _cc = new CarController();
            _bc = new BrandController();
            _mc = new ModelController();

        }

        public FormCarUpdate()
        {
        }

        private void ComboLoad()
        {
            cmbColor.Yukle<CarColorEnum>();
            cmbCarClass.Yukle<CarClassEnum>();
            cmbFuelType.Yukle<FuelTypeEnum>();
            cmbLicenceType.Yukle<DriverLicenceTypeEnum>();
            cmbColor.Yukle<CarColorEnum>();
            cmbCarClass.Yukle<CarClassEnum>();

            List<BrandDTO> bdto = _bc.BrandListele();
            cmbBrand.DisplayMember = "BrandName";
            cmbBrand.ValueMember = "Id";
            cmbBrand.DataSource = bdto;
            
            
        }
        private void FormCarUpdate_Load(object sender, EventArgs e)
        {
            ComboLoad();
            txtPlate.Text = _dto.Plate;
            dtpKaskoTarihi.Value = _dto.InspectionExpiryDate.Date;
            dtpSigortaTarih.Value = _dto.InsuranceExpiryDate.Date;
            txtCylindeerVolume.Text = _dto.CylindeerVolume;
            txtDailyPrice.Text = _dto.DailyPrice;
            txtEngineCapa.Text = _dto.EngineCapacity;
            dtpDateOfPurchase.Value = _dto.DateOfPurchase.Date;
            chkActive.Checked = _dto.IsActive;
            cmbModel.SelectedItem = _dto.ModelId;
            cmbColor.SelectedItem = _dto.CarColorEnum;
            cmbFuelType.SelectedItem = _dto.FuelType;
            cmbLicenceType.SelectedItem = _dto.DriverLicenceType;
            cmbCarClass.SelectedItem = _dto.CarClassEnum;
           

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _dto.DriverLicenceType = (DriverLicenceTypeEnum)cmbLicenceType.SelectedItem;
            _dto.FuelType = (FuelTypeEnum)cmbFuelType.SelectedItem;
            _dto.EngineCapacity = txtEngineCapa.Text;
            _dto.DailyPrice = txtDailyPrice.Text;
            _dto.CarClassEnum = (CarClassEnum)cmbCarClass.SelectedItem;
            _dto.CarColorEnum = (CarColorEnum)cmbColor.SelectedItem;
            _dto.CylindeerVolume = txtCylindeerVolume.Text;
            _dto.InspectionExpiryDate = dtpKaskoTarihi.Value;
            _dto.InsuranceExpiryDate = dtpSigortaTarih.Value;
            _dto.Plate = txtPlate.Text;
            _dto.DateOfPurchase = dtpDateOfPurchase.Value;
            _dto.IsActive = chkActive.Checked;

            var result = _cc.CarUpdate(_dto);
            result.NotificationShow();
            if (result.State==ResultState.Success)
            {
                this.Close();
            }

        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ModelDTO> mdto = _mc.ModelList((Guid)cmbBrand.SelectedValue);
            cmbModel.DisplayMember = "ModelName";
            cmbModel.ValueMember = "Id";
            cmbModel.DataSource = mdto;
        }
    }
}
