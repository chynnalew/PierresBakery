using Microsoft.VisualStudio.TestTools.UnitTesting;
using Goods.Models;
using System;
using System.Collections.Generic;

namespace PierresGoods.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_CreateNewInstanceOfBread_Bread()
    {
      Bread testBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }
    
    [TestMethod]
    public void GetPrice_ReturnsPriceOfOneLoafAsFive_Int()
    {
      Assert.AreEqual(5, Bread.GetPrice(1)); 
    }
    [TestMethod]
    public void GetPrice_ReturnsPriceOfTwoLoaves_Int()
    {
      Assert.AreEqual(10, Bread.GetPrice(2));
    }
    [TestMethod]
    public void GetPrice_ReturnsPriceOfThreeLoavesWithDiscount_Int()
    {
      Assert.AreEqual(10, Bread.GetPrice(3));
    }
    [TestMethod]
    public void GetPrice_ReturnsPriceOfTwentyLoavesWithDiscount_Int()
    {
      Assert.AreEqual(70, Bread.GetPrice(20));
    }
    [TestMethod]
    public void GetDiscount_ReturnsDiscountTotal_Int()
    {
      Assert.AreEqual(10, Bread.GetDiscount(7));
    }
  }
   [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_CreateNewInstanceOfPastry_Pastry()
    {
      Pastry testPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }
    [TestMethod]
    public void GetPrice_ReturnsPriceOfOnePastryAsTwo_Int()
    {
      Assert.AreEqual(2, Pastry.GetPrice(1));
    }
    [TestMethod]
    public void GetPrice_ReturnsPriceOfThreePastryAsFive_Int()
    {
      Assert.AreEqual(5, Pastry.GetPrice(3));
    }
    [TestMethod]
    public void GetPrice_ReturnsPriceOf20PastryAsThirtyFour_Int()
    {
      Assert.AreEqual(34, Pastry.GetPrice(20));
    }
    [TestMethod]
    public void GetDiscount_ReturnsDiscountTotal_Int()
    {
      Assert.AreEqual(2, Pastry.GetDiscount(7));
    }
  }
}