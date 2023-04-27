﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.calitha.goldparser;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        MyParser M;
        public Form1()
        {
            InitializeComponent();
            M = new MyParser("pld1.cgt",listBox1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            M.Parse(textBox1.Text);
        }
    }
}
