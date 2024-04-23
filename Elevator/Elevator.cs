using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
	public class Elevator
	{
		//structure/house has 5 floors

		private bool[] floorReady;
		public int currentFloor = 1;
		private int topfloor;
		public ElevatorStatus Status = ElevatorStatus.STOPPED;

		public Elevator(int numberOfFloors = 5)
		{
			floorReady = new bool[numberOfFloors + 1];
			topfloor = numberOfFloors;
		}

		private void Stop(int floor)
		{
			Status = ElevatorStatus.STOPPED;
			currentFloor = floor;
			floorReady[floor] = false;
			Console.WriteLine("Stopped at floor {0}", floor);
		}

		private void Descend(int floor)
		{
			for (int i = currentFloor; i >= 1; i--)
			{
				if (floorReady[i])
					Stop(floor);
				else
					continue;
			}

			Status = ElevatorStatus.STOPPED;
			Console.WriteLine("Waiting..");
		}

		private void Ascend(int floor)
		{
			for (int i = currentFloor; i <= topfloor; i++)
			{
				if (floorReady[i])
					Stop(floor);
				else
					continue;
			}

			Status = ElevatorStatus.STOPPED;
			Console.WriteLine("Waiting..");
		}

		void StayPut()
		{
			Console.WriteLine("That's our current floor");
		}

		public void FloorPress(int floor)
		{
			if (floor > topfloor)
			{
				Console.WriteLine("We only have {0} floors", topfloor);
				return;
			}

			floorReady[floor] = true;

			switch (Status)
			{

				case ElevatorStatus.DOWN:
					Descend(floor);
					break;

				case ElevatorStatus.STOPPED:
					if (currentFloor < floor)
						Ascend(floor);
					else if (currentFloor == floor)
						StayPut();
					else
						Descend(floor);
					break;

				case ElevatorStatus.UP:
					Ascend(floor);
					break;

				default:
					break;
			}


		}

		public enum ElevatorStatus
		{
			UP,
			STOPPED,
			DOWN
		}
	}
}
