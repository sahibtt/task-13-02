using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("string1'i daxil edin: ");
            string string1 = Console.ReadLine();
            Console.WriteLine("Indeksini tapmaq istediyniz chari daxil edin");
            char index = Console.ReadLine()[0];
            Finder(string1, index);
        }
        static void Finder(string string1, char index)
        {
            int counter = 0;
            for (int i = 0; i < string1.Length; i++)
            {
                if (string1[i] == index)
                {
                    Console.WriteLine(i);
                    counter++;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("-1");
            }
        }
    }
}
