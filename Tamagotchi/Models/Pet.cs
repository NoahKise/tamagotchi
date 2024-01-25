using System.Collections.Generic;

namespace Tamagotchi.Models
{
    public class Pet
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public string Personality { get; set; }
        public int PersonalityValue { get; private set; }

        public int Happiness { get; set; }
        public int Hunger { get; set; }
        public int Energy { get; set; }

        public bool IsAlive { get; set; }

        public int Id { get; }
        private static List<Pet> _instances = new() { };

        public Pet(string name, string color, string personality, int happiness, int hunger, int energy, bool isAlive)
        {
            Name = name;
            Color = color;
            Personality = personality;
            Happiness = happiness;
            Hunger = hunger;
            Energy = energy;
            IsAlive = isAlive;
            _instances.Add(this);
            Id = _instances.Count;

            PersonalityValue = GetPersonalityValue();
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

        public string PersonalityDescriptionName { get; private set; }
        public string PersonalityDescription { get; private set; }

        private static Dictionary<string, (int, string, string)> PersonalityValues = new Dictionary<string, (int, string, string)>
    {
        {"loyal", (5, "The Loyal Companion", "This character embodies unwavering loyalty, standing by friends through thick and thin. They're the reliable sidekick you can always count on, a beacon of steadfast support.")},
        {"humorous", (4, "The Jovial Jester", "Meet the life of the party, the one with a joke for every occasion. This character brings laughter wherever they go, turning mundane moments into uproarious anecdotes.")},
        {"judgmental", (3, "The Critical Observer", "Always armed with a discerning eye, this character is quick to pass judgment. Their critiques may sting, but their keen insights often reveal hidden truths others might overlook.")},
        {"creative", (6, "The Visionary Artist", "Imagination knows no bounds for this creative soul. Whether painting a masterpiece or crafting stories, they weave dreams into reality, leaving a trail of enchantment in their wake.")},
        {"curious", (7, "The Eternal Explorer", "Life is an adventure for this curious character. Armed with a magnifying glass of curiosity, they embark on a perpetual quest for knowledge, turning every day into a thrilling discovery.")},
        {"humble", (2, "The Modest Marvel", "Humility is the superpower of this character. Achievements are worn like secret treasures, and their down-to-earth demeanor makes them the unsung hero of any tale.")},
        {"abrasive", (1, "The Unfiltered Truth Teller", "No sugar-coating here. This character speaks the unvarnished truth, a tornado of authenticity. Though their honesty can be jarring, it stems from a heart of gold.")},
        {"anxious", (8, "The Perpetual Worrier", "Anxiety is a constant companion for this character. Their mind races faster than a speeding bullet, contemplating every 'what if.' Yet, in their worry, lies an unparalleled attention to detail.")},
        {"dirty", (9, "The Rebel Spirit", "Chaos is a canvas for this character. Embracing the unconventional, they find beauty in life's messiness, daring to challenge societal norms and reveling in the unpolished aspects of existence.")},
        {"moody", (10, "The Emotional Acrobat", "This character swings between highs and lows like a trapeze artist. Predicting their mood is as challenging as forecasting the weather, but the emotional rollercoaster is always an unforgettable ride.")}
    };

        public int GetPersonalityValue()
        {
            (int value, string descriptionName, string description) personalityTuple;
            if (PersonalityValues.TryGetValue(Personality.ToLower(), out personalityTuple))
            {
                PersonalityDescriptionName = personalityTuple.descriptionName;
                PersonalityDescription = personalityTuple.description;
                return personalityTuple.value;
            }
            
            return 0;
        }

    }


}