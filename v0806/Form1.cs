﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0806
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        string ws = "(・◇・)";

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string tmp = label1.Text;
            label1.Text = ws;
            ws = tmp;

            label1.Left += vx;
            label1.Top += vy;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            vx = -vx;
            vy = -vy;
        }
    }
}
