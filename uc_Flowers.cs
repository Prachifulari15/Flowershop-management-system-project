using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flowershop
{
    public partial class uc_Flowers : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-IPRS3Q12\\SQLEXPRESS;Initial Catalog=flowershop_DB;Integrated Security=True");

        public uc_Flowers()
        {
            InitializeComponent();
        }

        private void btn_Placeorder_rose_Click(object sender, EventArgs e)
        {
            uc_Flowers_Order fo = new uc_Flowers_Order();
            fo.Dock = DockStyle.Fill;
            this.Controls.Add(fo);
            fo.Visible = true;
            fo.BringToFront();

            
        }

        private void btn_Placeorder_lotus_Click(object sender, EventArgs e)
        {
            uc_Flowers_Order fo = new uc_Flowers_Order();
            fo.Dock = DockStyle.Fill;
            this.Controls.Add(fo);
            fo.Visible = true;
            fo.BringToFront();
        }

        private void btn_Placeorder_hibiscus_Click(object sender, EventArgs e)
        {
            uc_Flowers_Order fo = new uc_Flowers_Order();
            fo.Dock = DockStyle.Fill;
            this.Controls.Add(fo);
            fo.Visible = true;
            fo.BringToFront();
        }

        private void btn_Placeorder_orchids_Click(object sender, EventArgs e)
        {
            uc_Flowers_Order fo = new uc_Flowers_Order();
            fo.Dock = DockStyle.Fill;
            this.Controls.Add(fo);
            fo.Visible = true;
            fo.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            uc_Flowers_Order fo = new uc_Flowers_Order();
            fo.Dock = DockStyle.Fill;
            this.Controls.Add(fo);
            fo.Visible = true;
            fo.BringToFront();
        }

        private void btn_Placeorder_chryasanthemum_Click(object sender, EventArgs e)
        {
            uc_Flowers_Order fo = new uc_Flowers_Order();
            fo.Dock = DockStyle.Fill;
            this.Controls.Add(fo);
            fo.Visible = true;
            fo.BringToFront();
        }

        private void btn_Placeorder_marigold_Click(object sender, EventArgs e)
        {
            uc_Flowers_Order fo = new uc_Flowers_Order();
            fo.Dock = DockStyle.Fill;
            this.Controls.Add(fo);
            fo.Visible = true;
            fo.BringToFront();
        }

        private void btn_Placeorder_gerbera_Click(object sender, EventArgs e)
        {
            uc_Flowers_Order fo = new uc_Flowers_Order();
            fo.Dock = DockStyle.Fill;
            this.Controls.Add(fo);
            fo.Visible = true;
            fo.BringToFront();
        }

        private void btn_Placeorder_mogra_Click(object sender, EventArgs e)
        {
            uc_Flowers_Order fo = new uc_Flowers_Order();
            fo.Dock = DockStyle.Fill;
            this.Controls.Add(fo);
            fo.Visible = true;
            fo.BringToFront();
        }

        private void btn_Placeorder_aster_Click(object sender, EventArgs e)
        {
            uc_Flowers_Order fo = new uc_Flowers_Order();
            fo.Dock = DockStyle.Fill;
            this.Controls.Add(fo);
            fo.Visible = true;
            fo.BringToFront();
        }
    }
}
