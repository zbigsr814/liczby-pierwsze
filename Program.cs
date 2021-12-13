using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liczby_pierwsze
{
    class Program
    {

        static void Main(string[] args)
        {
            int maksymalnaLiczba, kolejnaLiczba = 2, x;
            var znacznik = 0;
            Console.WriteLine("Do której liczby wyliczyć liczby pierwsze: ");
            maksymalnaLiczba = int.Parse(Console.ReadLine());
            while (kolejnaLiczba <= maksymalnaLiczba)
            {

                for (int i = kolejnaLiczba; i > 2; i--)
                {
                    x = kolejnaLiczba % (i - 1);
                    if (x == 0)
                    {
                        znacznik = 1;
                        //Console.WriteLine(znacznik);
                    }
                }

                if (znacznik != 1)
                {
                    Console.Write("Liczbą pierszą jest " + kolejnaLiczba);
                    Console.WriteLine();
                }

                znacznik = 0;
                kolejnaLiczba++; 
            }
            Console.ReadKey();
        }
    }
}

