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
    public partial class FormPakaianUpdate : Form
    {
        Pakaian pk = new Pakaian();
        public FormPakaianUpdate()
        {
            InitializeComponent();
            showPakaian();
            this.DoubleBuffered = true;
        }

        private void FormPakaianUpdate_Load(object sender, EventArgs e)
        {

        }

   
        
        public void showPakaian()
        {
            dtPakaian.DataSource = pk.showPakaian();
            dtPakaian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
       

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormPakaian pk = new FormPakaian();
            pk.Show();
            this.Hide();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtIdPakaian.Clear();
            txtNamaPakaian.Clear();
            txtIdKategori.Clear();
            txtHarga.Clear();
            txtUkuran.Clear();
            txtStok.Clear();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                pk = new Pakaian();
                pk.updatePakaian(txtIdPakaian.Text, txtNamaPakaian.Text, txtIdKategori.Text, txtHarga.Text, txtUkuran.Text, txtStok.Text);

                MessageBox.Show("Update Success");
                showPakaian();
                btnClear.PerformClick();
                txtIdPakaian.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror" + ex.Message);
            }
        }

        private void dtPakaian_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPakaian.Text = dtPakaian.CurrentRow.Cells[0].Value.ToString();
            txtNamaPakaian.Text = dtPakaian.CurrentRow.Cells[1].Value.ToString();
            txtIdKategori.Text = dtPakaian.CurrentRow.Cells[2].Value.ToString();
            txtHarga.Text = dtPakaian.CurrentRow.Cells[3].Value.ToString();
            txtUkuran.Text = dtPakaian.CurrentRow.Cells[4].Value.ToString();
            txtStok.Text = dtPakaian.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
