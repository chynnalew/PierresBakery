using System;

namespace PierresGoods.Models
{
  public class Bread
  {
    public static int GetPrice(string breadAmount)
    {
      int breadPrice = 5;
      int breadAmountInt = int.Parse(breadAmount);
      if (breadAmountInt >= 3)
      {
        int discount = (breadAmountInt - (breadAmountInt % 3)) / 3 * breadPrice;
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
    public static int GetDiscount(string breadAmount)
    {
      int breadPrice = 5;
      int breadAmountInt = int.Parse(breadAmount);
      int discount = (breadAmountInt - (breadAmountInt % 3)) / 3 * breadPrice;
      return discount;
    }
  }
  public class Pastry
  {
    public static int GetPrice(string pastryAmount)
    {
      int pastryPrice = 2;
      int pastryAmountInt = int.Parse(pastryAmount);
      if (pastryAmountInt >= 3)
      {
        int discount = Pastry.GetDiscount(pastryAmount);
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
    public static int GetDiscount(string pastryAmount)
    {
      int pastryAmountInt = int.Parse(pastryAmount);
      int discount = (pastryAmountInt - (pastryAmountInt % 3)) / 3;
      return discount;
    }
  }
}