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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.templateBox = new System.Windows.Forms.PictureBox();
            this.btn_match = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(613, 387);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // templateBox
            // 
            this.templateBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.templateBox.Location = new System.Drawing.Point(645, 299);
            this.templateBox.Name = "templateBox";
            this.templateBox.Size = new System.Drawing.Size(100, 100);
            this.templateBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.templateBox.TabIndex = 1;
            this.templateBox.TabStop = false;
            // 
            // btn_match
            // 
            this.btn_match.Location = new System.Drawing.Point(670, 12);
            this.btn_match.Name = "btn_match";
            this.btn_match.Size = new System.Drawing.Size(75, 23);
            this.btn_match.TabIndex = 2;
            this.btn_match.Text = "Match";
            this.btn_match.UseVisualStyleBackColor = true;
            this.btn_match.Click += new System.EventHandler(this.btn_match_Click);
            // 
            // TemplateMatchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 411);
            this.Controls.Add(this.btn_match);
            this.Controls.Add(this.templateBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "TemplateMatchingForm";
            this.Text = "TemplateMatchingForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox templateBox;
        private System.Windows.Forms.Button btn_match;
    }
}