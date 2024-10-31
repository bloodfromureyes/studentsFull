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
    public partial class req3 : Form
    {
        public req3()
        {
            InitializeComponent();
        }

        private void req3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet._3". При необходимости она может быть перемещена или удалена.
            this._3TableAdapter.Fill(this.studentsDataSet._3);

        }
    }
}
