using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA300622_G2.Repositories.Concrete;

namespace WFA300622_G2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        CarRepositories carRepository = new CarRepositories();

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvList.DataSource = carRepository.GetCars();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            carRepository.CreateCar(Convert.ToInt32(txtID.Text), txtMarka.Text, Convert.ToDouble(txtPrice.Text));
            dgvList.DataSource = carRepository.GetCars();
            carRepository.ClearTextBox(txtID, txtMarka, txtPrice);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            carRepository.Find(Convert.ToInt32(txtSearchID.Text), txtMarka, txtPrice);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            carRepository.UpdateCar(Convert.ToInt32(txtSearchID.Text), txtUpdateMarka.Text, Convert.ToDouble(txtUpdatePrice.Text));
            dgvList.DataSource = carRepository.GetCars();
        }

    }
}
