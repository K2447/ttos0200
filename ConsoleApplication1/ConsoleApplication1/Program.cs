
using System;
using System.Linq;


namespace HT1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] annetutpisteet = new int[5];

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Anna pisteet: ");
                annetutpisteet[i] = int.Parse(Console.ReadLine());
            }


            int summa = annetutpisteet.Sum();
            Console.WriteLine("Suurimmat pisteet: " + annetutpisteet.Max());
            Console.WriteLine("Pienimmät pisteet: " + annetutpisteet.Min());
            int pisteet = summa - annetutpisteet.Min() - annetutpisteet.Max();
            Console.WriteLine("yhteis pisteet on: " + pisteet);
            Console.ReadLine();
          
        }
    }
}