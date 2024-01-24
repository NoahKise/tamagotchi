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

        public bool IsAlive { get; set; }

        public int Id { get; }
        private static List<Pet> _instances = new() { };

        public Pet(string name, string color, int happiness, int hunger, int energy, bool isAlive)
        {
            Name = name;
            Color = color;
            Happiness = happiness;
            Hunger = hunger;
            Energy = energy;
            IsAlive = isAlive;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public void Feed()
        {
            if (this.Hunger > 0)
            {
                this.Hunger -= 1;
            }

        }

        public void Attention()
        {
            if (this.Happiness < 10)
            {
                this.Happiness += 1;
            }
        }

        public void Rest()
        {
            if (this.Energy < 10)
            {
                this.Energy += 1;
            }
        }

        public void Die()
        {
            this.IsAlive = false;
        }

        public void passTime()
        {
            foreach (Pet pet in _instances)
            {
                if (pet.Happiness > 0)
                {
                    pet.Happiness -= 1;
                }
                if (pet.Hunger < 10)
                {
                    pet.Hunger += 1;
                }
                if (pet.Energy > 0)
                {
                    pet.Energy -= 1;
                }
            }
        }

        public static List<Pet> GetAll()
        {
            return _instances;
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Pet Find(int searchID)
        {
            return _instances[searchID - 1];
        }

    }


}