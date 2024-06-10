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
    public partial class sorat_hesab : Form
    {
        IMaliRepository Repository;
        public sorat_hesab()
        {
            Repository = new MaliRepository();
            InitializeComponent();
        }

        private void sorat_hesab_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void sorat_hesab_Load(object sender, EventArgs e)
        {
            
            dataGridView2.DataSource = Repository.selectAll();
        }
    }
}
