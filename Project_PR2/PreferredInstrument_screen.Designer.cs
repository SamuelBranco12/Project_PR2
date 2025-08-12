namespace Project_PR2
{
    partial class PreferredInstrument_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferredInstrument_screen));
            this.Drumbtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AcousticGuitarbtn = new System.Windows.Forms.Button();
            this.Guitarbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Drumbtn
            // 
            this.Drumbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Drumbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Drumbtn.Location = new System.Drawing.Point(98, 245);
            this.Drumbtn.Name = "Drumbtn";
            this.Drumbtn.Size = new System.Drawing.Size(113, 23);
            this.Drumbtn.TabIndex = 3;
            this.Drumbtn.Text = "DRUMS";
            this.Drumbtn.UseVisualStyleBackColor = false;
            this.Drumbtn.Click += new System.EventHandler(this.Drumbtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(537, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(154, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(303, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AcousticGuitarbtn
            // 
            this.AcousticGuitarbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AcousticGuitarbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AcousticGuitarbtn.Location = new System.Drawing.Point(320, 245);
            this.AcousticGuitarbtn.Name = "AcousticGuitarbtn";
            this.AcousticGuitarbtn.Size = new System.Drawing.Size(119, 23);
            this.AcousticGuitarbtn.TabIndex = 4;
            this.AcousticGuitarbtn.Text = "ACOUSTIC GUITAR\r\n";
            this.AcousticGuitarbtn.UseVisualStyleBackColor = false;
            this.AcousticGuitarbtn.Click += new System.EventHandler(this.AcousticGuitarbtn_Click);
            // 
            // Guitarbtn
            // 
            this.Guitarbtn.BackColor = System.Drawing.Color.Black;
            this.Guitarbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Guitarbtn.Location = new System.Drawing.Point(546, 245);
            this.Guitarbtn.Name = "Guitarbtn";
            this.Guitarbtn.Size = new System.Drawing.Size(130, 23);
            this.Guitarbtn.TabIndex = 5;
            this.Guitarbtn.Text = "GUITAR";
            this.Guitarbtn.UseVisualStyleBackColor = false;
            this.Guitarbtn.Click += new System.EventHandler(this.Guitarbtn_Click);
            // 
            // PreferredInstrument_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.Guitarbtn);
            this.Controls.Add(this.AcousticGuitarbtn);
            this.Controls.Add(this.Drumbtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PreferredInstrument_screen";
            this.Text = "PreferredInstrument_screen";
            this.Load += new System.EventHandler(this.PreferredInstrument_screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Drumbtn;
        private System.Windows.Forms.Button AcousticGuitarbtn;
        private System.Windows.Forms.Button Guitarbtn;
    }
}