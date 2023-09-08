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
    public partial class uc_Bouquet_Order : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-IPRS3Q12\\SQLEXPRESS;Initial Catalog=flowershop_DB;Integrated Security=True");

        SqlCommand cmd;
        public string id;
        public uc_Bouquet_Order()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into table_b_order values(@Customer_name,@Mobile_no,@Address,@Order_Date,@Delivery_Order_Date,@Bouquet_Type,@Bouquet_Category,@Price,@Quantity,@Total_Price)", con);
                cmd.CommandType = CommandType.Text;
                // cmd.Parameters.AddWithValue("@ProductID", txt_Productid.Text);
                cmd.Parameters.AddWithValue("@Customer_name", txt_Customername.Text);
                //cmd.Parameters.AddWithValue("@Last_Name", txt_Lastname.Text);
                cmd.Parameters.AddWithValue("@Mobile_no", txt_Mobileno.Text);
                cmd.Parameters.AddWithValue("@Address", txt_Address.Text);
                cmd.Parameters.AddWithValue("@Order_Date", dtp_Orderdate.Text);
                cmd.Parameters.AddWithValue("@Delivery_Order_Date", dtp_Delivery_order_date.Text);
                cmd.Parameters.AddWithValue("@Bouquet_Type", cmbox_Bouquet_Type.Text);
                cmd.Parameters.AddWithValue("@Bouquet_Category", cmbox_Bouquet_Category.Text);
                cmd.Parameters.AddWithValue("@Price", txt_Price.Text);
                cmd.Parameters.AddWithValue("@Quantity", txt_Quantity.Text);
                cmd.Parameters.AddWithValue("@Total_Price", txt_Total_Price.Text);

                //cmd.Parameters.AddWithValue("@ProdCat", Catcb.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Save Data Succesfully..", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fetchdetails();
                cleardata();
                con.Close();

            }
        }

        private bool IsValid()
        {
            if (txt_Customername.Text == String.Empty)
            {
                MessageBox.Show("Fill all details is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void cleardata()
        {
            // txt_Productid.Text = "";
            txt_Customername.Text = "";
           // txt_Lastname.Text = "";
            txt_Mobileno.Text = "";
            txt_Address.Text = "";
            dtp_Orderdate.Text = "";
            dtp_Delivery_order_date.Text = "";
            cmbox_Bouquet_Type.Text = "";
            cmbox_Bouquet_Category.Text = "";
            txt_Price.Text = "";
            txt_Quantity.Text = "";
            txt_Total_Price.Text = "";


        }
        private void fetchdetails()
        {
            string Query = string.Format("select Product_ID,Customer_name,Mobile_no,Address,Order_Date,Delivery_Order_Date,Bouquet_Type,Bouquet_Category,Price,Quantity,Total_Price from table_b_order");
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            da.Fill(ds, "temp");
            dataGridView_Bouquet_Order.DataSource = ds;
            dataGridView_Bouquet_Order.DataMember = "temp";

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Update();
            fetchdetails();
            cleardata();
        }
        public void Update()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-IPRS3Q12\\SQLEXPRESS;Initial Catalog=flowershop_DB;Integrated Security=True");
            cmd = new SqlCommand("update table_b_order set Customer_name=@Customer_name,Mobile_no=@Mobile_no,Address=@Address,Order_Date=@Order_Date,Delivery_Order_Date=@Delivery_Order_Date,Bouquet_Type=@Bouquet_Type,Bouquet_Category=@Bouquet_Category,Price=@Price,Quantity=@Quantity,Total_Price=@Total_Price where Product_ID=@Product_ID", con);
            cmd.CommandType = CommandType.Text;
            //cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Product_ID", id);
            cmd.Parameters.AddWithValue("@Customer_name", txt_Customername.Text);
           // cmd.Parameters.AddWithValue("@Last_Name", txt_Lastname.Text);
            cmd.Parameters.AddWithValue("@Mobile_no", txt_Mobileno.Text);
            cmd.Parameters.AddWithValue("@Address", txt_Address.Text);
            cmd.Parameters.AddWithValue("@Order_Date", dtp_Orderdate.Text);
            cmd.Parameters.AddWithValue("@Delivery_Order_Date", dtp_Delivery_order_date.Text);
            cmd.Parameters.AddWithValue("@Bouquet_Type", cmbox_Bouquet_Type.Text);
            cmd.Parameters.AddWithValue("@Bouquet_Category", cmbox_Bouquet_Category.Text);
            cmd.Parameters.AddWithValue("@Price", txt_Price.Text);
            cmd.Parameters.AddWithValue("@Quantity", txt_Quantity.Text);
            cmd.Parameters.AddWithValue("@Total_Price", txt_Total_Price.Text);
            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Data Succesfully..", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fetchdetails();
            con.Close();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            delete();
            fetchdetails();
            cleardata();
        }
        public void delete()
        {
            if (!string.IsNullOrEmpty(id))
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    DataTable dt = new DataTable();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from table_b_order where Product_ID=@Product_ID";
                    cmd.Parameters.AddWithValue("@Product_ID", id);
                    int num = cmd.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("Delete Data Successfully..");
                        cleardata();
                    }
                    else
                    {
                        MessageBox.Show("please select Record");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select Record");
            }
        }

        private void dataGridView_Bouquet_Order_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView_Bouquet_Order.Rows[e.RowIndex].Cells["Product_Id"].Value.ToString();
            txt_Customername.Text = dataGridView_Bouquet_Order.Rows[e.RowIndex].Cells["Customer_name"].Value.ToString();
           // txt_Lastname.Text = dataGridView_Bouquet_Order.Rows[e.RowIndex].Cells["Last_Name"].Value.ToString();
            txt_Mobileno.Text = dataGridView_Bouquet_Order.Rows[e.RowIndex].Cells["Mobile_no"].Value.ToString();
            txt_Address.Text = dataGridView_Bouquet_Order.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            dtp_Orderdate.Text = dataGridView_Bouquet_Order.Rows[e.RowIndex].Cells["Order_Date"].Value.ToString();
            dtp_Delivery_order_date.Text = dataGridView_Bouquet_Order.Rows[e.RowIndex].Cells["Delivery_Order_Date"].Value.ToString();
            cmbox_Bouquet_Type.Text = dataGridView_Bouquet_Order.Rows[e.RowIndex].Cells["Bouquet_Type"].Value.ToString();
            cmbox_Bouquet_Category.Text = dataGridView_Bouquet_Order.Rows[e.RowIndex].Cells["Bouquet_Category"].Value.ToString();
            txt_Price.Text = dataGridView_Bouquet_Order.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            txt_Quantity.Text = dataGridView_Bouquet_Order.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            txt_Total_Price.Text = dataGridView_Bouquet_Order.Rows[e.RowIndex].Cells["Total_Price"].Value.ToString();
        }

        private void cmbox_Bouquet_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbox_Bouquet_Type.SelectedItem.ToString() == "Round Bouquet")
            {
                txt_Price.Text = "400";
            }
            else if (cmbox_Bouquet_Type.SelectedItem.ToString() == "Basket Bouquet")
            {
                txt_Price.Text = "350";
            }
            else if (cmbox_Bouquet_Type.SelectedItem.ToString() == "Standing Bouquet")
            {
                txt_Price.Text = "500";
            }
            else if (cmbox_Bouquet_Type.SelectedItem.ToString() == "Possy Bouquet")
            {
                txt_Price.Text = "550";
            }
            else if (cmbox_Bouquet_Type.SelectedItem.ToString() == "Hoop Bouquet")
            {
                txt_Price.Text = "450";
            }
            else if (cmbox_Bouquet_Type.SelectedItem.ToString() == "Hand Bouquet")
            {
                txt_Price.Text = "550";
            }
            else if (cmbox_Bouquet_Type.SelectedItem.ToString() == "Multi flower Bouquet")
            {
                txt_Price.Text = "600";
            }
            else if (cmbox_Bouquet_Type.SelectedItem.ToString() == "Tulip flower Bouquet")
            {
                txt_Price.Text = "500";
            }
            
            else
            {
                txt_Price.Text = "0";
            }
        }

        private void txt_Quantity_TextChanged(object sender, EventArgs e)
        {
            if (txt_Quantity.Text.Length > 0)
            {
                txt_Total_Price.Text = (Convert.ToInt16(txt_Price.Text) * Convert.ToInt16(txt_Quantity.Text)).ToString();
            }
        }

        private void txt_Mobileno_TextChanged(object sender, EventArgs e)
        {
            if (txt_Mobileno.Text.Length > 10)
            {
                MessageBox.Show("Invalid Mobile Number..");
                txt_Mobileno.Focus();
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_Mobileno.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers...");
                txt_Mobileno.Text = txt_Mobileno.Text.Remove(txt_Mobileno.Text.Length - 1);
            }
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            uc_Home hc = new uc_Home();
            hc.Dock = DockStyle.Fill;
            this.Controls.Add(hc);
            hc.Visible = true;
            hc.BringToFront();
        }

        private void uc_Bouquet_Order_Load(object sender, EventArgs e)
        {
            fetchdetails();
        }

        private void txt_Customername_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_Customername.Text, "[a-zA-Z]"))          //code for character validation
            {
                MessageBox.Show("Please enter only characters...");
                txt_Customername.Text.Remove(txt_Customername.Text.Length - 0);
            }
        }

        private void txt_Address_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_Address.Text, "[a-zA-Z]"))          //code for character validation
            {
                MessageBox.Show("Please enter only characters...");
                txt_Address.Text.Remove(txt_Address.Text.Length - 0);
            }
        }
    }
    }

