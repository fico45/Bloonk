namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			this.imageList3 = new System.Windows.Forms.ImageList(this.components);
			this.imageList4 = new System.Windows.Forms.ImageList(this.components);
			this.imageList5 = new System.Windows.Forms.ImageList(this.components);
			this.imageList6 = new System.Windows.Forms.ImageList(this.components);
			this.imageList7 = new System.Windows.Forms.ImageList(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Salmon;
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(193, 101);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(113, 46);
			this.button1.TabIndex = 0;
			this.button1.Text = "Prijava";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(320, 12);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(153, 20);
			this.dateTimePicker1.TabIndex = 1;
			// 
			// imageList2
			// 
			this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// imageList3
			// 
			this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// imageList4
			// 
			this.imageList4.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList4.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList4.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// imageList5
			// 
			this.imageList5.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList5.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList5.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// imageList6
			// 
			this.imageList6.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList6.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList6.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// imageList7
			// 
			this.imageList7.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList7.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList7.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(92, 78);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(85, 153);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(298, 185);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(485, 378);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Blonk";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ImageList imageList2;
		private System.Windows.Forms.ImageList imageList3;
		private System.Windows.Forms.ImageList imageList4;
		private System.Windows.Forms.ImageList imageList5;
		private System.Windows.Forms.ImageList imageList6;
		private System.Windows.Forms.ImageList imageList7;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}

