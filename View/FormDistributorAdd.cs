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
    public partial class FormDistributorAdd : Form
    {
        Distributor ds = new Distributor();
        Validasi val = new Validasi();
        public FormDistributorAdd()
        {
            InitializeComponent();
            showDistributor();
            this.DoubleBuffered = true;
        }

        private void FormDistributorAdd_Load(object sender, EventArgs e)
        {
            txtIdDistributor.MaxLength = 6;
            txtNamaDistributor.MaxLength = 35;
            txtAlamat.MaxLength = 225;
        }

        public void showDistributor()
        {
            dtDistributor.DataSource = ds.showDistributor();
            dtDistributor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            FormDistributor ds = new FormDistributor();
            ds.Show();
            this.Hide();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtIdDistributor.Clear();
            txtNamaDistributor.Clear();
            txtAlamat.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (val.ValId(txtIdDistributor.Text) && val.valNama(txtNamaDistributor.Text) && val.ValAlamat(txtAlamat.Text))
            {
                try
                {
                    ds.addDistributor(txtIdDistributor.Text, txtNamaDistributor.Text, txtAlamat.Text);
                    MessageBox.Show("New Distributor Added ", "Add Distributor ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear.PerformClick();
                    txtIdDistributor.Focus();
                    showDistributor();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty field ", "eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
