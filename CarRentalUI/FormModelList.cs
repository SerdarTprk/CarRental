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
    public partial class FormModelList : Form
    {
        ModelController _mc;
        BrandController _bc;
        public FormModelList()
        {
            InitializeComponent();
            _mc = new ModelController();
            _bc = new BrandController();
            FormBrandAdd.BranAdded += BrandLoad;
            FormModelAdd.ModelAdded += ListLoad;
        }
       
        private void btnSil_Click(object sender, EventArgs e)
        {
            #region Validation
            if (lstModel.SelectedIndex == -1)
            {
                MessageBox.Show("Önce bir kayıt seçmeniz gerekmektedir.");
                return;
            }
            #endregion

            var model = (ModelDTO)lstModel.SelectedItem;

            ServiceResult result = _mc.DeleteModel(model);
            result.NotificationShow();
            if (result.State == ResultState.Success)
            {
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormModelAdd frm = new FormModelAdd();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void FormModelList_Load(object sender, EventArgs e)
        {
            BrandLoad();
        }
        private void BrandLoad()
        {
            List<BrandDTO> bdto = _bc.BrandListele();

            cmbBrand.DisplayMember = "BrandName";
            cmbBrand.ValueMember = "Id";
            cmbBrand.DataSource = bdto;
        }
        private  void ListLoad()
        {
         
            var Id = (Guid) cmbBrand.SelectedValue;

            List<ModelDTO> mdto = _mc.ModelList(Id);
         
            lstModel.DisplayMember = "ModelName";
            lstModel.ValueMember = "Id";
            lstModel.DataSource = mdto;


        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListLoad();
        }
    }
}
