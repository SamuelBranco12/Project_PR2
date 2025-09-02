namespace Project_PR2
{
    partial class Login_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_screen));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Storebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(59, 264);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "USER:\r\n";
            this.textBox2.Click += new System.EventHandler(this.textBox2_clock);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(59, 344);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 13);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "PASSWORD:";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Storebtn
            // 
            this.Storebtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Storebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Storebtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Storebtn.Location = new System.Drawing.Point(143, 405);
            this.Storebtn.Name = "Storebtn";
            this.Storebtn.Size = new System.Drawing.Size(99, 35);
            this.Storebtn.TabIndex = 4;
            this.Storebtn.Text = "ENTER";
            this.Storebtn.UseVisualStyleBackColor = false;
            this.Storebtn.Click += new System.EventHandler(this.Storebtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(104, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Don\'t have an account? Create one";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Login_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_PR2.Properties.Resources.Captura_de_tela_2025_09_02_122559;
            this.ClientSize = new System.Drawing.Size(1178, 699);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Storebtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_screen";
            this.Text = "Login_screen";
            this.Load += new System.EventHandler(this.Login_screen_Load);
            this.Click += new System.EventHandler(this.textBox2_clock);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Storebtn;
        private System.Windows.Forms.Label label2;
    }
}