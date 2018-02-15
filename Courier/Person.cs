using Bogus;
using Bogus.DataSets;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Courier
{
    class Person
    {
        public static Random rnd = new Random();

        public string Name { get; set; }
        public string Gender { get; set; }
        public Name.Gender NameGender { get; set; }
        public int Age { get; set; }
        public string Skills { get; set; }
        public string Traits { get; set; }
        public string NukaSunset { get; set; }
        public int[] Special { get; set; } = new int[7] { 5, 5, 5, 5, 5,5 ,5 };

        public Name.Gender ChooseNameGender(string gender)
        {
            Name.Gender[] nameGenders = new[] { Bogus.DataSets.Name.Gender.Male, Bogus.DataSets.Name.Gender.Female };

            if (gender.Equals("male")
                || gender.Equals("transmasculine"))
            {
                return nameGenders[0];
            }
            else if (gender.Equals("female")
              || gender.Equals("transfeminine"))
            {
                return nameGenders[1];
            }

            return nameGenders[rnd.Next(0, 2)];
        }

        private string PickSkills()
        {
            string[] picked = new string[2];
            List<string> skillsList = new List<string>(new string[] { "energy weapons", "melee weapons", "guns", "barter",
            "repair", "speech", "explosives", "unarmed", "medicine" });
            RollSkills(picked, skillsList);
            string[] pickedNoDupes = picked.Distinct().ToArray();
            bool sameLength = pickedNoDupes.Length == picked.Length;
            while (sameLength == false)
            {
                RollSkills(picked, skillsList);
                pickedNoDupes = picked.Distinct().ToArray();
                sameLength = pickedNoDupes.Length == picked.Length;
            }
            return String.Join(", ", picked);
        }

        private static void RollSkills(string[] picked, List<string> skillsList)
        {
            for (int index = 0; index <= 1; index++)
            {
                picked[index] = skillsList[rnd.Next(0, skillsList.Count)];
            }
        }

        private string TagTraits()
        {
            string[] tagged = new string[3];
            List<string> traitsList = new List<string>(new string[] { "built to destroy", "fast shot", "four eyes", "good natured", "heavy weapons",
            "kamikaze", "loose cannon", "small frame", "trigger discipline", "wild wasteland" });
            RollTraits(tagged, traitsList);
            string[] taggedNoDupes = tagged.Distinct().ToArray();
            bool sameLength = taggedNoDupes.Length == tagged.Length;
            while (sameLength == false)
            {
                RollTraits(tagged, traitsList);
                taggedNoDupes = tagged.Distinct().ToArray();
                sameLength = taggedNoDupes.Length == tagged.Length;
            }
            return String.Join(", ", tagged);
        }

        private void RollTraits(string[] tagged, List<string> traitsList)
        {
            for (int index = 0; index <= 2; index++)
            {
                tagged[index] = traitsList[rnd.Next(0, traitsList.Count)];
            }
        }

        private string NukaOrSunset()
        {
            string[] sodas = new string[] { "Nuka-Cola", "Sunset Sarsparilla" };
            return sodas[rnd.Next(0, 2)];
        }

        private int[] AssignSpecial()
        {
            int[] newSpecial = new int[7];
            RollSpecial(newSpecial);
            bool validSpecial = Utilities.IsValidSpecial(newSpecial);
            if (!validSpecial)
            {
                while (!validSpecial)
                {
                    RollSpecial(newSpecial);
                    validSpecial = Utilities.IsValidSpecial(newSpecial);
                }
            }
            return newSpecial;            
        }

        private void RollSpecial(int[] newSpecial)
        {
            for (int attrib = 0; attrib < Special.Length; attrib++)
            {
                newSpecial[attrib] = rnd.Next(1, 11);
            }
        }

        public Person()
        {
            string[] genders = new string[] { "male", "female", "agender", "androgyne", "bigender", "nonbinary", "pangender", "transfeminine", "transmasculine" };
            Faker f = new Faker();
            Gender = genders[rnd.Next(0, genders.Length - 1)];
            NameGender = ChooseNameGender(Gender);
            Skills = PickSkills();
            Traits = TagTraits();
            Name = f.Name.FullName(NameGender);
            NukaSunset = NukaOrSunset();
            Special = AssignSpecial();
        }
    }
}
