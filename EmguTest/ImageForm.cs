using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmguTest
{
    public partial class ImageForm : Form
    {
        private static string FILE_PATH_TEST_IMAGE = @"C:\Users\Isiah\Pictures\cotn\templates\test.png";
        private static string FILE_PATH_IMAGE = @"C:\Users\Isiah\Pictures\cotn\templates\Cadence.png";


        public ImageForm()
        {
            InitializeComponent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            picBox.Image = Image.FromFile(FILE_PATH_IMAGE);
        }

        private void btn_tpreset_Click(object sender, EventArgs e)
        {
            /* This section of code verify that the raw image loaded into a Bitmap object (raw -> Image -> Bitmap) contains alpha data
            var i = Image.FromFile(FILE_PATH_TEST_IMAGE);
            var b = new Bitmap(i);
            var hasAlpha = Image.IsAlphaPixelFormat(b.PixelFormat);
            */
            picBox.Image = Image.FromFile(FILE_PATH_TEST_IMAGE);
        }

        private void btn_process_Click(object sender, EventArgs e)
        {
            var image = picBox.Image;
            var src = new Emgu.CV.Image<Rgba, byte>(new Bitmap(image));

            rgba = src.Split(); // 4 grayscale

            var dst = new Emgu.CV.Image<Rgba, byte>(
                new Emgu.CV.Image<Gray, byte>[]
                {
                    rgba[0],
                    rgba[1],
                    rgba[2],
                    rgba[3]
                });

            if (rgba != null && rgba.Length == 4)
            {
                EnableChannelButtons();
            }

            Processed = dst;
        }

        private static Emgu.CV.Image<Gray, byte>[] rgba;
        private static Emgu.CV.Image<Rgba, byte> Processed { get; set; }

        private void EnableChannelButtons()
        {
            btn_c1.Enabled = btn_c2.Enabled = btn_c3.Enabled = btn_c4.Enabled = true;
        }
        private void DisableChannelButtons()
        {
            btn_c1.Enabled = btn_c2.Enabled = btn_c3.Enabled = btn_c4.Enabled = false;
        }

        private void DisplayChannelImage(Emgu.CV.Image<Gray, byte> channel)
        {
            picBox.Image = channel.ToBitmap();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // restored processed image
            // 1. load the image to be processed (test image with transparent background)
            // 2. Process (which the processed image is stored in the program)
            // 3. Swtich to antoher image (candence)
            // 4. Restore the verfiy the transparency retains.
            
            // 5. Result: Transparency lost. :(
            if (Processed != null)
            {
                picBox.Image = Processed.ToBitmap();
            }
        }

        private void btn_c1_Click(object sender, EventArgs e)
        {
            DisplayChannelImage(rgba[0]);
        }

        private void btn_c2_Click(object sender, EventArgs e)
        {
            DisplayChannelImage(rgba[1]);
        }

        private void btn_c3_Click(object sender, EventArgs e)
        {
            DisplayChannelImage(rgba[2]);
        }

        private void btn_c4_Click(object sender, EventArgs e)
        {
            DisplayChannelImage(rgba[3]);
        }
    }
}
