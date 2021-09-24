using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int GetPrice(string amountOfBread)
    {
      int breadPrice = 5;
      int amountOfBreadInt = int.Parse(amountOfBread);
      if (amountOfBreadInt >= 3)
      {
        int discount = (amountOfBreadInt/3)*5;
        int priceBefore = amountOfBreadInt * 5;
        int finalPrice = priceBefore - discount;
        return finalPrice;
      }
      else
      {
        int totalCost = breadPrice*amountOfBreadInt;
        return totalCost;
      }
    }
  }
}