using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lights_Out
{
	public partial class Board : UserControl
	{
		public Board(int boardSize = 3)
		{
			InitializeComponent();

			TLP.Parent = this;
			TLP.Location = new Point(0, 0);
			TLP.Size = new Size(500, 500);
			TLP.ColumnCount = boardSize;
			TLP.RowCount = boardSize;
			for (int i = 0; i < boardSize; i++)
			{
				TLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float)100.0/boardSize)); 
			}
			for (int i = 0; i < boardSize; i++)
			{
				TLP.RowStyles.Add(new RowStyle(SizeType.Percent, (float)100.0/boardSize)); 
			}
			for (int i = 0; i < boardSize; i++)
			{
				for (int j = 0; j < boardSize; j++)
				{
					Bulb bulb = new Bulb();
					bulb.Parent = TLP;
					bulb.Margin = new Padding(0, 0, 0, 0);
					bulb.Dock = DockStyle.Fill;
					bulb.BackColor = Color.White;
					int I = i, J = j;
					bulb.Click += (s, e) =>
					{
						System.Diagnostics.Debug.WriteLine("I'm in {0}, {1}", I, J);
						((Bulb)s).Stat++;
						if (I >= 1)
							((Bulb)TLP.GetControlFromPosition(I - 1, J)).Stat++;
						if (I <= ((TableLayoutPanel)((Control)s).Parent).ColumnCount - 2)
							((Bulb)TLP.GetControlFromPosition(I + 1, J)).Stat++;
						if (J >= 1)
							((Bulb)TLP.GetControlFromPosition(I, J - 1)).Stat++;
						if (J <= ((TableLayoutPanel)((Control)s).Parent).RowCount - 2)
							((Bulb)TLP.GetControlFromPosition(I, J + 1)).Stat++;
					};
					TLP.Controls.Add(bulb, i, j);
				}
			}
			TLP.Show();
		}

		TableLayoutPanel TLP = new TableLayoutPanel();
	}
}
