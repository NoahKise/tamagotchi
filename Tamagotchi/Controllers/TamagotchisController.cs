using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
  public class TamagotchisController : Controller
  {

    [HttpGet("/pets")]
    public ActionResult Index()
    {

      List<Pet> allTamagotchis = Pet.GetAll();
      return View(allTamagotchis);
    }

    [HttpGet("/pets/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/pets")]
    public ActionResult Create(string name, string color)
    {
      Pet myTamagotchi = new Pet(name, color, 10, 0, 10, true);
      return RedirectToAction("Index");
    }

     [HttpGet("/pets/{id}")]
    public ActionResult Details(int id)
    {
      Pet foundPet = Pet.Find(id);
      return View(foundPet);
    }

  }
}