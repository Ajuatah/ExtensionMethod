using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class StringExtensions
    {
        public static string Reverse(this string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }



    public class Program
    {
        static void Main(string[] args)
        {
            string original = "Andropov Ajebua";
            string reversed = original.Reverse();
            Console.WriteLine(reversed); // Output: "!aubejA vopordnA"

            Console.ReadKey();

        }
    }

}
