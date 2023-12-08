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
    public partial class FormPembelian : Form
    {
        Pembelian beli = new Pembelian();
        public FormPembelian()
        {
            InitializeComponent();
            showPembelian();
            this.DoubleBuffered = true;
        }

        private void FormPembelian_Load(object sender, EventArgs e)
        {

        }
       
        public void showPembelian()
        {
            dtPembelian.DataSource = beli.showPembelian();
            dtPembelian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
       
       
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            FormBeranda br = new FormBeranda();
            br.Show();
            this.Hide();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            FormPembelianAdd beli = new FormPembelianAdd();
            beli.Show();
            this.Hide();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            FormPembelianUpdate beli = new FormPembelianUpdate();
            beli.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FormPembelianDelete dl = new FormPembelianDelete();
            dl.Show();
            this.Hide();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            dtPembelian.DataSource = beli.Search(txtSearch.Text);
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            dtPembelian.DataSource = beli.Search(txtSearch.Text);
        }

        private void dtPembelian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
