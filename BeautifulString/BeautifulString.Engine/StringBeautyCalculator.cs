using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulString.Engine
{
    public static class StringBeautyCalculator
    {
        public static Int32 CalculateStringBeauty(string inputString)
        {
            //Ignore case
            inputString = inputString.ToLower();

            //initialize alphabet dicionary
            Dictionary<char, int> d = initializeDictionary();

            //count the frequency of each letter of the string
            foreach (char c in inputString)
                if (char.IsLetter(c))
                    d[c] += 1;


            Int32 currentValue = 26;
            Int32 beauty = 0;

            foreach (var item in d.OrderByDescending(c => c.Value))
            {
                beauty += (item.Value * currentValue);
                currentValue--;
            }

            return beauty;
        }

        private static Dictionary<char, int> initializeDictionary()
        {
            Dictionary<char, int> d = new Dictionary<char, int>(26);

            for (char i = 'a'; i <= 'z'; i++)
                d.Add(i, 0);

            return d;
        }

    }
}
