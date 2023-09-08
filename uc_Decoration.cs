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
    public partial class uc_Decoration : UserControl
    {
        public uc_Decoration()
        {
            InitializeComponent();
        }

       /* {
            uc_Decoration_Placeorder dp = new uc_Decoration_Placeorder();
            dp.Dock = DockStyle.Fill;
            this.Controls.Add(dp);
            dp.Visible = true;
            dp.BringToFront();
        }*/

        private void btn_Placeorder_house_decoration_Click(object sender, EventArgs e)
        {
            uc_Decoration_Placeorder dp = new uc_Decoration_Placeorder();
            dp.Dock = DockStyle.Fill;
            this.Controls.Add(dp);
            dp.Visible = true;
            dp.BringToFront();
        }

        private void btn_Placeorder_birthday_decoration_Click(object sender, EventArgs e)
        {
            uc_Decoration_Placeorder dp = new uc_Decoration_Placeorder();
            dp.Dock = DockStyle.Fill;
            this.Controls.Add(dp);
            dp.Visible = true;
            dp.BringToFront();
        }

        private void btn_Placeorder_house_decoration_Click_1(object sender, EventArgs e)
        {
            uc_Decoration_Placeorder dp = new uc_Decoration_Placeorder();
            dp.Dock = DockStyle.Fill;
            this.Controls.Add(dp);
            dp.Visible = true;
            dp.BringToFront();
        }

        private void btn_Placeorder_engagement_decoration_Click(object sender, EventArgs e)
        {
            uc_Decoration_Placeorder dp = new uc_Decoration_Placeorder();
            dp.Dock = DockStyle.Fill;
            this.Controls.Add(dp);
            dp.Visible = true;
            dp.BringToFront();
        }

        private void btn_Placeorder_wedding_decoration_Click(object sender, EventArgs e)
        {
            uc_Decoration_Placeorder dp = new uc_Decoration_Placeorder();
            dp.Dock = DockStyle.Fill;
            this.Controls.Add(dp);
            dp.Visible = true;
            dp.BringToFront();
        }

        private void btn_Placeorder_car_decoration_Click(object sender, EventArgs e)
        {
            uc_Decoration_Placeorder dp = new uc_Decoration_Placeorder();
            dp.Dock = DockStyle.Fill;
            this.Controls.Add(dp);
            dp.Visible = true;
            dp.BringToFront();
        }

        private void btn_Placeorder_temple_decoration_Click(object sender, EventArgs e)
        {
            uc_Decoration_Placeorder dp = new uc_Decoration_Placeorder();
            dp.Dock = DockStyle.Fill;
            this.Controls.Add(dp);
            dp.Visible = true;
            dp.BringToFront();
        }

        private void btn_Placeorder_wedding_varmala_Click(object sender, EventArgs e)
        {
            uc_Decoration_Placeorder dp = new uc_Decoration_Placeorder();
            dp.Dock = DockStyle.Fill;
            this.Controls.Add(dp);
            dp.Visible = true;
            dp.BringToFront();
        }

        private void btn_Placeorder_flower_jewellery_Click(object sender, EventArgs e)
        {
            uc_Decoration_Placeorder dp = new uc_Decoration_Placeorder();
            dp.Dock = DockStyle.Fill;
            this.Controls.Add(dp);
            dp.Visible = true;
            dp.BringToFront();
        }
    }
}
