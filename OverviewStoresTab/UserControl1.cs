﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverviewStoresTab
{
    public partial class UserControl1: UserControl
    {
        public event EventHandler MsgBtnClicked;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void StoreName_Click(object sender, EventArgs e)
        {

        }

        private void msgBtn_Click(object sender, EventArgs e)
        {
            MsgBtnClicked?.Invoke(this, e);
        }
    }
}
