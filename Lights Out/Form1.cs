using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lights_Out
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			this.ClientSize = new Size(600, 600);

			button_back.Hide();
			ActiveControl = textBox_size;
		}

		Board board;

		private void button_start_Click(object sender, EventArgs e)
		{
			int size;
			if(int.TryParse(textBox_size.Text, out size))
			{
				textBox_size.Text = "";

				button_start.Hide();
				textBox_size.Hide();
				label1.Hide();

				board = new Board(size);
				board.Parent = this;
				board.Location = new Point(50, 50);
				board.Margin = new Padding(50, 50, 50, 50);
				board.Show();
				button_back.Show();
			}
		}

		private void button_back_Click(object sender, EventArgs e)
		{
			button_back.Hide();
			board.Hide();
			board = null;

			button_start.Show();
			textBox_size.Show();
			label1.Show();
		}

		private void textBox_size_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
				button_start.PerformClick();
		}
	}
}
