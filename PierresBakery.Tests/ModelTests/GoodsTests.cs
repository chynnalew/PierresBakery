using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;
using System.Collections.Generic;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_CreateNewInstanceOfBread_Bread()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }
    
    [TestMethod]
    public void GetPrice_ReturnsPriceOfOneLoafAsFive_Int()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(5, testBread.GetPrice("1")); 
    }
    [TestMethod]
    public void GetPrice_ReturnsPriceOfTwoLoafs_Int()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(10, testBread.GetPrice("2"));
    }
    [TestMethod]
    public void GetPrice_ReturnsPriceOfThreeLoafsWithDiscount_Int()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(10, testBread.GetPrice("3"));
    }
    [TestMethod]
    public void GetPrice_ReturnsPriceOfTwentyLoafsWithDiscount_Int()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(70, testBread.GetPrice("20"));
    }
  }
   [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_CreateNewInstanceOfPastry_Pastry()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }
    [TestMethod]
    public void GetPrice_ReturnsPriceOfOnePastryAsTwo_Int()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(2, testPastry.GetPrice("1"));
    }
    [TestMethod]
    public void GetPrice_ReturnsPriceOfThreePastryAsFive_Int()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(5, testPastry.GetPrice("3"));
    }
    [TestMethod]
    public void GetPrice_ReturnsPriceOf20PastryAsThirtyFour_Int()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(34, testPastry.GetPrice("20"));
    }
  }
}