using System;

namespace CustomerOrder.Models
{
  public class Customer
  {
    public string OrderName {get; set;}
    public int BreadOrder {get; set;}
    public int PastryOrder {get; set;}
    public int PieOrder {get; set;}

    public Customer(string name, int breadAmount, int pastryAmount, int pieAmount)
    {
      OrderName = name;
      BreadOrder = breadAmount;
      PastryOrder = pastryAmount;
      PieOrder = pieAmount;
    }
  }
}