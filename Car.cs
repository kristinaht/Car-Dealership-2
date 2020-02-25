using System;

namespace Models{
  
  public class Car
  {
    public string MakeModel;
    public int Price;
    public int Miles;
    public string Message;

    public Car(string makeModel, int price, int miles, string message)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Message = message;
    }

    public bool WorthBuyingPrice(int maxPrice, int maxMiles)
    {
      return (Price <maxPrice && Miles<maxMiles);
    }

    // public bool WorthBuyingMiles(int maxMiles)
    // {
    //   return (Miles < maxMiles);
    // }
  }
}