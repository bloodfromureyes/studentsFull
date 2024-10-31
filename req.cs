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
    public partial class req : Form
    {
        public req()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void req_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            req1 req1 = new req1();
            req1.Show();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            req2 req2 = new req2();
            req2.Show();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            req3 req3 = new req3();
            req3.Show();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            req4 req4 = new req4();
            req4.Show();
        }
    }
}
