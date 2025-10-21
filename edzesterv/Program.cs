using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Edzesterv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vezeteknev;
            string keresztnev;
            int suly = 0;
            int cel = 0;
            double edzesAlapHossz = 0;
            double kaloriaSzorzo = 0;
            string[] celok = { "Állóképesség", "Izomtömeg", "Fogyás" };

            // Név bekérése és ellenőrzése
            while (true)
            {
                Console.Write("Kérem a vezetéknevét (nagybetűvel kezdve): ");
                vezeteknev = Console.ReadLine();
                if (char.IsUpper(vezeteknev[0]))
                {
                    break;
                }
                Console.WriteLine("Hibás név! Nagybetűvel kell kezdődnie.");
            }

            while (true)
            {
                Console.Write("Kérem a keresztnevét (nagybetűvel kezdve): ");
                keresztnev = Console.ReadLine();
                if (char.IsUpper(keresztnev[0]))
                {
                    break;
                }
                Console.WriteLine("Hibás név! Nagybetűvel kell kezdődnie.");
            }

            // Testsúly bekérése (50-120 kg között)
            while (true)
            {
                Console.Write("Kérem a testsúlyát (kg, 50 és 120 között): ");
                string bemenet = Console.ReadLine();
                if (int.TryParse(bemenet, out suly) && suly >= 50 && suly <= 120)
                {
                    break;
                }
                Console.WriteLine("Érvénytelen súly! 50 és 120 közötti számot adjon meg.");
            }


            // Cél kiválasztása
            Console.WriteLine("Válasszon célt:");
            Console.WriteLine("1 - Állóképesség fejlesztése");
            Console.WriteLine("2 - Izomtömeg növelése");
            Console.WriteLine("3 - Fogyás");
            string celSzoveg = "";
            while (true)
            {
                Console.Write("Adja meg a célt (1-3): ");
                celSzoveg = Console.ReadLine();
                if (int.TryParse(celSzoveg, out cel) && cel >= 1 && cel <= 3)
                {
                    break;
                }
                Console.WriteLine("Érvénytelen cél! Csak 1, 2 vagy 3 lehet.");
            }

            // Alap értékek beállítása a cél szerint
            if (cel == 1)
            {
                edzesAlapHossz = 45;
                kaloriaSzorzo = 0.12;
            }
            else if (cel == 2)
            {
                edzesAlapHossz = 40;
                kaloriaSzorzo = 0.10;
            }
            else
            {
                edzesAlapHossz = 30;
                kaloriaSzorzo = 0.15;
            }

            // Heti edzésnapok bekérése
            int napok = 0;
            string napokSzoveg = "";

            while (true)
            {
                Console.Write("Hány napot szeretne edzeni a héten (1-7): ");
                napokSzoveg = Console.ReadLine();
                if (int.TryParse(napokSzoveg, out napok) && napok >= 1 && napok <= 7)
                {
                    break;
                }
                Console.WriteLine("Érvénytelen nap! 1 és 7 közötti számot adjon meg.");
            }

            // Edzésnapok erősségi szintjei
            int[] erossegek = new int[napok];   // tömb létrehozása a napok számával 
            for (int i = 0; i < napok; i++) // minden napra bekérés 
            {
                string szintSzoveg = "";
                int szint = 0;
                while (true)
                {
                    Console.Write($"Kérem a(z) {i + 1}. nap erősségi szintjét (1-5): ");
                    szintSzoveg = Console.ReadLine();
                    if (int.TryParse(szintSzoveg, out szint) && szint >= 1 && szint <= 5)
                    {
                        erossegek[i] = szint;
                        break;
                    }
                    Console.WriteLine("Érvénytelen erősség! 1 és 5 közötti számot adjon meg.");
                }
            }



            // Heti edzésidő számítása
            double hetiIdo = 0;
            for (int i = 0; i < napok; i++)
            {
                double napiIdo = edzesAlapHossz * (1 + 0.1 * erossegek[i]);
                hetiIdo += napiIdo;
            }

            // Kalória számítása
            double kaloriamennyiseg = suly * hetiIdo * kaloriaSzorzo;

            // Kiírás
            Console.WriteLine("\n--- Eredmények ---");
            Console.WriteLine($"Név: {vezeteknev} {keresztnev}");
            Console.WriteLine($"Cél: {celok[cel - 1]}");
            Console.WriteLine($"Heti edzésidő: {hetiIdo:F2} perc");
            Console.WriteLine($"Heti elégetett kalória: {kaloriamennyiseg:F2} kcal");

            Console.ReadKey();
        }
    }
}
