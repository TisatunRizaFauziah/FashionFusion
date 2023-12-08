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
    public partial class FormPembelianUpdate : Form
    {
        Pembelian beli = new Pembelian();
        public FormPembelianUpdate()
        {
            InitializeComponent();
            showPembelian();
            this.DoubleBuffered = true;
        }

        private void FormPembelianUpdate_Load(object sender, EventArgs e)
        {

        }

        public void showPembelian()
        {
            dtPembelian.DataSource = beli.showPembelian();
            dtPembelian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
     

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            FormPembelian beli = new FormPembelian();
            beli.Show();
            this.Hide();
        }

        private void dtTimeTglPembelian_ValueChanged(object sender, EventArgs e)
        {
            dtTimeTglPembelian.CustomFormat = "dd/MM/yyyy";
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtIdDistributor.Clear();
            dtTimeTglPembelian.Value = DateTime.Now;
            txtIdDistributor.Clear();
            txtIdPakaian.Clear();
            txtJumlah.Clear();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                beli.updatePembelian(txtIdPembelian.Text, dtTimeTglPembelian.Value, txtIdDistributor.Text, txtIdPakaian.Text, txtJumlah.Text);
                this.Controls.Clear();
                this.InitializeComponent();
                txtIdPembelian.Focus();
                MessageBox.Show("Update Success");
                showPembelian();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "eror", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dtPembelian_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                
                txtIdPembelian.Text = this.dtPembelian.CurrentRow.Cells[0].Value?.ToString();

                if (DateTime.TryParse(this.dtPembelian.CurrentRow.Cells[1].Value?.ToString(), out DateTime tglPembelian))
                {
                    dtTimeTglPembelian.Value = tglPembelian;
                }
                else
                {
                    MessageBox.Show("Error parsing dateTimeMulaiUPPL.");
                    dtTimeTglPembelian.Value = DateTime.Now;
                }

                txtIdDistributor.Text = this.dtPembelian.CurrentRow.Cells[2].Value?.ToString();
                txtIdPakaian.Text = this.dtPembelian.CurrentRow.Cells[3].Value?.ToString();
                txtJumlah.Text = this.dtPembelian.CurrentRow.Cells[4].Value?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
