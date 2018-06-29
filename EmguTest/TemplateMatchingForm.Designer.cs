namespace EmguTest
{
    partial class TemplateMatchingForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_match = new System.Windows.Forms.Button();
            this.txt_confidence = new System.Windows.Forms.TextBox();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.ddl_scene = new System.Windows.Forms.ComboBox();
            this.ddl_template = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ddl_method = new System.Windows.Forms.ComboBox();
            this.ib_scene = new Emgu.CV.UI.ImageBox();
            this.ib_template = new Emgu.CV.UI.ImageBox();
            this.btn_debug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ib_scene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ib_template)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_match
            // 
            this.btn_match.Location = new System.Drawing.Point(726, 128);
            this.btn_match.Name = "btn_match";
            this.btn_match.Size = new System.Drawing.Size(75, 23);
            this.btn_match.TabIndex = 2;
            this.btn_match.Text = "Match";
            this.btn_match.UseVisualStyleBackColor = true;
            this.btn_match.Click += new System.EventHandler(this.btn_match_Click);
            // 
            // txt_confidence
            // 
            this.txt_confidence.Enabled = false;
            this.txt_confidence.Location = new System.Drawing.Point(701, 173);
            this.txt_confidence.Name = "txt_confidence";
            this.txt_confidence.Size = new System.Drawing.Size(100, 20);
            this.txt_confidence.TabIndex = 3;
            // 
            // txt_location
            // 
            this.txt_location.Enabled = false;
            this.txt_location.Location = new System.Drawing.Point(701, 203);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(100, 20);
            this.txt_location.TabIndex = 4;
            // 
            // ddl_scene
            // 
            this.ddl_scene.FormattingEnabled = true;
            this.ddl_scene.Location = new System.Drawing.Point(680, 12);
            this.ddl_scene.Name = "ddl_scene";
            this.ddl_scene.Size = new System.Drawing.Size(121, 21);
            this.ddl_scene.TabIndex = 5;
            this.ddl_scene.SelectedIndexChanged += new System.EventHandler(this.ddl_scene_SelectedIndexChanged);
            // 
            // ddl_template
            // 
            this.ddl_template.FormattingEnabled = true;
            this.ddl_template.Location = new System.Drawing.Point(680, 242);
            this.ddl_template.Name = "ddl_template";
            this.ddl_template.Size = new System.Drawing.Size(121, 21);
            this.ddl_template.TabIndex = 6;
            this.ddl_template.SelectedIndexChanged += new System.EventHandler(this.ddl_template_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Scene:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Confidence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Template:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Method:";
            // 
            // ddl_method
            // 
            this.ddl_method.FormattingEnabled = true;
            this.ddl_method.Location = new System.Drawing.Point(680, 101);
            this.ddl_method.Name = "ddl_method";
            this.ddl_method.Size = new System.Drawing.Size(121, 21);
            this.ddl_method.TabIndex = 11;
            // 
            // ib_scene
            // 
            this.ib_scene.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ib_scene.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ib_scene.Location = new System.Drawing.Point(12, 12);
            this.ib_scene.Name = "ib_scene";
            this.ib_scene.Size = new System.Drawing.Size(607, 387);
            this.ib_scene.TabIndex = 2;
            this.ib_scene.TabStop = false;
            // 
            // ib_template
            // 
            this.ib_template.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ib_template.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ib_template.Location = new System.Drawing.Point(628, 269);
            this.ib_template.Name = "ib_template";
            this.ib_template.Size = new System.Drawing.Size(173, 130);
            this.ib_template.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ib_template.TabIndex = 2;
            this.ib_template.TabStop = false;
            // 
            // btn_debug
            // 
            this.btn_debug.Location = new System.Drawing.Point(634, 39);
            this.btn_debug.Name = "btn_debug";
            this.btn_debug.Size = new System.Drawing.Size(167, 23);
            this.btn_debug.TabIndex = 13;
            this.btn_debug.Text = "Debug";
            this.btn_debug.UseVisualStyleBackColor = true;
            this.btn_debug.Click += new System.EventHandler(this.btn_debug_Click);
            // 
            // TemplateMatchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 411);
            this.Controls.Add(this.btn_debug);
            this.Controls.Add(this.ib_template);
            this.Controls.Add(this.ib_scene);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ddl_method);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddl_template);
            this.Controls.Add(this.ddl_scene);
            this.Controls.Add(this.txt_location);
            this.Controls.Add(this.txt_confidence);
            this.Controls.Add(this.btn_match);
            this.Name = "TemplateMatchingForm";
            this.Text = "TemplateMatchingForm";
            ((System.ComponentModel.ISupportInitialize)(this.ib_scene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ib_template)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_match;
        private System.Windows.Forms.TextBox txt_confidence;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.ComboBox ddl_scene;
        private System.Windows.Forms.ComboBox ddl_template;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddl_method;
        private Emgu.CV.UI.ImageBox ib_scene;
        private Emgu.CV.UI.ImageBox ib_template;
        private System.Windows.Forms.Button btn_debug;
    }
}