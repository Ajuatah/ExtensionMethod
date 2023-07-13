using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

    public static class StringUtility
    {
        public static string Truncate(this string input, int length)
        {
            if (input.Length <= length)
                return input;

            return input.Substring(0, length) + "...";
        }
    }

    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                    yield return item;
            }
        }
    }



    public class Program
    {
        static void Main(string[] args)
        {
            //using the extention method 
            string original = "Andropov Ajebua";
            string reversed = original.Reverse();
            Console.WriteLine(reversed); // Output: "!aubejA vopordnA"


            //using the String utility class extention method 
            
            string text = "Welcome to Ajuatah Coding Arena";
            string truncated = text.Truncate(15);
            Console.WriteLine(truncated); // Output: "Welcome to Ajua..."


            // Usage of the extension method in EnumerableExtensions class 
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            List<int> evenNumbers = numbers.Filter(n => n % 2 == 0).ToList();
            Console.WriteLine(string.Join(", ", evenNumbers)); // Output: "2, 4"

            Console.ReadKey();

        }
    }

}
