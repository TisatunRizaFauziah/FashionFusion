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
    public partial class FormDistributorDelete : Form
    {

        Distributor ds = new Distributor();
        public FormDistributorDelete()
        {
            InitializeComponent();
            showDistributor();
            this.DoubleBuffered = true;
        }

        private void FormDistributorDelete_Load(object sender, EventArgs e)
        {

        }
        
        public void showDistributor()
        {
            dtDistributor.DataSource = ds.showDistributor();
            dtDistributor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        bool verify()
        {
            if (string.IsNullOrEmpty(txtIdDistributor.Text) || string.IsNullOrEmpty(txtNamaDistributor.Text) || string.IsNullOrEmpty(txtAlamat.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {
                    ds = new Distributor();
                    ds.deleteDistributor(txtIdDistributor.Text);
                    showDistributor();
                    btnClear.PerformClick();
                    MessageBox.Show("Distributor Deleted Suksess", "Delete Distributor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdDistributor.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error - Distributor tidak terhapus", "Delete Pelanggan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtDistributor_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtIdDistributor.Text = dtDistributor.CurrentRow.Cells[0].Value.ToString();
            txtNamaDistributor.Text = dtDistributor.CurrentRow.Cells[1].Value.ToString();
            txtAlamat.Text = dtDistributor.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtIdDistributor.Clear();
            txtNamaDistributor.Clear();
            txtAlamat.Clear();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            FormDistributor ds = new FormDistributor();
            ds.Show();
            this.Hide();
        }
    }
}
