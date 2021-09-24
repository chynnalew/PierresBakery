using System;

namespace CustomerOrder.Models
{
  public class Customer
  {
    public string OrderName {get; set;}
    public int BreadOrder {get; set;}
    public int PastryOrder {get; set;}

    public Customer(string name, int breadAmount, int pastryAmount)
    {
      OrderName = name;
      BreadOrder = breadAmount;
      PastryOrder = pastryAmount;
    }
  }
}