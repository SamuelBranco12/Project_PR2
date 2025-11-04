namespace Project_PR2
{
    partial class register
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
            this.Userbtn = new System.Windows.Forms.TextBox();
            this.emailbtn1 = new System.Windows.Forms.TextBox();
            this.passbtn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Userbtn
            // 
            this.Userbtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Userbtn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Userbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userbtn.Location = new System.Drawing.Point(68, 279);
            this.Userbtn.Name = "Userbtn";
            this.Userbtn.Size = new System.Drawing.Size(127, 17);
            this.Userbtn.TabIndex = 1;
            this.Userbtn.TextChanged += new System.EventHandler(this.Userbtn_TextChanged);
            // 
            // emailbtn1
            // 
            this.emailbtn1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.emailbtn1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailbtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailbtn1.Location = new System.Drawing.Point(68, 359);
            this.emailbtn1.Name = "emailbtn1";
            this.emailbtn1.Size = new System.Drawing.Size(127, 17);
            this.emailbtn1.TabIndex = 2;
            // 
            // passbtn
            // 
            this.passbtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.passbtn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passbtn.Location = new System.Drawing.Point(69, 442);
            this.passbtn.Name = "passbtn";
            this.passbtn.Size = new System.Drawing.Size(127, 17);
            this.passbtn.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(123, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(4, 436);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(50, 24);
            this.Pass.TabIndex = 10;
            this.Pass.Text = "Pass";
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_PR2.Properties.Resources.Captura_de_tela_2025_09_02_123551;
            this.ClientSize = new System.Drawing.Size(1169, 659);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passbtn);
            this.Controls.Add(this.emailbtn1);
            this.Controls.Add(this.Userbtn);
            this.Name = "register";
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Userbtn;
        private System.Windows.Forms.TextBox emailbtn1;
        private System.Windows.Forms.TextBox passbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Pass;
    }
}