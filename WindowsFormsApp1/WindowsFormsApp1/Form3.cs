﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloonk
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void Form3_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
            Form5 f5 = new Form5();
            this.Hide();
            f5.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 f1 = new Form1();
			this.Hide();
			f1.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form4 f4 = new Form4();
			this.Hide();
			f4.ShowDialog();
		}

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            this.Hide();
            f6.ShowDialog();
        }

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}
	}
}
