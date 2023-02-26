using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
		
    public void GetUserOrder_GetsUserOrder_UserOrder()
    {
      int breadOrder = 3;
      Bread newBread = new Bread(breadOrder);
      int breadOrderVal = newBread.BreadOrder;
      int breadOrderCost = newBread.BreadCost;
      Assert.AreEqual(3, breadOrderVal);
    }

    public void GetUserCost_GetsUserCost_Cost()
    {
      int breadOrder = 3;
      Bread newBread = new Bread(breadOrder);
      int breadOrderVal = newBread.BreadOrder;
      int breadOrderCost = newBread.BreadCost;
      Assert.AreEqual(10, breadOrderCost);
    } 
  }
}