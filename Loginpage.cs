using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace flowershop
{
    public partial class Loginpage : Form
    {
        public Loginpage()
        {
            InitializeComponent();
        }
        

        /*private void lnk_ShowHidepass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnk_ShowHidepass.Text == "Show")
            {
                lnk_ShowHidepass.Text = "Hide";
                txt_Password.PasswordChar = '\0';
            }
            else
            {
                lnk_ShowHidepass.Text = "Show";
                txt_Password.PasswordChar = '*';
            }
        }*/

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "User" && txt_Password.Text == "imrd")
            {
                Homepage hm = new Homepage();
                hm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter valid Username & Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            if(txt_Password.PasswordChar=='*')
            {
                btn_Hide.BringToFront();
                txt_Password.PasswordChar = '\0';
            }
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            if (txt_Password.PasswordChar == '\0')
            {
                btn_Hide.BringToFront();
                txt_Password.PasswordChar = '*';
            }
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}