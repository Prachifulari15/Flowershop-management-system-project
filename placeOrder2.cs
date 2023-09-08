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
    public partial class placeOrder2 : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-IPRS3Q12\\SQLEXPRESS;Initial Catalog=flowershop_DB;Integrated Security=True");

        SqlCommand cmd;
        public string id;
        public placeOrder2()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Placeorder_table values(@First Name,@Last Name,@Mobile no,@Address,@Order Date,@Delivery Order Date,@Flowers,@Quantity_Flowers,@Bouquet,@Quantity_Bouquet,@Others,@Quantity_Others,@Price,@Total Price)", con);
                cmd.CommandType = CommandType.Text;
                // cmd.Parameters.AddWithValue("@ProductID", txt_Productid.Text);
                cmd.Parameters.AddWithValue("@First Name", txt_Firstname.Text);
                cmd.Parameters.AddWithValue("@Last Name", txt_Lastname.Text);
                cmd.Parameters.AddWithValue("@Mobile No", txt_Mobileno.Text);
                cmd.Parameters.AddWithValue("@Address", txt_Address.Text);
                cmd.Parameters.AddWithValue("@Order Date", dtp_Orderdate.Text);
                cmd.Parameters.AddWithValue("@Delivery Order Date", dtp_Delivery_order_date.Text);
                cmd.Parameters.AddWithValue("@Flowers", cmbox_Flowers.Text);
                cmd.Parameters.AddWithValue("@Quantity_Flowers", numUD_Quantity_flower.Text);
                cmd.Parameters.AddWithValue("@Bouquet", cmbox_Bouquet.Text);
                cmd.Parameters.AddWithValue("@Quantity Bouquet", numUD_Quantity_bouquet.Text);
                cmd.Parameters.AddWithValue("@Others", cmbox_Others.Text);
                cmd.Parameters.AddWithValue("@Quantity_Others", numUD_Quantity_others.Text);
                cmd.Parameters.AddWithValue("@Price", txt_Price.Text);
                cmd.Parameters.AddWithValue("@Total Price", txt_Totalprice.Text);
                //cmd.Parameters.AddWithValue("@ProdCat", Catcb.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("New record saved in database succesfully", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fetchdetails();
                cleardata();
                con.Close();

            }
        }
        private bool IsValid()
        {
            if (txt_Firstname.Text == String.Empty)
            {
                MessageBox.Show("Product ID is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void cleardata()
        {
            // txt_Productid.Text = "";
            txt_Firstname.Text = "";
            txt_Lastname.Text = "";
            txt_Mobileno.Text = "";
            txt_Address.Text = "";
            dtp_Orderdate.Text = "";
            dtp_Delivery_order_date.Text = "";
            cmbox_Flowers.Text = "";
            numUD_Quantity_flower.Text = "";
            cmbox_Bouquet.Text = "";
            numUD_Quantity_bouquet.Text = "";
            cmbox_Others.Text = "";
            numUD_Quantity_others.Text = "";
            numUD_Quantity_flower.Text = "";
            txt_Price.Text = "";
            txt_Totalprice.Text = "";

        }
        private void fetchdetails()
        {
            string Query = string.Format("select ProductID,ItemCategory,ItemName,Price from table_additems");
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            da.Fill(ds, "temp");
            dataGridView_Placeorder.DataSource = ds;
            dataGridView_Placeorder.DataMember = "temp";

        }

        private void dataGridView_Placeorder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView_Placeorder.Rows[e.RowIndex].Cells["Product ID"].Value.ToString();
            txt_Firstname.Text = dataGridView_Placeorder.Rows[e.RowIndex].Cells["First Name"].Value.ToString();
            txt_Lastname.Text = dataGridView_Placeorder.Rows[e.RowIndex].Cells["Last Name"].Value.ToString();
            txt_Mobileno.Text = dataGridView_Placeorder.Rows[e.RowIndex].Cells["Mobile No"].Value.ToString();
            txt_Address.Text = dataGridView_Placeorder.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            dtp_Orderdate.Text = dataGridView_Placeorder.Rows[e.RowIndex].Cells["Order Date"].Value.ToString();
            dtp_Delivery_order_date.Text = dataGridView_Placeorder.Rows[e.RowIndex].Cells["Delivery Order Date"].Value.ToString();
            cmbox_Flowers.Text = dataGridView_Placeorder.Rows[e.RowIndex].Cells["Flowers"].Value.ToString();
            numUD_Quantity_flower.Text = dataGridView_Placeorder.Rows[e.RowIndex].Cells["Quantity_Flowers"].Value.ToString();
            cmbox_Bouquet.Text = dataGridView_Placeorder.Rows[e.RowIndex].Cells["Bouquet"].Value.ToString();
            numUD_Quantity_bouquet.Text = dataGridView_Placeorder.Rows[e.RowIndex].Cells["Quantity_Bouquet"].Value.ToString();
            cmbox_Others.Text = dataGridView_Placeorder.Rows[e.RowIndex].Cells["Others"].Value.ToString();
            numUD_Quantity_others.Text = dataGridView_Placeorder.Rows[e.RowIndex].Cells["Quantity_Others"].Value.ToString();
            txt_Price.Text = dataGridView_Placeorder.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            txt_Totalprice.Text = dataGridView_Placeorder.Rows[e.RowIndex].Cells["Total Price"].Value.ToString();
        }

        private void btn_Payment_Click(object sender, EventArgs e)
        {
            uc_Payment py = new uc_Payment();
            py.Dock = DockStyle.Fill;
            this.Controls.Add(py);
            py.Visible = true;
            py.BringToFront();
        }
    }
    }

