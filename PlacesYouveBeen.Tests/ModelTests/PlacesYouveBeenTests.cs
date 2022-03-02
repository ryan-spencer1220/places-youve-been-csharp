using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PlacesYouveBeen.Models;
using System;

namespace PlacesYouveBeen.Tests
{
  [TestClass]
  public class PlacesTest
  {
    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("Portland");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
    [TestMethod]
    public void GetCity_ReturnCityName_String()
    {
      string city = "Portland";
      Place newPlace = new Place("Portland");
      string result = newPlace.City;
      Assert.AreEqual(city, result);

    }

    [TestMethod]
    public void SetCity_SetCityName_String()
    {
      string City="Kansas";
      Place newPlace = new Place(City);
      string updatedCity =  "NewYork";
      newPlace.City = updatedCity;
      string result =newPlace.City ;

      Assert.AreEqual(updatedCity, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_PlaceList()
    {
      List<Place> newPlace = new List<Place> { };
      List<Place> result = Place.GetAll();
      CollectionAssert.AreEqual(newPlace, result);
    }
  }
}