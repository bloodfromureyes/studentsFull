namespace autoservice
{
    partial class req3
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
            this.studentsDataSet = new autoservice.studentsDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._3TableAdapter = new autoservice.studentsDataSetTableAdapters._3TableAdapter();
            this.iDГруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиефакультетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countIDСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDГруппыDataGridViewTextBoxColumn,
            this.названиефакультетаDataGridViewTextBoxColumn,
            this.countIDСтудентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 395);
            this.dataGridView1.TabIndex = 0;
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "studentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "3";
            this.bindingSource1.DataSource = this.studentsDataSet;
            // 
            // _3TableAdapter
            // 
            this._3TableAdapter.ClearBeforeFill = true;
            // 
            // iDГруппыDataGridViewTextBoxColumn
            // 
            this.iDГруппыDataGridViewTextBoxColumn.DataPropertyName = "ID_Группы";
            this.iDГруппыDataGridViewTextBoxColumn.HeaderText = "ID_Группы";
            this.iDГруппыDataGridViewTextBoxColumn.Name = "iDГруппыDataGridViewTextBoxColumn";
            // 
            // названиефакультетаDataGridViewTextBoxColumn
            // 
            this.названиефакультетаDataGridViewTextBoxColumn.DataPropertyName = "Название_факультета";
            this.названиефакультетаDataGridViewTextBoxColumn.HeaderText = "Название_факультета";
            this.названиефакультетаDataGridViewTextBoxColumn.Name = "названиефакультетаDataGridViewTextBoxColumn";
            this.названиефакультетаDataGridViewTextBoxColumn.Width = 130;
            // 
            // countIDСтудентаDataGridViewTextBoxColumn
            // 
            this.countIDСтудентаDataGridViewTextBoxColumn.DataPropertyName = "Count-ID_Студента";
            this.countIDСтудентаDataGridViewTextBoxColumn.HeaderText = "Count-ID_Студента";
            this.countIDСтудентаDataGridViewTextBoxColumn.Name = "countIDСтудентаDataGridViewTextBoxColumn";
            this.countIDСтудентаDataGridViewTextBoxColumn.Width = 120;
            // 
            // req3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 391);
            this.Controls.Add(this.dataGridView1);
            this.Name = "req3";
            this.Text = "req3";
            this.Load += new System.EventHandler(this.req3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private studentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private studentsDataSetTableAdapters._3TableAdapter _3TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDГруппыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиефакультетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countIDСтудентаDataGridViewTextBoxColumn;
    }
}