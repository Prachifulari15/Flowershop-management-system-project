using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace flowershop
{
    public partial class uc_Additems : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-IPRS3Q12\\SQLEXPRESS;Initial Catalog=flowershop_DB;Integrated Security=True");

        SqlCommand cmd;
        public string id;
        public uc_Additems()
        {
            InitializeComponent();
            
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into table_additems values(@ItemCategory,@ItemName,@Price)", con);
                cmd.CommandType = CommandType.Text;
               // cmd.Parameters.AddWithValue("@ProductID", txt_Productid.Text);
                cmd.Parameters.AddWithValue("@ItemCategory", cmbox_Item_category.Text);
                cmd.Parameters.AddWithValue("@ItemName", txt_Itemname.Text);
                cmd.Parameters.AddWithValue("@Price", txt_price.Text);
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
            if (txt_Itemname.Text == String.Empty)
            {
                MessageBox.Show("Product ID is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void cleardata()
        {
           // txt_Productid.Text = "";
            cmbox_Item_category.Text = "";
            txt_Itemname.Text = "";
            txt_price.Text = "";

        }
        private void fetchdetails()
        {
            string Query = string.Format("select ProductID,ItemCategory,ItemName,Price from table_additems");
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            da.Fill(ds, "temp");
            dataGridView_AddItems.DataSource = ds;
            dataGridView_AddItems.DataMember = "temp";

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
            SqlCommand cmd = new SqlCommand("Update table_additems set ItemCategory=@ItemCategory,ItemName=@ItemName,Price=@Price where ProductID=@ProductID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ProductID", id);
            cmd.Parameters.AddWithValue("@ItemCategory", cmbox_Item_category.Text);
            cmd.Parameters.AddWithValue("@ItemName", txt_Itemname.Text);
            cmd.Parameters.AddWithValue("@Price", txt_price.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Data Succesfully..", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fetchdetails();
            con.Close();
        }


        private void dataGridView_AddItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView_AddItems.Rows[e.RowIndex].Cells["ProductId"].Value.ToString();
            cmbox_Item_category.Text = dataGridView_AddItems.Rows[e.RowIndex].Cells["ItemCategory"].Value.ToString();
            txt_Itemname.Text = dataGridView_AddItems.Rows[e.RowIndex].Cells["ItemName"].Value.ToString();
            txt_price.Text = dataGridView_AddItems.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            //txtProdName.Text = Customerdgv.Rows[e.RowIndex].Cells["CustProduct"].Value.ToString();
            // Catcb.Text = Customerdgv.Rows[e.RowIndex].Cells["ProdCat"].Value.ToString();
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
                    cmd.CommandText = "delete from table_additems where ProductID=@ProductID";
                    cmd.Parameters.AddWithValue("@ProductID", id);
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

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            uc_Home hc = new uc_Home();
            hc.Dock = DockStyle.Fill;
            this.Controls.Add(hc);
            hc.Visible = true;
            hc.BringToFront();
        }

        private void uc_Additems_Load(object sender, EventArgs e)
        {
            fetchdetails();
        }

        private void txt_Itemname_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txt_Itemname.Text, "[a-zA-Z]"))          //code for character validation
            {
                MessageBox.Show("Please enter only characters...");
                txt_Itemname.Text.Remove(txt_Itemname.Text.Length - 0);
            }
        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_price.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers...");
                txt_price.Text = txt_price.Text.Remove(txt_price.Text.Length - 1);
            }
        }
        //on form 1
       /* public static string txt_Itemname;

        //on form2 access static variable and assign value
        uc_Additems.textVal = TextBox1.Text.trim();

//on form1 add the static variable value to combobox
combobox1.Items.Add(textVal);*/

        /*private void txt_Itemname_Click(object sender, EventArgs e)
        {
            uc_Flowers_Order frm2 = new uc_Flowers_Order(this.cmbox_Item_category.Text);

           // frm2.ShowDialog();
            InitializeComponent();
            this.cmbox_Item_category.Items.Add(cmbox_Item_category);
        }*/
    }

        /* private void btn_Update_Click(object sender, EventArgs e)
         {

         }*/
    }
/* void BindData()
{
 SqlCommand cmd = new SqlCommand("select * from AddIteams_table", con);
 SqlDataAdapter sd = new SqlDataAdapter(cmd);
 DataTable dt = new DataTable();
 sd.Fill(dt);
 dataGridView_AddItems.DataSource = dt;
}*/






/* private void uc_Additems_Load(object sender, EventArgs e)
 {
     BindData();
 }*/

/* private void btn_Update_Click(object sender, EventArgs e)
 {
     con.Open();
     SqlCommand cmd = new SqlCommand("update AddIteams_table set lbl_productid ='" + txt_Productid.Text + "',lbl_Category ='" + cmbox_Item_category.Text + "',lbl_Itemname ='" + txt_Itemname.Text + "',lbl_Price ='" + txt_price.Text + "'", con);
     cmd.ExecuteNonQuery();
     con.Close();
     MessageBox.Show("Successfully Updated");
     BindData();
 }*/

/* private void dataGridView_AddItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
 {

 }*/

/* private void btn_Delete_Click(object sender, EventArgs e)
 {
     if (txt_Productid != null)
     {
         con.Open();
         SqlCommand cmd = new SqlCommand("Delete AddItems_table where ProductID='" + int.Parse(txt_Productid.Text) + "'", con);
         cmd.ExecuteNonQuery();
         con.Close();
         MessageBox.Show("Successfully Deleted");
         BindData();
     }
     else
     {
         MessageBox.Show("Enter Product ID");
     }
 }*/

/* private void btn_Search_Click(object sender, EventArgs e)
 {
     SqlCommand cmd = new SqlCommand("select * from AddItems_table where Product ID ='" + int.Parse(txt_Productid.Text) + "'", con);
     SqlDataAdapter sd = new SqlDataAdapter(cmd);
     DataTable dt = new DataTable();
     sd.Fill(dt);
     dataGridView_AddItems.DataSource = dt;
 }*/
//on form 1
/*public static string 

//on form2 access static variable and assign value
form1.textVal = TextBox1.Text.trim();

//on form1 add the static variable value to combobox
combobox1.Items.Add(textVal);*/





