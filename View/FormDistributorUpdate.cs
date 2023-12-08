using FashionFusion.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionFusion.View
{
    public partial class FormDistributorUpdate : Form
    {
        Distributor ds = new Distributor();
        public FormDistributorUpdate()
        {
            InitializeComponent();
            showDistributor();
            this.DoubleBuffered = true;
        }

        private void FormDistributorUpdate_Load(object sender, EventArgs e)
        {

        }
  
        public void showDistributor()
        {
            dtDistributor.DataSource = ds.showDistributor();
            dtDistributor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                ds.updateDistributor(txtIdDistributor.Text, txtNamaDistributor.Text, txtAlamat.Text);
                MessageBox.Show("Update Success");
                showDistributor();
                btnClear.PerformClick();
                txtIdDistributor.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Eror " + ex.Message);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtIdDistributor.Clear();
            txtNamaDistributor.Clear();
            txtAlamat.Clear();
        }

        private void dtDistributor_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtIdDistributor.Text = dtDistributor.CurrentRow.Cells[0].Value.ToString();
            txtNamaDistributor.Text = dtDistributor.CurrentRow.Cells[1].Value.ToString();
            txtAlamat.Text = dtDistributor.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            FormDistributor ds = new FormDistributor();
            ds.Show();
            this.Hide();
        }

        private void labelAlamat_Click(object sender, EventArgs e)
        {

        }
    }
}
