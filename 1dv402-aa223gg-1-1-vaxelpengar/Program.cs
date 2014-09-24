using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402_aa223gg_1_1_vaxelpengar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarera variabler
            double totalSum;             //den totala summan
            double roundingOffAmount;    //öresavrundning
            uint toPay;                  //belopp att betala
            int recievedMoney;           //erhållet belopp
            int change;                  //växel

            //kontrollera om totalsumman anges rätt
            while (true)
            {
                try
                {
                    //Fyll i totalsumma
                    Console.Write("Ange totalsumma: ");
                    totalSum = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    //Om något annat än ett flyttal fylls i
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Totalsumman felaktig.");
                    Console.ResetColor();
                }
            }

            //Om totalsumman efter avrundning är mindre än 1 kr visas felmeddelande
            if (totalSum < 0.5)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Totalsumman är för liten. Köpet kunde inte genomföras.");
                Console.ResetColor();
                return;
            }

            //kontrollera om erhållet belopp anges rätt
            while (true)
            {
                try
                {
                    //Fyll i erhållet belopp
                    Console.Write("Ange erhållet belopp: ");
                    recievedMoney = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    //om något annat än ett heltal fylls i
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erhållet belopp felaktigt!");
                    Console.ResetColor();
                }
            }
            
            //Avrunda totalsumman
            toPay = (uint)Math.Round(totalSum);
            roundingOffAmount = toPay - totalSum;
            
            //Om beloppet att betala efter öresavrundning är större än det erhållna beloppet visas felmeddelande
            if (toPay > recievedMoney)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Erhållet belopp är för litet. Köpet kunde inte genomföras.");
                Console.ResetColor();
                return;
            }

            //Räkna ut beloppet att betala tillbaka
            change = recievedMoney - (int)toPay;

            //Skriv ut kvittot
            Console.WriteLine("\nKVITTO");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Totalt \t\t: {0,12:c}", totalSum);
            Console.WriteLine("Öresavrundning \t: {0,12:c}", roundingOffAmount);
            Console.WriteLine("Att betala \t: {0,12:c}", toPay);
            Console.WriteLine("Kontant \t: {0,12:c}", recievedMoney);
            Console.WriteLine("Tillbaka\t: {0,12:c}", change);
            Console.WriteLine("------------------------------");

            //Deklarera ny variabel
            int cashBack;

            //Räkna ut och skriv ut antal sedlar/mynt tillbaka
            cashBack = change / 500;
            if (cashBack > 0)
            {
                Console.WriteLine("500-lappar \t: {0}", cashBack);
            }
            change = change % 500;

            cashBack = change / 100;
            if (cashBack > 0)
            {
                Console.WriteLine("100-lappar \t: {0}", cashBack);
            }
            change = change % 100;

            cashBack = change / 50;
            if (cashBack > 0)
            {
                Console.WriteLine("50-lappar \t: {0}", cashBack);
            }
            change = change % 50;

            cashBack = change / 20;
            if (cashBack > 0)
            {
                Console.WriteLine("20-lappar \t: {0}", cashBack);
            }
            change = change % 20;

            cashBack = change / 10;
            if (cashBack > 0)
            {
                Console.WriteLine("10-kronor \t: {0}", cashBack);
            }
            change = change % 10;

            cashBack = change / 5;
            if (cashBack > 0)
            {
                Console.WriteLine("5-kronor \t: {0}", cashBack);
            }
            change = change % 5;

            cashBack = change;
            if (cashBack > 0)
            {
                Console.WriteLine("1-kronor \t: {0}", cashBack);
            }
        }
    }
}

