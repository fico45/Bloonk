﻿using Bloonk.DataAccess;
using Bloonk.DataAccess.DataModel;
using System;
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
	public partial class Form1 : Form
	{
        //Donor test;
		public Form1()
		{
			InitializeComponent();
           // test = DALfactory.DonorData.Get("00000000001");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			this.Hide();
			f2.ShowDialog();
		}
	}
}
