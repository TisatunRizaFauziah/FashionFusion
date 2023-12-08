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
    public partial class FormKategoriAdd : Form
    {
        Kategori kt = new Kategori();
        Validasi val = new Validasi();
        public FormKategoriAdd()
        {
            InitializeComponent();
            showKategori();
            this.DoubleBuffered = true;
        }

        private void FormKategoriAdd_Load(object sender, EventArgs e)
        {
            txtIdKategori.MaxLength = 6;
            txtNamaKategori.MaxLength = 255;
        }
     
       
        public void showKategori()
        {
            dtKategori.DataSource = kt.showKategori();
            dtKategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            kt = new Kategori();

            if (val.ValId(txtIdKategori.Text) && val.valNama(txtNamaKategori.Text) )
            {
                try
                {
                    kt.addKategori(txtIdKategori.Text, txtNamaKategori.Text);
                    MessageBox.Show("New Kategori Added ", "Add Kategori ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear.PerformClick();
                    txtIdKategori.Focus();
                    showKategori();

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

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtIdKategori.Clear();
            txtNamaKategori.Clear();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            FormKategori kt = new FormKategori();
            kt.Show();
            this.Hide();
        }
    }
}
