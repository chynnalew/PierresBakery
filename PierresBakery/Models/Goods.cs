using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int GetPrice(string breadAmount)
    {
      int breadPrice = 5;
      int breadAmountInt = int.Parse(breadAmount);
      if (breadAmountInt >= 3)
      {
        int discount = (breadAmountInt/3)*5;
        int priceBefore = breadAmountInt * 5;
        int finalPrice = priceBefore - discount;
        return finalPrice;
      }
      else
      {
        int totalCost = breadPrice*breadAmountInt;
        return totalCost;
      }
    }
  }
  public class Pastry
  {
    public int GetPrice(string pastryAmount)
    {
      int pastryPrice = 2;
      int pastryAmountInt = int.Parse(pastryAmount);
      if (pastryAmountInt >= 3)
      {
        return 1;
      }
      else
      {
        int totalCost = pastryPrice*pastryAmountInt;
        return totalCost;
      }
    }
  }
}