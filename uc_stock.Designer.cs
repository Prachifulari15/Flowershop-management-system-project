namespace flowershop
{
    partial class uc_stock
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_stock));
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Item_name = new System.Windows.Forms.Label();
            this.lbl_avail_stock = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txt_avail_stock_level = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.cmbox_Item_name = new System.Windows.Forms.ComboBox();
            this.txt_Category = new System.Windows.Forms.TextBox();
            this.dataGridView_stock = new System.Windows.Forms.DataGridView();
            this.btn_Cancle = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_add_stock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Font = new System.Drawing.Font("Sitka Small", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_stock.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_stock.Location = new System.Drawing.Point(553, 38);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(224, 48);
            this.lbl_stock.TabIndex = 1;
            this.lbl_stock.Text = "== Stock ==";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Category.Location = new System.Drawing.Point(96, 231);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(175, 29);
            this.lbl_Category.TabIndex = 2;
            this.lbl_Category.Text = "Item Category :";
            // 
            // lbl_Item_name
            // 
            this.lbl_Item_name.AutoSize = true;
            this.lbl_Item_name.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Item_name.Location = new System.Drawing.Point(96, 157);
            this.lbl_Item_name.Name = "lbl_Item_name";
            this.lbl_Item_name.Size = new System.Drawing.Size(142, 29);
            this.lbl_Item_name.TabIndex = 3;
            this.lbl_Item_name.Text = "Item Name :";
            // 
            // lbl_avail_stock
            // 
            this.lbl_avail_stock.AutoSize = true;
            this.lbl_avail_stock.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_avail_stock.Location = new System.Drawing.Point(96, 310);
            this.lbl_avail_stock.Name = "lbl_avail_stock";
            this.lbl_avail_stock.Size = new System.Drawing.Size(241, 29);
            this.lbl_avail_stock.TabIndex = 4;
            this.lbl_avail_stock.Text = "Available Stcok level :";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_price.Location = new System.Drawing.Point(96, 387);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(81, 29);
            this.lbl_price.TabIndex = 5;
            this.lbl_price.Text = "Price :";
            // 
            // txt_avail_stock_level
            // 
            this.txt_avail_stock_level.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_avail_stock_level.Location = new System.Drawing.Point(343, 308);
            this.txt_avail_stock_level.Name = "txt_avail_stock_level";
            this.txt_avail_stock_level.Size = new System.Drawing.Size(236, 32);
            this.txt_avail_stock_level.TabIndex = 8;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_price.Location = new System.Drawing.Point(343, 387);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(236, 32);
            this.txt_price.TabIndex = 9;
            // 
            // cmbox_Item_name
            // 
            this.cmbox_Item_name.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cmbox_Item_name.FormattingEnabled = true;
            this.cmbox_Item_name.Items.AddRange(new object[] {
            "Rose",
            "Lotus",
            "Marigold",
            "Hibiscus",
            "Gerbera",
            "Cactus",
            "Mogra",
            "Orchids",
            "Aster",
            "Chryasanthemum",
            "Round Bouquet",
            "Basket Bouquet",
            "Standing Bouquet",
            "Possy Bouquet",
            "Hoop Bouquet",
            "Hand Bouquet",
            "Multi flower Bouquet",
            "Tulip flower Bouquet"});
            this.cmbox_Item_name.Location = new System.Drawing.Point(338, 157);
            this.cmbox_Item_name.Name = "cmbox_Item_name";
            this.cmbox_Item_name.Size = new System.Drawing.Size(234, 37);
            this.cmbox_Item_name.TabIndex = 10;
            this.cmbox_Item_name.SelectedIndexChanged += new System.EventHandler(this.cmbox_Item_name_SelectedIndexChanged);
            // 
            // txt_Category
            // 
            this.txt_Category.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_Category.Location = new System.Drawing.Point(336, 231);
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.Size = new System.Drawing.Size(236, 32);
            this.txt_Category.TabIndex = 11;
            // 
            // dataGridView_stock
            // 
            this.dataGridView_stock.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stock.Location = new System.Drawing.Point(130, 622);
            this.dataGridView_stock.Name = "dataGridView_stock";
            this.dataGridView_stock.RowHeadersWidth = 62;
            this.dataGridView_stock.RowTemplate.Height = 33;
            this.dataGridView_stock.Size = new System.Drawing.Size(813, 225);
            this.dataGridView_stock.TabIndex = 12;
            this.dataGridView_stock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_stock_CellDoubleClick);
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.BackColor = System.Drawing.Color.DeepPink;
            this.btn_Cancle.Font = new System.Drawing.Font("Sitka Small", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Cancle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Cancle.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancle.Image")));
            this.btn_Cancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancle.Location = new System.Drawing.Point(756, 522);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(173, 64);
            this.btn_Cancle.TabIndex = 130;
            this.btn_Cancle.Text = "Cancle";
            this.btn_Cancle.UseVisualStyleBackColor = false;
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.DeepPink;
            this.btn_Edit.Font = new System.Drawing.Font("Sitka Small", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Edit.Image")));
            this.btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit.Location = new System.Drawing.Point(459, 522);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(183, 64);
            this.btn_Edit.TabIndex = 129;
            this.btn_Edit.Text = "Edit Stock";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_add_stock
            // 
            this.btn_add_stock.BackColor = System.Drawing.Color.DeepPink;
            this.btn_add_stock.Font = new System.Drawing.Font("Sitka Small", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_add_stock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_add_stock.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_stock.Image")));
            this.btn_add_stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_stock.Location = new System.Drawing.Point(177, 522);
            this.btn_add_stock.Name = "btn_add_stock";
            this.btn_add_stock.Size = new System.Drawing.Size(176, 64);
            this.btn_add_stock.TabIndex = 127;
            this.btn_add_stock.Text = "Add Stock";
            this.btn_add_stock.UseVisualStyleBackColor = false;
            this.btn_add_stock.Click += new System.EventHandler(this.btn_add_stock_Click);
            // 
            // uc_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_Cancle);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_add_stock);
            this.Controls.Add(this.dataGridView_stock);
            this.Controls.Add(this.txt_Category);
            this.Controls.Add(this.cmbox_Item_name);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_avail_stock_level);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_avail_stock);
            this.Controls.Add(this.lbl_Item_name);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.lbl_stock);
            this.Name = "uc_stock";
            this.Size = new System.Drawing.Size(1450, 906);
            this.Load += new System.EventHandler(this.uc_stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_stock;
        private Label lbl_Category;
        private Label lbl_Item_name;
        private Label lbl_avail_stock;
        private Label lbl_price;
        private TextBox txt_avail_stock_level;
        private TextBox txt_price;
        private ComboBox cmbox_Item_name;
        private TextBox txt_Category;
        private DataGridView dataGridView_stock;
        private Button btn_Cancle;
        private Button btn_Edit;
        private Button btn_add_stock;
    }
}
