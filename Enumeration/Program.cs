using Enumeration;
using System;
namespace Enumaration
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Wich fruit do you like?");
            foreach (EFruit item in Enum.GetValues(typeof(EFruit)))
            {
                Console.WriteLine(item + ":" + (int)item);
            }

            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine("I like {0}´s, too", (EFruit)userInput);

        }
    }
}