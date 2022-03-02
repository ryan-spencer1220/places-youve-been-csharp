using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    public string City{get;set;}
    public Place(string city)
    {
      City = city;
    }
  }
}