namespace Project_PR2
{
    partial class Drums_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drums_Screen));
            this.confirmbtn = new System.Windows.Forms.Button();
            this.datagridint = new System.Windows.Forms.DataGridView();
            this.instrumentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrumentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cJ3022404PR2DataSet1 = new Project_PR2.CJ3022404PR2DataSet1();
            this.cJ3022404PR2DataSet = new Project_PR2.CJ3022404PR2DataSet();
            this.cJ3022404PR2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cJ3022404PR2DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentsTableAdapter = new Project_PR2.CJ3022404PR2DataSet1TableAdapters.InstrumentsTableAdapter();
            this.textpesq1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmbtn
            // 
            this.confirmbtn.BackColor = System.Drawing.SystemColors.ControlText;
            this.confirmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.confirmbtn.Location = new System.Drawing.Point(839, 259);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(103, 31);
            this.confirmbtn.TabIndex = 0;
            this.confirmbtn.Text = "BUY";
            this.confirmbtn.UseVisualStyleBackColor = false;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // datagridint
            // 
            this.datagridint.AllowUserToOrderColumns = true;
            this.datagridint.AutoGenerateColumns = false;
            this.datagridint.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.datagridint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instrumentIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityInStockDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.updatedAtDataGridViewTextBoxColumn});
            this.datagridint.DataSource = this.instrumentsBindingSource;
            this.datagridint.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datagridint.Location = new System.Drawing.Point(486, 290);
            this.datagridint.Name = "datagridint";
            this.datagridint.Size = new System.Drawing.Size(633, 286);
            this.datagridint.TabIndex = 1;
            this.datagridint.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridint_CellContentClick);
            // 
            // instrumentIDDataGridViewTextBoxColumn
            // 
            this.instrumentIDDataGridViewTextBoxColumn.DataPropertyName = "InstrumentID";
            this.instrumentIDDataGridViewTextBoxColumn.HeaderText = "InstrumentID";
            this.instrumentIDDataGridViewTextBoxColumn.Name = "instrumentIDDataGridViewTextBoxColumn";
            this.instrumentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // quantityInStockDataGridViewTextBoxColumn
            // 
            this.quantityInStockDataGridViewTextBoxColumn.DataPropertyName = "QuantityInStock";
            this.quantityInStockDataGridViewTextBoxColumn.HeaderText = "QuantityInStock";
            this.quantityInStockDataGridViewTextBoxColumn.Name = "quantityInStockDataGridViewTextBoxColumn";
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            // 
            // updatedAtDataGridViewTextBoxColumn
            // 
            this.updatedAtDataGridViewTextBoxColumn.DataPropertyName = "UpdatedAt";
            this.updatedAtDataGridViewTextBoxColumn.HeaderText = "UpdatedAt";
            this.updatedAtDataGridViewTextBoxColumn.Name = "updatedAtDataGridViewTextBoxColumn";
            // 
            // instrumentsBindingSource
            // 
            this.instrumentsBindingSource.DataMember = "Instruments";
            this.instrumentsBindingSource.DataSource = this.cJ3022404PR2DataSet1;
            // 
            // cJ3022404PR2DataSet1
            // 
            this.cJ3022404PR2DataSet1.DataSetName = "CJ3022404PR2DataSet1";
            this.cJ3022404PR2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // cJ3022404PR2DataSetBindingSource1
            // 
            this.cJ3022404PR2DataSetBindingSource1.DataSource = this.cJ3022404PR2DataSet;
            this.cJ3022404PR2DataSetBindingSource1.Position = 0;
            // 
            // instrumentsTableAdapter
            // 
            this.instrumentsTableAdapter.ClearBeforeFill = true;
            // 
            // textpesq1
            // 
            this.textpesq1.Location = new System.Drawing.Point(657, 264);
            this.textpesq1.Name = "textpesq1";
            this.textpesq1.Size = new System.Drawing.Size(100, 20);
            this.textpesq1.TabIndex = 2;
            this.textpesq1.TextChanged += new System.EventHandler(this.textpesq1_TextChanged);
            // 
            // Drums_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_PR2.Properties.Resources.Captura_de_tela_2025_10_07_122607;
            this.ClientSize = new System.Drawing.Size(1120, 637);
            this.Controls.Add(this.textpesq1);
            this.Controls.Add(this.datagridint);
            this.Controls.Add(this.confirmbtn);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Drums_Screen";
            this.Text = "Drums_Screen";
            this.Load += new System.EventHandler(this.Drums_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.DataGridView datagridint;
        private System.Windows.Forms.BindingSource cJ3022404PR2DataSetBindingSource1;
        private CJ3022404PR2DataSet cJ3022404PR2DataSet;
        private System.Windows.Forms.BindingSource cJ3022404PR2DataSetBindingSource;
        private CJ3022404PR2DataSet1 cJ3022404PR2DataSet1;
        private System.Windows.Forms.BindingSource instrumentsBindingSource;
        private CJ3022404PR2DataSet1TableAdapters.InstrumentsTableAdapter instrumentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn instrumentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textpesq1;
    }
}