using System.Collections.Generic;

namespace Tamagotchi.Models
{
    public class Pet
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public int Happiness { get; set; }
        public int Hunger { get; set; }
        public int Energy { get; set; }
        private static List<Pet> _instances = new() { };

        public Pet(string name, string color, int happiness, int hunger, int energy)
        {
            Name = name;
            Color = color;
            Happiness = happiness;
            Hunger = hunger;
            Energy = energy;
            _instances.Add(this);
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

    }


}