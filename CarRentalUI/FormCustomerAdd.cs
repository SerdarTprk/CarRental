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
    public partial class FormCustomerAdd : Form
    {
        public static Event1 CustomerAdded;
        CustomerDTO _cd;
        CustomerController _cc;
        public FormCustomerAdd()
        {
            InitializeComponent();
            _cc = new CustomerController();
            _cd = new CustomerDTO();
        }

        private void FormCustomerAdd_Load(object sender, EventArgs e)
        {
            cmbLicenceType.Yukle<DriverLicenceTypeEnum>();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            string message = "";
            if (string.IsNullOrWhiteSpace(txtTcKimlik.Text))
            {
                message += "Kimlik numarası boş geçilemez.\n";
            }
            if (message != "")
            {
                MessageBox.Show(message);
                return;
            }
            //dto map
                var dto = new CustomerDTO()
                {
                    FirstName = txtfirstname.Text,
                    LastName = txtlastname.Text,
                    Phone = txtphone.Text,
                    E_mail = txtmail.Text,
                    TcNo = txtTcKimlik.Text,
                    Adress = txtaddress.Text,
                    DriverLicenceType = (DriverLicenceTypeEnum)cmbLicenceType.SelectedItem

                };
            //bll iş katmanı
                var result = _cc.CustomerAdd(dto);
                result.NotificationShow();
                if (result.State == ResultState.Success)
                {
                    txtaddress.Text = "";
                    txtfirstname.Text = "";
                    txtlastname.Text = "";
                    txtmail.Text = "";
                    txtphone.Text = "";
                    txtTcKimlik.Text = "";
                    cmbLicenceType.SelectedIndex = -1;

                    CustomerAdded.Raise();
                }
            }
        }
    }

