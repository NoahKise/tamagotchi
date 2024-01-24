using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tamagotchi.Models;
using System;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class PetTests : IDisposable
  {
    public void Dispose()
    {
      Pet.ClearAll();
    }

    [TestMethod]
    public void PetOpeningConstructor_CreatesInstanceOfPet_Pet()
    {
      Pet newPet = new("brad", "yellow", 2, 2, 2, true);
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
      bool isAlive = true;
      Pet brad = new(name, color, happiness, hunger, energy, isAlive);
      Assert.AreEqual(brad.Name, name);
      Assert.AreEqual(brad.Color, color);
      Assert.AreEqual(brad.Happiness, happiness);
      Assert.AreEqual(brad.Hunger, hunger);
      Assert.AreEqual(brad.Energy, energy);
      Assert.AreEqual(brad.IsAlive, isAlive);
    }

    [TestMethod]
    public void PetConstructor_SetProperties()
    {
      string name = "brad";
      string color = "yellow";
      int happiness = 2;
      int hunger = 2;
      int energy = 2;
      bool isAlive = true;
      Pet brad = new(name, color, happiness, hunger, energy, isAlive);
      brad.Name = name;
      brad.Color = color;
      brad.Happiness = happiness;
      brad.Hunger = hunger;
      brad.Energy = energy;
      brad.IsAlive = isAlive;
      Assert.AreEqual(brad.Name, name);
      Assert.AreEqual(brad.Color, color);
      Assert.AreEqual(brad.Happiness, happiness);
      Assert.AreEqual(brad.Hunger, hunger);
      Assert.AreEqual(brad.Energy, energy);
      Assert.AreEqual(brad.IsAlive, isAlive);
    }

    [TestMethod]
    public void GetId_PetInstantiateWithAnIdAndGetterReturns_Int()
    {
      string name = "brad";
      string color = "yellow";
      int happiness = 2;
      int hunger = 2;
      int energy = 2;
      bool isAlive = true;
      Pet brad = new(name, color, happiness, hunger, energy, isAlive);
      int result = brad.Id;
      Assert.AreEqual(1, result);
    }

  }
}