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
    public partial class uc_fbo : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-IPRS3Q12\\SQLEXPRESS;Initial Catalog=flowershop_DB;Integrated Security=True");

        SqlCommand cmd;
        public string id;
        public uc_fbo()
        {
            InitializeComponent();
        }

        private void uc_fbo_Load(object sender, EventArgs e)
        {

        }

        private void radiobtn_Flowers_CheckedChanged(object sender, EventArgs e)
        {
            radiobtn_Flowers.ForeColor = System.Drawing.Color.Green;
            radiobtn_Bouquet.ForeColor = System.Drawing.Color.Red;

            cmbox_Select_Item.Items.Clear();
            cmbox_Select_Item.Items.Add("Rose");
            cmbox_Select_Item.Items.Add("Lotus");
        }

        private void radiobtn_Bouquet_CheckedChanged(object sender, EventArgs e)
        {
            radiobtn_Flowers.ForeColor = System.Drawing.Color.Green;
            radiobtn_Bouquet.ForeColor = System.Drawing.Color.Red;

            cmbox_Select_Item.Items.Clear();
            cmbox_Select_Item.Items.Add("Round Bouquet");
            cmbox_Select_Item.Items.Add("Hand Bouquet");
        }

        private void cmbox_Select_Item_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbox_Select_Item.SelectedItem.ToString() == "Rose")
            {
                txt_Price.Text = "10";
            }
            else if (cmbox_Select_Item.SelectedItem.ToString() == "Lotus")
            {
                txt_Price.Text = "20";
            }
            else if (cmbox_Select_Item.SelectedItem.ToString() == "Round Bouquet")
            {
                txt_Price.Text = "400";
            }
            else if (cmbox_Select_Item.SelectedItem.ToString() == "Hand Bouquet")
            {
                txt_Price.Text = "450";
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
                txt_Total.Text = (Convert.ToInt16(txt_Price.Text) * Convert.ToInt16(txt_Quantity.Text)).ToString();
            }
            //txt_Total.Text = (Convert.ToInt16(txt_Price.Text) * Convert.ToInt16(txt_Quantity.Text)).ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into table_PlaceOrder_fb values(@Customer_Name,@Mobile_No,@Address,@Order_Date,@Delivery_Order_Date,@Item_Name,@Price,@Quantity,@Total)", con);
                cmd.CommandType = CommandType.Text;
                // cmd.Parameters.AddWithValue("@ProductID", txt_Productid.Text);
                cmd.Parameters.AddWithValue("@Customer_Name", txt_Customer_Name.Text);
                //cmd.Parameters.AddWithValue("@Last_Name", txt_Lastname.Text);
                cmd.Parameters.AddWithValue("@Mobile_No", txt_Mobileno.Text);
                cmd.Parameters.AddWithValue("@Address", txt_Address.Text);
                cmd.Parameters.AddWithValue("@Order_Date", dtp_Orderdate.Text);
                cmd.Parameters.AddWithValue("@Delivery_Order_Date", dtp_Delivery_order_date.Text);
                cmd.Parameters.AddWithValue("@Item_Name", cmbox_Select_Item.Text);
                cmd.Parameters.AddWithValue("@Price", txt_Price.Text);
                cmd.Parameters.AddWithValue("@Quantity", txt_Quantity.Text);
                cmd.Parameters.AddWithValue("@Total", txt_Total.Text);

                //cmd.Parameters.AddWithValue("@ProdCat", Catcb.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Save Data succesfully...", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fetchdetails();
                cleardata();
                con.Close();

            }
        }

        private bool IsValid()
        {
            if (txt_Customer_Name.Text == String.Empty)
            {
                MessageBox.Show("First Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void cleardata()
        {
            // txt_Productid.Text = "";
            txt_Customer_Name.Text = "";
            //txt_Lastname.Text = "";
            txt_Mobileno.Text = "";
            txt_Address.Text = "";
            dtp_Orderdate.Text = "";
            dtp_Delivery_order_date.Text = "";
            cmbox_Select_Item.Text = "";
            txt_Price.Text = "";
            txt_Quantity.Text = "";
            txt_Total.Text = "";


        }
        private void fetchdetails()
        {
            string Query = string.Format("select Product_ID,Customer_Name,Mobile_No,Address,Order_Date,Delivery_Order_Date,Item_Name,Price,Quantity,Total from table_PlaceOrder_fb");
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            da.Fill(ds, "temp");
            dataGridView_fbo.DataSource = ds;
            dataGridView_fbo.DataMember = "temp";

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
            cmd = new SqlCommand("update table_PlaceOrder_fb set Customer_Name=@Customer_Name,Mobile_No=@Mobile_No,Address=@Address,Order_Date=@Order_Date,Delivery_Order_Date=@Delivery_Order_Date,Item_Name=@Item_Name,Price=@Price,Quantity=@Quantity,Total=@Total where Product_ID=@Product_ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Product_ID", id);
            cmd.Parameters.AddWithValue("@Customer_Name", txt_Customer_Name.Text);
            //cmd.Parameters.AddWithValue("@Last_Name", txt_Lastname.Text);
            cmd.Parameters.AddWithValue("@Mobile_No", txt_Mobileno.Text);
            cmd.Parameters.AddWithValue("@Address", txt_Address.Text);
            cmd.Parameters.AddWithValue("@Order_Date", dtp_Orderdate.Text);
            cmd.Parameters.AddWithValue("@Delivery_Order_Date", dtp_Delivery_order_date.Text);
            cmd.Parameters.AddWithValue("@Item_Name", cmbox_Select_Item.Text);
            cmd.Parameters.AddWithValue("@Price", txt_Price.Text);
            cmd.Parameters.AddWithValue("@Quantity",txt_Quantity.Text);
            cmd.Parameters.AddWithValue("@Total", txt_Total.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New record Update in database succesfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmd.CommandText = "delete from table_PlaceOrder_fb where Product_ID=@Product_ID";
                    cmd.Parameters.AddWithValue("@Product_ID", id);
                    int num = cmd.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("Delete data successfully");
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

       /* private void numup_qty_ValueChanged(object sender, EventArgs e)
        {
            if (numup_qty.Text.Length > 0)
            {
                txt_Total.Text = (Convert.ToInt16(txt_Price.Text) * Convert.ToInt16(txt_Quantity.Text)).ToString();
            }
        }*/

        /*private void numUD_Quantity_ValueChanged(object sender, EventArgs e)
        {
            txt_Total.Text = Convert.ToInt16(txt_Price.Text) * Convert.ToInt16(numUD_Quantity.).ToString();
        }*/
    }
}
