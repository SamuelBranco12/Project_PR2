namespace Project_PR2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ENTERbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ENTERbtn
            // 
            this.ENTERbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ENTERbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ENTERbtn.Location = new System.Drawing.Point(522, 604);
            this.ENTERbtn.Name = "ENTERbtn";
            this.ENTERbtn.Size = new System.Drawing.Size(103, 40);
            this.ENTERbtn.TabIndex = 0;
            this.ENTERbtn.Text = "ENTER";
            this.ENTERbtn.UseVisualStyleBackColor = false;
            this.ENTERbtn.Click += new System.EventHandler(this.ENTERbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Project_PR2.Properties.Resources.Captura_de_tela_2025_09_02_121806;
            this.ClientSize = new System.Drawing.Size(1396, 656);
            this.Controls.Add(this.ENTERbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ENTERbtn;
    }
}

