using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flowershop
{
    public partial class uc_Home : UserControl
    {
        public uc_Home()
        {
            InitializeComponent();
        }
        private int imageNumber = 1;      //Images Slider
        
        private void LoadNextImage()
        {
            if (imageNumber == 10)
            {
                imageNumber = 1;
                picbox_slider.ImageLocation = String.Format(@"ImageSlider\\{0}.jpg", imageNumber);
                imageNumber++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //int i;
            LoadNextImage();
           /* if (Image < 10)
            {
                picbox_slider.ImageLocation = "F:\\FlowerShop Management Project\\ImageSlider\\" + Image + ".jpg";
                Image++;
            }*/
        }

         private void btn_OrderNow_Click(object sender, EventArgs e)
         {
            /* uc_Placeorder pc = new uc_Placeorder();
             pc.Show();*/

            uc_Flowers_Order fo = new uc_Flowers_Order();
            fo.Dock = DockStyle.Fill;
            this.Controls.Add(fo);
            fo.Visible = true;
            fo.BringToFront();

        }
         /*private int imageNumber = 1;
         private void LoadNextImage()
         {
             if(imageNumber == 10)
             {
                 imageNumber = 1;
                 picbox_slider.ImageLocation = String.Format(@"ImageSlider\{0}.jpg", imageNumber);
                 imageNumber++;
             }
         }

         private void timer1_Tick(object sender, EventArgs e)
         {
             LoadNextImage();
         }
     }*/
    }
}
