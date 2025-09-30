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
            this.datainstrumentview = new System.Windows.Forms.DataGridView();
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
            this.instrumentsTableAdapter = new Project_PR2.CJ3022404PR2DataSet1TableAdapters.InstrumentsTableAdapter();
            this.labelpesq1 = new System.Windows.Forms.Label();
            this.cJ3022404PR2DataSet2 = new Project_PR2.CJ3022404PR2DataSet2();
            this.instrumentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentsTableAdapter1 = new Project_PR2.CJ3022404PR2DataSet2TableAdapters.InstrumentsTableAdapter();
            this.textpesq1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datainstrumentview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsBindingSource1)).BeginInit();
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
            // datainstrumentview
            // 
            this.datainstrumentview.AutoGenerateColumns = false;
            this.datainstrumentview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datainstrumentview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instrumentIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityInStockDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.updatedAtDataGridViewTextBoxColumn});
            this.datainstrumentview.DataSource = this.instrumentsBindingSource1;
            this.datainstrumentview.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datainstrumentview.Location = new System.Drawing.Point(636, 340);
            this.datainstrumentview.Name = "datainstrumentview";
            this.datainstrumentview.Size = new System.Drawing.Size(445, 240);
            this.datainstrumentview.TabIndex = 0;
            this.datainstrumentview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datainstrumentview_CellContentClick);
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
            // instrumentsTableAdapter
            // 
            this.instrumentsTableAdapter.ClearBeforeFill = true;
            // 
            // labelpesq1
            // 
            this.labelpesq1.AutoSize = true;
            this.labelpesq1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpesq1.Location = new System.Drawing.Point(1030, 317);
            this.labelpesq1.Name = "labelpesq1";
            this.labelpesq1.Size = new System.Drawing.Size(51, 20);
            this.labelpesq1.TabIndex = 2;
            this.labelpesq1.Text = "label1";
            // 
            // cJ3022404PR2DataSet2
            // 
            this.cJ3022404PR2DataSet2.DataSetName = "CJ3022404PR2DataSet2";
            this.cJ3022404PR2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instrumentsBindingSource1
            // 
            this.instrumentsBindingSource1.DataMember = "Instruments";
            this.instrumentsBindingSource1.DataSource = this.cJ3022404PR2DataSet2;
            // 
            // instrumentsTableAdapter1
            // 
            this.instrumentsTableAdapter1.ClearBeforeFill = true;
            // 
            // textpesq1
            // 
            this.textpesq1.Location = new System.Drawing.Point(827, 314);
            this.textpesq1.Name = "textpesq1";
            this.textpesq1.Size = new System.Drawing.Size(100, 20);
            this.textpesq1.TabIndex = 3;
            this.textpesq1.TextChanged += new System.EventHandler(this.textpesq1_TextChanged);
            // 
            // Drums_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_PR2.Properties.Resources.Captura_de_tela_2025_09_30_110009;
            this.ClientSize = new System.Drawing.Size(1120, 637);
            this.Controls.Add(this.textpesq1);
            this.Controls.Add(this.labelpesq1);
            this.Controls.Add(this.datainstrumentview);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Drums_screen";
            this.Text = "Drums_Screen";
            this.Load += new System.EventHandler(this.Drums_screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datainstrumentview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CJ3022404PR2DataSet cJ3022404PR2DataSet;
        private System.Windows.Forms.BindingSource cJ3022404PR2DataSetBindingSource;
        private System.Windows.Forms.DataGridView datainstrumentview;
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
        private System.Windows.Forms.Label labelpesq1;
        private CJ3022404PR2DataSet2 cJ3022404PR2DataSet2;
        private System.Windows.Forms.BindingSource instrumentsBindingSource1;
        private CJ3022404PR2DataSet2TableAdapters.InstrumentsTableAdapter instrumentsTableAdapter1;
        private System.Windows.Forms.TextBox textpesq1;
    }
}