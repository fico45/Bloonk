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
    public partial class Form7: Form
    {
        public Form7()
        {
            InitializeComponent();
        }

		private void Form7_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form4 f4 = new Form4();
			this.Hide();
			f4.ShowDialog();
		}
	}
}
