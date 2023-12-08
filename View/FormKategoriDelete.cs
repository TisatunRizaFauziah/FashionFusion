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
    public partial class FormKategoriDelete : Form
    {
        Kategori kt = new Kategori();
        public FormKategoriDelete()
        {
            InitializeComponent();
            showKategori();
            this.DoubleBuffered = true;
        }

        private void FormKategoriDelete_Load(object sender, EventArgs e)
        {

        }

        public void showKategori()
        {
            dtKategori.DataSource = kt.showKategori();
            dtKategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        bool verify()
        {
            if (string.IsNullOrEmpty(txtIdKategori.Text) || string.IsNullOrEmpty(txtNamaKategori.Text))
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
                    kt.deleteKategori(txtIdKategori.Text);
                    showKategori();
                    btnClear.PerformClick();

                    MessageBox.Show("kategori Deleted Suksess", "Delete kategori", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdKategori.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error - kategori tidak terhapus", "Delete kategori",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {

            txtIdKategori.Clear();
            txtNamaKategori.Clear();
        }

        private void dtKategori_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtIdKategori.Text = dtKategori.CurrentRow.Cells[0].Value.ToString();
            txtNamaKategori.Text = dtKategori.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            FormKategori kt = new FormKategori();
            kt.Show();
            this.Hide();
        }
    }
}
