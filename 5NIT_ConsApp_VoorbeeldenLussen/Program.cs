using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _5NIT_ConsApp_VoorbeeldenLussen
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Voorbeeld: de begrensde herhaling
            /// 
            /// Voorbeeld: de begrensde herhaling 
            /// 
            Console.WriteLine("Voorbeeld: de begrensde herhaling\n-----------------------");

            for (int teller = 1; teller < 11; teller++)
            {
                Console.WriteLine($"Zin {teller}: Ik hou zo fantastisch veel van programmeren...");
            }

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Voorbeeld van de voorwaardelijke herhaling met aanvangsvoorwaarde
            /// 
            ///  Voorbeeld van de voorwaardelijke herhaling met aanvangsvoorwaarde 
            /// 
            Console.WriteLine(" Voorbeeld van de voorwaardelijke herhaling met aanvangsvoorwaarde");

            Int32 teller2 = 0;

            while (teller2<10)
            {
                Console.WriteLine("Ik hou fantastisch veel van wiskunde...");
                teller2 = teller2 + 1;
            }

            Console.Write("Gelieve een getal kleiner dan 20 in te vullen:   ");
            Int16 ingevoerdGetal = Convert.ToInt16(Console.ReadLine());

            while (ingevoerdGetal>=20)
            {
                Console.Write("Gelieve een getal kleiner dan 20 in te vullen:   ");
                ingevoerdGetal = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Uw getal is kleiner dan 20");

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Voorbeeld van de voorwaardelijke herhaling met afbreekvoorwaarde
            /// 
            /// Voorbeeld van de voorwaardelijke herhaling met afbreekvoorwaarde 
            /// 
            Console.WriteLine("Voorbeeld van de voorwaardelijke herhaling met afbreekvoorwaarde");
            
            Int32 teller3 = 0;

            do
            {
                Console.WriteLine("Ik hou ontzettend veel van Frans.");
                teller3++;
            } while (teller3 < 10);

            do
            {
                Console.Write("Gelieve een getal in te voeren kleiner dan 20...    ");
                ingevoerdGetal = Convert.ToInt16(Console.ReadLine());
            } while (ingevoerdGetal >=20);

            Console.WriteLine("Uw getal is kleiner dan 20.");

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Voorbeeld For each-lus
            /// 
            /// Voorbeeld For each-lus 
            /// 
            Console.WriteLine("Voorbeeld For each-lus");

            String Uitvoer = "";
            foreach (String NaamSchijf in Environment.GetLogicalDrives())
            {
                Uitvoer = Uitvoer + NaamSchijf + Environment.NewLine;
            }
            Console.WriteLine(Uitvoer);
            Console.ReadLine();


            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 24.1
            /// 
            /// Oefening 24.1: Dierentuin 
            /// 
            Console.WriteLine("Oefening 24.1: Dierentuin");



            Console.ReadKey();
            Console.Clear();
            #endregion

        }
    }
}
