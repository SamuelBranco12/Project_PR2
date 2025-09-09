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
            this.AcousticGuitarbtn = new System.Windows.Forms.Button();
            this.Guitarbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Drumbtn
            // 
            this.Drumbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Drumbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Drumbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drumbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Drumbtn.Location = new System.Drawing.Point(190, 405);
            this.Drumbtn.Name = "Drumbtn";
            this.Drumbtn.Size = new System.Drawing.Size(126, 40);
            this.Drumbtn.TabIndex = 3;
            this.Drumbtn.Text = "DRUMS";
            this.Drumbtn.UseVisualStyleBackColor = false;
            this.Drumbtn.Click += new System.EventHandler(this.Drumbtn_Click);
            // 
            // AcousticGuitarbtn
            // 
            this.AcousticGuitarbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AcousticGuitarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AcousticGuitarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcousticGuitarbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AcousticGuitarbtn.Location = new System.Drawing.Point(531, 405);
            this.AcousticGuitarbtn.Name = "AcousticGuitarbtn";
            this.AcousticGuitarbtn.Size = new System.Drawing.Size(144, 40);
            this.AcousticGuitarbtn.TabIndex = 4;
            this.AcousticGuitarbtn.Text = "ACOUSTIC GUITAR\r\n";
            this.AcousticGuitarbtn.UseVisualStyleBackColor = false;
            this.AcousticGuitarbtn.Click += new System.EventHandler(this.AcousticGuitarbtn_Click);
            // 
            // Guitarbtn
            // 
            this.Guitarbtn.BackColor = System.Drawing.Color.Black;
            this.Guitarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Guitarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guitarbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Guitarbtn.Location = new System.Drawing.Point(910, 405);
            this.Guitarbtn.Name = "Guitarbtn";
            this.Guitarbtn.Size = new System.Drawing.Size(140, 40);
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
            this.BackgroundImage = global::Project_PR2.Properties.Resources.Captura_de_tela_2025_09_09_115423;
            this.ClientSize = new System.Drawing.Size(1198, 673);
            this.Controls.Add(this.Guitarbtn);
            this.Controls.Add(this.AcousticGuitarbtn);
            this.Controls.Add(this.Drumbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PreferredInstrument_screen";
            this.Text = "PreferredInstrument_screen";
            this.Load += new System.EventHandler(this.PreferredInstrument_screen_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Drumbtn;
        private System.Windows.Forms.Button AcousticGuitarbtn;
        private System.Windows.Forms.Button Guitarbtn;
    }
}