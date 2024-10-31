using autoservice.studentsDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoservice
{
    public partial class services : Form
    {
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\students\\students.mdb";
        private OleDbConnection myConnection;
        public services()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void услугиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.услугиBindingSource.EndEdit();
            факультетыTableAdapter.Update(studentsDataSet.Факультеты);
          

        }

        private void services_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Факультеты". При необходимости она может быть перемещена или удалена.
            this.факультетыTableAdapter.Fill(this.studentsDataSet.Факультеты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "новоселовDataSet.Услуги". При необходимости она может быть перемещена или удалена.
           

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text =="")
            {
                MessageBox.Show("Введите ID факультета!");
            }
            else
            {

                факультетыBindingSource.Filter = "[ID_Факультета]=\'" + toolStripTextBox1.Text + "\'";
            } 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            факультетыTableAdapter.Fill(studentsDataSet.Факультеты);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void услугиDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
