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
      int pastryOrderVal = newPastry.PastryOrder;
      int pastryOrderCost = newPastry.PastryCost;
      Assert.AreEqual(4, pastryOrderVal);
    }

    public void GetUserCost_GetsUserCost_Cost()
    {
      int pastryOrder = 4;
      Pastry newPastry = new Pastry(pastryOrder);
      int pastryOrderVal = newPastry.PastryOrder;
      int pastryOrderCost = newPastry.PastryCost;
      Assert.AreEqual(6, pastryOrderCost);
    }
  }
}
