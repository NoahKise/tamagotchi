using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.AddControllersWithViews
{
    public class HomeController : Controller 
    {
        [Route("/")]
        public ActionResult Form() { return View(); }

        [Route("/story")]
        public ActionResult Story(string One, string Two, string Three, string Four, string Five, string Six, string Seven, string Eight, string Nine, string Ten, string Eleven, string Twelve)
        {
            StoryVariables storyVariables = new StoryVariables();
            storyVariables.One = One;
            storyVariables.Two = Two;
            storyVariables.Three = Three;
            storyVariables.Four = Four;
            storyVariables.Five = Five;
            storyVariables.Six = Six;
            storyVariables.Seven = Seven;
            storyVariables.Eight = Eight;
            storyVariables.Nine = Nine;
            storyVariables.Ten = Ten;
            storyVariables.Eleven = Eleven;
            storyVariables.Twelve = Twelve;
            return View(storyVariables);
        }
    }
}