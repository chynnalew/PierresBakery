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
      Customer testCustomer = new Customer();
      Assert.AreEqual(typeof(Customer), testCustomer.GetType());
    }
  }
}