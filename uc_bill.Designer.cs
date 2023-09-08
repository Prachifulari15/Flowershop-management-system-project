namespace flowershop
{
    partial class uc_bill
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
            this.dgv_bill = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_bill
            // 
            this.dgv_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bill.Location = new System.Drawing.Point(85, 187);
            this.dgv_bill.Name = "dgv_bill";
            this.dgv_bill.RowHeadersWidth = 62;
            this.dgv_bill.RowTemplate.Height = 33;
            this.dgv_bill.Size = new System.Drawing.Size(1243, 350);
            this.dgv_bill.TabIndex = 0;
            // 
            // uc_bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_bill);
            this.Name = "uc_bill";
            this.Size = new System.Drawing.Size(1414, 786);
            this.Load += new System.EventHandler(this.uc_bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_bill;
    }
}
