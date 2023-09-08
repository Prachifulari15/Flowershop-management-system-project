namespace flowershop
{
    partial class uc_fbo
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
            this.radiobtn_Flowers = new System.Windows.Forms.RadioButton();
            this.radiobtn_Bouquet = new System.Windows.Forms.RadioButton();
            this.lbl_SelectItem = new System.Windows.Forms.Label();
            this.cmbox_Select_Item = new System.Windows.Forms.ComboBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.dtp_Delivery_order_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Delivery_orderdate = new System.Windows.Forms.Label();
            this.lbl_Mobileno = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Mobileno = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.txt_Customer_Name = new System.Windows.Forms.TextBox();
            this.lbl_Firstname = new System.Windows.Forms.Label();
            this.dtp_Orderdate = new System.Windows.Forms.DateTimePicker();
            this.lbl_Orderdate = new System.Windows.Forms.Label();
            this.dataGridView_fbo = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fbo)).BeginInit();
            this.SuspendLayout();
            // 
            // radiobtn_Flowers
            // 
            this.radiobtn_Flowers.AutoSize = true;
            this.radiobtn_Flowers.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radiobtn_Flowers.Location = new System.Drawing.Point(849, 112);
            this.radiobtn_Flowers.Name = "radiobtn_Flowers";
            this.radiobtn_Flowers.Size = new System.Drawing.Size(120, 33);
            this.radiobtn_Flowers.TabIndex = 0;
            this.radiobtn_Flowers.TabStop = true;
            this.radiobtn_Flowers.Text = "Flowers";
            this.radiobtn_Flowers.UseVisualStyleBackColor = true;
            this.radiobtn_Flowers.CheckedChanged += new System.EventHandler(this.radiobtn_Flowers_CheckedChanged);
            // 
            // radiobtn_Bouquet
            // 
            this.radiobtn_Bouquet.AutoSize = true;
            this.radiobtn_Bouquet.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radiobtn_Bouquet.Location = new System.Drawing.Point(1052, 112);
            this.radiobtn_Bouquet.Name = "radiobtn_Bouquet";
            this.radiobtn_Bouquet.Size = new System.Drawing.Size(123, 33);
            this.radiobtn_Bouquet.TabIndex = 1;
            this.radiobtn_Bouquet.TabStop = true;
            this.radiobtn_Bouquet.Text = "Bouquet";
            this.radiobtn_Bouquet.UseVisualStyleBackColor = true;
            this.radiobtn_Bouquet.CheckedChanged += new System.EventHandler(this.radiobtn_Bouquet_CheckedChanged);
            // 
            // lbl_SelectItem
            // 
            this.lbl_SelectItem.AutoSize = true;
            this.lbl_SelectItem.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_SelectItem.Location = new System.Drawing.Point(683, 205);
            this.lbl_SelectItem.Name = "lbl_SelectItem";
            this.lbl_SelectItem.Size = new System.Drawing.Size(142, 29);
            this.lbl_SelectItem.TabIndex = 2;
            this.lbl_SelectItem.Text = "Select Iteam";
            // 
            // cmbox_Select_Item
            // 
            this.cmbox_Select_Item.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cmbox_Select_Item.FormattingEnabled = true;
            this.cmbox_Select_Item.Location = new System.Drawing.Point(867, 205);
            this.cmbox_Select_Item.Name = "cmbox_Select_Item";
            this.cmbox_Select_Item.Size = new System.Drawing.Size(395, 37);
            this.cmbox_Select_Item.TabIndex = 3;
            this.cmbox_Select_Item.SelectedIndexChanged += new System.EventHandler(this.cmbox_Select_Item_SelectedIndexChanged);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Price.Location = new System.Drawing.Point(683, 302);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(67, 29);
            this.lbl_Price.TabIndex = 4;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Quantity.Location = new System.Drawing.Point(927, 302);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(105, 29);
            this.lbl_Quantity.TabIndex = 5;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Total.Location = new System.Drawing.Point(1190, 302);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(66, 29);
            this.lbl_Total.TabIndex = 6;
            this.lbl_Total.Text = "Total";
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_Price.Location = new System.Drawing.Point(675, 364);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(150, 32);
            this.txt_Price.TabIndex = 7;
            // 
            // txt_Total
            // 
            this.txt_Total.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_Total.Location = new System.Drawing.Point(1190, 364);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(150, 32);
            this.txt_Total.TabIndex = 8;
            // 
            // dtp_Delivery_order_date
            // 
            this.dtp_Delivery_order_date.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dtp_Delivery_order_date.Location = new System.Drawing.Point(333, 400);
            this.dtp_Delivery_order_date.Name = "dtp_Delivery_order_date";
            this.dtp_Delivery_order_date.Size = new System.Drawing.Size(278, 32);
            this.dtp_Delivery_order_date.TabIndex = 54;
            // 
            // lbl_Delivery_orderdate
            // 
            this.lbl_Delivery_orderdate.AutoSize = true;
            this.lbl_Delivery_orderdate.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Delivery_orderdate.Location = new System.Drawing.Point(81, 403);
            this.lbl_Delivery_orderdate.Name = "lbl_Delivery_orderdate";
            this.lbl_Delivery_orderdate.Size = new System.Drawing.Size(234, 29);
            this.lbl_Delivery_orderdate.TabIndex = 53;
            this.lbl_Delivery_orderdate.Text = "Delivery Order Date :";
            // 
            // lbl_Mobileno
            // 
            this.lbl_Mobileno.AutoSize = true;
            this.lbl_Mobileno.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Mobileno.Location = new System.Drawing.Point(94, 163);
            this.lbl_Mobileno.Name = "lbl_Mobileno";
            this.lbl_Mobileno.Size = new System.Drawing.Size(129, 29);
            this.lbl_Mobileno.TabIndex = 50;
            this.lbl_Mobileno.Text = "Mobile no :";
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_Address.Location = new System.Drawing.Point(249, 238);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(267, 32);
            this.txt_Address.TabIndex = 49;
            // 
            // txt_Mobileno
            // 
            this.txt_Mobileno.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_Mobileno.Location = new System.Drawing.Point(258, 163);
            this.txt_Mobileno.Name = "txt_Mobileno";
            this.txt_Mobileno.Size = new System.Drawing.Size(267, 32);
            this.txt_Mobileno.TabIndex = 48;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Address.Location = new System.Drawing.Point(94, 240);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(110, 29);
            this.lbl_Address.TabIndex = 47;
            this.lbl_Address.Text = "Address :";
            // 
            // txt_Customer_Name
            // 
            this.txt_Customer_Name.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_Customer_Name.Location = new System.Drawing.Point(288, 90);
            this.txt_Customer_Name.Name = "txt_Customer_Name";
            this.txt_Customer_Name.Size = new System.Drawing.Size(267, 32);
            this.txt_Customer_Name.TabIndex = 46;
            // 
            // lbl_Firstname
            // 
            this.lbl_Firstname.AutoSize = true;
            this.lbl_Firstname.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Firstname.Location = new System.Drawing.Point(90, 90);
            this.lbl_Firstname.Name = "lbl_Firstname";
            this.lbl_Firstname.Size = new System.Drawing.Size(192, 29);
            this.lbl_Firstname.TabIndex = 45;
            this.lbl_Firstname.Text = "Customer Name :";
            // 
            // dtp_Orderdate
            // 
            this.dtp_Orderdate.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dtp_Orderdate.Location = new System.Drawing.Point(261, 319);
            this.dtp_Orderdate.Name = "dtp_Orderdate";
            this.dtp_Orderdate.Size = new System.Drawing.Size(278, 32);
            this.dtp_Orderdate.TabIndex = 44;
            // 
            // lbl_Orderdate
            // 
            this.lbl_Orderdate.AutoSize = true;
            this.lbl_Orderdate.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Orderdate.Location = new System.Drawing.Point(94, 319);
            this.lbl_Orderdate.Name = "lbl_Orderdate";
            this.lbl_Orderdate.Size = new System.Drawing.Size(140, 29);
            this.lbl_Orderdate.TabIndex = 43;
            this.lbl_Orderdate.Text = "Order Date :";
            // 
            // dataGridView_fbo
            // 
            this.dataGridView_fbo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_fbo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_fbo.Location = new System.Drawing.Point(12, 638);
            this.dataGridView_fbo.Name = "dataGridView_fbo";
            this.dataGridView_fbo.RowHeadersWidth = 62;
            this.dataGridView_fbo.RowTemplate.Height = 33;
            this.dataGridView_fbo.Size = new System.Drawing.Size(1863, 225);
            this.dataGridView_fbo.TabIndex = 107;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DeepPink;
            this.btn_Search.Font = new System.Drawing.Font("Sitka Small", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Search.Location = new System.Drawing.Point(1076, 517);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(173, 64);
            this.btn_Search.TabIndex = 106;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.DeepPink;
            this.btn_Update.Font = new System.Drawing.Font("Sitka Small", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Update.Location = new System.Drawing.Point(796, 517);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(183, 64);
            this.btn_Update.TabIndex = 105;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.DeepPink;
            this.btn_Delete.Font = new System.Drawing.Font("Sitka Small", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Delete.Location = new System.Drawing.Point(519, 517);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(185, 64);
            this.btn_Delete.TabIndex = 104;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.DeepPink;
            this.btn_Save.Font = new System.Drawing.Font("Sitka Small", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Save.Location = new System.Drawing.Point(261, 517);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(176, 64);
            this.btn_Save.TabIndex = 103;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_Quantity.Location = new System.Drawing.Point(908, 364);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(150, 32);
            this.txt_Quantity.TabIndex = 108;
            // 
            // uc_fbo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.dataGridView_fbo);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dtp_Delivery_order_date);
            this.Controls.Add(this.lbl_Delivery_orderdate);
            this.Controls.Add(this.lbl_Mobileno);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_Mobileno);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.txt_Customer_Name);
            this.Controls.Add(this.lbl_Firstname);
            this.Controls.Add(this.dtp_Orderdate);
            this.Controls.Add(this.lbl_Orderdate);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.cmbox_Select_Item);
            this.Controls.Add(this.lbl_SelectItem);
            this.Controls.Add(this.radiobtn_Bouquet);
            this.Controls.Add(this.radiobtn_Flowers);
            this.Name = "uc_fbo";
            this.Size = new System.Drawing.Size(1494, 908);
            this.Load += new System.EventHandler(this.uc_fbo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fbo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton radiobtn_Flowers;
        private RadioButton radiobtn_Bouquet;
        private Label lbl_SelectItem;
        private ComboBox cmbox_Select_Item;
        private Label lbl_Price;
        private Label lbl_Quantity;
        private Label lbl_Total;
        private TextBox txt_Price;
        private TextBox txt_Total;
        private DateTimePicker dtp_Delivery_order_date;
        private Label lbl_Delivery_orderdate;
        private Label lbl_Mobileno;
        private TextBox txt_Address;
        private TextBox txt_Mobileno;
        private Label lbl_Address;
        private TextBox txt_Customer_Name;
        private Label lbl_Firstname;
        private DateTimePicker dtp_Orderdate;
        private Label lbl_Orderdate;
        private DataGridView dataGridView_fbo;
        private Button btn_Search;
        private Button btn_Update;
        private Button btn_Delete;
        private Button btn_Save;
        private TextBox txt_Quantity;
    }
}
