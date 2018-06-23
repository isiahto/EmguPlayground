namespace EmguTest
{
    partial class ImageForm
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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_process = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_tpreset = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_c1 = new System.Windows.Forms.Button();
            this.btn_c2 = new System.Windows.Forms.Button();
            this.btn_c3 = new System.Windows.Forms.Button();
            this.btn_c4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(12, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(260, 260);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(12, 282);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_process
            // 
            this.btn_process.Location = new System.Drawing.Point(105, 282);
            this.btn_process.Name = "btn_process";
            this.btn_process.Size = new System.Drawing.Size(75, 23);
            this.btn_process.TabIndex = 2;
            this.btn_process.Text = "Process";
            this.btn_process.UseVisualStyleBackColor = true;
            this.btn_process.Click += new System.EventHandler(this.btn_process_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(197, 282);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_tpreset
            // 
            this.btn_tpreset.Location = new System.Drawing.Point(12, 311);
            this.btn_tpreset.Name = "btn_tpreset";
            this.btn_tpreset.Size = new System.Drawing.Size(75, 23);
            this.btn_tpreset.TabIndex = 4;
            this.btn_tpreset.Text = "TP Reset";
            this.btn_tpreset.UseVisualStyleBackColor = true;
            this.btn_tpreset.Click += new System.EventHandler(this.btn_tpreset_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(105, 311);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_c1
            // 
            this.btn_c1.Enabled = false;
            this.btn_c1.Location = new System.Drawing.Point(278, 12);
            this.btn_c1.Name = "btn_c1";
            this.btn_c1.Size = new System.Drawing.Size(75, 23);
            this.btn_c1.TabIndex = 6;
            this.btn_c1.Text = "c1";
            this.btn_c1.UseVisualStyleBackColor = true;
            this.btn_c1.Click += new System.EventHandler(this.btn_c1_Click);
            // 
            // btn_c2
            // 
            this.btn_c2.Enabled = false;
            this.btn_c2.Location = new System.Drawing.Point(278, 41);
            this.btn_c2.Name = "btn_c2";
            this.btn_c2.Size = new System.Drawing.Size(75, 23);
            this.btn_c2.TabIndex = 7;
            this.btn_c2.Text = "c2";
            this.btn_c2.UseVisualStyleBackColor = true;
            this.btn_c2.Click += new System.EventHandler(this.btn_c2_Click);
            // 
            // btn_c3
            // 
            this.btn_c3.Enabled = false;
            this.btn_c3.Location = new System.Drawing.Point(278, 70);
            this.btn_c3.Name = "btn_c3";
            this.btn_c3.Size = new System.Drawing.Size(75, 23);
            this.btn_c3.TabIndex = 8;
            this.btn_c3.Text = "c3";
            this.btn_c3.UseVisualStyleBackColor = true;
            this.btn_c3.Click += new System.EventHandler(this.btn_c3_Click);
            // 
            // btn_c4
            // 
            this.btn_c4.Enabled = false;
            this.btn_c4.Location = new System.Drawing.Point(278, 99);
            this.btn_c4.Name = "btn_c4";
            this.btn_c4.Size = new System.Drawing.Size(75, 23);
            this.btn_c4.TabIndex = 9;
            this.btn_c4.Text = "c4";
            this.btn_c4.UseVisualStyleBackColor = true;
            this.btn_c4.Click += new System.EventHandler(this.btn_c4_Click);
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 344);
            this.Controls.Add(this.btn_c4);
            this.Controls.Add(this.btn_c3);
            this.Controls.Add(this.btn_c2);
            this.Controls.Add(this.btn_c1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_tpreset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_process);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.picBox);
            this.Name = "ImageForm";
            this.Text = "ImageForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_process;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_tpreset;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_c1;
        private System.Windows.Forms.Button btn_c2;
        private System.Windows.Forms.Button btn_c3;
        private System.Windows.Forms.Button btn_c4;
    }
}