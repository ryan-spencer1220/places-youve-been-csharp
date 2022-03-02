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
    public ActionResult Create(string city)
    {
      Place newPlace = new Place(city);
      return RedirectToAction("Index");
    }
    
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    
  }
}