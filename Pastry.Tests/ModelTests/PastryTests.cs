using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
	[TestClass]
	public class PastryTests
	{
		[TestMethod]
		public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
		{
			Pastry newPastry = new Pastry(7);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
		}

    [TestMethod]
		
    public void GetUserOrder_GetsUserOrder_UserOrder()
    {
      int pastryOrder = 4;
      Pastry newPastry = new Pastry(pastryOrder);
      int result = newPastry;
      Assert.AreEqual(pastryOrder, result);
    }
    }
	}
