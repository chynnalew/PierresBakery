using System;
using System.Collections.Generic;
using Goods.Models;
using CustomerOrder.Models;

namespace Program
{
  public class PierresBakery
  {
    static void Main()
    {
      Console.Clear();
      Console.WriteLine("---------------- \n");
      Console.WriteLine("WELCOME TO PIERRE'S BAKERY \n");
      Console.WriteLine("---------------- \n");
      Console.WriteLine("We are currently serving Bread and Pastries \nPress Enter to start");
      Console.ReadLine();
      Console.Clear();
      Console.WriteLine("---------------- \n");
      Console.WriteLine("Would you like to see our prices? \n > Enter Y for Yes, any other key for No\n");
      Console.WriteLine("---------------- \n");
      string seePrices = Console.ReadLine();
      if (seePrices == "y" || seePrices == "Y")
      {
        Console.Clear();
        Console.WriteLine("---------------- \n");
        Console.WriteLine("Bread is $5 each or three for $10! \nPastries are $2 each or three for $5! \n");
        Console.WriteLine("---------------- \n");
      }
      Console.WriteLine("Would you like to place an order? \n > Enter Y for Yes, any other key for No");
      string makeOrder = Console.ReadLine();
      while (makeOrder == "y" || makeOrder == "Y")
      {
        Console.Clear();
        Console.WriteLine("---------------- \n");
        Console.WriteLine("Please enter your name: ");
        string userName = Console.ReadLine();
        Console.WriteLine("How many loafs of bread would you like to order?");
        int userBread;
        while (!int.TryParse(Console.ReadLine(), out userBread))
        {
          Console.WriteLine("Please enter a positive number");
          Console.WriteLine("How many loafs of bread would you like to order?");
        }
        Console.WriteLine("How many Pastries would you like to order?");
        int userPastries;
        while (!int.TryParse(Console.ReadLine(), out userPastries))
        {
          Console.WriteLine("Please enter a positive number");
          Console.WriteLine("How many pastries would you like to order?");
        }
        Customer user = new Customer(userName, userBread, userPastries);

        int breadCost = Bread.GetPrice(user.BreadOrder);
        int pastryCost = Pastry.GetPrice(user.PastryOrder);
        int totalCost = breadCost + pastryCost;
        int totalSavings = Bread.GetDiscount(user.BreadOrder)+Pastry.GetDiscount(user.PastryOrder);
        Console.Clear();
        Console.WriteLine("---------------- \n");
        Console.WriteLine("Your Order: \n");
        Console.WriteLine($"Order Name: {user.OrderName}");
        Console.WriteLine($"Bread Loafs: {user.BreadOrder} \nBread Cost: ${breadCost}");
        Console.WriteLine($"Pastries: {user.PastryOrder} \nPastry Cost: ${pastryCost}");
        Console.WriteLine("-");
        Console.WriteLine($"You saved ${totalSavings}!");
        Console.WriteLine($"Total Cost: ${totalCost} \n");
        Console.WriteLine("---------------- \n");

        Console.WriteLine("Is everything correct?\n > Enter Y for Yes, any other key to re-make your order");
        string editOrder = Console.ReadLine();
        if (editOrder == "y" || editOrder =="Y")
        {
          Console.WriteLine("Would you like to place this order?\n > Enter Y for Yes, any other key for No");
          string placeOrder = Console.ReadLine();
          if (placeOrder == "y" || placeOrder =="Y")
          {
            Console.Clear();
            Console.WriteLine("---------------- \n");
            Console.WriteLine($"Thank you {user.OrderName}, your order has been placed.\n \nWe would give you a call when you order is ready, but unfortunately, we're not real :(");
            Console.WriteLine("---------------- \n");
            Console.WriteLine("Enter any key to Exit");
            Console.ReadLine();
          }
          break;
        }
      }
      Console.Clear();
      Console.WriteLine("---------------- \n");
      Console.WriteLine("Thank you for visiting Pierre's! Good Bye!");
      Console.WriteLine("---------------- \n");
    }
  }
}