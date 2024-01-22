using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.AddControllersWithViews
{
    public class HomeController : Controller 
    {
        [Route("/")]
        public ActionResult MadLibSelection() { return View(); }
        
        [Route("/seinfeldform")]
        public ActionResult SeinfeldForm() { return View(); }

        [Route("/magicschoolbusform")]
        public ActionResult MagicSchoolBusForm() { return View(); }

        [Route("/seinfeldstory")]
        public ActionResult SeinfeldStory(string One, string Two, string Three, string Four, string Five, string Six, string Seven, string Eight, string Nine, string Ten, string Eleven, string Twelve)
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

        [Route("/magicschoolbusstory")]
        public ActionResult MagicSchoolBusStory(string One, string Two, string Three, string Four, string Five, string Six, string Seven, string Eight, string Nine, string Ten, string Eleven, string Twelve, string Thirteen, string Fourteen, string Fifteen)
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
            storyVariables.Thirteen = Thirteen;
            storyVariables.Fourteen = Fourteen;
            storyVariables.Fifteen = Fifteen;
            return View(storyVariables);
        }
    }
}