using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoservice
{
    public partial class loginform : Form
    {
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\students\\students.mdb";
        private OleDbConnection myConnection;
        public loginform()
        {
            InitializeComponent();

            this.PassField.Size = new Size(this.PassField.Size.Width, 194);
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastpoint;



        private void LoginField_TextChanged(object sender, EventArgs e)
        {

        }


        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            

                MainMenuAdmin mainMenuAdmin = new MainMenuAdmin();

            if (LoginField.Text == "" || PassField.Text == "")
                MessageBox.Show("Введите логин и пароль");
            else
            {

                string query1 = string.Format("SELECT * FROM Пользователи WHERE Логин = '{0}' AND Пароль = '{0}'", LoginField.Text, PassField.Text);

                OleDbCommand mycommand = new OleDbCommand(query1, myConnection);
                mycommand.CommandText = query1;
                OleDbDataReader reader = mycommand.ExecuteReader();
                if (reader.HasRows)
                {
                    this.Hide();
                    MainMenu mainMenuForm = new MainMenu();
                    mainMenuAdmin.Show();
                    MessageBox.Show("Вы успешно авторизовались!");
                }

                else if (LoginField.Text == "admin" && PassField.Text == "admin")
                {
                    this.Hide();
                mainMenuAdmin.Show();
                MessageBox.Show("Вы успешно авторизовались!");
                }
               
                else
                   
                    MessageBox.Show("Неправильный логин или пароль");
                LoginField.Text = "";
                PassField.Text = "";

            }




            


        }




        //   DB db = new DB();
        //   DataTable table = new DataTable();





        //else
        //{

        //  MainMenu mainMenuForm = new MainMenu();
        //mainMenuForm.Show();
        //}


        private void RegisterButtong_Click_1(object sender, EventArgs e)
        {


            register registerform = new register();
            registerform.Show();
        }

        private void MainPanel_MouseDown_1(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void MainPanel_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
    }
}