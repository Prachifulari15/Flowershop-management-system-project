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

namespace flowershop
{
    public partial class uc_Decoration_Report : UserControl
    {
        public uc_Decoration_Report()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-IPRS3Q12\\SQLEXPRESS;Initial Catalog=flowershop_DB;Integrated Security=True");

        SqlCommand cmd;
        public string id;

        private void btn_Load_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sdf = new SqlDataAdapter("select * from table_dec_order where Delivery_Order_Date between'" + dtp_From.Value.ToString("yyyy-MM-dd") + "' and '" + dtp_to.Value.ToString("yyyy-MM-dd") + "'", con);
            DataTable sd = new DataTable();
            sdf.Fill(sd);
            dataGridView_Decoration_Report.DataSource = sd;
        }
    }
}
