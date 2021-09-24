using System;

namespace Goods.Models
{
  public class Bread
  {
    public static int GetPrice(int breadAmountInt)
    {
      int breadPrice = 5;
      if (breadAmountInt >= 3)
      {
        int discount = Bread.GetDiscount(breadAmountInt);;
        int priceBefore = breadAmountInt * breadPrice;
        int finalPrice = priceBefore - discount;
        return finalPrice;
      }
      else
      {
        int totalCost = breadPrice*breadAmountInt;
        return totalCost;
      }
    }
    public static int GetDiscount(int breadAmountInt)
    {
      int breadPrice = 5;
      int discount = (breadAmountInt - (breadAmountInt % 3)) / 3 * breadPrice;
      return discount;
    }
  }
  public class Pastry
  {
    public static int GetPrice(int pastryAmountInt)
    {
      int pastryPrice = 2;
      if (pastryAmountInt >= 3)
      {
        int discount = Pastry.GetDiscount(pastryAmountInt);
        int priceBefore = pastryAmountInt * pastryPrice;
        int finalPrice = priceBefore - discount;
        return finalPrice;
      }
      else
      {
        int totalCost = pastryPrice*pastryAmountInt;
        return totalCost;
      }
    }
    public static int GetDiscount(int pastryAmountInt)
    {
      int discount = (pastryAmountInt - (pastryAmountInt % 3)) / 3;
      return discount;
    }
  }
}