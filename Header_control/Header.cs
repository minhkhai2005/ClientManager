﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Header_control
{
    public partial class Header: UserControl
    {
        public event EventHandler showManagerDetails;
        public Header()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void uesrname_Click(object sender, EventArgs e)
        {
            showManagerDetails?.Invoke(this, EventArgs.Empty);
        }

        private void avt_Click(object sender, EventArgs e)
        {
            showManagerDetails?.Invoke(this, EventArgs.Empty);
        }

        private void userRole_Click(object sender, EventArgs e)
        {
            showManagerDetails?.Invoke(this, EventArgs.Empty);
        }
    }
}
