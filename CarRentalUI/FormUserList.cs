using CarRental.BLL;
using CarRental.DTO;
using CarRental.UI;
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
    public partial class FormUserList : Form
    {
        UserController _uc;
        public FormUserList()
        {
            InitializeComponent();
            _uc = new UserController();
            FormUserAdd.UserAdded += ListLoad;
        }

        private void FormUserList_Load(object sender, EventArgs e)
        {
            ListLoad();
        }
        private void ListLoad()
        {
            List<UserDTO> udto = _uc.UserList();
            lstUser.DisplayMember = "UserName";
            lstUser.ValueMember = "Id";
            lstUser.DataSource = udto;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FormUserAdd frm = new FormUserAdd();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnPasswordChange_Click(object sender, EventArgs e)
        {
            FormPasswordChange frm = new FormPasswordChange((UserDTO)lstUser.SelectedItem);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
