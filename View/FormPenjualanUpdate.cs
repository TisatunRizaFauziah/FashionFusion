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
    public partial class FormPenjualanUpdate : Form
    {
        Penjualan pj = new Penjualan();
        public FormPenjualanUpdate()
        {
            InitializeComponent();
            showPenjualan();
            this.DoubleBuffered = true;
        }

        private void FormPenjualanUpdate_Load(object sender, EventArgs e)
        {

        }
     
        public void showPenjualan()
        {
            dtPenjualan.DataSource = pj.showPemjualan();
            dtPenjualan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
      
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            FormPenjualan pj = new FormPenjualan();
            pj.Show();
            this.Hide();
        }

        private void dtTimeTglPenjualan_ValueChanged_1(object sender, EventArgs e)
        {
            dtTimeTglPenjualan.CustomFormat = "dd/MM/yyyy";
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtIdPenjualan.Clear();
            dtTimeTglPenjualan.Value = DateTime.Now;
            txtIdPelanggan.Clear();
            txtIdPakaian.Clear();
            txtJumlah.Clear();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                pj.updatePenjualan(txtIdPenjualan.Text, dtTimeTglPenjualan.Value, txtIdPelanggan.Text, txtIdPakaian.Text, txtJumlah.Text);
                txtIdPenjualan.Focus();
                MessageBox.Show("Update Success");
                showPenjualan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "eror", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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
