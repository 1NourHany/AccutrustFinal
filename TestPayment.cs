﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Lab_System
{
    public partial class TestPayment : Form
    {
        public TestPayment()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TestPayment_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            CBCtest C = new CBCtest();
            C.Show();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn C = new SignIn();
            C.Show();
        }
    }
}
