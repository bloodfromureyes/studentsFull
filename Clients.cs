using autoservice.studentsDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace autoservice
{
    public partial class Clients : Form
    {
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\students\\students.mdb";
        private OleDbConnection myConnection;
        public Clients()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
            
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.студентыBindingSource.EndEdit();
        

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.studentsDataSet.Студенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "новоселовDataSet._Клиенты_услуги". При необходимости она может быть перемещена или удалена.

            // TODO: данная строка кода позволяет загрузить данные в таблицу "новоселовDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
           


        }
        Point lastpoint;
        private void Clients_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void Clients_MouseMove(object sender, MouseEventArgs e)
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

        private void ClientAddButton_Click(object sender, EventArgs e)
        {
        
        }

        private void FreshButton_Click(object sender, EventArgs e)
        {
            this.студентыTableAdapter.Fill(this.studentsDataSet.Студенты);
        }

        private void ClientRemoveButton_Click(object sender, EventArgs e)
        {
            //if (textBox4.Text == "")
                MessageBox.Show("Введите номер клиента!");
         //   else
            {
            //    var kod = textBox4.Text;
      //          var query = "DELETE FROM Клиенты WHERE [Гос номер] = " + kod;
        //        OleDbCommand command = new OleDbCommand(query, myConnection);
           //     command.ExecuteNonQuery();
             //   MessageBox.Show("Клиент удален");
               // this.клиентыTableAdapter.Fill(this.новоселовDataSet.Клиенты);
            }
        }

        private void ClientFindButton_Click(object sender, EventArgs e)
        {
       //     var name = textBox1.Text;

           
          // OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Клиенты WHERE [ФИО] LIKE '*" + name + "*'", myConnection);
          //  DataSet ds = new DataSet();
          //  adapter.Fill(ds);

           // this.клиентыDataGridView.AutoGenerateColumns = true;
           // this.клиентыDataGridView.DataSource = ds.Tables[0];
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
            this.студентыTableAdapter.Fill(this.studentsDataSet.Студенты);
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            this.студентыTableAdapter.Update(this.studentsDataSet.Студенты);
        }

        private void клиентыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           
           
        }
        private void создатьToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void вырезатьToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(toolStripTextBox2.Text))
            {
                MessageBox.Show("Введите ID студента!");
                return;
            }

            try
            {

                студентыBindingSource.Filter = $"[ID_Студента] = '{toolStripTextBox2.Text}'";


                if (студентыBindingSource.Count == 0)
                {
                    MessageBox.Show("Студент не найден.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка при выполнении поиска: " + ex.Message);
            }
        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {
            студентыTableAdapter.Fill(studentsDataSet.Студенты);
        }

        private void сохранитьToolStripButton_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.студентыBindingSource.EndEdit();
            студентыTableAdapter.Update(studentsDataSet.Студенты);
        }
    }
}
