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
    public partial class FormSignUp : Form
    {
        Validasi val = new Validasi();
        public FormSignUp()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {
            txtId.MaxLength = 6;
            txtAdmin.MaxLength = 35;
            txtPasswoard.MaxLength = 8;
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            if (val.ValId(txtId.Text) && val.valAdmin(txtAdmin.Text) && val.ValPassword(txtPasswoard.Text))
            {
                try
                {
                    admin.tambahAdmin(txtId.Text, txtAdmin.Text, txtPasswoard.Text);

                    MessageBox.Show("New Admin Added ", "Add Admin ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtId.Focus();
                    FormSignIn fr = new FormSignIn();
                    fr.Show();
                    this.Hide();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormSignIn sg = new FormSignIn();
            sg.Show();
            this.Hide();
        }
    }
}
