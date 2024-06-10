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
    public partial class serves_anjam_shodehcs : Form
    {
        ILavazem Repository;
        public serves_anjam_shodehcs()
        {
            Repository = new Lavazem();
            InitializeComponent();
        }

        private void serves_anjam_shodehcs_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void serves_anjam_shodehcs_Load(object sender, EventArgs e)
        {
            M1();
        }

        private void M1()
        {
            dataGridView3.DataSource = Repository.selectAll();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            M1();
        }
    }
}
