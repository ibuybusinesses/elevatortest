using Microsoft.VisualStudio.TestTools.UnitTesting;
using Elevator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Tests
{
	[TestClass()]
	public class ElevatorTests
	{
		[TestMethod()]
		public void ElevatorTest()
		{
			//Assert.Fail();
		}

		[TestMethod()]
		public void FloorPressTest()
		{
			Elevator elevator = new Elevator(5);
			elevator.FloorPress(2);
			Assert.IsTrue(true);
			//Assert.Fail();
		}
	}
}