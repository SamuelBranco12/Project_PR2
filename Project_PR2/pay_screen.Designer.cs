namespace Project_PR2
{
    partial class pay_screen
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
            this.rtbNota = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbNota
            // 
            this.rtbNota.Location = new System.Drawing.Point(353, 56);
            this.rtbNota.Name = "rtbNota";
            this.rtbNota.Size = new System.Drawing.Size(333, 425);
            this.rtbNota.TabIndex = 0;
            this.rtbNota.Text = "";
            this.rtbNota.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // pay_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_PR2.Properties.Resources.Captura_de_tela_2025_12_02_090830;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 557);
            this.Controls.Add(this.rtbNota);
            this.DoubleBuffered = true;
            this.Name = "pay_screen";
            this.Text = "pay_screen";
            this.Load += new System.EventHandler(this.pay_screen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbNota;
    }
}