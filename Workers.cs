using autoservice.studentsDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoservice
{
    public partial class Workers : Form
    {
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\students\\students.mdb";
        private OleDbConnection myConnection;
        public Workers()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void мастераBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.мастераBindingSource.EndEdit();
          

        }

        private void Workers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Группы". При необходимости она может быть перемещена или удалена.
            this.группыTableAdapter.Fill(this.studentsDataSet.Группы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "новоселовDataSet.Мастера". При необходимости она может быть перемещена или удалена.
            

        }

        Point lastpoint;
        private void Workers_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void Workers_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddworkerButton_Click(object sender, EventArgs e)
        {
            
        }

        private void RemoveworkerButton_Click(object sender, EventArgs e)
        {
           //int kod = Convert.ToInt32(textBox4.Text);

           // string query = "DELETE FROM Мастера WHERE [Код мастера] = " + kod;
         //   OleDbCommand command = new OleDbCommand(query, myConnection);
           // command.ExecuteNonQuery();
           // MessageBox.Show("Сотрудник удален");
        }

        private void ChangeworkerButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
          if (toolStripTextBox1.Text =="")
            {
                MessageBox.Show("Введите ID группы!");

            }
            else
            {

                        группыBindingSource.Filter = "[ID_Группы]=\'" + toolStripTextBox1.Text + "\'";
            }    
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

           
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.группыBindingSource.EndEdit();
            группыTableAdapter.Update(studentsDataSet.Группы);
        }

        private void мастераDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            группыTableAdapter.Fill(studentsDataSet.Группы);
        }
    }
}
