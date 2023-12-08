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
    public partial class FormDistributor : Form
    {
        Distributor ds = new Distributor();
        public FormDistributor()
        {
            InitializeComponent();
            showDistributor();
            this.DoubleBuffered = true;
        }

        public void showDistributor()
        {
            dtDistributor.DataSource = ds.showDistributor();
            dtDistributor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
           
            FormBeranda br = new FormBeranda();
            br.Show();
            this.Hide();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            FormDistributorAdd ds = new FormDistributorAdd();
            ds.Show();
            this.Hide();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            FormDistributorUpdate ds = new FormDistributorUpdate();
            ds.Show();
            this.Hide();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            FormDistributorDelete ds = new FormDistributorDelete();
            ds.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            dtDistributor.DataSource = ds.Search(txtSearch.Text);
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            dtDistributor.DataSource = ds.Search(txtSearch.Text);
        }

        private void FormDistributor_Load(object sender, EventArgs e)
        {

        }
    }
}
