namespace autoservice
{
    partial class services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(services));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.услугиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.факультетыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsDataSet = new autoservice.studentsDataSet();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.услугиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.услугиDataGridView = new System.Windows.Forms.DataGridView();
            this.iDФакультетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиефакультетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.числоместDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествопреподавателейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.факультетыTableAdapter = new autoservice.studentsDataSetTableAdapters.ФакультетыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingNavigator)).BeginInit();
            this.услугиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.факультетыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(769, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // услугиBindingNavigator
            // 
            this.услугиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.услугиBindingNavigator.BindingSource = this.факультетыBindingSource;
            this.услугиBindingNavigator.CountItem = null;
            this.услугиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.услугиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripButton1,
            this.toolStripSeparator4,
            this.bindingNavigatorAddNewItem,
            this.toolStripSeparator2,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator3,
            this.toolStripButton2,
            this.toolStripSeparator5,
            this.услугиBindingNavigatorSaveItem,
            this.toolStripSeparator1});
            this.услугиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.услугиBindingNavigator.MoveFirstItem = null;
            this.услугиBindingNavigator.MoveLastItem = null;
            this.услугиBindingNavigator.MoveNextItem = null;
            this.услугиBindingNavigator.MovePreviousItem = null;
            this.услугиBindingNavigator.Name = "услугиBindingNavigator";
            this.услугиBindingNavigator.PositionItem = null;
            this.услугиBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.услугиBindingNavigator.TabIndex = 20;
            this.услугиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(63, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // факультетыBindingSource
            // 
            this.факультетыBindingSource.DataMember = "Факультеты";
            this.факультетыBindingSource.DataSource = this.studentsDataSet;
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "studentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(55, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(83, 22);
            this.toolStripLabel1.Text = "ID факультета";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(45, 22);
            this.toolStripButton1.Text = "Найти";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton2.Text = "Обновить";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // услугиBindingNavigatorSaveItem
            // 
            this.услугиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.услугиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("услугиBindingNavigatorSaveItem.Image")));
            this.услугиBindingNavigatorSaveItem.Name = "услугиBindingNavigatorSaveItem";
            this.услугиBindingNavigatorSaveItem.Size = new System.Drawing.Size(73, 22);
            this.услугиBindingNavigatorSaveItem.Text = "Сохранить ";
            this.услугиBindingNavigatorSaveItem.Click += new System.EventHandler(this.услугиBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // услугиBindingSource
            // 
            this.услугиBindingSource.DataMember = "Услуги";
            // 
            // услугиDataGridView
            // 
            this.услугиDataGridView.AutoGenerateColumns = false;
            this.услугиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.услугиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDФакультетаDataGridViewTextBoxColumn,
            this.названиефакультетаDataGridViewTextBoxColumn,
            this.числоместDataGridViewTextBoxColumn,
            this.количествопреподавателейDataGridViewTextBoxColumn});
            this.услугиDataGridView.DataSource = this.факультетыBindingSource;
            this.услугиDataGridView.Location = new System.Drawing.Point(-1, 24);
            this.услугиDataGridView.Name = "услугиDataGridView";
            this.услугиDataGridView.Size = new System.Drawing.Size(594, 574);
            this.услугиDataGridView.TabIndex = 20;
            this.услугиDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.услугиDataGridView_CellContentClick);
            // 
            // iDФакультетаDataGridViewTextBoxColumn
            // 
            this.iDФакультетаDataGridViewTextBoxColumn.DataPropertyName = "ID_Факультета";
            this.iDФакультетаDataGridViewTextBoxColumn.HeaderText = "ID_Факультета";
            this.iDФакультетаDataGridViewTextBoxColumn.Name = "iDФакультетаDataGridViewTextBoxColumn";
            // 
            // названиефакультетаDataGridViewTextBoxColumn
            // 
            this.названиефакультетаDataGridViewTextBoxColumn.DataPropertyName = "Название_факультета";
            this.названиефакультетаDataGridViewTextBoxColumn.HeaderText = "Название_факультета";
            this.названиефакультетаDataGridViewTextBoxColumn.Name = "названиефакультетаDataGridViewTextBoxColumn";
            this.названиефакультетаDataGridViewTextBoxColumn.Width = 150;
            // 
            // числоместDataGridViewTextBoxColumn
            // 
            this.числоместDataGridViewTextBoxColumn.DataPropertyName = "Число_мест";
            this.числоместDataGridViewTextBoxColumn.HeaderText = "Число_мест";
            this.числоместDataGridViewTextBoxColumn.Name = "числоместDataGridViewTextBoxColumn";
            // 
            // количествопреподавателейDataGridViewTextBoxColumn
            // 
            this.количествопреподавателейDataGridViewTextBoxColumn.DataPropertyName = "Количество_преподавателей";
            this.количествопреподавателейDataGridViewTextBoxColumn.HeaderText = "Количество_преподавателей";
            this.количествопреподавателейDataGridViewTextBoxColumn.Name = "количествопреподавателейDataGridViewTextBoxColumn";
            this.количествопреподавателейDataGridViewTextBoxColumn.Width = 200;
            // 
            // факультетыTableAdapter
            // 
            this.факультетыTableAdapter.ClearBeforeFill = true;
            // 
            // services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.услугиDataGridView);
            this.Controls.Add(this.услугиBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "services";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "services";
            this.Load += new System.EventHandler(this.services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingNavigator)).EndInit();
            this.услугиBindingNavigator.ResumeLayout(false);
            this.услугиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.факультетыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
       
        private System.Windows.Forms.BindingSource услугиBindingSource;
        private System.Windows.Forms.BindingNavigator услугиBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton услугиBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView услугиDataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private studentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource факультетыBindingSource;
        private studentsDataSetTableAdapters.ФакультетыTableAdapter факультетыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDФакультетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиефакультетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn числоместDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествопреподавателейDataGridViewTextBoxColumn;
    }
}