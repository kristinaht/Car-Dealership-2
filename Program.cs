using System;
using System.Collections.Generic;
using Dealership.Models;


namespace Dealership
{

  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "Still the best car ever!");
      Car yugo = new Car("1980 Yugo Koral", 700, 56000, "They don't make them like this anymore. Luckily.");
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "Boring, but still drives.");
      Car amc = new Car("1976 AMC Pacer", 400, 198000, "Not sure what this is, but if you're into it...");

      List<Car> Cars = new List<Car>() {volkswagen, yugo, ford, amc};

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);
      Console.WriteLine("Enter maximum mileage: ");
      string stringMaxMiles = Console.ReadLine();
      int maxMiles = int.Parse(stringMaxMiles);

      List<Car> CarsMatchingSearch = new List<Car>(0);

      yugo.SetPrice(300);

      foreach(Car automobile in Cars)
      {
        if(automobile.WorthBuyingPrice(maxPrice, maxMiles))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }
      if(CarsMatchingSearch.Count > 0)
      {
        foreach(Car automobile in CarsMatchingSearch)
        {
          Console.WriteLine("__________________________");
          Console.WriteLine(automobile.GetMakeModel());
          Console.WriteLine(automobile.GetMiles() + " miles.");
          Console.WriteLine(automobile.GetMessage());
          Console.WriteLine("$" + automobile.GetPrice());
        }
      }
      else
      {
      Console.WriteLine("No cars for you!");
      }
     }
  }
}  