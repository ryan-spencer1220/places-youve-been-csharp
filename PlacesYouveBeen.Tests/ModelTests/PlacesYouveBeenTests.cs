using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PlacesYouveBeen.Models;
using System;

namespace PlacesYouveBeen.Tests
{
  [TestClass]
  public class PlacesTest :IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }
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

    [TestMethod]
    public void GetAll_ReturnsPlaces_PlaceList()
    {
      string placeOne = "Portland";
      string placeTwo = "New York";
      Place newPlaceOne = new Place(placeOne);
      Place newPlaceTwo = new Place(placeTwo);
      List<Place> newList = new List<Place> { newPlaceOne, newPlaceTwo };
      List<Place> result = Place.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}