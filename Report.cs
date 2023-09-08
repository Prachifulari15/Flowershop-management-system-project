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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void btn_Flowers_Report_Click(object sender, EventArgs e)
        {
            uc_Flower_Report fr = new uc_Flower_Report();
            fr.Dock = DockStyle.Fill;
            this.Controls.Add(fr);
            fr.Visible = true;
            fr.BringToFront();

            p1.Height = btn_Flowers_Report.Height;     // code for moving sidepanel
            p1.Top = btn_Flowers_Report.Top;
        }

        private void btn_Bouquet_Report_Click(object sender, EventArgs e)
        {
            uc_Bouquet_Report br = new uc_Bouquet_Report();
            br.Dock = DockStyle.Fill;
            this.Controls.Add(br);
            br.Visible = true;
            br.BringToFront();

            p1.Height = btn_Bouquet_Report.Height;     // code for moving sidepanel
            p1.Top = btn_Bouquet_Report.Top;
        }

        private void btn_Decoration_Report_Click(object sender, EventArgs e)
        {
            uc_Decoration_Report dr = new uc_Decoration_Report();
            dr.Dock = DockStyle.Fill;
            this.Controls.Add(dr);
            dr.Visible = true;
            dr.BringToFront();

            p1.Height = btn_Decoration_Report.Height;     // code for moving sidepanel
            p1.Top = btn_Decoration_Report.Top;
        }

       /* private void p1_Paint(object sender, PaintEventArgs e)
        {

        }*/
    }
}
