using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling disemvoweler with test perameters
            Disemvoweler("Nickelback is my favorite band. Their songwriting can't be beat!");
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls.");


            // keep the console open
            Console.ReadKey();
        }

        /// <summary>
        /// Takes a string, violently separates the vowlels from the consonants!
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Consonants only, no spaces!</returns>
        public static string Disemvoweler(string input)
        {
            //changes all characters to lower case
            //stores in input for future use
            input = input.ToLower();
            //new variable for consonants
            string cons = null;
            //new variable for vowels
            string vowels = null;

            //loop through input to compare each character
            for (int i = 0; i < input.Length; i++)
            {
                //if consonant
                if ("wrtypsdfghjklzxcvbnm".Contains(input[i]))
                {
                    //add to disemvoweler!
                    cons = cons + input[i].ToString();
                }
                //otherwise
                else if ("aeiou".Contains(input[i]))
                {
                    //add vowel to new vowel list in order
                    vowels = vowels + input[i].ToString();
                }
            }


            // Write out the various string results
            Console.WriteLine("Original: {0}", input);
            Console.WriteLine("Disemvoweled: {0}", cons);
            Console.WriteLine("Vowels Removed: {0}", vowels);
            // Return the Disemvoweled string as well for testing
            return cons;
        }
    }
}
