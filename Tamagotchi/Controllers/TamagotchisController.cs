// using Microsoft.AspNetCore.Mvc;
// using Tamagotchi.Models;
// using System.Collections.Generic;

// namespace Tamagotchi.Controllers
// {
//   public class TamagotchisController : Controller
//   {

//     [HttpGet("/tamagotchis")]
//     public ActionResult Index()
//     {

//       List<Tamagotchi> allTamagotchis = Tamagotchi.GetAll();
//       return View(allTamagotchis);
//     }

//     [HttpGet("/tamagotchis/new")]
//     public ActionResult New()
//     {
//       return View();
//     }

//     [HttpPost("/tamagotchis")]
//     public ActionResult Create(string name, string color, int happiness, int hunger, int energy)
//     {
//       Tamagotchi myTamagotchi = new Tamagotchi(name, color, happiness, hunger, energy);
//       return RedirectToAction("Index");
//     }

//   }
// }