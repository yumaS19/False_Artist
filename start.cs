﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace False_Artist
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            int player = int.Parse(people.Text);
            Program.GameStart(player);
        }
    }
}