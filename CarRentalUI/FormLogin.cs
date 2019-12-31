using CarRental.BLL;
using CarRental.DTO;
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
    public partial class FormLogin : Form
    {
        UserController _sc;
        public static Event1 Listele;
        public FormLogin()
        {
            InitializeComponent();
            _sc = new UserController();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text ) && string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Kullanıcı adı ve password boş geçilemez");
                return;
            }
           var kontrol= _sc.UserLogin(txtName.Text, txtPassword.Text);
            if (kontrol!=null)
            {

                HashSet<RoleDTO> roles = (HashSet<RoleDTO>)kontrol.Roles;
                
                lstRoller.DataSource =roles.ToList();
                lstRoller.DisplayMember = "RoleName";
                lstRoller.ValueMember = "Id";
                Listele.Raise();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve password hatalı");
            }
            Session.CurrentUser = kontrol;
        }

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            Session.CurrentRole =(RoleDTO) lstRoller.SelectedItem;
            FormMain frm = new FormMain();
            frm.Show();
            this.Hide();
        }
    }
}
