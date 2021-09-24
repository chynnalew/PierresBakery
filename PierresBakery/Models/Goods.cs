using System;

namespace Goods.Models
{
  public class Bread
  {
    
    private static int price = 5;
    public int Amount {get; set;}
    public Bread(int amount)
    {
      Amount = amount;
    }
    public static int GetPrice(int breadAmount)
    {
      if (breadAmount >= 3)
      {
        int cost = (breadAmount * price) - Bread.GetDiscount(breadAmount);
        return cost;
      }
      else
      {
        int cost = price*breadAmount;
        return cost;
      }
    }
    public static int GetDiscount(int breadAmount)
    {
      int discount = (breadAmount - (breadAmount % 3)) / 3 * price;
      return discount;
    }
  }
  public class Pastry
  {
    private static int price = 2;
    public int Amount {get; set;}
    public Pastry(int amount)
    {
      Amount = amount;
    }
    public static int GetPrice(int pastryAmount)
    {
      if (pastryAmount >= 3)
      {
        int cost = (pastryAmount * price) - Pastry.GetDiscount(pastryAmount);
        return cost;
      }
      else
      {
        int cost = price*pastryAmount;
        return cost;
      }
    }
    public static int GetDiscount(int pastryAmount)
    {
      int discount = (pastryAmount - (pastryAmount % 3)) / 3;
      return discount;
    }
  }
}