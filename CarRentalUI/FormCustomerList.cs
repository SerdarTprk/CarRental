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
    public partial class FormCustomerList : Form
    {
        CustomerController _cc;
        public FormCustomerList()
        {
            InitializeComponent();
            _cc = new CustomerController();
            FormCustomerAdd.CustomerAdded += ListLoad;
            FormCustomerUpdate.customerUpdated += ListLoad;
        }
        
        private void FormCustomerList_Load(object sender, EventArgs e)
        {
            ListLoad();
        }
        /*post # aspect yazmamızı saglıyor.örn transaction sürecini aspectte kolayca alabiliriz.
          aspect oriented;  try catchlerden dolayı ana kodu yalın vaziyette yazmak için  [] içinde etiketliyoruz anakodu burada yaıyoruz ve derleme sırasında try catchleri galan kendisi ekliyor.
       */
        private void Btnguncelle_Click(object sender, EventArgs e)
        {
            #region Validation
            if (listCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Önce bir kayıt seçmeniz gerekir");
                return;
            }
            #endregion
            var customer = (CustomerDTO)listCustomer.SelectedItem;
            FormCustomerUpdate frm = new FormCustomerUpdate(customer);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
        private void ListLoad()
        {
            List<CustomerDTO> customers = new List<CustomerDTO>();
            customers = _cc.GetAllCustomer();
            listCustomer.DataSource = null;
            listCustomer.DisplayMember = "FirstName";
            listCustomer.ValueMember = "Id";
            listCustomer.DataSource = customers;
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            #region Validation
            if (listCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Önce bir kayıt seçmeniz gerekmektedir.");
                return;
            }
            #endregion
            var customer = (CustomerDTO)listCustomer.SelectedItem;
            ServiceResult result = _cc.CustomerDelete(customer);
            result.NotificationShow();
            if (result.State == ResultState.Success)
            {
                ListLoad();
            }
        }

        private void ListCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
