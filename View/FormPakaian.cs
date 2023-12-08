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
    public partial class FormPakaian : Form
    {
        private Pakaian pakaian = new Pakaian();
        public FormPakaian()
        {
            InitializeComponent();
            showPakaian();
            this.DoubleBuffered = true;
        }

        private void FormPakaian_Load(object sender, EventArgs e)
        {

        }
       

        public void showPakaian()
        {
            dtPakaian.DataSource = pakaian.showPakaian();
            dtPakaian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            FormBeranda br = new FormBeranda();
            br.Show();
            this.Hide();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            FormPakaianAdd pk = new FormPakaianAdd();
            pk.Show();
            this.Hide();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            FormPakaianUpdate pk = new FormPakaianUpdate();
            pk.Show();
            this.Hide();

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            FormPakaianDelete pk = new FormPakaianDelete();
            pk.Show();
            this.Hide();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            dtPakaian.DataSource = pakaian.Search(txtSearch.Text);
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            dtPakaian.DataSource = pakaian.Search(txtSearch.Text);
        }
    }
}
