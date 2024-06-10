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
    public partial class bar : Form

    {
        IBarRepository Repository;
        bar_manager f1 = new bar_manager();
        private object repository;

        public bar()
        {
            InitializeComponent();
            Repository = new BarRepository();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f1.Show();
        }

        private void bar_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void bar_Load(object sender, EventArgs e)
        {

        }
        bool ValidateInputs()
        {


            if (txt1.Text == "")
            {

                MessageBox.Show("لطفا مبدا را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt2.Text == "")
            {
                MessageBox.Show("لطفا مقصد را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt4.Text == "")
            {
                MessageBox.Show("لطفا نام نام صاحب بار را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt3.Value == 0)
            {
                MessageBox.Show("لطفا نام مبلغ کرایه بار را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt5.Text == "")
            {
                MessageBox.Show("لطفا نام راننده را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt6.Text == "")
            {
                MessageBox.Show("لطفا تاریخ را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
              bool isSuccess =  Repository.insert(txt1.Text, txt2.Text, (int)txt3.Value, txt4.Text, txt5.Text, txt6.Text);
                if (isSuccess == true)
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("عملیات با شکست مواجه شد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            }
        }
    }

