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
    public ActionResult Create(string cityName)
    {
      Place newPlace = new Place(cityName);
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
  }
}