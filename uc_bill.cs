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
    public partial class uc_bill : UserControl
    {
        public uc_bill()
        {
            InitializeComponent();
        }

        private void uc_bill_Load(object sender, EventArgs e)
        {
            Show();
        }
        private void show()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-IPRS3Q12\\SQLEXPRESS;Initial Catalog=flowershop_DB;Integrated Security=True");
            string strSQL = "select Flowers_Type,Quantity,Price,Bouquet_Type,Quantity,Price from Flowers_Order_tb,Bouquet_Order_tb";
            SqlDataAdapter dt = new SqlDataAdapter(strSQL, con);
            DataSet ds = new DataSet();
            dt.Fill(ds, "Flower_Order_tb, Bouquet_Order_tb");
            con.Close();
            dgv_bill.DataSource = ds;
            //dgv_bill.DataBind();
        }
    }
}
