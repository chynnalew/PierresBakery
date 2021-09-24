using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerOrder.Models;
using System;
using System.Collections.Generic;

namespace CustomerOrder.Tests
{
  [TestClass]
  public class CustomerTests
  {
    [TestMethod]
    public void Customer_CreatesNewCustomer_Customer()
    {
      Customer testCustomer = new Customer("Fred", 1, 1, 1);
      Assert.AreEqual(typeof(Customer), testCustomer.GetType());
    }
    [TestMethod]
    public void Customer_ReadsBreadOrderAmount_String()
    {
      Customer testCustomer = new Customer("Fred", 1, 1, 1);
       Assert.AreEqual(1, testCustomer.BreadOrder);
    }
    [TestMethod]
    public void Customer_ReadsPastryOrderAmount_String()
    {
      Customer testCustomer = new Customer("Fred", 1, 1, 1);
       Assert.AreEqual(1, testCustomer.PastryOrder);
    }
    [TestMethod]
    public void Customer_ReadsPieOrderAmount_String()
    {
      Customer testCustomer = new Customer("Fred", 1, 1, 1);
       Assert.AreEqual(1, testCustomer.PieOrder);
    }
  }
}