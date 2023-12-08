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
    public partial class FormPenjualan : Form
    {
        Penjualan pj = new Penjualan();
        public FormPenjualan()
        {
            InitializeComponent();
            showPenjualan();
            this.DoubleBuffered = true;
        }

        private void FormPenjualan_Load(object sender, EventArgs e)
        {

        }
       
      
        public void showPenjualan()
        {
            dtPenjualan.DataSource = pj.showPemjualan();
            dtPenjualan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
       

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            FormBeranda br = new FormBeranda();
            br.Show();
            this.Hide();
        }

        private void dtPenjualan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            FormPenjualanAdd pj = new FormPenjualanAdd();
            pj.Show();
            this.Hide();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            FormPenjualanUpdate pj = new FormPenjualanUpdate();
            pj.Show();
            this.Hide();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            FormPenjualanDelete pj = new FormPenjualanDelete();
            pj.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            dtPenjualan.DataSource = pj.Search(txtSearch.Text);
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            dtPenjualan.DataSource = pj.Search(txtSearch.Text);
        }
    }
}
