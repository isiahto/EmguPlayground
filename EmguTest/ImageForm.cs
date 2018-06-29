using System.IO;
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
        private static string FILE_PATH_IMAGE = @"Images\Sprites\Entities\Cadence.png";


        public ImageForm()
        {
            InitializeComponent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            picBox.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, FILE_PATH_IMAGE));
            
        }

        private void btn_tpreset_Click(object sender, EventArgs e)
        {
            /* This section of code verify that the raw image loaded into a Bitmap object (raw -> Image -> Bitmap) contains alpha data
            var i = Image.FromFile(FILE_PATH_TEST_IMAGE);
            var b = new Bitmap(i);
            var hasAlpha = Image.IsAlphaPixelFormat(b.PixelFormat);

            However, it has been verified that:
                Image<Rgba, byte>().ToBitmap()
            does not display transparent data, because PNG USE BGRA !!!
            */
            // picBox.Image = Image.FromFile(FILE_PATH_TEST_IMAGE);
            picBox.Image = new Emgu.CV.Image<Bgra, byte>(Path.Combine(Environment.CurrentDirectory, FILE_PATH_IMAGE)).ToBitmap();
        }

        private void btn_process_Click(object sender, EventArgs e)
        {
            var image = picBox.Image;
            var src = new Emgu.CV.Image<Bgra, byte>(new Bitmap(image));
            SplitChannels(src);

            // Perform binary thresolding here:
            var channels = src.Split();
            var alpha = channels[3];
            var g = src.Convert<Gray, byte>();

            // right now, alpha is all 255 (full white)
            // we need to apply thresold so that:
            // if it is black (or super low like < 5) then assign to 0;
            // Otherwise, it should be part of the image hence alpha = 255;
            var newAlpha = g.ThresholdBinary(new Gray(10), new Gray(255));

            var newImage = new Emgu.CV.Image<Bgra, byte>(
                new Emgu.CV.Image<Gray, byte>[] 
                {
                    channels[0],
                    channels[1],
                    channels[2],
                    newAlpha
                });

            picBox.Image = newImage.ToBitmap();
        }

        private void SplitChannels(Emgu.CV.Image<Bgra, byte> src)
        {
            bgra = src.Split(); // 4 grayscale

            var dst = new Emgu.CV.Image<Bgra, byte>(
                new Emgu.CV.Image<Gray, byte>[]
                {
                    bgra[0],
                    bgra[1],
                    bgra[2],
                    bgra[3]
                });

            Processed = dst;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var sd = new SaveFileDialog();
            if (sd.ShowDialog() == DialogResult.OK)
            {
                picBox.Image.Save(sd.FileName);
                Console.WriteLine("File saved!");
            }
            else
            {
                Console.WriteLine("File did not save...");
            }
        }

        private static Emgu.CV.Image<Gray, byte>[] bgra;
        private static Emgu.CV.Image<Bgra, byte> Processed { get; set; }

        #region Debug channel splitting
        private void DisplayChannelImage(Emgu.CV.Image<Gray, byte> channel)
        {
            if (channel != null)
            {
                picBox.Image = channel.ToBitmap();
            }
            else
            {
                Console.WriteLine("Channel is null! Check splitting => rgba process.");
            }
        }

        private void btn_c1_Click(object sender, EventArgs e)
        {
            DisplayChannelImage(bgra?[0]);
        }

        private void btn_c2_Click(object sender, EventArgs e)
        {
            DisplayChannelImage(bgra?[1]);
        }

        private void btn_c3_Click(object sender, EventArgs e)
        {
            DisplayChannelImage(bgra?[2]);
        }

        private void btn_c4_Click(object sender, EventArgs e)
        {
            DisplayChannelImage(bgra?[3]);
        }
        #endregion

    }
}
