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
    public partial class uc_Decoration_Placeorder : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-IPRS3Q12\\SQLEXPRESS;Initial Catalog=flowershop_DB;Integrated Security=True");
        SqlCommand cmd;
        public string id;
        public uc_Decoration_Placeorder()
        {
            InitializeComponent();
        }
        
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into table_dec_order values(@Customer_name,@Mobile_no,@Address,@Order_Date,@Delivery_Order_Date,@Types_of_Decoration,@Decoration_Category,@Size_of_place,@Total)", con);
                cmd.CommandType = CommandType.Text;
                // cmd.Parameters.AddWithValue("@ProductID", txt_Productid.Text);
                cmd.Parameters.AddWithValue("@Customer_name", txt_Customername.Text);
                //cmd.Parameters.AddWithValue("@Last_Name", txt_Lastname.Text);
                cmd.Parameters.AddWithValue("@Mobile_no", txt_Mobileno.Text);
                cmd.Parameters.AddWithValue("@Address", txt_Address.Text);
                cmd.Parameters.AddWithValue("@Order_Date", dtp_Orderdate.Text);
                cmd.Parameters.AddWithValue("@Delivery_Order_Date", dtp_Deliveryorderdate.Text);
                cmd.Parameters.AddWithValue("@Types_of_Decoration", cmbox_Typeofdecoration.Text);
                cmd.Parameters.AddWithValue("@Decoration_Category", cmbox_Decoration_category.Text);
                cmd.Parameters.AddWithValue("@Size_of_place", cmbox_Sizeofplace.Text);
                cmd.Parameters.AddWithValue("@Total", txt_Total.Text);
                

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
            //txt_Lastname.Text = "";
            txt_Mobileno.Text = "";
            txt_Address.Text = "";
            dtp_Orderdate.Text = "";
            dtp_Deliveryorderdate.Text = "";
            cmbox_Typeofdecoration.Text = "";
            cmbox_Decoration_category.Text = "";
            cmbox_Sizeofplace.Text = "";
            txt_Total.Text = "";
            


        }
        private void fetchdetails()
        {
            string Query = string.Format("select Product_ID,Customer_name,Mobile_no,Address,Order_Date,Delivery_Order_Date,Types_of_Decoration,Decoration_Category,Size_of_place,Total from table_dec_order");
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            da.Fill(ds, "temp");
            dataGridView_Placeorder_for_decoration.DataSource = ds;
            dataGridView_Placeorder_for_decoration.DataMember = "temp";

        }

        private void dataGridView_Placeorder_for_decoration_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView_Placeorder_for_decoration.Rows[e.RowIndex].Cells["Product_Id"].Value.ToString();
            txt_Customername.Text = dataGridView_Placeorder_for_decoration.Rows[e.RowIndex].Cells["Customer_name"].Value.ToString();
           // txt_Lastname.Text = dataGridView_Placeorder_for_decoration.Rows[e.RowIndex].Cells["Last_Name"].Value.ToString();
            txt_Mobileno.Text = dataGridView_Placeorder_for_decoration.Rows[e.RowIndex].Cells["Mobile_no"].Value.ToString();
            txt_Address.Text = dataGridView_Placeorder_for_decoration.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            dtp_Orderdate.Text = dataGridView_Placeorder_for_decoration.Rows[e.RowIndex].Cells["Order_Date"].Value.ToString();
            dtp_Deliveryorderdate.Text = dataGridView_Placeorder_for_decoration.Rows[e.RowIndex].Cells["Delivery_Order_Date"].Value.ToString();
            cmbox_Typeofdecoration.Text = dataGridView_Placeorder_for_decoration.Rows[e.RowIndex].Cells["Types_of_Decoration"].Value.ToString();
            cmbox_Decoration_category.Text = dataGridView_Placeorder_for_decoration.Rows[e.RowIndex].Cells["Decoration_Category"].Value.ToString();
            cmbox_Sizeofplace.Text = dataGridView_Placeorder_for_decoration.Rows[e.RowIndex].Cells["Size_of_place"].Value.ToString();
            txt_Total.Text = dataGridView_Placeorder_for_decoration.Rows[e.RowIndex].Cells["Total"].Value.ToString();
            //txt_Total_Price.Text = dataGridView_Flowers_Order.Rows[e.RowIndex].Cells["Total_Price"].Value.ToString();
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
            cmd = new SqlCommand("update table_dec_order set Customer_name=@Customer_name,Mobile_no=@Mobile_no,Address=@Address,Order_Date=@Order_Date,Delivery_Order_Date=@Delivery_Order_Date,Types_of_Decoration=@Types_of_Decoration,Decoration_Category=@Decoration_Category,Size_of_place=@Size_of_place,Total=@Total where Product_ID=@Product_ID", con);
            cmd.CommandType = CommandType.Text;
            //cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Product_ID", id);
            cmd.Parameters.AddWithValue("@Customer_name", txt_Customername.Text);
            //cmd.Parameters.AddWithValue("@Last_Name", txt_Lastname.Text);
            cmd.Parameters.AddWithValue("@Mobile_no", txt_Mobileno.Text);
            cmd.Parameters.AddWithValue("@Address", txt_Address.Text);
            cmd.Parameters.AddWithValue("@Order_Date", dtp_Orderdate.Text);
            cmd.Parameters.AddWithValue("@Delivery_Order_Date", dtp_Deliveryorderdate.Text);
            cmd.Parameters.AddWithValue("@Types_of_Decoration", cmbox_Typeofdecoration.Text);
            cmd.Parameters.AddWithValue("@Decoration_Category", cmbox_Decoration_category.Text);
            cmd.Parameters.AddWithValue("@Size_of_place", cmbox_Sizeofplace.Text);
            cmd.Parameters.AddWithValue("@Total", txt_Total.Text);
            

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
                    cmd.CommandText = "delete from table_dec_order where Product_ID=@Product_ID";
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

        private void cmbox_Typeofdecoration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbox_Typeofdecoration.SelectedItem.ToString() == "House Decoration")
            {
                txt_Total.Text = "2000";
            }
            else if (cmbox_Typeofdecoration.SelectedItem.ToString() == "Birthday Decoration")
            {
                txt_Total.Text = "2500";
            }
            else if (cmbox_Typeofdecoration.SelectedItem.ToString() == "Engagement Decoration")
            {
                txt_Total.Text = "5000";
            }
            else if (cmbox_Typeofdecoration.SelectedItem.ToString() == "Wedding Decoration")
            {
                txt_Total.Text = "10,000";
            }
            else if (cmbox_Typeofdecoration.SelectedItem.ToString() == "Car Decoration")
            {
                txt_Total.Text = "3000";
            }
            else if (cmbox_Typeofdecoration.SelectedItem.ToString() == "Temple Decoration")
            {
                txt_Total.Text = "2500";
            }
            else if (cmbox_Typeofdecoration.SelectedItem.ToString() == "Wedding Varmala")
            {
                txt_Total.Text = "3000";
            }
            else if (cmbox_Typeofdecoration.SelectedItem.ToString() == "Flowers Jewellary")
            {
                txt_Total.Text = "1500";
            }

            else
            {
                txt_Total.Text = "0";
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

        private void uc_Decoration_Placeorder_Load(object sender, EventArgs e)
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
        

        /*private void uc_Decoration_Placeorder_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
        }*/
    }
    
    

