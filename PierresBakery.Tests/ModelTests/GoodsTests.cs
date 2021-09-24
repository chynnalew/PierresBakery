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
    public void GetPrice_ReturnsPriceOfOneLoafAsOne_Int()
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
    public void GetPrice_ReturnsPriceOfTenLoafsWithDiscount_Int()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(35, testBread.GetPrice("10"));
    }
  }
}