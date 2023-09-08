namespace flowershop
{
    partial class uc_Additems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Additems));
            this.lbl_AddItems = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Cancle = new System.Windows.Forms.Button();
            this.dataGridView_AddItems = new System.Windows.Forms.DataGridView();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.cmbox_Item_category = new System.Windows.Forms.ComboBox();
            this.lbl_Itemname = new System.Windows.Forms.Label();
            this.txt_Itemname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AddItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AddItems
            // 
            this.lbl_AddItems.AutoSize = true;
            this.lbl_AddItems.Font = new System.Drawing.Font("Sitka Small", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_AddItems.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_AddItems.Location = new System.Drawing.Point(339, 46);
            this.lbl_AddItems.Name = "lbl_AddItems";
            this.lbl_AddItems.Size = new System.Drawing.Size(302, 48);
            this.lbl_AddItems.TabIndex = 0;
            this.lbl_AddItems.Text = "== Add Items ==";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.DeepPink;
            this.btn_Save.Font = new System.Drawing.Font("Sitka Small", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(72, 453);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(175, 61);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.DeepPink;
            this.btn_Delete.Font = new System.Drawing.Font("Sitka Small", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(302, 453);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(188, 61);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.DeepPink;
            this.btn_Update.Font = new System.Drawing.Font("Sitka Small", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(553, 453);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(178, 61);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.BackColor = System.Drawing.Color.DeepPink;
            this.btn_Cancle.Font = new System.Drawing.Font("Sitka Small", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Cancle.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancle.Image")));
            this.btn_Cancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancle.Location = new System.Drawing.Point(799, 453);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(170, 61);
            this.btn_Cancle.TabIndex = 7;
            this.btn_Cancle.Text = "Cancle";
            this.btn_Cancle.UseVisualStyleBackColor = false;
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // dataGridView_AddItems
            // 
            this.dataGridView_AddItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_AddItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AddItems.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_AddItems.Location = new System.Drawing.Point(144, 577);
            this.dataGridView_AddItems.Name = "dataGridView_AddItems";
            this.dataGridView_AddItems.RowHeadersWidth = 62;
            this.dataGridView_AddItems.RowTemplate.Height = 33;
            this.dataGridView_AddItems.Size = new System.Drawing.Size(726, 225);
            this.dataGridView_AddItems.TabIndex = 10;
            this.dataGridView_AddItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AddItems_CellDoubleClick);
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_price.Location = new System.Drawing.Point(288, 323);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(275, 32);
            this.txt_price.TabIndex = 18;
            this.txt_price.TextChanged += new System.EventHandler(this.txt_price_TextChanged);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Price.Location = new System.Drawing.Point(112, 323);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(81, 29);
            this.lbl_Price.TabIndex = 17;
            this.lbl_Price.Text = "Price :";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Category.Location = new System.Drawing.Point(112, 164);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(175, 29);
            this.lbl_Category.TabIndex = 25;
            this.lbl_Category.Text = "Item Category :";
            // 
            // cmbox_Item_category
            // 
            this.cmbox_Item_category.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cmbox_Item_category.FormattingEnabled = true;
            this.cmbox_Item_category.Items.AddRange(new object[] {
            "Flowers",
            "Bouquet",
            "Others",
            "Decoration"});
            this.cmbox_Item_category.Location = new System.Drawing.Point(296, 164);
            this.cmbox_Item_category.Name = "cmbox_Item_category";
            this.cmbox_Item_category.Size = new System.Drawing.Size(256, 37);
            this.cmbox_Item_category.TabIndex = 26;
            // 
            // lbl_Itemname
            // 
            this.lbl_Itemname.AutoSize = true;
            this.lbl_Itemname.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Itemname.Location = new System.Drawing.Point(112, 240);
            this.lbl_Itemname.Name = "lbl_Itemname";
            this.lbl_Itemname.Size = new System.Drawing.Size(142, 29);
            this.lbl_Itemname.TabIndex = 27;
            this.lbl_Itemname.Text = "Item Name :";
            // 
            // txt_Itemname
            // 
            this.txt_Itemname.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_Itemname.Location = new System.Drawing.Point(289, 240);
            this.txt_Itemname.Name = "txt_Itemname";
            this.txt_Itemname.Size = new System.Drawing.Size(274, 32);
            this.txt_Itemname.TabIndex = 28;
           // this.txt_Itemname.Click += new System.EventHandler(this.txt_Itemname_Click);
            this.txt_Itemname.TextChanged += new System.EventHandler(this.txt_Itemname_TextChanged);
            // 
            // uc_Additems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_Itemname);
            this.Controls.Add(this.lbl_Itemname);
            this.Controls.Add(this.cmbox_Item_category);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.dataGridView_AddItems);
            this.Controls.Add(this.btn_Cancle);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_AddItems);
            this.Name = "uc_Additems";
            this.Size = new System.Drawing.Size(1899, 839);
            this.Load += new System.EventHandler(this.uc_Additems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AddItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_AddItems;
        private Button btn_Save;
        private Button btn_Delete;
        private Button btn_Update;
        private Button btn_Cancle;
        private DataGridView dataGridView_AddItems;
        private TextBox txt_price;
        private Label lbl_Price;
        private Label lbl_Category;
        private ComboBox cmbox_Item_category;
        private Label lbl_Itemname;
        private TextBox txt_Itemname;
    }
}
