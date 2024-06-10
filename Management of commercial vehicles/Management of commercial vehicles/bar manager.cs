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
    public partial class bar_manager : Form
    {
        IBarRepository Repository;
        public bar_manager()
        {
            Repository = new BarRepository();
            InitializeComponent();
        }

        private void bar_manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void bar_manager_Load(object sender, EventArgs e)
        {
            M1();
        }

        private void M1()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Repository.selectAll();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            M1();
        }
    }
}
