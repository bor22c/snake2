﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 newFor1 = new Form4();
            newFor1.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 newFor3 = new Form6();
            newFor3.Show();
            Hide();
        }
    }
}
