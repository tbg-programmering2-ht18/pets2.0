using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static List<Animal> animals = new List<Animal>();
        private static readonly Random getrandom = new Random();

        static void Main(string[] args)
        {
           
            animals.Add(new Cat("Blixten"));
            animals.Add(new Dog("Kliffe"));
            animals.Add(new Bird("Pip"));

            Console.WriteLine(@"This is a animal tester, see what spirit animal you have!
            Press any key to see what you are! (esc. ends it all)");


            // Every time a button get pushed except esc, it will continue shows random animals. 
            // If esc is pressed, the program will exit.
            ConsoleKey ck = Console.ReadKey().Key;
            while (ck != ConsoleKey.Escape)
            {
                int x = getrandom.Next(0, animals.Count - 1);
                Console.WriteLine("\nYour spirit animal is...");
                Console.WriteLine(animals[x].Show());
                Console.WriteLine("Press ESC to quit or any key to : \n");
                ck = Console.ReadKey().Key;

            }
        }
    }
}