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
    public partial class req2 : Form
    {
        public req2()
        {
            InitializeComponent();
        }

        private void req2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet._2". При необходимости она может быть перемещена или удалена.
            this._2TableAdapter.Fill(this.studentsDataSet._2);

        }
    }
}
