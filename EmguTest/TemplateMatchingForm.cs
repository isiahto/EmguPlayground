using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            InitResources();
            InitDropDownLists();
        }

        private static string IMAGE_MAIN = @"C:\Users\Isiah\Pictures\cotn\level.jpg";
        private static string IMAGE_TEMPLATE = @"C:\Users\Isiah\Pictures\cotn\templates\Cadence_trans.png";

        private static Dictionary<string, string> scenes = new Dictionary<string, string>();
        private static Dictionary<string, string> templates = new Dictionary<string, string>();
        private static Dictionary<string, Emgu.CV.CvEnum.TemplateMatchingType> matchType = new Dictionary<string, Emgu.CV.CvEnum.TemplateMatchingType>();

        private void InitResources()
        {
            // Scene
            scenes.Add("-SELECT-", null);
            scenes.Add("Level 1", @"Images\Scenes\level1.png");
            scenes.Add("Level 2", @"Images\Scenes\level2.png");

            // Template
            templates.Add("-SELECT-", null);
            templates.Add("Heart", @"Images\Sprites\UI\heart.png");
            templates.Add("Empty Heart", @"Images\Sprites\UI\heart_empty.png");
            templates.Add("Half Heart", @"Images\Sprites\UI\heart_half.png");
            templates.Add("Shovel Slot", @"Images\Sprites\UI\slot_shovel.png");
            templates.Add("Weapon Slot", @"Images\Sprites\UI\slot_attack.png");
            templates.Add("Bomb Slot", @"Images\Sprites\UI\slot_bomb.png");

            // Match types
            matchType.Add("Ccoeff", Emgu.CV.CvEnum.TemplateMatchingType.Ccoeff);
            matchType.Add("CcoeffNormed", Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed);
            matchType.Add("Ccorr", Emgu.CV.CvEnum.TemplateMatchingType.Ccorr);
            matchType.Add("CcorrNormed", Emgu.CV.CvEnum.TemplateMatchingType.CcorrNormed);
            matchType.Add("Sqdiff", Emgu.CV.CvEnum.TemplateMatchingType.Sqdiff);
            matchType.Add("SqdiffNormed", Emgu.CV.CvEnum.TemplateMatchingType.SqdiffNormed);
        }

        private void InitDropDownLists()
        {
            // Init Scene ddl
            ddl_scene.DataSource = new BindingSource(scenes, null);
            ddl_scene.DisplayMember = "Key";
            ddl_scene.ValueMember = "Value";

            // Init Tempalte ddl
            ddl_template.DataSource = new BindingSource(templates, null);
            ddl_template.DisplayMember = "Key";
            ddl_template.ValueMember = "Value";

            // Match method
            ddl_method.DataSource = new BindingSource(matchType, null);
            ddl_method.DisplayMember = "Key";
            ddl_method.ValueMember = "Value";
        }

        private void btn_match_Click(object sender, EventArgs e)
        {
            var sceneImg = new Image<Bgr, byte>(ib_scene.Image.Bitmap);
            var templateImg = new Image<Bgr, byte>(ib_template.Image.Bitmap).Resize(55, 55, Emgu.CV.CvEnum.Inter.Linear);
            var final = sceneImg.Copy();

            #region Template Matching
            using (var result = sceneImg.MatchTemplate(templateImg, matchType.ElementAt(ddl_method.SelectedIndex).Value))
            {
                result.MinMax(out double[] minValues, out double[] maxValues, out Point[] minLocations, out Point[] maxLocations);
                if (maxValues[0] > 0.1)
                {
                    Rectangle match = new Rectangle(maxLocations[0], templateImg.Size);
                    txt_confidence.Text = maxValues[0].ToString();
                    txt_location.Text = maxLocations[0].ToString();

                    final.Draw(match, new Bgr(0, 0, 155), 3);
                }
            }

            ib_scene.Image = final;
            #endregion
        }

        private void btn_debug_Click(object sender, EventArgs e)
        {
            ddl_scene_SelectedIndexChanged(ddl_scene, null);
            return;
        }

        private void ddl_scene_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ddl = sender as ComboBox;
            var imgPath = scenes.ElementAt(ddl.SelectedIndex).Value;
            if (imgPath == null)
            {
                ib_scene.Image = null;
            }
            else
            {
                ib_scene.Image = new Image<Bgra, byte>(Path.Combine(Environment.CurrentDirectory, imgPath));
            }
        }

        private void ddl_template_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ddl = sender as ComboBox;
            var imgPath = templates.ElementAt(ddl.SelectedIndex).Value;
            if (imgPath == null)
            {
                ib_template.Image = null;
            }
            else
            {
                ib_template.Image = new Image<Bgra, byte>(Path.Combine(Environment.CurrentDirectory, imgPath));
            }
        }
    }
}
