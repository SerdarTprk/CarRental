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
    public partial class FormCarUpdate : Form
    {
        CarDTO _cd;
        CarController _cc;
        public FormCarUpdate(CarDTO cardto)
        {
            InitializeComponent();
            _cd = new CarDTO();
            _cc = new CarController();

        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
