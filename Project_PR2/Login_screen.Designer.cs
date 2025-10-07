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
            this.usertxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Enterbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usertxt
            // 
            this.usertxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.usertxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.Location = new System.Drawing.Point(59, 264);
            this.usertxt.Multiline = true;
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(211, 20);
            this.usertxt.TabIndex = 1;
            this.usertxt.Click += new System.EventHandler(this.textBox2_clock);
            this.usertxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // passtxt
            // 
            this.passtxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.passtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Location = new System.Drawing.Point(59, 344);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '•';
            this.passtxt.Size = new System.Drawing.Size(172, 22);
            this.passtxt.TabIndex = 2;
            this.passtxt.Click += new System.EventHandler(this.textBox1_Click);
            this.passtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(101, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Don\'t have an account? Create one";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Enterbtn
            // 
            this.Enterbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Enterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Enterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enterbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Enterbtn.Location = new System.Drawing.Point(150, 411);
            this.Enterbtn.Name = "Enterbtn";
            this.Enterbtn.Size = new System.Drawing.Size(75, 33);
            this.Enterbtn.TabIndex = 6;
            this.Enterbtn.Text = "ENTER";
            this.Enterbtn.UseVisualStyleBackColor = false;
            this.Enterbtn.Click += new System.EventHandler(this.Enterbtn_Click);
            // 
            // Login_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_PR2.Properties.Resources.Captura_de_tela_2025_09_02_122559;
            this.ClientSize = new System.Drawing.Size(1178, 699);
            this.Controls.Add(this.Enterbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usertxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_screen";
            this.Text = "Login_screen";
            this.Load += new System.EventHandler(this.Login_screen_Load);
            this.Click += new System.EventHandler(this.textBox2_clock);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Enterbtn;
    }
}