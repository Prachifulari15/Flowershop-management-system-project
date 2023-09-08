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
    public partial class uc_Flowers_Order : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-IPRS3Q12\\SQLEXPRESS;Initial Catalog=flowershop_DB;Integrated Security=True");

        SqlCommand cmd;
        public string id;
        public uc_Flowers_Order()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into table_f_order values(@Customer_name,@Mobile_no,@Address,@Order_Date,@Delivery_Order_Date,@Flowers_Types,@Colour,@Price,@Quantity,@Total_Price)", con);
                cmd.CommandType = CommandType.Text;
                // cmd.Parameters.AddWithValue("@ProductID", txt_Productid.Text);
                cmd.Parameters.AddWithValue("@Customer_name", txt_Customername.Text);
                //cmd.Parameters.AddWithValue("@Last_Name", txt_Lastname.Text);
                cmd.Parameters.AddWithValue("@Mobile_no", txt_Mobileno.Text);
                cmd.Parameters.AddWithValue("@Address", txt_Address.Text);
                cmd.Parameters.AddWithValue("@Order_Date", dtp_Orderdate.Text);
                cmd.Parameters.AddWithValue("@Delivery_Order_Date", dtp_Delivery_order_date.Text);
                cmd.Parameters.AddWithValue("@Flowers_Types", cmbox_Flowers_types.Text);
                cmd.Parameters.AddWithValue("@Colour", cmbox_Colour.Text);
                cmd.Parameters.AddWithValue("@Price", txt_Price.Text);
                cmd.Parameters.AddWithValue("@Quantity", txt_Quantity.Text);
                cmd.Parameters.AddWithValue("@Total_Price", txt_Total_Price.Text);

                //cmd.Parameters.AddWithValue("@ProdCat", Catcb.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Save Data succesfully..", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fetchdetails();
                cleardata();
                con.Close();


                //call billing frame
                /*uc_Billing fo = new uc_Billing();
                fo.Dock = DockStyle.Fill;
                this.Controls.Add(fo);
                fo.Visible = true;
                fo.BringToFront();*/
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
            dtp_Delivery_order_date.Text = "";
            cmbox_Flowers_types.Text = "";
            cmbox_Colour.Text = "";
            txt_Price.Text = "";
            txt_Quantity.Text = "";
            txt_Total_Price.Text = "";
            

        }
        private void fetchdetails()
        {
            string Query = string.Format("select Product_ID,Customer_name,Mobile_no,Address,Order_Date,Delivery_Order_Date,Flowers_Types,Colour,Price,Quantity,Total_Price from table_f_order");
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            da.Fill(ds, "temp");
            dataGridView_Flowers_Order.DataSource = ds;
            dataGridView_Flowers_Order.DataMember = "temp";

        }

        private void dataGridView_Flowers_Order_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView_Flowers_Order.Rows[e.RowIndex].Cells["Product_Id"].Value.ToString();
            txt_Customername.Text = dataGridView_Flowers_Order.Rows[e.RowIndex].Cells["Customer_name"].Value.ToString();
           // txt_Lastname.Text = dataGridView_Flowers_Order.Rows[e.RowIndex].Cells["Last_Name"].Value.ToString();
            txt_Mobileno.Text = dataGridView_Flowers_Order.Rows[e.RowIndex].Cells["Mobile_no"].Value.ToString();
            txt_Address.Text = dataGridView_Flowers_Order.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            dtp_Orderdate.Text = dataGridView_Flowers_Order.Rows[e.RowIndex].Cells["Order_Date"].Value.ToString();
            dtp_Delivery_order_date.Text = dataGridView_Flowers_Order.Rows[e.RowIndex].Cells["Delivery_Order_Date"].Value.ToString();
            cmbox_Flowers_types.Text = dataGridView_Flowers_Order.Rows[e.RowIndex].Cells["Flowers_Types"].Value.ToString();
            cmbox_Colour.Text = dataGridView_Flowers_Order.Rows[e.RowIndex].Cells["Colour"].Value.ToString();
            txt_Price.Text = dataGridView_Flowers_Order.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            txt_Quantity.Text = dataGridView_Flowers_Order.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            txt_Total_Price.Text = dataGridView_Flowers_Order.Rows[e.RowIndex].Cells["Total_Price"].Value.ToString();
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
            cmd = new SqlCommand("update table_f_order set Customer_name=@Customer_name,Mobile_no=@Mobile_no,Address=@Address,Order_Date=@Order_Date,Delivery_Order_Date=@Delivery_Order_Date,Flowers_Types=@Flowers_Types,Colour=@Colour,Price=@Price,Quantity=@Quantity,Total_Price=@Total_Price where Product_ID=@Product_ID", con);
            cmd.CommandType = CommandType.Text;
            //cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Product_ID",id);
            cmd.Parameters.AddWithValue("@Customer_name", txt_Customername.Text);
            //cmd.Parameters.AddWithValue("@Last_Name", txt_Lastname.Text);
            cmd.Parameters.AddWithValue("@Mobile_no", txt_Mobileno.Text);
            cmd.Parameters.AddWithValue("@Address", txt_Address.Text);
            cmd.Parameters.AddWithValue("@Order_Date", dtp_Orderdate.Text);
            cmd.Parameters.AddWithValue("@Delivery_Order_Date", dtp_Delivery_order_date.Text);
            cmd.Parameters.AddWithValue("@Flowers_Types", cmbox_Flowers_types.Text);
            cmd.Parameters.AddWithValue("@Colour", cmbox_Colour.Text);
            cmd.Parameters.AddWithValue("@Price", txt_Price.Text);
            cmd.Parameters.AddWithValue("@Quantity", txt_Quantity.Text);
            cmd.Parameters.AddWithValue("@Total_Price", txt_Total_Price.Text);

            /*cmd.Parameters.AddWithValue("@CustName", CNametb.Text);
            cmd.Parameters.AddWithValue("@CustPhoneNo", Phonetb.Text);
            cmd.Parameters.AddWithValue("@CustAddress", Addresstb.Text);
            cmd.Parameters.AddWithValue("@CustProduct", txtProdName.Text);
            cmd.Parameters.AddWithValue("@CustId", id);*/
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
                    cmd.CommandText = "delete from table_f_order where Product_ID=@Product_ID";
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

        private void cmbox_Flowers_types_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbox_Flowers_types.SelectedItem.ToString() == "Rose")
            {
                txt_Price.Text = "10";
            }
            else if (cmbox_Flowers_types.SelectedItem.ToString() == "Lotus")
            {
                txt_Price.Text = "20";
            }
            else if (cmbox_Flowers_types.SelectedItem.ToString() == "Hibiscus")
            {
                txt_Price.Text = "10";
            }
            else if (cmbox_Flowers_types.SelectedItem.ToString() == "Orchids")
            {
                txt_Price.Text = "30";
            }
            else if (cmbox_Flowers_types.SelectedItem.ToString() == "Cactus")
            {
                txt_Price.Text = "20";
            }
            else if (cmbox_Flowers_types.SelectedItem.ToString() == "Chryasanthemum")
            {
                txt_Price.Text = "20";
            }
            else if (cmbox_Flowers_types.SelectedItem.ToString() == "Marigold")
            {
                txt_Price.Text = "20";
            }
            else if (cmbox_Flowers_types.SelectedItem.ToString() == "Gerbera")
            {
                txt_Price.Text = "30";
            }
            else if (cmbox_Flowers_types.SelectedItem.ToString() == "Mogra")
            {
                txt_Price.Text = "30";
            }
            else if (cmbox_Flowers_types.SelectedItem.ToString() == "Aster")
            {
                txt_Price.Text = "25";
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
            /* if (System.Text.RegularExpressions.Regex.IsMatch(txt_Quantity.Text, "[^0-9]"))
             {
                 MessageBox.Show("Please enter only numbers...");
                 txt_Quantity.Text = txt_Quantity.Text.Remove(txt_Quantity.Text.Length - 1);
             }*/

            /*Int32 val1 = Convert.ToInt32(txt_Price.Text);
            Int32 val2 = Convert.ToInt32(txt_Quantity.Text);
            Int32 val3 = val1 * val2;
            txt_Total_Price.Text = Convert.ToString(val3);*/

            /*if (Convert.ToInt16(txt_Quantity.Text) > Convert.ToInt16(lbl_Quantity_flower.Text))
            {
                MessageBox.Show("Your Available Stock Is Less");
                txt_Quantity.Text = lbl_Quantity_flower.Text;
            }*/
        }

        private void txt_Mobileno_TextChanged(object sender, EventArgs e)
        {
            if (txt_Mobileno.Text.Length > 10)                          //code for mobile no validation
            {
                
                MessageBox.Show("Invalid Mobile Number..");
                txt_Mobileno.Focus();
            }
            if(System.Text.RegularExpressions.Regex.IsMatch(txt_Mobileno.Text,"[^0-9]"))
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

        private void uc_Flowers_Order_Load(object sender, EventArgs e)
        {
            fetchdetails();
        }

        private void txt_Customername_TextChanged(object sender, EventArgs e)
        {
            if(!System.Text.RegularExpressions.Regex.IsMatch(txt_Customername.Text,"[a-zA-Z]"))          //code for character validation
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

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_Price.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers...");
                txt_Price.Text = txt_Price.Text.Remove(txt_Price.Text.Length - 1);
            }
        }

        private void txt_Total_Price_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_Total_Price.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers...");
                txt_Total_Price.Text = txt_Total_Price.Text.Remove(txt_Total_Price.Text.Length - 1);
            }
        }

      //  private void Autokeyvalue(object sender, KeyEventArgs e)
       /* {
            try
            {

                con.Open();
                SqlCommand checker = new SqlCommand("SELECT * from table_f_order", con);
                SqlDataReader reader = checker.ExecuteReader();
                while (reader.Read())
                {
                    cmbox_Flowers_types.Text = reader["Flowers_Types"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }*/

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
