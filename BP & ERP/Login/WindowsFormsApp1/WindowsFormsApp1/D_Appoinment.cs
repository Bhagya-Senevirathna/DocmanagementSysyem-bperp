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
    public partial class D_Appoinment : UserControl
    {
        public D_Appoinment()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Today Appoinment
            d_Appoinment_11.Show();
            d_Appoinment_11.BringToFront();

            d_Appoinment_21.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //All Appoinment
            d_Appoinment_21.Show();
            d_Appoinment_21.BringToFront();

            d_Appoinment_11.Hide();
        }
    }
}
