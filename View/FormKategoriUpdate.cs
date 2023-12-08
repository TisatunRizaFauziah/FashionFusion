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
    public partial class FormKategoriUpdate : Form
    {
        Kategori kt = new Kategori();
        public FormKategoriUpdate()
        {
            InitializeComponent();
            showKategori();
            this.DoubleBuffered = true;
        }

        private void FormKategoriUpdate_Load(object sender, EventArgs e)
        {

        }
      
       
        public void showKategori()
        {
            dtKategori.DataSource = kt.showKategori();
            dtKategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                kt = new Kategori();
                kt.updateKategori(txtIdKategori.Text, txtNamaKategori.Text);

                MessageBox.Show("Update Success ");
                showKategori();
                btnClear.PerformClick();
                txtIdKategori.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Update Eror " + ex.Message);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtIdKategori.Clear();
            txtNamaKategori.Clear();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            FormKategori kt = new FormKategori();
            kt.Show();
            this.Hide();
        }

        private void dtKategori_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtIdKategori.Text = dtKategori.CurrentRow.Cells[0].Value.ToString();
            txtNamaKategori.Text = dtKategori.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
