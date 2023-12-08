using FashionFusion.Controller;
using FashionFusion.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FashionFusion
{
    public partial class FormSignIn : Form
    {
        Admin admin = new Admin();
        Welcome wl = new Welcome();
        public FormSignIn()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            txtPasswoard.PasswordChar = '*';
      
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if ((txtAdmin.Text == "") || (txtPasswoard.Text == ""))
            {
                MessageBox.Show("Need login data ", "wrong login ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = txtAdmin.Text;
                string pass = txtPasswoard.Text;
            
                DataTable table = admin.getlist(new MySqlConnector.MySqlCommand
                    ("SELECT * FROM admin WHERE admin = '" + name + "' AND passwoard = '" + pass + "'"));
                if (table.Rows.Count > 0)
                {
                    AppSession.SetLoggedInUser(name);
                    FormBeranda fb = new FormBeranda();
                    fb.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("your admin and passwoard are not exist", "wrong login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            FormSignUp sg = new FormSignUp();
            sg.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        { 

            if (MessageBox.Show("Exit or not", "exit confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                
            }
            else
            {
               
                Application.Exit();
            }

        }

        private void pictureBoxBuka_Click(object sender, EventArgs e)
        {
            if (pictureBoxBuka.Visible == true)
            {
                
                pictureBoxBuka.Visible = false;
                pictureBoxTutup.Visible = true;
                txtPasswoard.UseSystemPasswordChar = false;
            }
        }



        private void pictureBoxTutup_Click(object sender, EventArgs e)
        {
            if (pictureBoxTutup.Visible == true)
            {
                
                pictureBoxTutup.Visible = false;
                pictureBoxBuka.Visible = true;
                txtPasswoard.UseSystemPasswordChar = true; 
            }
        }

        private void txtPasswoard_TextChanged_1(object sender, EventArgs e)
        {
            txtPasswoard.PasswordChar = '*';
        }
    }
    public static class AppSession
    {
        public static string LoggedInUser { get; private set; }

        public static void SetLoggedInUser(string username)
        {
            LoggedInUser = username;
        }
    }

}
