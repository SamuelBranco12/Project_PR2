namespace Project_PR2
{
    partial class Drums_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drums_screen));
            this.cJ3022404PR2DataSet = new Project_PR2.CJ3022404PR2DataSet();
            this.cJ3022404PR2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewinstruments = new System.Windows.Forms.DataGridView();
            this.textpesq1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewinstruments)).BeginInit();
            this.SuspendLayout();
            // 
            // cJ3022404PR2DataSet
            // 
            this.cJ3022404PR2DataSet.DataSetName = "CJ3022404PR2DataSet";
            this.cJ3022404PR2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cJ3022404PR2DataSetBindingSource
            // 
            this.cJ3022404PR2DataSetBindingSource.DataSource = this.cJ3022404PR2DataSet;
            this.cJ3022404PR2DataSetBindingSource.Position = 0;
            // 
            // dataGridViewinstruments
            // 
            this.dataGridViewinstruments.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewinstruments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewinstruments.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewinstruments.Location = new System.Drawing.Point(623, 335);
            this.dataGridViewinstruments.Name = "dataGridViewinstruments";
            this.dataGridViewinstruments.Size = new System.Drawing.Size(497, 228);
            this.dataGridViewinstruments.TabIndex = 0;
            // 
            // textpesq1
            // 
            this.textpesq1.Location = new System.Drawing.Point(761, 203);
            this.textpesq1.Name = "textpesq1";
            this.textpesq1.Size = new System.Drawing.Size(100, 20);
            this.textpesq1.TabIndex = 1;
            this.textpesq1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(761, 294);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // Drums_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_PR2.Properties.Resources.Captura_de_tela_2025_09_23_115240;
            this.ClientSize = new System.Drawing.Size(1120, 637);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textpesq1);
            this.Controls.Add(this.dataGridViewinstruments);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Drums_screen";
            this.Text = "Drums_Screen";
            this.Load += new System.EventHandler(this.Drums_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewinstruments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CJ3022404PR2DataSet cJ3022404PR2DataSet;
        private System.Windows.Forms.BindingSource cJ3022404PR2DataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewinstruments;
        private System.Windows.Forms.TextBox textpesq1;
        private System.Windows.Forms.TextBox textBox2;
    }
}