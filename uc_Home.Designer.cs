namespace flowershop
{
    partial class uc_Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_Home));
            this.label1 = new System.Windows.Forms.Label();
            this.picbox_slider = new System.Windows.Forms.PictureBox();
            this.btn_OrderNow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_slider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(112, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Fresh Flowers Shop...";
            // 
            // picbox_slider
            // 
            this.picbox_slider.Image = ((System.Drawing.Image)(resources.GetObject("picbox_slider.Image")));
            this.picbox_slider.Location = new System.Drawing.Point(112, 223);
            this.picbox_slider.Name = "picbox_slider";
            this.picbox_slider.Size = new System.Drawing.Size(1174, 428);
            this.picbox_slider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_slider.TabIndex = 3;
            this.picbox_slider.TabStop = false;
            // 
            // btn_OrderNow
            // 
            this.btn_OrderNow.BackColor = System.Drawing.Color.DeepPink;
            this.btn_OrderNow.Font = new System.Drawing.Font("Sitka Small", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_OrderNow.Location = new System.Drawing.Point(556, 754);
            this.btn_OrderNow.Name = "btn_OrderNow";
            this.btn_OrderNow.Size = new System.Drawing.Size(377, 79);
            this.btn_OrderNow.TabIndex = 4;
            this.btn_OrderNow.Text = "Order Now";
            this.btn_OrderNow.UseVisualStyleBackColor = false;
            this.btn_OrderNow.Click += new System.EventHandler(this.btn_OrderNow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(878, 668);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(609, 53);
            this.label3.TabIndex = 5;
            this.label3.Text = "Make Occassion more special...";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // uc_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_OrderNow);
            this.Controls.Add(this.picbox_slider);
            this.Controls.Add(this.label1);
            this.Name = "uc_Home";
            this.Size = new System.Drawing.Size(1526, 874);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox picbox_slider;
        private Button btn_OrderNow;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}
