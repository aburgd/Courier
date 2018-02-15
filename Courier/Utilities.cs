using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier
{
    public static class Utilities
    {
        public static bool IsValidSpecial(this int[] special)
        {
            return special.Sum() == 40;
        }

        public static bool IsValidSkills(this string[] skills)
        {
            return skills.Distinct().Count() < skills.Count();
        }
    }
}
