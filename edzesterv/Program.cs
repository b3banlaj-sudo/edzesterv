using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.Write("Kérem a célját (fogyás, izomtömeg növelés, állóképesség fejlesztés): ");
            cel = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Köszönöm a válaszokat!");


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
