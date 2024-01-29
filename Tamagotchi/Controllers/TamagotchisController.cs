using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;
using System.Linq;

namespace Tamagotchi.Controllers
{
  public class TamagotchisController : Controller
  {

    // [HttpGet("/pets")]
    // public ActionResult Index()
    // {

    //   List<Pet> allTamagotchis = Pet.GetAll();
    //   return View(allTamagotchis);
    // }

    private readonly TamagotchiContext _db;

    public TamagotchisController(TamagotchiContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Pet> model = _db.Pets.ToList();
      return View(model);
    }

    [HttpGet("/pets/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/pets")]
    public ActionResult Create(string name, string color, string personality)
    {
      Pet myTamagotchi = new Pet(name, color, personality, 10, 0, 10, true);
      int personalityValue = myTamagotchi.GetPersonalityValue();
      string personalityDescription = myTamagotchi.PersonalityDescription;
      string descriptionName = myTamagotchi.PersonalityDescriptionName;
      return RedirectToAction("Index");
    }

    // [HttpGet("/pets/{id}")]
    // public ActionResult Details(int id)
    // {
    //   Pet foundPet = Pet.Find(id);
    //   return View(foundPet);
    // }

    // [HttpPost("/pets/{id}")]
    // public ActionResult HandlePetAction(int id, string action)
    // {
    //   Pet pet = Pet.Find(PetId);

    //   if (pet == null)
    //   {
    //     return NotFound();
    //   }

    //   switch (action)
    //   {
    //     case "attention":
    //       pet.Attention();
    //       break;
    //     case "feed":
    //       pet.Feed();
    //       break;
    //     case "rest":
    //       pet.Rest();
    //       break;

    //     default:
    //       return BadRequest("Invalid action");
    //   }

    //   return RedirectToAction("Details", new { id = pet.PetId });
    // }

    // [HttpPost("/pets/passTime")]
    // public ActionResult PassTime()
    // {
    //   Pet firstPet = Pet.GetAll()[0];
    //   if (firstPet != null)
    //   {
    //     firstPet.passTime();
    //   }
    //   return RedirectToAction("Index");
    // }

  }
}