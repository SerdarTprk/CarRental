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

namespace CarRentalUI
{
    public partial class FormCustomerUpdate : Form
    {
        CustomerDTO _dto;
        CustomerController _cc;
        public static event Event1 customerUpdated;

        
        public FormCustomerUpdate(CustomerDTO customer)
        {
            InitializeComponent();
            _dto = customer;
            _cc = new CustomerController();

        }

        private void FormCustomerUpdate_Load(object sender, EventArgs e)
        {
            cmbLicenceType.Yukle<DriverLicenceTypeEnum>();

            txtaddress.Text = _dto.Adress;
            txtfirstname.Text = _dto.FirstName;
            txtlastname.Text = _dto.LastName;
            txtmail.Text = _dto.E_mail;
            txtphone.Text = _dto.Phone;
            txtTcKimlik.Text = _dto.TcNo;
            cmbLicenceType.SelectedItem = _dto.DriverLicenceType;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
           
            _dto.Adress = txtaddress.Text;
            _dto.E_mail = txtmail.Text;
            _dto.DriverLicenceType = (DriverLicenceTypeEnum)cmbLicenceType.SelectedItem;
            _dto.FirstName = txtfirstname.Text;
            _dto.LastName = txtlastname.Text;
            _dto.Phone = txtphone.Text;
            _dto.TcNo = txtTcKimlik.Text;

            var result = _cc.UpdateCustomer(_dto);
            result.NotificationShow();
            if (result.State==ResultState.Success)
            {
                customerUpdated();
                this.Close();
            }
        }
    }
}
