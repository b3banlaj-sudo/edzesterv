using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace edzesterv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string keresztnev;
            string vezeteknev;
            int suly;
            int cel;
           
            Console.WriteLine("Edzésterv");
            Console.Write("Kérem a vezetéknevét: ");
            vezeteknev = Console.ReadLine();
            Console.Write("Kérem a nevét: ");
            keresztnev = Console.ReadLine();
            Console.Write("(kilogrammban, valós szám 50 és 120 között) ");
            suly = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem a célját (állóképesség fejlesztés, izomtömeg növelés, fogyás ): ");
            cel = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Köszönöm a válaszokat!");




           

            while (cel > 0) {
                Console.Write("Hány napot szeretne edzeni a héten: ");
                int edzesnap = Convert.ToInt32(Console.ReadLine());
                if (edzesnap >0 )
                {
                    for (int i = 1; i <= edzesnap; i++)
                    {
                        Console.Write($"Kérem az {i}. nap erősségi szintjét (1-5): ");
                        int erosseg = Convert.ToInt32(Console.ReadLine());
                        if (erosseg < 1 || erosseg > 5)
                        {
                            Console.WriteLine("Hibás adatot adott meg!");
                            i--;
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Hibás adatot adott meg!");
                }
            }

            if (cel == 1)
            {



            }
            else if (cel == 2)
            {

            }
            else if (cel == 3)
            {

            }
            else
            {
                Console.WriteLine("Hibás adatot adott meg!");
            }



            Console.ReadKey();


          




        }
    }
}
