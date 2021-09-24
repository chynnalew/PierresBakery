using System;

namespace CustomerOrder.Models
{
  public class Customer
  {
    public string OrderName {get; set;}
    public string BreadOrder {get; set;}
    public string PastryOrder {get; set;}

    public Customer(string name, string breadAmount, string pastryAmount)
    {
      OrderName = name;
      BreadOrder = breadAmount;
      PastryOrder = pastryAmount;
    }
  }
}