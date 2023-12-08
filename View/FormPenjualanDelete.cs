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
    public partial class FormPenjualanDelete : Form
    {
        public FormPenjualanDelete()
        {
            InitializeComponent();
            showPenjualan();
            this.DoubleBuffered = true;
        }

        private void FormPenjualanDelete_Load(object sender, EventArgs e)
        {

        }
        Penjualan pj = new Penjualan();
     
        public void showPenjualan()
        {
            dtPenjualan.DataSource = pj.showPemjualan();
            dtPenjualan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    
        bool verify()
        {
            if (string.IsNullOrEmpty(txtIdPelanggan.Text) || dtTimeTglPenjualan.Value == null || string.IsNullOrEmpty(txtIdPelanggan.Text) || string.IsNullOrEmpty(txtIdPakaian.Text) || string.IsNullOrEmpty(txtJumlah.Text))
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
            FormPenjualan pj = new FormPenjualan();
            pj.Show();
            this.Hide();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtIdPenjualan.Clear();
            dtTimeTglPenjualan.Value = DateTime.Now;
            txtIdPelanggan.Clear();
            txtIdPakaian.Clear();
            txtJumlah.Clear();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            if (verify())
            {
                try
                {
                    pj.deletePenjualan(txtIdPenjualan.Text);
                    showPenjualan();
                    btnClear.PerformClick();
                    MessageBox.Show("Penjualan Deleted Suksess", "Delete Penjualan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdPenjualan.Focus();
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

        private void dtTimeTglPenjualan_ValueChanged_1(object sender, EventArgs e)
        {
            dtTimeTglPenjualan.CustomFormat = "dd/MM/yyyy";
        }

        private void dtPenjualan_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPenjualan.Text = this.dtPenjualan.CurrentRow.Cells[0].Value?.ToString();
            dtTimeTglPenjualan.Value = Convert.ToDateTime(this.dtPenjualan.CurrentRow.Cells[1].Value);
            txtIdPelanggan.Text = this.dtPenjualan.CurrentRow.Cells[2].Value?.ToString();
            txtIdPakaian.Text = this.dtPenjualan.CurrentRow.Cells[3].Value?.ToString();
            txtJumlah.Text = this.dtPenjualan.CurrentRow.Cells[4].Value?.ToString();
        }
    }
}
