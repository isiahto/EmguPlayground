using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace EmguTest
{
    public partial class TemplateMatchingForm : Form
    {
        public TemplateMatchingForm()
        {
            InitializeComponent();
            InitImages();
        }

        private static string IMAGE_MAIN = @"C:\Users\Isiah\Pictures\cotn\level.jpg";
        private static string IMAGE_TEMPLATE = @"C:\Users\Isiah\Pictures\cotn\templates\Cadence_trans.png";

        private void InitImages()
        {
            pictureBox.Image = Image.FromFile(IMAGE_MAIN);
            templateBox.Image = Image.FromFile(IMAGE_TEMPLATE);
        }

        private void btn_match_Click(object sender, EventArgs e)
        {
            var src = new Image<Bgra, byte>(IMAGE_MAIN);
            var tmp = new Image<Bgra, byte>(IMAGE_TEMPLATE);
            var final = src.Copy();

            using (var result = src.MatchTemplate(tmp, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
            {
                result.MinMax(out double[] minValues, out double[] maxValues, out Point[] minLocations, out Point[] maxLocations);

                // Confident rate @ 0.39 (pretty low)
                // TODO: try out different templates!
                if (maxValues[0] > 0.1)
                {
                    Rectangle match = new Rectangle(maxLocations[0], tmp.Size);
                    final.Draw(match, new Bgra(0, 0, 155, 255), 3);
                }
            }

            pictureBox.Image = final.ToBitmap();
        }
    }
}
