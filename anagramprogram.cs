using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binarytree
{
    public class anagramprogram
    {
        public static void CheckAnagram()
        {
            string str1 = "heater";
            string str2 = "reheat";
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);

            Console.WriteLine(val1);
            Console.WriteLine(val2);

            if (val1==val2)
            {
                Console.WriteLine("It's an Anagram");
            }else
            {
                Console.WriteLine("It's not an Anagram");
            }


        }
    }
}
