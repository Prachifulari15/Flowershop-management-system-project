using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flowershop
{
    public partial class uc_Bouquet : UserControl
    {
        public uc_Bouquet()
        {
            InitializeComponent();
        }

        private void btn_Placeorder_round_bouquet_Click(object sender, EventArgs e)
        {
            uc_Bouquet_Order bq = new uc_Bouquet_Order();
            bq.Dock = DockStyle.Fill;
            this.Controls.Add(bq);
            bq.Visible = true;
            bq.BringToFront();
        }

        private void btn_Placeorder_basket_bouquet_Click(object sender, EventArgs e)
        {
            uc_Bouquet_Order bq = new uc_Bouquet_Order();
            bq.Dock = DockStyle.Fill;
            this.Controls.Add(bq);
            bq.Visible = true;
            bq.BringToFront();
        }

        private void btn_Placeorder_standing_bouquet_Click(object sender, EventArgs e)
        {
            uc_Bouquet_Order bq = new uc_Bouquet_Order();
            bq.Dock = DockStyle.Fill;
            this.Controls.Add(bq);
            bq.Visible = true;
            bq.BringToFront();
        }

        private void btn_Placeorder_possy_bouquet_Click(object sender, EventArgs e)
        {
            uc_Bouquet_Order bq = new uc_Bouquet_Order();
            bq.Dock = DockStyle.Fill;
            this.Controls.Add(bq);
            bq.Visible = true;
            bq.BringToFront();
        }

        private void btn_Placeorder_hoop_bouquet_Click(object sender, EventArgs e)
        {
            uc_Bouquet_Order bq = new uc_Bouquet_Order();
            bq.Dock = DockStyle.Fill;
            this.Controls.Add(bq);
            bq.Visible = true;
            bq.BringToFront();
        }

        private void btn_Placeorder_hand_bouquet_Click(object sender, EventArgs e)
        {
            uc_Bouquet_Order bq = new uc_Bouquet_Order();
            bq.Dock = DockStyle.Fill;
            this.Controls.Add(bq);
            bq.Visible = true;
            bq.BringToFront();
        }

        private void btn_Placeorder_multiflower_bouquet_Click(object sender, EventArgs e)
        {
            uc_Bouquet_Order bq = new uc_Bouquet_Order();
            bq.Dock = DockStyle.Fill;
            this.Controls.Add(bq);
            bq.Visible = true;
            bq.BringToFront();
        }

        private void btn_Placeorder_tulipflower_bouquet_Click(object sender, EventArgs e)
        {
            uc_Bouquet_Order bq = new uc_Bouquet_Order();
            bq.Dock = DockStyle.Fill;
            this.Controls.Add(bq);
            bq.Visible = true;
            bq.BringToFront();
        }
    }
}
