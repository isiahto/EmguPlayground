namespace EmguTest
{
    partial class Form1
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
            this.imgBox = new Emgu.CV.UI.ImageBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_rmat = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(12, 12);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(260, 237);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgBox.TabIndex = 2;
            this.imgBox.TabStop = false;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(12, 255);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_rmat
            // 
            this.btn_rmat.Location = new System.Drawing.Point(93, 255);
            this.btn_rmat.Name = "btn_rmat";
            this.btn_rmat.Size = new System.Drawing.Size(75, 23);
            this.btn_rmat.TabIndex = 4;
            this.btn_rmat.Text = "RMAT";
            this.btn_rmat.UseVisualStyleBackColor = true;
            this.btn_rmat.Click += new System.EventHandler(this.btn_rmat_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(197, 255);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 298);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_rmat);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.imgBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imgBox;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_rmat;
        private System.Windows.Forms.Button btn_save;
    }
}

