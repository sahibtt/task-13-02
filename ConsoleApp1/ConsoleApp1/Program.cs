using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("neche imtahan oldugunu daxil edin, sonra ise imtahanlar ballarini sira ile daxil edin");
            string imtahansayi = Console.ReadLine();
            int say = int.Parse(imtahansayi);
            int[] arr = new int[say];

            for (int i = 0; i < arr.Length; i++)
            {
            step1:
                Console.WriteLine("imtahan ballarini daxil edin");
                string b = Console.ReadLine();
                int points = int.Parse(b);
                arr[i] = points;
            step2:
                if (points > 100)
                {
                    Console.WriteLine("imtahan neticesi 100den boyuk ola bilmez, yeniden daxil edin");
                    goto step1;
                }


            }


            if (calcavg(arr, say) > 60)
            {
                Console.WriteLine("mezun oldunuz");

            }
            else
            {
                Console.WriteLine("mezun ola bilmediniz");



            }



        }
        static int calcavg(int[] arr, int points)
        {
            int examsum = 0;
            int average = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                examsum += arr[i];
            }
            average = examsum / arr.Length;

            return average;



        }
    }
}
