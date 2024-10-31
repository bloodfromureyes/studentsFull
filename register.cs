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
    public partial class register : Form
    {
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\students\\students.mdb";
        private OleDbConnection myConnection;
        public register()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

   
  
        Point lastpoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {

            if (LoginRegister.Text == "" || PassRegister.Text == "")
                MessageBox.Show("Введите логин и пароль");
           
            else
            { 
            string login = LoginRegister.Text;
            string password = PassRegister.Text;
            string query = "INSERT INTO Пользователи (Логин, Пароль) VALUES ('" + login + "','" + password + "')";
            string query1 = string.Format("SELECT * FROM Пользователи WHERE Логин = '{0}'", LoginRegister.Text);
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbCommand mycommand = new OleDbCommand(query1, myConnection);
            mycommand.CommandText = query1;
            OleDbDataReader reader = mycommand.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Пользователь уже зарегестрирован");
            }
               else if (command.ExecuteNonQuery() == 1)

            
                    MessageBox.Show("Вы успешно зарегестрировались!");
               
            }
            
           
            }
    

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void panel1_MouseDown_2(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove_2(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
    }
}
