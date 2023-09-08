using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace flowershop
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            p1.Height = btn_Home.Height;
            p1.Top = btn_Home.Top;   // code for moving sidepanel
            
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
               

                uc_Home hp = new uc_Home();
                this.Controls.Add(hp);
                hp.Dock = DockStyle.Fill;
                this.Controls.Add(hp);
                hp.Visible = true;
                hp.BringToFront();


                p1.Height = btn_Home.Height;    // code for moving sidepanel
                p1.Top = btn_Home.Top;

        }

        private void btn_Flowers_Click(object sender, EventArgs e)
        {


            //uc_Flowers fc = new uc_Flowers();
            //fc.Dock = DockStyle.Fill;
            //this.Controls.Add(fc);
            uc_Flowers bs = new uc_Flowers();
            this.Controls.Add(bs);
            bs.Dock = DockStyle.Fill;
            bs.Visible = true;
            bs.BringToFront();
            

            p1.Height = btn_Flowers.Height;    // code for moving sidepanel
            p1.Top = btn_Flowers.Top;

            //uc_Flowers bs = new uc_Flowers();
            //this.Controls.Add(bs);
            //bs.Dock = DockStyle.Fill;
           

          

        }

        private void btn_Bouquet_Click(object sender, EventArgs e)
        {
            
            uc_Bouquet bc = new uc_Bouquet();
            bc.Dock = DockStyle.Fill;
            this.Controls.Add(bc);
            bc.Visible = true;
            bc.BringToFront();
            p1.Height = btn_Bouquet.Height;    // code for moving sidepanel
            p1.Top = btn_Bouquet.Top;
        }

        private void btn_Decoration_Click(object sender, EventArgs e)
        {
            
            uc_Decoration dc = new uc_Decoration();
            dc.Dock = DockStyle.Fill;
            this.Controls.Add(dc);
            dc.Visible = true;
            dc.BringToFront();

            p1.Height = btn_Decoration.Height;     // code for moving sidepanel
            p1.Top = btn_Decoration.Top;
        }

        /*private void btn_Placeorder_Click(object sender, EventArgs e)
        {
            
            uc_fbo PO = new uc_fbo();
            PO.Dock = DockStyle.Fill;
            this.Controls.Add(PO);
            PO.Visible = true;
            PO.BringToFront();


            p1.Height = btn_Placeorder.Height;    // code for moving sidepanel
            p1.Top = btn_Placeorder.Top;
        }*/

       /* private void btn_AddItems_Click(object sender, EventArgs e)
        {
            
            uc_Additems ac = new uc_Additems();
            ac.Dock = DockStyle.Fill;
            this.Controls.Add(ac);
            ac.Visible = true;
            ac.BringToFront();

            p1.Height = btn_AddItems.Height;      // code for moving sidepanel
            p1.Top = btn_AddItems.Top;
        }*/

        private void btn_Aboutus_Click(object sender, EventArgs e)
        {
            
            uc_Aboutus bc = new uc_Aboutus();
            bc.Dock = DockStyle.Fill;
            this.Controls.Add(bc);
            bc.Visible = true;
            bc.BringToFront();

            p1.Height = btn_Aboutus.Height;      // code for moving sidepanel
            p1.Top = btn_Aboutus.Top;
        }

        private void btn_Contactus_Click(object sender, EventArgs e)
        {
            
            uc_Contactus cc = new uc_Contactus();
            cc.Dock = DockStyle.Fill;
            this.Controls.Add(cc);
            cc.Visible = true;
            cc.BringToFront();

            p1.Height = btn_Contactus.Height;     // code for moving sidepanel
            p1.Top = btn_Contactus.Top;
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Loginpage lp = new Loginpage();
            lp.Show();
            this.Hide();
        }

        private void Homepage_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_Billing_Click(object sender, EventArgs e)
        {
            uc_Billing bb = new uc_Billing();
            bb.Dock = DockStyle.Fill;
            this.Controls.Add(bb);
            bb.Visible = true;
            bb.BringToFront();

            p1.Height = btn_Billing.Height;     // code for moving sidepanel
            p1.Top = btn_Billing.Top;
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            Report re = new Report();
            re.Show();

            p1.Height = btn_Report.Height;     // code for moving sidepanel
            p1.Top = btn_Report.Top;
        }

        private void uc_Home3_Load(object sender, EventArgs e)
        {

        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            uc_stock ss = new uc_stock();
            ss.Dock = DockStyle.Fill;
            this.Controls.Add(ss);
            ss.Visible = true;
            ss.BringToFront();

            p1.Height = btn_Stock.Height;     // code for moving sidepanel
            p1.Top = btn_Stock.Top;
        }

        /*private void btn_AddItems_Click(object sender, EventArgs e)
        {

        }*/


        /*private void btn_Billing_Click(object sender, EventArgs e)
        {
            uc_Billing bb = new uc_Billing();
            bb.Dock = DockStyle.Fill;
            this.Controls.Add(bb);
            bb.Visible = true;
            bb.BringToFront();

            p1.Height = btn_Billing.Height;     // code for moving sidepanel
            p1.Top = btn_Billing.Top;
        }*/
    }
    }

