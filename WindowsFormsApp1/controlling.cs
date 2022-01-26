using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class controlling : Form
    {
        public controlling()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 newFor1 = new Form6();
            newFor1.Show();
            Hide();
        }

        private void controlling_Load(object sender, EventArgs e)
        {

        }
    }
}
