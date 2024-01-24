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
  }
}