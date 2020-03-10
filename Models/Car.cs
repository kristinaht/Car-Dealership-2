using System;
using System.Collections.Generic;

namespace Dealership.Models
{

  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    public string Message { get; set; }
    private static List<Car> _cars = new List<Car>(){};

    public Car(string makeModel, int price, int miles, string message)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Message = message;
      _cars.Add(this);
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public string GetMessage()
    {
      return Message;
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }

    public bool WorthBuyingPrice(int maxPrice, int maxMiles)
    {
      return (Price <maxPrice && Miles<maxMiles);
    }
  }
}