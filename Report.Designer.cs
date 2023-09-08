namespace flowershop
{
    partial class Report
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_side_Homepage = new System.Windows.Forms.Panel();
            this.btn_Bouquet_Report = new System.Windows.Forms.Button();
            this.btn_Flowers_Report = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.Panel();
            this.btn_Decoration_Report = new System.Windows.Forms.Button();
            this.uc_Flower_Report1 = new flowershop.uc_Flower_Report();
            this.pnl_side_Homepage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_side_Homepage
            // 
            this.pnl_side_Homepage.BackColor = System.Drawing.Color.DeepPink;
            this.pnl_side_Homepage.Controls.Add(this.btn_Bouquet_Report);
            this.pnl_side_Homepage.Controls.Add(this.btn_Flowers_Report);
            this.pnl_side_Homepage.Controls.Add(this.p1);
            this.pnl_side_Homepage.Controls.Add(this.btn_Decoration_Report);
            this.pnl_side_Homepage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_side_Homepage.ForeColor = System.Drawing.Color.Coral;
            this.pnl_side_Homepage.Location = new System.Drawing.Point(0, 0);
            this.pnl_side_Homepage.Name = "pnl_side_Homepage";
            this.pnl_side_Homepage.Size = new System.Drawing.Size(348, 946);
            this.pnl_side_Homepage.TabIndex = 7;
            // 
            // btn_Bouquet_Report
            // 
            this.btn_Bouquet_Report.FlatAppearance.BorderSize = 0;
            this.btn_Bouquet_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bouquet_Report.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Bouquet_Report.ForeColor = System.Drawing.Color.White;
            this.btn_Bouquet_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Bouquet_Report.Location = new System.Drawing.Point(33, 355);
            this.btn_Bouquet_Report.Name = "btn_Bouquet_Report";
            this.btn_Bouquet_Report.Size = new System.Drawing.Size(312, 60);
            this.btn_Bouquet_Report.TabIndex = 2;
            this.btn_Bouquet_Report.Text = "Bouquet Sales Report";
            this.btn_Bouquet_Report.UseVisualStyleBackColor = true;
            this.btn_Bouquet_Report.Click += new System.EventHandler(this.btn_Bouquet_Report_Click);
            // 
            // btn_Flowers_Report
            // 
            this.btn_Flowers_Report.FlatAppearance.BorderSize = 0;
            this.btn_Flowers_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Flowers_Report.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Flowers_Report.ForeColor = System.Drawing.Color.White;
            this.btn_Flowers_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Flowers_Report.Location = new System.Drawing.Point(36, 289);
            this.btn_Flowers_Report.Name = "btn_Flowers_Report";
            this.btn_Flowers_Report.Size = new System.Drawing.Size(309, 60);
            this.btn_Flowers_Report.TabIndex = 6;
            this.btn_Flowers_Report.Text = "Flowers Sales Report";
            this.btn_Flowers_Report.UseVisualStyleBackColor = true;
            this.btn_Flowers_Report.Click += new System.EventHandler(this.btn_Flowers_Report_Click);
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Navy;
            this.p1.Location = new System.Drawing.Point(12, 289);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(10, 60);
            this.p1.TabIndex = 2;
            // 
            // btn_Decoration_Report
            // 
            this.btn_Decoration_Report.FlatAppearance.BorderSize = 0;
            this.btn_Decoration_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Decoration_Report.Font = new System.Drawing.Font("Sitka Small", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Decoration_Report.ForeColor = System.Drawing.Color.White;
            this.btn_Decoration_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Decoration_Report.Location = new System.Drawing.Point(33, 421);
            this.btn_Decoration_Report.Name = "btn_Decoration_Report";
            this.btn_Decoration_Report.Size = new System.Drawing.Size(312, 91);
            this.btn_Decoration_Report.TabIndex = 3;
            this.btn_Decoration_Report.Text = "Decorations Booking Report";
            this.btn_Decoration_Report.UseVisualStyleBackColor = true;
            this.btn_Decoration_Report.Click += new System.EventHandler(this.btn_Decoration_Report_Click);
            // 
            // uc_Flower_Report1
            // 
            this.uc_Flower_Report1.Location = new System.Drawing.Point(351, 0);
            this.uc_Flower_Report1.Name = "uc_Flower_Report1";
            this.uc_Flower_Report1.Size = new System.Drawing.Size(2263, 1486);
            this.uc_Flower_Report1.TabIndex = 8;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 946);
            this.Controls.Add(this.uc_Flower_Report1);
            this.Controls.Add(this.pnl_side_Homepage);
            this.Name = "Report";
            this.Text = "Report";
            this.pnl_side_Homepage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_side_Homepage;
        private Button btn_Bouquet_Report;
        private Button btn_Flowers_Report;
        private Panel p1;
        private Button btn_Decoration_Report;
        private uc_Flower_Report uc_Flower_Report1;
    }
}