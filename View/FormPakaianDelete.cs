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
    public partial class FormPakaianDelete : Form
    {
        Pakaian pk = new Pakaian();
        public FormPakaianDelete()
        {
            InitializeComponent();
            showPakaian();
            this.DoubleBuffered = true;
        }

        public void showPakaian()
        {
            dtPakaian.DataSource = pk.showPakaian();
            dtPakaian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        bool verify()
        {
            if (string.IsNullOrEmpty(txtIdPakaian.Text) || string.IsNullOrEmpty(txtNamaPakaian.Text) || string.IsNullOrEmpty(txtIdKategori.Text) ||
                string.IsNullOrEmpty(txtHarga.Text) || string.IsNullOrEmpty(txtUkuran.Text) || string.IsNullOrEmpty(txtStok.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
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

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {
                    pk.deletePakaian(txtIdPakaian.Text);
                    showPakaian();
                    btnClear.PerformClick();

                    MessageBox.Show("pekaian Deleted Suksess", "Delete pakaian", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdPakaian.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error-Pakaian tidak terhapus", "Delete pakaian",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

        private void FormPakaianDelete_Load_1(object sender, EventArgs e)
        {

        }
    }
}
