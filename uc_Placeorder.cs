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
    public partial class uc_Placeorder : UserControl
    {

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-IPRS3Q12\\SQLEXPRESS;Initial Catalog=flowershop_DB;Integrated Security=True");
        private void btn_Save_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=LAPTOP-IPRS3Q12\\SQLEXPRESS;Initial Catalog=flowershop_DB;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("insert into Placeorder_table values('"+int.Parse(txt_ProductID.Text)+"','"+txt_Firstname.Text+ "','" + txt_Lastname.Text + "','" + txt_Mobileno.Text + "','" + txt_Address.Text + "','" + dtp_Orderdate.Text + "','" + dtp_Delivery_order_date.Text + "','" + cmbox_Flowers.Text + "','" + numUD_Quantity_flower.Text + "','" + cmbox_Bouquet.Text + "','" + numUD_Quantity_bouquet.Text + "','" + cmbox_Others.Text + "','" + numUD_Quantity_others.Text + "','" + txt_Price.Text + "','" + txt_Totalprice.Text + "',getdate())",con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted");
            con.Close();
            BindData();
        }
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * from Placeorder_table",con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView_Placeorder.DataSource = dt;
        }

        private void uc_Placeorder_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void btn_Update_Click(object sender, EventArgs e)
            
        {
            con.Open();
            SqlCommand command = new SqlCommand("update Placeorder_table set lbl_Firstname ='" + txt_Firstname.Text + "',lbl_Lastname ='" + txt_Lastname.Text + "',lbl_Mobileno ='" + txt_Mobileno.Text + "',lbl_Address ='" + txt_Address.Text + "',lbl_Orderdate='" + dtp_Orderdate.Text + "',lbl_Delivery_orderdate='" + dtp_Delivery_order_date.Text + "',lbl_Flowers='" + cmbox_Flowers.Text + "',lbl_Quantity_Flowers='" + numUD_Quantity_flower.Text + "',lbl_Bouquet='" + cmbox_Bouquet.Text + "',lbl_Quantity_Bouquet='" + numUD_Quantity_bouquet.Text + "',lbl_Others='" + cmbox_Others.Text + "',lbl_Quantity_Others='" + numUD_Quantity_others.Text + "',lbl_Price='" + txt_Price.Text + "',lbl_Totalprice='" + txt_Totalprice.Text + "',UpdateDate= getdate() where Product ID='"+int.Parse(txt_ProductID.Text)+"'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated");
            BindData();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_ProductID != null)
            {
                con.Open();
                SqlCommand command = new SqlCommand("Delete Placeorder_table where ProductID='" + int.Parse(txt_ProductID.Text) + "'", con);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Deleted");
                BindData();
            }
            else
            {
                MessageBox.Show("Enter Product ID");
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Placeorder_table where Product ID ='"+int.Parse(txt_ProductID.Text)+"'", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView_Placeorder.DataSource = dt;
        }
    }
}

        
