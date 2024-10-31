namespace autoservice
{
    partial class req2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentsDataSet = new autoservice.studentsDataSet();
            this._2TableAdapter = new autoservice.studentsDataSetTableAdapters._2TableAdapter();
            this.sumСуммастипендииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDГруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDФакультетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sumСуммастипендииDataGridViewTextBoxColumn,
            this.iDГруппыDataGridViewTextBoxColumn,
            this.iDФакультетаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(370, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "2";
            this.bindingSource1.DataSource = this.studentsDataSet;
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "studentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _2TableAdapter
            // 
            this._2TableAdapter.ClearBeforeFill = true;
            // 
            // sumСуммастипендииDataGridViewTextBoxColumn
            // 
            this.sumСуммастипендииDataGridViewTextBoxColumn.DataPropertyName = "Sum-Сумма_стипендии";
            this.sumСуммастипендииDataGridViewTextBoxColumn.HeaderText = "Sum-Сумма_стипендии";
            this.sumСуммастипендииDataGridViewTextBoxColumn.Name = "sumСуммастипендииDataGridViewTextBoxColumn";
            this.sumСуммастипендииDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDГруппыDataGridViewTextBoxColumn
            // 
            this.iDГруппыDataGridViewTextBoxColumn.DataPropertyName = "ID_Группы";
            this.iDГруппыDataGridViewTextBoxColumn.HeaderText = "ID_Группы";
            this.iDГруппыDataGridViewTextBoxColumn.Name = "iDГруппыDataGridViewTextBoxColumn";
            // 
            // iDФакультетаDataGridViewTextBoxColumn
            // 
            this.iDФакультетаDataGridViewTextBoxColumn.DataPropertyName = "ID_Факультета";
            this.iDФакультетаDataGridViewTextBoxColumn.HeaderText = "ID_Факультета";
            this.iDФакультетаDataGridViewTextBoxColumn.Name = "iDФакультетаDataGridViewTextBoxColumn";
            // 
            // req2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 309);
            this.Controls.Add(this.dataGridView1);
            this.Name = "req2";
            this.Text = "req2";
            this.Load += new System.EventHandler(this.req2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private studentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private studentsDataSetTableAdapters._2TableAdapter _2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumСуммастипендииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDГруппыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDФакультетаDataGridViewTextBoxColumn;
    }
}