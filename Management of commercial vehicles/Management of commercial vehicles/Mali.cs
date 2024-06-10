using System;
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
    
    public partial class Mali : Form
    {
        variz f1 = new variz();
        bardasht f2 = new bardasht();
        sorat_hesab f3 = new sorat_hesab();
        public Mali()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f3.Show();
        }

        private void Mali_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
