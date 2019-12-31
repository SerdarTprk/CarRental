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

namespace CarRental.UI
{
    public partial class FormUserAdd : Form
    {
        UserController _uc;
        RoleController _rc;
        public static event Event1 UserAdded;
        public FormUserAdd()
        {
            InitializeComponent();
            _uc = new UserController();
            _rc = new RoleController();
        }

        private void FormUserAdd_Load(object sender, EventArgs e)
        {
            List<RoleDTO> dto = _rc.RoleList();
            lstKullaniciTipi.DataSource = dto;
            lstKullaniciTipi.ValueMember = "Id";
            lstKullaniciTipi.DisplayMember = "RoleName";
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text) && string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre boş geçilemez");
                return;
            }
            
            {

            }
            if (lstKullaniciTipi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen kullanıcı tipini seçiniz");
                return;
            }

            UserDTO dto = new UserDTO()
            {
                Password = txtPassword.Text,
                UserName = txtUserName.Text,
            };
            List<RoleDTO> rdto = new List<RoleDTO>();

            foreach (var item in lstKullaniciTipi.SelectedItems)
            {
                rdto.Add((RoleDTO)item);
            }
            var result = _uc.UserAdd(dto, rdto);
            result.NotificationShow();

            if (result.State==ResultState.Success)
            {
                UserAdded.Raise();
                txtPassword.Text = "";
                txtUserName.Text = "";

            }
        }
    }
}
