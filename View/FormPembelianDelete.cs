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
    public partial class FormPembelianDelete : Form
    {
        Pembelian beli = new Pembelian();
        public FormPembelianDelete()
        {
            InitializeComponent();
            showPembelian();
            this.DoubleBuffered = true;
        }

        private void FormPembelianDelete_Load(object sender, EventArgs e)
        {

        }

        bool verify()
        {
            if (string.IsNullOrEmpty(txtIdPembelian.Text) || dtTimeTglPembelian.Value == null || string.IsNullOrEmpty(txtIdDistributor.Text) || string.IsNullOrEmpty(txtIdPakaian.Text) || string.IsNullOrEmpty(txtJumlah.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void showPembelian()
        {
            dtPembelian.DataSource = beli.showPembelian();
            dtPembelian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormPembelian beli = new FormPembelian();
            beli.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIdPembelian.Clear();
            dtTimeTglPembelian.Value = DateTime.Now;
            txtIdDistributor.Clear();
            txtIdPakaian.Clear();
            txtJumlah.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {
                    beli.deletePembelian(txtIdPembelian.Text);
                    showPembelian();
                    btnClear.PerformClick();
                    MessageBox.Show("Penjualan Deleted Suksess", "Delete Penjualan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdPembelian.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error - penjualan tidak terhapus", "Delete penjualan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtTimeTglPembelian_ValueChanged(object sender, EventArgs e)
        {
            dtTimeTglPembelian.CustomFormat = "dd/MM/yyyy";
        }

        private void dtPembelian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPembelian.Text = this.dtPembelian.CurrentRow.Cells[0].Value?.ToString();
            dtTimeTglPembelian.Value = Convert.ToDateTime(this.dtPembelian.CurrentRow.Cells[1].Value);
            txtIdDistributor.Text = this.dtPembelian.CurrentRow.Cells[2].Value?.ToString();
            txtIdPakaian.Text = this.dtPembelian.CurrentRow.Cells[3].Value?.ToString();
            txtJumlah.Text = this.dtPembelian.CurrentRow.Cells[4].Value?.ToString();
        }
    }
}
