using Microsoft.AspNetCore.Mvc;
using PlacesYouveBeen.Models;
using System.Collections.Generic;

namespace PlacesYouveBeen.Controllers
{
  public class PlacesController : Controller
  {

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }
    
    [HttpPost("/places")]
    public ActionResult Create(string cityName,string stateName,string countryName,string duration)
    {
      Place newPlace = new Place(cityName,stateName,countryName,duration);
      return RedirectToAction("Index");
    }
    
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
      Place foundPlace = Place.Find(id);
      return View(foundPlace);
    }

    [HttpPost("/places/delete")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return View();
    }


    [HttpPost("/places/delete/{id}")]
    public ActionResult Delete(int id)
    {
      Place.DeleteOne(id);
      return View();
    }
  }
}