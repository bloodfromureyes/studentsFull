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
    public partial class req4 : Form
    {
        public req4()
        {
            InitializeComponent();
        }

        private void req4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet._4". При необходимости она может быть перемещена или удалена.
            this._4TableAdapter.Fill(this.studentsDataSet._4);

        }
    }
}
