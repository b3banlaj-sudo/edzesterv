using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edzesterv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nev;
            int suly;
            int magassag;
            double bmi;
            double kerekites;

            Console.Write("Kérem a nevét: ");
            nev = Console.ReadLine();
            Console.Write("Kérem a súlyát (kg): ");
            suly = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem a magasságát (cm): ");
            magassag = Convert.ToInt32(Console.ReadLine());
            bmi = suly / Math.Pow((magassag / 100.0), 2);
            kerekites = Math.Round(bmi, 2);
            Console.WriteLine($"{nev}, az ön BMI értéke: {kerekites}");
            
        }
    }
}
