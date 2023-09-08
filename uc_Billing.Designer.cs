namespace flowershop
{
    partial class uc_Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Billing));
            this.lbl_Billing = new System.Windows.Forms.Label();
            this.txt_Customername = new System.Windows.Forms.TextBox();
            this.lbl_Customername = new System.Windows.Forms.Label();
            this.lbl_Mobileno = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Mobileno = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.cmbox_Select_Items = new System.Windows.Forms.ComboBox();
            this.lbl_Item_Name = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_Total_Price = new System.Windows.Forms.TextBox();
            this.lbl_Total_Price = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.btn_Cancle = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // lbl_Billing
            // 
            this.lbl_Billing.AutoSize = true;
            this.lbl_Billing.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Billing.Font = new System.Drawing.Font("Sitka Small", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Billing.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Billing.Location = new System.Drawing.Point(544, 38);
            this.lbl_Billing.Name = "lbl_Billing";
            this.lbl_Billing.Size = new System.Drawing.Size(244, 48);
            this.lbl_Billing.TabIndex = 7;
            this.lbl_Billing.Text = "== Billing ==";
            // 
            // txt_Customername
            // 
            this.txt_Customername.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_Customername.Location = new System.Drawing.Point(331, 195);
            this.txt_Customername.Name = "txt_Customername";
            this.txt_Customername.Size = new System.Drawing.Size(267, 32);
            this.txt_Customername.TabIndex = 53;
            this.txt_Customername.TextChanged += new System.EventHandler(this.txt_Customername_TextChanged);
            this.txt_Customername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.check1);
            this.txt_Customername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Checkname);
            this.txt_Customername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.check3);
            this.txt_Customername.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.check2);
            // 
            // lbl_Customername
            // 
            this.lbl_Customername.AutoSize = true;
            this.lbl_Customername.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Customername.Location = new System.Drawing.Point(144, 195);
            this.lbl_Customername.Name = "lbl_Customername";
            this.lbl_Customername.Size = new System.Drawing.Size(181, 29);
            this.lbl_Customername.TabIndex = 52;
            this.lbl_Customername.Text = "Cutomer Name :";
            // 
            // lbl_Mobileno
            // 
            this.lbl_Mobileno.AutoSize = true;
            this.lbl_Mobileno.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Mobileno.Location = new System.Drawing.Point(144, 265);
            this.lbl_Mobileno.Name = "lbl_Mobileno";
            this.lbl_Mobileno.Size = new System.Drawing.Size(129, 29);
            this.lbl_Mobileno.TabIndex = 89;
            this.lbl_Mobileno.Text = "Mobile no :";
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_Address.Location = new System.Drawing.Point(331, 323);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(267, 32);
            this.txt_Address.TabIndex = 88;
            this.txt_Address.TextChanged += new System.EventHandler(this.txt_Address_TextChanged);
            // 
            // txt_Mobileno
            // 
            this.txt_Mobileno.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_Mobileno.Location = new System.Drawing.Point(331, 262);
            this.txt_Mobileno.Name = "txt_Mobileno";
            this.txt_Mobileno.Size = new System.Drawing.Size(267, 32);
            this.txt_Mobileno.TabIndex = 87;
            this.txt_Mobileno.TextChanged += new System.EventHandler(this.txt_Mobileno_TextChanged);
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Address.Location = new System.Drawing.Point(153, 326);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(110, 29);
            this.lbl_Address.TabIndex = 86;
            this.lbl_Address.Text = "Address :";
            // 
            // cmbox_Select_Items
            // 
            this.cmbox_Select_Items.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cmbox_Select_Items.FormattingEnabled = true;
            this.cmbox_Select_Items.Items.AddRange(new object[] {
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
            "Basket Bouquet",
            "Standing Bouquet",
            "Possy Bouquet",
            "Hoop Bouquet",
            "Hand Bouquet",
            "Multi flower Bouquet",
            "Tulip flower Bouquet",
            "House Decoration",
            "Birthday Decoration",
            "Engagement Decoration",
            "Wedding Decoration",
            "Car Decoration",
            "Temple Decoration",
            "Wedding Varmala",
            "Flowers Jewellary"});
            this.cmbox_Select_Items.Location = new System.Drawing.Point(335, 391);
            this.cmbox_Select_Items.Name = "cmbox_Select_Items";
            this.cmbox_Select_Items.Size = new System.Drawing.Size(278, 37);
            this.cmbox_Select_Items.TabIndex = 93;
            // 
            // lbl_Item_Name
            // 
            this.lbl_Item_Name.AutoSize = true;
            this.lbl_Item_Name.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Item_Name.Location = new System.Drawing.Point(139, 391);
            this.lbl_Item_Name.Name = "lbl_Item_Name";
            this.lbl_Item_Name.Size = new System.Drawing.Size(154, 29);
            this.lbl_Item_Name.TabIndex = 92;
            this.lbl_Item_Name.Text = "Iteam Name :";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_Quantity.Location = new System.Drawing.Point(334, 524);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(267, 32);
            this.txt_Quantity.TabIndex = 111;
            this.txt_Quantity.TextChanged += new System.EventHandler(this.txt_Quantity_TextChanged);
            // 
            // txt_Total_Price
            // 
            this.txt_Total_Price.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_Total_Price.Location = new System.Drawing.Point(331, 606);
            this.txt_Total_Price.Name = "txt_Total_Price";
            this.txt_Total_Price.Size = new System.Drawing.Size(267, 32);
            this.txt_Total_Price.TabIndex = 110;
            // 
            // lbl_Total_Price
            // 
            this.lbl_Total_Price.AutoSize = true;
            this.lbl_Total_Price.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Total_Price.Location = new System.Drawing.Point(129, 597);
            this.lbl_Total_Price.Name = "lbl_Total_Price";
            this.lbl_Total_Price.Size = new System.Drawing.Size(140, 29);
            this.lbl_Total_Price.TabIndex = 109;
            this.lbl_Total_Price.Text = "Total Price :";
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_Price.Location = new System.Drawing.Point(334, 458);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(267, 32);
            this.txt_Price.TabIndex = 108;
            this.txt_Price.TextChanged += new System.EventHandler(this.txt_Price_TextChanged);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Price.Location = new System.Drawing.Point(139, 458);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(81, 29);
            this.lbl_Price.TabIndex = 107;
            this.lbl_Price.Text = "Price :";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Quantity.Location = new System.Drawing.Point(129, 524);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(119, 29);
            this.lbl_Quantity.TabIndex = 106;
            this.lbl_Quantity.Text = "Quantity :";
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.BackColor = System.Drawing.Color.DeepPink;
            this.btn_Cancle.Font = new System.Drawing.Font("Sitka Small", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Cancle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Cancle.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancle.Image")));
            this.btn_Cancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancle.Location = new System.Drawing.Point(519, 763);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(288, 64);
            this.btn_Cancle.TabIndex = 116;
            this.btn_Cancle.Text = "Cancle";
            this.btn_Cancle.UseVisualStyleBackColor = false;
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.DeepPink;
            this.btn_Print.Font = new System.Drawing.Font("Sitka Small", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Print.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Print.Image = ((System.Drawing.Image)(resources.GetObject("btn_Print.Image")));
            this.btn_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Print.Location = new System.Drawing.Point(94, 763);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(292, 64);
            this.btn_Print.TabIndex = 117;
            this.btn_Print.Text = "PrintBill";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // uc_Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Cancle);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_Total_Price);
            this.Controls.Add(this.lbl_Total_Price);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.cmbox_Select_Items);
            this.Controls.Add(this.lbl_Item_Name);
            this.Controls.Add(this.lbl_Mobileno);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_Mobileno);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.txt_Customername);
            this.Controls.Add(this.lbl_Customername);
            this.Controls.Add(this.lbl_Billing);
            this.Name = "uc_Billing";
            this.Size = new System.Drawing.Size(1407, 984);
            this.Load += new System.EventHandler(this.uc_Billing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Billing;
        private TextBox txt_Customername;
        private Label lbl_Customername;
        private Label lbl_Mobileno;
        private TextBox txt_Address;
        private TextBox txt_Mobileno;
        private Label lbl_Address;
        private ComboBox cmbox_Select_Items;
        private Label lbl_Item_Name;
        private TextBox txt_Quantity;
        private TextBox txt_Total_Price;
        private Label lbl_Total_Price;
        private TextBox txt_Price;
        private Label lbl_Price;
        private Label lbl_Quantity;
        private Button btn_Cancle;
        private Button btn_Print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}
