using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
  public class Place
  {
    public string City{get;set;}
    public int Id{get;}
    private static List<Place> _placeList = new List<Place> {};
    public Place(string city)
    {
      City = city;
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
    
    public static Place Find(int id)
    {
      return _placeList[id -1];
    }
  }
}