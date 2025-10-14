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




            //            2.A programnak a megadott bemenő adatokkal kell dolgoznia:
            //            Edzés típusa(pl.Állóképesség → &quot; Futás / Kerékpározás & quot;, Izomtömeg → &quot; Súlyzós edzés&quot;,
            //Fogyás → &quot; Intervall edzés&quot;).
            //Edzés alaphossza(percben)
            // Állóképesség: 45 perc
            // Izomtömeg: 60 perc
            // Fogyás: 30 perc

            //Hibakezelés: Ha a beolvasott cél nem 1, 2 vagy 3, a program írjon ki hibaüzenetet, és állítsa
            //az alaphosszt 0 - ra, a típust &quot; Érvénytelen cél&quot; -ra.

            //3.A program számítsa ki a heti edzésterhelést!
            //Kérdezze meg a felhasználótól, hány napot szeretne edzeni a héten(pl. 3, 4, 5 nap).
            //Kérjen be minden edzésnapra egy erősségi szintet(1 - től 5 - ig, egész szám).Addig kell
            //beolvasni, míg megfelelő értéket kapsz!
            //Az új bemenő adatok alapján a program az alábbiakat számolja ki!
            //Számítsa ki a napra vonatkozó edzésidőt:

            //4.Számítás és Kimenet
            //Végül program az adatok beolvasása után számítsa ki a teljes heti edzésidőt(az összes
            //edzésnap időtartamának összege).
            //Számítsa ki a becsült összes elégetett kalóriát a héten.

            //Kalória szorzó a céltól függően:
            // Állóképesség: 0.12
            // Izomtömeg: 0.10
            // Fogyás: 0.15

            //Írja ki a felhasználó nevének, céljának, a heti teljes edzésidőnek és az elégetett kalóriának az

            //összegzését a képernyőre.

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
