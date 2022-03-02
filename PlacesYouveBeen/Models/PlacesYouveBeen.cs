using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    public string City{get;set;}
    public string State{get;set;}
    public string Country{get;set;}

    public string Duration{get;set;}


    public int Id{get;}
    private static List<Place> _placeList = new List<Place> {};
    public Place(string city, string state, string country, string duration)
    {
      City = city;
      State = state;
      Country = country;
      Duration = duration;
      _placeList.Add(this);
      Id=_placeList.Count;

    }
    public static List<Place> GetAll()
    {
        return _placeList;
    }
    
    public static void ClearAll()
    {
      _placeList.Clear();
    }


    public static void DeleteOne(int id)
    {
      _placeList.RemoveAt(id-1);
    }
    
    public static Place Find(int id)
    {
      return _placeList[id -1];
    }
  }
}
