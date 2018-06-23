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
            
        }
    }
}
