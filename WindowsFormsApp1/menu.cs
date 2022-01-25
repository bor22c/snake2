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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Play newFor = new Play();
            newFor.Show();
            Hide();
        }

   

        private void button3_Click(object sender, EventArgs e)
        {
            customization newFor2 = new customization();
            newFor2.Show();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
