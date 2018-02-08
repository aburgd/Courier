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
        public string NukaSars { get; set; }
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
            var skills = new List<string>(new string[] {"energy weapons", "melee weapons", "guns", "barter",
            "repair", "speech", "explosives", "unarmed", "medicine" });
            

            // hard-coded 2 because picked skills always start with 2
            for (int i = 0; i < 2; i++)
            {
                pickedSkills[i] = skills[rnd.Next(skills.Count)];
            }
            return pickedSkills;
        }

        public Person()
        {
            var genders = new[] { "male", "female", "agender", "androgyne", "bigender", "nonbinary", "pangender", "transfeminine", "transmasculine"};
            Dictionary<string, int> Special = new Dictionary<string, int>();
            Person Courier = new Person();
            Courier.Gender = Courier.PickRandom(genders);
            Courier.NameGender = Courier.ChooseNameGender(Courier);
            Courier.Name = Person.FullName.ToString();
            foreach (KeyValuePair<string, int> attribute in Courier.Special)
            {
                Courier.Special[attribute.Key] = Courier.Random.Int(1, 10);
            }
        }
    }
}
