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
  }
}