namespace Project_PR2
{
    partial class register_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register_Screen));
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cJ3022404PR2DataSet = new Project_PR2.CJ3022404PR2DataSet();
            this.uSERSTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERSTableAdapter = new Project_PR2.CJ3022404PR2DataSetTableAdapters.USERSTableAdapter();
            this.tableAdapterManager = new Project_PR2.CJ3022404PR2DataSetTableAdapters.TableAdapterManager();
            this.cJ3022404PR2DataSet1 = new Project_PR2.CJ3022404PR2DataSet();
            this.cJ3022404PR2DataSet2 = new Project_PR2.CJ3022404PR2DataSet();
            this.usersTableAdapter1 = new Project_PR2.CJ3022404PR2DataSetTableAdapters.USERSTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSTableAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // uSERSBindingSource
            // 
            this.uSERSBindingSource.DataMember = "USERS";
            this.uSERSBindingSource.DataSource = this.cJ3022404PR2DataSet;
            this.uSERSBindingSource.CurrentChanged += new System.EventHandler(this.uSERSBindingSource_CurrentChanged);
            // 
            // cJ3022404PR2DataSet
            // 
            this.cJ3022404PR2DataSet.DataSetName = "CJ3022404PR2DataSet";
            this.cJ3022404PR2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSERSTableAdapterBindingSource
            // 
            this.uSERSTableAdapterBindingSource.DataSource = typeof(Project_PR2.CJ3022404PR2DataSetTableAdapters.USERSTableAdapter);
            // 
            // uSERSTableAdapter
            // 
            this.uSERSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Project_PR2.CJ3022404PR2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = this.uSERSTableAdapter;
            // 
            // cJ3022404PR2DataSet1
            // 
            this.cJ3022404PR2DataSet1.DataSetName = "CJ3022404PR2DataSet";
            this.cJ3022404PR2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cJ3022404PR2DataSet2
            // 
            this.cJ3022404PR2DataSet2.DataSetName = "CJ3022404PR2DataSet";
            this.cJ3022404PR2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // register_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "register_Screen";
            this.Text = "register_Screen";
            this.Load += new System.EventHandler(this.register_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSTableAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cJ3022404PR2DataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CJ3022404PR2DataSet cJ3022404PR2DataSet;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private CJ3022404PR2DataSetTableAdapters.USERSTableAdapter uSERSTableAdapter;
        private CJ3022404PR2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CJ3022404PR2DataSet cJ3022404PR2DataSet1;
        private CJ3022404PR2DataSet cJ3022404PR2DataSet2;
        private CJ3022404PR2DataSetTableAdapters.USERSTableAdapter usersTableAdapter1;
        private System.Windows.Forms.BindingSource uSERSTableAdapterBindingSource;
        private System.Windows.Forms.Button button1;
    }
}