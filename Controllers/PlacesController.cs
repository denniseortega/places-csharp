using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System;

namespace Places.Controllers
{
    public class PlacesController : Controller
    {
        [HttpGet("/places")]
        public ActionResult Index()
        {
            List<Place> allPlaces = Place.GetAll();
            return View(allPlaces);
        }
        [HttpGet("/places/new")]
        public ActionResult Form()
        {
            return View();
        }
        [HttpPost("/places/new")]
        public ActionResult Create()
        {
          Place newPlace = new Place (Request.Form["city"], Request.Form["description"],Request.Form["image"]);
          newPlace.Save();
          Console.WriteLine(newPlace.GetImageUrl());
          List<Place> allPlaces = Place.GetAll();
          return View("Index", allPlaces);
        }
        [HttpGet("/places/{id}")]
        public ActionResult Details(int id)
        {
          Place place = Place.Find(id);
          return View(place);
        }
        [HttpPost("/places/delete")]
        public ActionResult Delete()
        {
            Place.ClearAll();
            return View();
        }
    }
}
