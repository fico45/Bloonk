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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 f1 = new Form1();
			this.Hide();
			f1.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form3 f3 = new Form3();
			this.Hide();
			f3.ShowDialog();
		}
	}
}
