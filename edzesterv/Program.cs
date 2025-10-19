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
                    string vezeteknev ;
                    string keresztnev ;
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
                    string sulySzoveg = "";
                    while (true)
                    {
                        Console.Write("Kérem a testsúlyát (kg, 50 és 120 között): ");
                        sulySzoveg = Console.ReadLine();
                        if (int.TryParse(sulySzoveg, out suly) && suly >= 50 && suly <= 120) // érvényes szám és tartomány
                {
                            break;
                        }
                        Console.WriteLine("Érvénytelen súly! 50 és 120 közötti számot adjon meg.");
                    }
                }
            }
