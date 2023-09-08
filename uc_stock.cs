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
    public partial class uc_stock : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-IPRS3Q12\\SQLEXPRESS;Initial Catalog=flowershop_DB;Integrated Security=True");

        SqlCommand cmd;
        public string id;
        public uc_stock()
        {
            InitializeComponent();
        }

        private void cmbox_Item_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbox_Item_name.Text == "Rose")
            {
                txt_Category.Text = "Flowers";
                txt_avail_stock_level.Text = "200";
                txt_price.Text = "10";
            }

            if (cmbox_Item_name.Text == "Lotus")
            {
                txt_Category.Text = "Flowers";
                txt_avail_stock_level.Text = "100";
                txt_price.Text = "20";
            }

            if (cmbox_Item_name.Text == "Hibiscus")
            {
                txt_Category.Text = "Flowers";
                txt_avail_stock_level.Text = "50";
                txt_price.Text = "10";
            }

            if (cmbox_Item_name.Text == "Orchids")
            {
                txt_Category.Text = "Flowers";
                txt_avail_stock_level.Text = "100";
                txt_price.Text = "30";
            }

            if (cmbox_Item_name.Text == "Cactus")
            {
                txt_Category.Text = "Flowers";
                txt_avail_stock_level.Text = "50";
                txt_price.Text = "20";
            }

            if (cmbox_Item_name.Text == "Chryasanthemum")
            {
                txt_Category.Text = "Flowers";
                txt_avail_stock_level.Text = "70 kg";
                txt_price.Text = "20";
            }

            if (cmbox_Item_name.Text == "Marigold")
            {
                txt_Category.Text = "Flowers";
                txt_avail_stock_level.Text = "150 kg";
                txt_price.Text = "20";
            }

            if (cmbox_Item_name.Text == "Gerbera")
            {
                txt_Category.Text = "Flowers";
                txt_avail_stock_level.Text = "50";
                txt_price.Text = "30";
            }

            if (cmbox_Item_name.Text == "Mogra")
            {
                txt_Category.Text = "Flowers";
                txt_avail_stock_level.Text = "20 kg";
                txt_price.Text = "30";
            }

            if (cmbox_Item_name.Text == "Aster")
            {
                txt_Category.Text = "Flowers";
                txt_avail_stock_level.Text = "30";
                txt_price.Text = "25";
            }

            if (cmbox_Item_name.Text == "Round Bouquet")
            {
                txt_Category.Text = "Bouquet";
                txt_avail_stock_level.Text = "10";
                txt_price.Text = "400";
            }

            if (cmbox_Item_name.Text == "Basket Bouquet")
            {
                txt_Category.Text = "Bouquet";
                txt_avail_stock_level.Text = "15";
                txt_price.Text = "350";
            }

            if (cmbox_Item_name.Text == "Standing Bouquet")
            {
                txt_Category.Text = "Bouquet";
                txt_avail_stock_level.Text = "10";
                txt_price.Text = "500";
            }

            if (cmbox_Item_name.Text == "Possy Bouquet")
            {
                txt_Category.Text = "Bouquet";
                txt_avail_stock_level.Text = "15";
                txt_price.Text = "550";
            }

            if (cmbox_Item_name.Text == "Hoop Bouquet")
            {
                txt_Category.Text = "Bouquet";
                txt_avail_stock_level.Text = "10";
                txt_price.Text = "450";
            }

            if (cmbox_Item_name.Text == "Hand Bouquet")
            {
                txt_Category.Text = "Bouquet";
                txt_avail_stock_level.Text = "15";
                txt_price.Text = "550";
            }

            if (cmbox_Item_name.Text == "Multi flower Bouquet")
            {
                txt_Category.Text = "Bouquet";
                txt_avail_stock_level.Text = "5";
                txt_price.Text = "600";
            }

            if (cmbox_Item_name.Text == "Tulip flower Bouquet")
            {
                txt_Category.Text = "Bouquet";
                txt_avail_stock_level.Text = "5";
                txt_price.Text = "500";
            }



        }

        private void dataGridView_stock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView_stock.Rows[e.RowIndex].Cells["Product_ID"].Value.ToString();
            cmbox_Item_name.Text = dataGridView_stock.Rows[e.RowIndex].Cells["Item_name"].Value.ToString();
            txt_Category.Text=dataGridView_stock.Rows[e.RowIndex].Cells["Item_category"].Value.ToString();
            txt_avail_stock_level.Text = dataGridView_stock.Rows[e.RowIndex].Cells["Available_stock_level"].Value.ToString();
            txt_price.Text = dataGridView_stock.Rows[e.RowIndex].Cells["Price"].Value.ToString();

        }

        private void btn_add_stock_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into table_stock values(@Item_name,@Item_category,@Available_stock_level,@Price)", con);
                cmd.CommandType = CommandType.Text;
               
                cmd.Parameters.AddWithValue("@Item_name", cmbox_Item_name.Text);
                cmd.Parameters.AddWithValue("@Item_category", txt_Category.Text);
                cmd.Parameters.AddWithValue("@Available_stock_level", txt_avail_stock_level.Text);
                cmd.Parameters.AddWithValue("@Price", txt_price.Text);
                

                //cmd.Parameters.AddWithValue("@ProdCat", Catcb.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Add Stock Succesfully..", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fetchdetails();
                cleardata();
                con.Close();

            }
        }

        private bool IsValid()
        {
            if (cmbox_Item_name.Text == String.Empty)
            {
                MessageBox.Show("Item name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void cleardata()
        {
           
            cmbox_Item_name.Text = "";
            txt_Category.Text = "";
            txt_avail_stock_level.Text = "";
            txt_price.Text = "";


        }
        private void fetchdetails()
        {
            string Query = string.Format("select Product_ID,Item_name,Item_category,Available_stock_level,Price from table_stock");
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            da.Fill(ds, "temp");
            dataGridView_stock.DataSource = ds;
            dataGridView_stock.DataMember = "temp";

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Update();
            fetchdetails();
            cleardata();
        }
        public void Update()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-IPRS3Q12\\SQLEXPRESS;Initial Catalog=flowershop_DB;Integrated Security=True");
            cmd = new SqlCommand("update table_stock set Item_name=@Item_name,Item_category=@Item_category,Available_stock_level=@Available_stock_level,Price=@Price where Product_ID=@Product_ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Item_name", cmbox_Item_name.Text);
            cmd.Parameters.AddWithValue("@Item_category", txt_Category.Text);
            cmd.Parameters.AddWithValue("@Available_stock_level", txt_avail_stock_level.Text);
            cmd.Parameters.AddWithValue("@Price", txt_price.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Edit stock Succesfully..", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fetchdetails();
            con.Close();

        }

        private void uc_stock_Load(object sender, EventArgs e)
        {
            fetchdetails();
        }
    }
    }

        /* private void cmbox_Item_category_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (cmbox_Item_category.Text == "Flowers") 
             if(cmbox_Item_name.Text=="Rose")
             {

                 txt_avail_stock_level.Text = "200";
                 txt_price.Text = "10";
             }
             if (cmbox_Item_category.Text == "Flowers") 
             if(cmbox_Item_name.Text=="Lotus")
             {

                 txt_avail_stock_level.Text = "100";
                 txt_price.Text = "20";
             }
         }*/
    

