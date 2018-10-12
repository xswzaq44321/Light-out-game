using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Lights_Out
{
	class Bulb: Button
	{
		private int stat;

		public int Stat
		{
			get { return stat; }
			set {
				stat = value % 2;
				if (stat == 0)
				{
					this.BackColor = Color.White;
				}else
				{
					this.BackColor = Color.Black;
				}
			}
		}
	}
}
