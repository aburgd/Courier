using Bogus;
using Bogus.DataSets;
using System;
using System.Collections.Generic;

namespace Person
{
    class Person : Faker
    {
        static Random rnd = new Random();
                
        public new string Name { get; set; }
        public string Gender { get; set; }
        public Name.Gender NameGender { get; set; }
        public int Age { get; set; }
        public string[] Skills { get; set; }
        public string[] Traits { get; set; }
        public string NukaSunset { get; set; }
        public Dictionary<string, int> Special { get; set; } = new Dictionary<string, int>()
            {
                { "Strength", 5 },
                { "Perception", 5 },
                { "Endurance", 5 },
                { "Charisma", 5 },
                { "Intelligence", 5 },
                { "Agility", 5 },
                { "Luck", 5 }
            };

    public Name.Gender ChooseNameGender(Person person)
        {
            var gender = person.Gender;
            var nameGenders = new[] { Bogus.DataSets.Name.Gender.Male, Bogus.DataSets.Name.Gender.Female };

            if (gender.Equals("male") 
                || gender.Equals("transmasculine"))
            {
                return nameGenders[0];
            } else if (gender.Equals("female")
                || gender.Equals("transfeminine"))
            {
                return nameGenders[1];
            }
            
            return nameGenders[rnd.Next(0, 1)];
        }

        private string[] PickSkills()
        {
            string[] pickedSkills = new string[2];
            List<string> skills = new List<string>(new string[] {"energy weapons", "melee weapons", "guns", "barter",
            "repair", "speech", "explosives", "unarmed", "medicine" });
            

            // two items in the picked array, always two skills
            for (int i = 0; i < 1; i++)
            {
                pickedSkills[i] = skills[rnd.Next(skills.Count)];
            }
            return pickedSkills;
        }

        private string[] TagTraits()
        {
            string[] taggedTraits = new string[3];
            List<string> traits = new List<string>(new string[] { "built to destroy", "fast shot", "four eyes", "good natured", "heavy natured",
            "kamikaze", "loose cannon", "small frame", "trigger discipline", "wild wasteland" });

            for (int i = 0; i < 2; i++)
            {
                taggedTraits[i] = traits[rnd.Next(traits.Count)];
            }
            return taggedTraits;
        }

        private string NukaOrSunset()
        {
            string[] sodas = new string[] { "Nuka-Cola", "Sunset Sarsparilla" };
            return sodas[rnd.Next(0, 1)];
        }

        public Person()
        {
            string[] genders = new string[] { "male", "female", "agender", "androgyne", "bigender", "nonbinary", "pangender", "transfeminine", "transmasculine"};
            Dictionary<string, int> Special = new Dictionary<string, int>();
            Person Courier = new Person();
            Courier.Gender = Courier.PickRandom(genders);
            Courier.NameGender = Courier.ChooseNameGender(Courier);
            Courier.Name = Person.FullName.ToString();
            Courier.NukaSunset = Courier.NukaOrSunset();
            foreach (KeyValuePair<string, int> attribute in Courier.Special)
            {
                Courier.Special[attribute.Key] = Courier.Random.Int(1, 10);
            }
            Courier.Traits = Courier.TagTraits();
            Courier.Skills = Courier.PickSkills();
        }
    }
}
