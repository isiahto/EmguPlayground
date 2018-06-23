using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EmguTest
{
    public partial class Form1 : Form
    {
        // private static string IMAGE_PATH = @"C:\Users\Isiah\Pictures\cotn\templates\Cadence.png";
        private static string IMAGE_PATH = @"C:\Users\Isiah\Pictures\cotn\templates\test.png";
        private static Image<Rgba, byte> DEFAULT_IMAGE = new Image<Rgba, byte>(IMAGE_PATH);

        public Form1()
        {
            InitializeComponent();
            InitImage();
            //LoadImageData();
            //RunTemplateMatching();
        }

        private void InitImage()
        {
            SetImage(DEFAULT_IMAGE);
        }

        private void SetImage(IImage src)
            => imgBox.Image = src;

       

        private void ConvertBlackToTransparent()
        {
            var gray = new Image<Gray, byte>(DEFAULT_IMAGE.Bitmap);
            var alphaImg = gray.ThresholdBinary(new Gray(10), new Gray(255));
            var alpha = alphaImg.Mat;

            var mats = DEFAULT_IMAGE.Mat.Split();

            Mat[] rgba = { mats[0], mats[1], mats[2], alpha  };

            var vMat = new VectorOfMat(rgba);
            var final = new Mat(gray.Rows, gray.Cols, Emgu.CV.CvEnum.DepthType.Cv8U, 4);
            CvInvoke.Merge(vMat, final);

            imgBox.Image = final.ToImage<Rgba, byte>();

        }

        private void ConvertBlackToTransparent(Bitmap image)
        {
            //Mat src = new Mat(new Size(image.Width, image.Height),
            //                    Emgu.CV.CvEnum.DepthType.Cv8U, 4);

            var src = new Image<Rgb, byte>(image);
            var graySrc = src.Convert<Gray, byte>();

            // var alpha = graySrc.ThresholdBinary(new Gray(100), new Gray(255));

            var srcMat = src.Mat;
            var finalMat = new Mat(image.Height, image.Width, Emgu.CV.CvEnum.DepthType.Cv8U, 4);
            var tmp = new Mat(image.Height, image.Width, Emgu.CV.CvEnum.DepthType.Cv8U, 1);
            var alpha = new Mat(image.Height, image.Width, Emgu.CV.CvEnum.DepthType.Cv8U, 1);

            CvInvoke.CvtColor(srcMat, tmp, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            imgBox.Image = tmp.ToImage<Rgba, byte>();

            CvInvoke.Threshold(tmp, alpha, 100, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
            imgBox.Image = alpha.ToImage<Rgba, byte>();


            var rgb = new VectorOfMat(3);

            CvInvoke.Split(srcMat, rgb);

            Mat[] rgba = { rgb[0], rgb[1], rgb[2], alpha };

            VectorOfMat rgbaMat = new VectorOfMat(rgba);

            CvInvoke.Merge(rgbaMat, finalMat);

            imgBox.Image = finalMat.ToImage<Rgba, byte>();

            //Mat m = new Mat(image.Height, image.Width, Emgu.CV.CvEnum.DepthType.Cv8U, 4);

            //m.PushBack(src[0].Mat);
            //m.PushBack(src[1].Mat);
            //m.PushBack(src[2].Mat);
            //m.PushBack(alpha.Mat);

            //imgBox.Image = m.ToImage<Rgba, byte>();
        }

        private void LoadImageData()
        {
            var src = new Bitmap(Image.FromFile(IMAGE_PATH));
            ConvertBlackToTransparent(src);
            // imgBox.Image = new Image<Rgba, byte>(src);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            InitImage();
        }

        private void btn_rmat_Click(object sender, EventArgs e)
        {
            ConvertBlackToTransparent();
        }


        /** Testing:
         * 1. Create a folder for testing images
         * 2. Create a transparent test image
         * 3. Test the save functionality
         */

        private static string SAVE_TO = @"C:\Users\Isiah\Pictures\cotn\templates\test_save.png";
        private void btn_save_Click(object sender, EventArgs e)
        {
            // hard code for now
            /* Test
             * 1. IImage.Save
             * 2. Image<Rgba, byte>.Save
             */

            // 1.
            imgBox.Image.Save(SAVE_TO);

            // 2.
            // var canvasImage = imgBox.Image;


            //var d = new SaveFileDialog();
            //if (d.ShowDialog() == DialogResult.OK)
            //{
            //    var path = d.FileName;
            //    DEFAULT_IMAGE.Save(path);
            //}

            Console.WriteLine("Save completed");
        }
    }
}
