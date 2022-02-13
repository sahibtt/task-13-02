using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zehmet olmazsa eded daxil edin");
            string reqem = Console.ReadLine();
            int num = int.Parse(reqem);
            if (num <= 0)
            {
                Console.WriteLine("Duzgun eded daxil edin");
                return;
            }
            if (num == 1)
            {
                Console.WriteLine("Daxil etdiyiniz eded ne sade deyil ne de murekkeb");
                return;
            }
            Console.WriteLine(isprime(num));



        }

        static bool isprime(int a)
        {
            int netice = 0;
            int i = 0;

            for (i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    netice++;
                }






            }
            if (netice == 2)
                return true;
            return false;

        }
    }
}
