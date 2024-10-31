using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoservice
{
    public partial class req1 : Form
    {
        public req1()
        {
            InitializeComponent();
        }

        private void req1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet._1". При необходимости она может быть перемещена или удалена.
            this._1TableAdapter.Fill(this.studentsDataSet._1);

        }
    }
}
