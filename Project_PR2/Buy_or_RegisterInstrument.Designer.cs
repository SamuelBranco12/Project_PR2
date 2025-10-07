namespace Project_PR2
{
    partial class Buy_or_RegisterInstrument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buy_or_RegisterInstrument));
            this.BUY = new System.Windows.Forms.Button();
            this.Register_Instrumentbtn = new System.Windows.Forms.Button();
            this.OR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BUY
            // 
            this.BUY.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BUY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BUY.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUY.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BUY.Location = new System.Drawing.Point(156, 171);
            this.BUY.Name = "BUY";
            this.BUY.Size = new System.Drawing.Size(175, 120);
            this.BUY.TabIndex = 0;
            this.BUY.Text = "BUY";
            this.BUY.UseVisualStyleBackColor = false;
            this.BUY.Click += new System.EventHandler(this.button1_Click);
            // 
            // Register_Instrumentbtn
            // 
            this.Register_Instrumentbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Register_Instrumentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Register_Instrumentbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Instrumentbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Register_Instrumentbtn.Location = new System.Drawing.Point(443, 171);
            this.Register_Instrumentbtn.Name = "Register_Instrumentbtn";
            this.Register_Instrumentbtn.Size = new System.Drawing.Size(178, 120);
            this.Register_Instrumentbtn.TabIndex = 1;
            this.Register_Instrumentbtn.Text = "Register Instrument";
            this.Register_Instrumentbtn.UseVisualStyleBackColor = false;
            this.Register_Instrumentbtn.Click += new System.EventHandler(this.Register_Instrumentbtn_Click);
            // 
            // OR
            // 
            this.OR.AutoSize = true;
            this.OR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OR.Location = new System.Drawing.Point(365, 226);
            this.OR.Name = "OR";
            this.OR.Size = new System.Drawing.Size(45, 20);
            this.OR.TabIndex = 2;
            this.OR.Text = "OUR";
            // 
            // Buy_or_RegisterInstrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OR);
            this.Controls.Add(this.Register_Instrumentbtn);
            this.Controls.Add(this.BUY);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Buy_or_RegisterInstrument";
            this.Text = "Buy_or_RegisterInstrument";
            this.Load += new System.EventHandler(this.Buy_or_RegisterInstrument_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BUY;
        private System.Windows.Forms.Button Register_Instrumentbtn;
        private System.Windows.Forms.Label OR;
    }
}