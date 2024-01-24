using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tamagotchi.Models;
using System;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class PetTests
  {
    // public void Dispose()
    // {
    //   Pet.ClearAll();
    // }

    [TestMethod]
    public void PetOpeningConstructor_CreatesInstanceOfPet_Pet()
    {
      Pet newPet = new("brad", "yellow", 2, 2, 2);
      Assert.AreEqual(typeof(Pet), newPet.GetType());
    }

    [TestMethod]
    public void GetPetDetails_ReturnsPetDetails_String()
    {
      string name = "brad";
      string color = "yellow";
      int happiness = 2;
      int hunger = 2;
      int energy = 2;
      Pet brad = new(name, color, happiness, hunger, energy);
      Assert.AreEqual(brad.Name, name);
      Assert.AreEqual(brad.Color, color);
      Assert.AreEqual(brad.Happiness, happiness);
      Assert.AreEqual(brad.Hunger, hunger);
      Assert.AreEqual(brad.Energy, energy);
    }

    [TestMethod]
    public void PetConstructor_SetProperties()
    {
      string name = "brad";
      string color = "yellow";
      int happiness = 2;
      int hunger = 2;
      int energy = 2;
      Pet brad = new(name, color, happiness, hunger, energy);
      brad.Name = name;
      brad.Color = color;
      brad.Happiness = happiness;
      brad.Hunger = hunger;
      brad.Energy = energy;
      Assert.AreEqual(brad.Name, name);
      Assert.AreEqual(brad.Color, color);
      Assert.AreEqual(brad.Happiness, happiness);
      Assert.AreEqual(brad.Hunger, hunger);
      Assert.AreEqual(brad.Energy, energy);
    }

  }
}