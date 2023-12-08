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
    public partial class FormPembelianAdd : Form
    {
        Pembelian beli = new Pembelian();
        Validasi val = new Validasi();
        public FormPembelianAdd()
        {
            InitializeComponent();
            showPembelian();
            this.DoubleBuffered = true;
        }

        private void FormPembelianAdd_Load(object sender, EventArgs e)
        {
            txtIdPembelian.MaxLength = 6;
            txtIdDistributor.MaxLength = 6;
            txtIdPakaian.MaxLength = 6;
            txtJumlah.MaxLength = 8;
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

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtIdPembelian.Clear();
            dtTimeTglPembelian.Value = DateTime.Now; // Menggunakan propery Value untuk mengatur nilai DateTimePicker
            txtIdDistributor.Clear();
            txtIdPakaian.Clear();
            txtJumlah.Clear();
        }
    

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (val.ValId(txtIdPembelian.Text) && val.ValId(txtIdDistributor.Text) && val.ValId(txtIdPakaian.Text) && val.ValStok(txtJumlah.Text))
            {
                try
                {
                    beli.addPembelian(txtIdPembelian.Text, dtTimeTglPembelian.Value, txtIdDistributor.Text, txtIdPakaian.Text, txtJumlah.Text);
                    MessageBox.Show("New Pembelian Added ", "Add Pembelian ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showPembelian();
                    txtIdPembelian.Focus();
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

        private void dtTimeTglPembelian_ValueChanged_1(object sender, EventArgs e)
        {
            dtTimeTglPembelian.CustomFormat = "dd/MM/yyyy";
        }
    }
}
