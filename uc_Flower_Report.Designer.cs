namespace flowershop
{
    partial class uc_Flower_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Flower_Report));
            this.lbl_From = new System.Windows.Forms.Label();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.lbl_To = new System.Windows.Forms.Label();
            this.btn_Load = new System.Windows.Forms.Button();
            this.dataGridView_Flower_Report = new System.Windows.Forms.DataGridView();
            this.lbl_Flower_Report = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Flower_Report)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_From.Location = new System.Drawing.Point(205, 154);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(82, 29);
            this.lbl_From.TabIndex = 104;
            this.lbl_From.Text = "From :";
            // 
            // dtp_From
            // 
            this.dtp_From.Location = new System.Drawing.Point(302, 154);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(278, 31);
            this.dtp_From.TabIndex = 105;
            // 
            // dtp_to
            // 
            this.dtp_to.Location = new System.Drawing.Point(757, 154);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(278, 31);
            this.dtp_to.TabIndex = 107;
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Font = new System.Drawing.Font("Sitka Small", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_To.Location = new System.Drawing.Point(699, 154);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(52, 29);
            this.lbl_To.TabIndex = 106;
            this.lbl_To.Text = "To :";
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.DeepPink;
            this.btn_Load.Font = new System.Drawing.Font("Sitka Small", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Load.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Load.Image = ((System.Drawing.Image)(resources.GetObject("btn_Load.Image")));
            this.btn_Load.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Load.Location = new System.Drawing.Point(1109, 139);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(176, 64);
            this.btn_Load.TabIndex = 124;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // dataGridView_Flower_Report
            // 
            this.dataGridView_Flower_Report.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Flower_Report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Flower_Report.Location = new System.Drawing.Point(49, 257);
            this.dataGridView_Flower_Report.Name = "dataGridView_Flower_Report";
            this.dataGridView_Flower_Report.RowHeadersWidth = 62;
            this.dataGridView_Flower_Report.RowTemplate.Height = 33;
            this.dataGridView_Flower_Report.Size = new System.Drawing.Size(1451, 444);
            this.dataGridView_Flower_Report.TabIndex = 125;
            // 
            // lbl_Flower_Report
            // 
            this.lbl_Flower_Report.AutoSize = true;
            this.lbl_Flower_Report.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Flower_Report.Font = new System.Drawing.Font("Sitka Small", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Flower_Report.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Flower_Report.Location = new System.Drawing.Point(522, 58);
            this.lbl_Flower_Report.Name = "lbl_Flower_Report";
            this.lbl_Flower_Report.Size = new System.Drawing.Size(373, 48);
            this.lbl_Flower_Report.TabIndex = 133;
            this.lbl_Flower_Report.Text = "== Flower Report ==";
            // 
            // uc_Flower_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Flower_Report);
            this.Controls.Add(this.dataGridView_Flower_Report);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.dtp_to);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.dtp_From);
            this.Controls.Add(this.lbl_From);
            this.Name = "uc_Flower_Report";
            this.Size = new System.Drawing.Size(1466, 882);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Flower_Report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_From;
        private DateTimePicker dtp_From;
        private DateTimePicker dtp_to;
        private Label lbl_To;
        private Button btn_Load;
        private DataGridView dataGridView_Flower_Report;
        private Label lbl_Flower_Report;
    }
}
