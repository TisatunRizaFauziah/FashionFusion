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
    public partial class FormPakaianAdd : Form
    {
        Pakaian pk = new Pakaian();
        Validasi val = new Validasi();
        public FormPakaianAdd()
        {
            InitializeComponent();
            showPakaian();
            this.DoubleBuffered = true;
        }

        private void FormPakaianAdd_Load(object sender, EventArgs e)
        {
            txtIdPakaian.MaxLength = 6;
            txtNamaPakaian.MaxLength = 225;
            txtIdKategori.MaxLength = 6;
            txtHarga.MaxLength = 8;
            txtUkuran.MaxLength = 1;
            txtStok.MaxLength = 6;
        }

        public void showPakaian()
        {
            dtPakaian.DataSource = pk.showPakaian();
            dtPakaian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            pk = new Pakaian();

            if (val.ValId(txtIdPakaian.Text) && val.valNama(txtNamaPakaian.Text) && val.ValId(txtIdKategori.Text) && val.Valharga(txtHarga.Text) && val.ValUkuran(txtUkuran.Text) && val.ValStok(txtStok.Text))
            {
                try
                {
                    pk.addPakaian(txtIdPakaian.Text, txtNamaPakaian.Text, txtIdKategori.Text, txtHarga.Text, txtUkuran.Text, txtStok.Text);
                    MessageBox.Show("New Pakaian Added ", "Add pakaian ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear.PerformClick();
                    txtIdPakaian.Focus();
                    showPakaian();

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
