﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_of_commercial_vehicles
{
    public partial class home : Form
    {
        bar f3 = new bar();
        Mali f4 = new Mali();
        servis f5 = new servis();
        public home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        } 
    
        private void button2_Click(object sender, EventArgs e)
        {
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f5.Show();

        }
    }
}
