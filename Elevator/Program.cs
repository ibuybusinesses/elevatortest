using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Elevator
{
	public class Program
	{
		private const string EXIT = "e";


		public static void Main(string[] args)
		{
			Elevator elevator = new Elevator(5);
			string destination = string.Empty;
			Program p = new Program();
			
		//Starting point...
		Start:
			Console.WriteLine("Welcome to test elevator!");

			int floor = 1;

			while (destination != EXIT)
			{
				Console.WriteLine("Please press which floor you would like to go to");

				destination = Console.ReadLine();
				if (Int32.TryParse(destination, out floor))
					elevator.FloorPress(floor);
				else if (destination == EXIT)
					Console.WriteLine("We finished to test elevator!");
				else
					Console.WriteLine("Incorrect floor. Please try again");
				p.EmulatePressingButtons(ref elevator);
			}
		}

		public void EmulatePressingButtons(ref Elevator elevator)
		{
			Thread.Sleep(3000);
			Random randomButtonPress = new Random(1);
			int randomButton = randomButtonPress.Next(1, 100);
			
			int randomFloor = randomButton % 5;
			switch (randomFloor)
			{
				case 1:
					Console.WriteLine("Button was pressed on floor 1");
					elevator.FloorPress(1);
					break;
				case 2:
					Console.WriteLine("Button was pressed on floor 2");
					elevator.FloorPress(2);
					break;
				case 3:
					Console.WriteLine("Button was pressed on floor 3");
					elevator.FloorPress(3);
					break;
				case 4:
					Console.WriteLine("Button was pressed on floor 4");
					elevator.FloorPress(4);
					break;
				case 5:
					Console.WriteLine("Button was pressed on floor 5");
					elevator.FloorPress(5);
					break;
				default:
					break;
			}
		}
	}
}
