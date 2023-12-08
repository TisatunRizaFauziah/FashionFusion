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
    public partial class FormPenjualanAdd : Form
    {


        Penjualan pj = new Penjualan();
        Validasi val = new Validasi();
        public FormPenjualanAdd()
        {
            InitializeComponent();
            showPenjualan();
            this.DoubleBuffered = true;
        }

        private void FormPenjualanAdd_Load(object sender, EventArgs e)
        {
            txtIdPenjualan.MaxLength = 6;
            txtIdPelanggan.MaxLength = 6;
            txtIdPakaian.MaxLength = 6;
            txtJumlah.MaxLength = 8;
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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (val.ValId(txtIdPenjualan.Text) && val.ValId(txtIdPelanggan.Text) && val.ValId(txtIdPakaian.Text) && val.ValStok(txtJumlah.Text))
            {
                try
                {
                    pj.addPenjualan(txtIdPenjualan.Text, dtTimeTglPenjualan.Value, txtIdPelanggan.Text, txtIdPakaian.Text, txtJumlah.Text);
                    MessageBox.Show("New Penjualan Added ", "Add Penjualan ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showPenjualan();
                    txtIdPenjualan.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "eror", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Empty field ", "eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
