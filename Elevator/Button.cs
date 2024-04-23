using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
	public class Button
	{
		public int floor { get; set; }

		public bool upDirection { get; set; }
		public bool downDirection { get; set; }

		public Button(int value) {
			floor = value;
			switch (floor)
			{
				case 1:
					upDirection = true;
					downDirection = false;
					break;
				case 2:
					upDirection = true;
					downDirection = false;
					break;
				case 3:
					upDirection = true;
					downDirection = false;
					break;
				case 4:
					upDirection = true;
					downDirection = false;
					break;
				case 5:
					upDirection = false;
					downDirection = true;
					break;
				default:
					break;
			}
		}
	}
}
