namespace PierresBakery.Models
{
  public class Bread
  {
    public int GetPrice(string amountOfBread)
    {
      int breadPrice = 5;
      int amountOfBreadInt = int.Parse(amountOfBread);
      int totalCost = breadPrice*amountOfBreadInt;
      return totalCost;
    }
  }
}