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

    [HttpPost("/pets/{id}")]
    public ActionResult HandlePetAction(int id, string action)
    {
      Pet pet = Pet.Find(id);

      if (pet == null)
      {
        return NotFound();
      }

      switch (action)
      {
        case "attention":
          pet.Attention();
          break;
        case "feed":
          pet.Feed();
          break;
        case "rest":
          pet.Rest();
          break;

        default:
          return BadRequest("Invalid action");
      }

      return RedirectToAction("Details", new { id = pet.Id });
    }

    [HttpPost("/pets/passTime")]
    public ActionResult PassTime()
    {
      Pet firstPet = Pet.GetAll()[0];
      if (firstPet != null)
      {
        firstPet.passTime();
      }
      return RedirectToAction("Index");
    }

  }
}