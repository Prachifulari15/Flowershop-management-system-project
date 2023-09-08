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
using System.Drawing.Imaging;
//using System.Windows.Forms.PrintDialog;
//using System.Windows.Forms.PrintPreviewDialog;

namespace flowershop
{
    public partial class uc_Billing : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-IPRS3Q12\\SQLEXPRESS;Initial Catalog=flowershop_DB;Integrated Security=True");
        SqlCommand cmd;
        public string id;

        public uc_Billing()
        {
            InitializeComponent();
        }

       private void cmbox_Select_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbox_Select_Items.SelectedItem.ToString() == "Rose")
            {
                txt_Price.Text = "10";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Lotus")
            {
                txt_Price.Text = "20";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Hibiscus")
            {
                txt_Price.Text = "10";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Orchids")
            {
                txt_Price.Text = "30";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Cactus")
            {
                txt_Price.Text = "20";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Chryasanthemum")
            {
                txt_Price.Text = "20";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Marigold")
            {
                txt_Price.Text = "20";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Gerbera")
            {
                txt_Price.Text = "30";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Mogra")
            {
                txt_Price.Text = "30";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Aster")
            {
                txt_Price.Text = "25";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Round Bouquet")
            {
                txt_Price.Text = "400";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Basket Bouquet")
            {
                txt_Price.Text = "350";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Standing Bouquet")
            {
                txt_Price.Text = "500";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Possy Bouquet")
            {
                txt_Price.Text = "550";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Hoop Bouquet")
            {
                txt_Price.Text = "450";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Hand Bouquet")
            {
                txt_Price.Text = "550";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Multi flower Bouquet")
            {
                txt_Price.Text = "600";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Tulip flower Bouquet")
            {
                txt_Price.Text = "500";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "House Decoration")
            {
                txt_Price.Text = "2000";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Birthday Decoration")
            {
                txt_Price.Text = "2500";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Engagement Decoration")
            {
                txt_Price.Text = "5000";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Wedding Decoration")
            {
                txt_Price.Text = "10,000";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Car Decoration")
            {
                txt_Price.Text = "3000";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Temple Decoration")
            {
                txt_Price.Text = "2500";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Wedding Varmala")
            {
                txt_Price.Text = "3000";
            }
            else if (cmbox_Select_Items.SelectedItem.ToString() == "Flowers Jewellary")
            {
                txt_Price.Text = "1500";
            }

            else
            {
                txt_Price.Text = "0";
            }
            txt_Total_Price.Text = "";
            txt_Quantity.Text = "";

        }
        
        private void txt_Quantity_TextChanged(object sender, EventArgs e)
        {
            if (txt_Quantity.Text.Length > 0)
            {
                txt_Total_Price.Text = (Convert.ToInt16(txt_Price.Text) * Convert.ToInt16(txt_Quantity.Text)).ToString();
            }
            //txt_Grant_Total.Text = (Convert.ToInt16(txt_Grant_Total.Text) + Convert.ToInt16(txt_Total_Price.Text)).ToString();
        }

        private void btn_AddToCart_Click(object sender, EventArgs e)
        {
           /* if (IsValid())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into table_billing values(@Item_name,@Price,@Quantity,@Total_Price)", con);
                cmd.CommandType = CommandType.Text;
                // cmd.Parameters.AddWithValue("@ProductID", txt_Productid.Text);
                cmd.Parameters.AddWithValue("@Item_name", cmbox_Select_Items.Text);
                cmd.Parameters.AddWithValue("@Price", txt_Price.Text);
                cmd.Parameters.AddWithValue("@Quantity", txt_Quantity.Text);
                cmd.Parameters.AddWithValue("@Total_Price", txt_Total_Price.Text);
               // cmd.Parameters.AddWithValue("@Grant_Total", txt_Grant_Total.Text);
                //txt_Grant_Total.Text = (Convert.ToInt16(txt_Grant_Total.Text) + Convert.ToInt16(txt_Total_Price.Text)).ToString();
                //cmd.Parameters.AddWithValue("@ProdCat", Catcb.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Add To Cart Succesfully..", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fetchdetails();
                cleardata();
                con.Close();

            }*/
            
            //txt_Grant_Total.Text = (Convert.ToInt16(txt_Grant_Total.Text) + Convert.ToInt16(txt_Total_Price.Text)).ToString();
        }

        private bool IsValid()
        {
            if (cmbox_Select_Items.Text == String.Empty)
            {
                MessageBox.Show("Item Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void cleardata()
        {
            // txt_Productid.Text = "";
            cmbox_Select_Items.Text = "";
            txt_Price.Text = "";
            txt_Quantity.Text = "";
            txt_Total_Price.Text = "";
           // txt_Grant_Total.Text = "";

        }
        private void fetchdetails()
        {
            string Query = string.Format("select Product_ID,Item_name,Price,Quantity,Total_price from table_billing");
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            da.Fill(ds, "temp");
           // dataGridView_Billing.DataSource = ds;
           // dataGridView_Billing.DataMember = "temp";

        }

       // private void btn_Remove_Click(object sender, EventArgs e)
        /*{
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
                    cmd.CommandText = "delete from table_billing where Product_ID=@Product_ID";
                    cmd.Parameters.AddWithValue("@Product_ID", id);
                    int num = cmd.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("Removed data successfully");
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
        }*/

        /*private void dataGridView_Billing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView_Billing.Rows[e.RowIndex].Cells["Product_Id"].Value.ToString();
            cmbox_Select_Items.Text = dataGridView_Billing.Rows[e.RowIndex].Cells["Item_Name"].Value.ToString();
            txt_Price.Text = dataGridView_Billing.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            txt_Quantity.Text = dataGridView_Billing.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            txt_Total_Price.Text = dataGridView_Billing.Rows[e.RowIndex].Cells["Total_Price"].Value.ToString();
            txt_Grant_Total.Text = dataGridView_Billing.Rows[e.RowIndex].Cells["Grant_Total"].Value.ToString();
        }*/
        /*private void Grant_Total()
        {
            int Grant_total = 0;
            for(int i = 0; i < dataGridView_Billing.Rows.Count;++i)
            {
                Grant_total += Convert.ToInt32(dataGridView_Billing.Rows[i].Cells[1].Value);
                    //Grant_total+int.Parse(dataGridView_Billing.Rows[i].Cells[0].Value.ToString());
               
            }
            txt_Grant_Total.Text = Grant_total.ToString();
        }*/
        private void txt_Mobileno_TextChanged(object sender, EventArgs e)
        {
            if(txt_Mobileno.Text.Length > 10)
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
        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("         ==========  Receipt  ==========", new Font("Times New Roman", 12), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("            Raj Flowers & Decorators", new Font("Sitka Small", 12), Brushes.Black, new Point(10, 30));
            e.Graphics.DrawString("                                                          Date : " + DateTime.Now.ToShortDateString(), new Font("Times New Roman", 10), Brushes.Black, new Point(10, 45));
            e.Graphics.DrawString("==================================================", new Font("Times New Roman", 12), Brushes.Black, new Point(10, 55));
           // e.Graphics.DrawString("Bill No : " + txt_Customername.Text.ToString(), new Font("Times New Roman", 10), Brushes.Black, new Point(10, 65));
            e.Graphics.DrawString("Cutomer Name : "+txt_Customername.Text.ToString(), new Font("Times New Roman", 10), Brushes.Black, new Point(10, 65));
              e.Graphics.DrawString("Mobile No : " + txt_Mobileno.Text.ToString(), new Font("Times New Roman", 10), Brushes.Black, new Point(10, 85));
              e.Graphics.DrawString("Address : " + txt_Address.Text.ToString(), new Font("Times New Roman", 10), Brushes.Black, new Point(10, 105));
              e.Graphics.DrawString("Item Name : " + cmbox_Select_Items.Text.ToString(), new Font("Times New Roman", 10), Brushes.Black, new Point(10, 125));
              e.Graphics.DrawString("Price : " + txt_Price.Text.ToString(), new Font("Times New Roman", 10), Brushes.Black, new Point(10, 145));
              e.Graphics.DrawString("Quantity : " + txt_Quantity.Text.ToString(), new Font("Times New Roman", 10), Brushes.Black, new Point(10, 165));
              e.Graphics.DrawString("Total Price : " + txt_Total_Price.Text.ToString(), new Font("Times New Roman", 10), Brushes.Black, new Point(10, 185));
            e.Graphics.DrawString("==========  Thank you for visiting... ==========", new Font("Times New Roman", 12), Brushes.Black, new Point(10, 215));
            //e.Graphics.DrawImage(bmp,0,0);
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
             printPreviewDialog1.Document = printDocument1;
             printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Item detail", 385, 300);
             printPreviewDialog1.ShowDialog();

            /*int height = dataGridView_Billing.Height;
            dataGridView_Billing.Height = dataGridView_Billing.RowCount * dataGridView_Billing.RowTemplate.Height * 2;
            Bitmap bmp = new Bitmap(dataGridView_Billing.Width, dataGridView_Billing.Height);
            dataGridView_Billing.DrawToBitmap(bmp, new Rectangle(0,0 ,dataGridView_Billing.Width, dataGridView_Billing.Height));
            dataGridView_Billing.Height = height;
            printPreviewDialog1.ShowDialog();/*
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            /*uc_bill ub = new uc_bill();
            ub.Dock = DockStyle.Fill;
            this.Controls.Add(ub);
            ub.Visible = true;
            ub.BringToFront();*/
        }

      /*  private void dataGridView_Billing_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView_Billing.Rows[e.RowIndex].Cells["Product_Id"].Value.ToString();
            cmbox_Select_Items.Text = dataGridView_Billing.Rows[e.RowIndex].Cells["Item_name"].Value.ToString();
            txt_Price.Text = dataGridView_Billing.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            txt_Quantity.Text = dataGridView_Billing.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            txt_Total_Price.Text = dataGridView_Billing.Rows[e.RowIndex].Cells["Total_Price"].Value.ToString();
            //txt_Grant_Total.Text = dataGridView_Billing.Rows[e.RowIndex].Cells["Grant_Total"].Value.ToString();
        }*/

        private void uc_Billing_Load(object sender, EventArgs e)
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

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_Price.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers...");
                txt_Price.Text = txt_Price.Text.Remove(txt_Price.Text.Length - 1);
            }
        }

        private void Checkname(object sender, KeyPressEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void check1(object sender, KeyEventArgs e)
        {
        }

        private void check2(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void check3(object sender, KeyEventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand checker = new SqlCommand("SELECT * from table_f_order WHERE Customer_name='" + txt_Customername.Text + "'", con);

                //SqlCommand checker = new SqlCommand("SELECT table_f_order.Flowers_types,table_f_order.Customer_name,table_f_order.Mobile_no,table_f_order.Address,table_f_order.Price,table_f_order.Total_Price,table_f_order.Quantity,table_b_order.Bouquet_Type,table_b_order.Price,table_b_order.Total_Price,table_b_order.Quantity FROM table_f_order,table_b_order INNER JOIN table_f_order.table_b_order ON table_f_order table_b_order.Customer_name = Customer_name ", con);
                //SqlCommand checker = new SqlCommand("SELECT * from table_f_order inner join table_b_order on Customer_name.Customername=Customer_name.Customername '" + txt_Customername.Text + txt_Customername.Text + "'", con);
                //SqlCommand ch = new SqlCommand("SELECT * from table_b_order WHERE Bouquet_Type='" + cmbox_Select_Items.Text + "'", con);
                SqlDataReader reader = checker.ExecuteReader();
                while (reader.Read())
                {
                   // txt_billno.Text = reader[Product_ID].ToString();
                    cmbox_Select_Items.Text = reader["Flowers_Types"].ToString();
                    txt_Customername.Text = reader["Customer_name"].ToString();
                    txt_Mobileno.Text = reader["Mobile_no"].ToString();
                    txt_Address.Text = reader["Address"].ToString();
                    txt_Price.Text = reader["Price"].ToString();
                    txt_Total_Price.Text = reader["Total_Price"].ToString();
                    txt_Quantity.Text = reader["Quantity"].ToString();
                   // cmbox_Select_Items.Text = reader["Flowers_Types"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

       /* private void txt_billno_TextChanged(object sender, EventArgs e)
        {
            //txt_billno.Text++;
            var no = Convert.ToInt32(txt_billno.Text);
            txt_billno.Text = Convert.ToString(no);
        }*/
        //txt_Grant_Total.Text = (Convert.ToInt16(txt_Grant_Total.Text) + Convert.ToInt16(txt_Total_Price.Text)).ToString();

        /* private void btn_Delete_Click(object sender, EventArgs e)
         {

         }*/
    }

    /*private void txt_Total_Price_TextChanged(object sender, EventArgs e)
    {

    }*/
    

    

}

