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
    public partial class FormKategori : Form
    {
        Kategori kt = new Kategori();
        public FormKategori()
        {
            InitializeComponent();
            showkategori();
            this.DoubleBuffered = true;
        }

        private void FormKategori_Load(object sender, EventArgs e)
        {

        }
           
        public void showkategori()
        {
            dtKategori.DataSource = kt.showKategori();
            dtKategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            FormKategoriAdd kt = new FormKategoriAdd();
            kt.Show();
            this.Hide();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            FormKategoriUpdate kt = new FormKategoriUpdate();
            kt.Show();
            this.Hide();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            FormKategoriDelete kt = new FormKategoriDelete();
            kt.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            dtKategori.DataSource = kt.Search(txtSearch.Text);
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            dtKategori.DataSource = kt.Search(txtSearch.Text);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            FormBeranda br = new FormBeranda();
            br.Show();
            this.Hide();
        }
    }
}
