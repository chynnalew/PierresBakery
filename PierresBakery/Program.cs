using System;
using System.Collections.Generic;
using PierresGoods.Models;
using CustomerOrder.Models;

namespace Program
{
  public class PierresBakery
  {
    static void Main()
    {
      Console.WriteLine("---------------- \n");
      Console.WriteLine("WELCOME TO PIERRE'S BAKERY \n");
      Console.WriteLine("---------------- \n");
      Console.WriteLine("We are currently serving Bread and Pastries \n");
      Console.WriteLine("Would you like to see our prices? \n > Enter Y for Yes, any other key for No");
      string seePrices = Console.ReadLine();
      if (seePrices == "y" || seePrices == "Y")
      {
        Console.WriteLine("---------------- \n");
        Console.WriteLine("Bread is $5 each or three for $10! \nPastries are $2 each or three for $5! \n");
        Console.WriteLine("---------------- \n");
      }
      Console.WriteLine("Would you like to place an order? \n > Enter Y for Yes, any other key for No");
      string makeOrder = Console.ReadLine();
      while(makeOrder == "y" || makeOrder == "Y")
      {
        Console.WriteLine("---------------- \n");
        Console.WriteLine("Please enter your name: ");
        string userName = Console.ReadLine();
        Console.WriteLine("How many loafs of bread would you like to order?");
        string userBread = Console.ReadLine();
        Console.WriteLine("How many Pastries would you like to order?");
        string userPastries = Console.ReadLine();
  
        Customer user = new Customer(userName, userBread, userPastries);

        int breadCost = Bread.GetPrice(user.BreadOrder);
        int pastryCost = Pastry.GetPrice(user.PastryOrder);
        int totalCost = breadCost + pastryCost;
        int totalSavings = Bread.GetDiscount(user.BreadOrder)+Pastry.GetDiscount(user.PastryOrder);
        Console.WriteLine("---------------- \n");
        Console.WriteLine("Your Order: \n");
        Console.WriteLine($"Order Name: {user.OrderName}");
        Console.WriteLine($"Bread Loafs: {user.BreadOrder} \n     Cost: ${breadCost}");
        Console.WriteLine($"Pastries: {user.PastryOrder} \n     Cost: ${pastryCost}");
        Console.WriteLine("-");
        Console.WriteLine($"You saved ${totalSavings}!");
        Console.WriteLine($"Total Cost: ${totalCost} \n");
        Console.WriteLine("---------------- \n");

        Console.WriteLine("Is everything correct?\n > Enter Y for Yes, any other key for No");
        string editOrder = Console.ReadLine();
        if (editOrder == "y" || editOrder =="Y")
        {
          Console.WriteLine("Would you like to place this order?\n > Enter Y for Yes, any other key for No");
          string placeOrder = Console.ReadLine();
          if (placeOrder == "y" || placeOrder =="Y")
          {
            Console.WriteLine("---------------- \n");
            Console.WriteLine($"Thank you {user.OrderName}, your order has been placed.\n \nWe would give you a call when you order is ready, but unfortunately, we're not real :(");
          }
          break;
        }
        else
        {
          Console.WriteLine("---------------- \n");
          Console.WriteLine("Please re-make your order: ");
        }
      }
      Console.WriteLine("Thank you for visiting Pierre's! Good Bye!");
      Console.WriteLine("---------------- \n");
    }
  }
}