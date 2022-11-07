using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dashboard
{

    public partial class login : Form
    {
        readonly string Username = "bayy";
        readonly string Password = "bysetia.my.id";
        public login()
        {
            InitializeComponent();
            
        }

        private void login_Load(object sender, EventArgs e)
        {
            tb_password.UseSystemPasswordChar = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == Username && tb_password.Text == Password)
            {
               // MessageBox.Show("Kamu berhasil login");
                Dashboard db = new Dashboard();
                db.Show();
                this.Hide();
            }
            else if (tb_username.Text == "" || tb_password.Text == "")
            {
                MessageBox.Show("Kamu belum mengisi form login");
            }
            else
            {
                MessageBox.Show("Username atau Password Salah ");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tb_password.UseSystemPasswordChar = false;
            }
            else
            {
                tb_password.UseSystemPasswordChar = true;
            }
        }

        private void login_DpiChangedBeforeParent(object sender, EventArgs e)
        {

        }
    }
}
