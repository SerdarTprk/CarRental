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

namespace CarRentalUI
{
    public partial class FormPasswordChange : Form
    {
        UserDTO _dto;
        public FormPasswordChange(UserDTO dto)
        {
            InitializeComponent();
            _dto = dto;
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtEskiSifre.Text) && string.IsNullOrWhiteSpace(txtYeniSifre.Text) && string.IsNullOrWhiteSpace(txtYeniSifreTekrar.Text))
            {
                MessageBox.Show( "Eski Şifre ve Yeni şifre Boş geçilemez");
                return;
            }
            if (txtEskiSifre.Text != _dto.Password)
            {
                MessageBox.Show("Eski şifre, şifrenizle eşleşmiyor");
                return;
            }

            if (txtYeniSifre.Text != txtYeniSifreTekrar.Text)
            {
                MessageBox.Show("Yeni şifreler aynı değil");
                return;
            }
            
            
        }
    }
}
