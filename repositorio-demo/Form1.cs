﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repositorio_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 55;
            MessageBox.Show("todo ok por ahora" + num);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("boton 2");
        }


    }
}
