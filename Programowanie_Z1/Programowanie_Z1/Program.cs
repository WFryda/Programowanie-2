﻿using System;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double wynik = 0.0;
            string rownanie;
            Mat.OdwrotnaNotacjaPolska onp = new Mat.OdwrotnaNotacjaPolska();
            //for (int i = 1; i < args.Length; i++)
            //{
            //    liczby[i-1] = char.Parse(args[i]);
            //}
            rownanie=args[0].Replace("x",args[1]);
            onp.Parse(rownanie);
            Console.WriteLine(onp.ZamianaWyrazenia);
            Console.WriteLine(onp.WyrazeniePostfixowe);
            wynik = onp.Ocenianie();
            //Console.WriteLine(onp.ZamianaWyrazenia);
            //Console.WriteLine(onp.WyrazeniePostfixowe);
            Console.WriteLine(wynik);
            int ilosc = int.Parse(args[4]);
            double[] liczby = new double[ilosc];
            liczby[0] = double.Parse(args[2]);
            liczby[ilosc - 1] = double.Parse(args[3]);
            double krok = (liczby[ilosc - 1] - liczby[0]) / (ilosc - 1);
            for (int i = 1; i < ilosc - 1; i++)
            {
                liczby[i] = liczby[0] + krok * i;
            }
            string[] liczby2 = new string[ilosc];
            for (int i = 0; i < ilosc; i++)
            {
                liczby2[i] = liczby[i].ToString();
                liczby2[i] = liczby2[i].Replace(',', '.');
                rownanie = args[0].Replace("x", liczby2[i]);
                onp.Parse(rownanie);
                wynik = onp.Ocenianie();
                Console.WriteLine("{0} => {1}", liczby2[i], wynik);
            }

            //onp.Parse("3+4*2/(1-5)^2^3");
            //wynik = onp.Ocenianie();
            //Console.WriteLine("oryginał: {0}", onp.OrygnialneWyrazenie);
            //Console.WriteLine("zamiana: {0}", onp.ZamianaWyrazenia);
            //Console.WriteLine("postfix: {0}", onp.WyrazeniePostfixowe);
            //Console.WriteLine("wynik: {0}", wynik);

            //wynik = 0.0;
            //Console.WriteLine();
            //onp.Parse("exp(sin(1+2))-100");
            //wynik = onp.Ocenianie();
            //Console.WriteLine("oryginał: {0}", onp.OrygnialneWyrazenie);
            //Console.WriteLine("zamiana: {0}", onp.ZamianaWyrazenia);
            //Console.WriteLine("postfix: {0}", onp.WyrazeniePostfixowe);
            //Console.WriteLine("wynik: {0}", wynik);

            //Console.WriteLine();
            //onp.Parse("abs(10)");
            //wynik = onp.Ocenianie();
            //Console.WriteLine("oryginał: {0}", onp.OrygnialneWyrazenie);
            //Console.WriteLine("zamiana: {0}", onp.ZamianaWyrazenia);
            //Console.WriteLine("postfix: {0}", onp.WyrazeniePostfixowe);
            //Console.WriteLine("wynik: {0}", wynik);
            //Console.WriteLine("");


            //Console.WriteLine();
            //Console.WriteLine();
            //for (int i = 1; i <= 5; i++)
            //{
            //    string wyrazenie = "sin2*";
            //    wyrazenie += i;
            //    Oblicz(wyrazenie);
            //}

            Console.WriteLine("Koniec programu");
            Console.ReadLine();


        }

        static void Oblicz(string wyrazenie)
        {
            double wynik;
            Mat.OdwrotnaNotacjaPolska onp = new Mat.OdwrotnaNotacjaPolska();
            Console.WriteLine();
            onp.Parse(wyrazenie);
            wynik = onp.Ocenianie();
            Console.WriteLine("oryginał: {0}", onp.OrygnialneWyrazenie);
            Console.WriteLine("zamiana: {0}", onp.ZamianaWyrazenia);
            Console.WriteLine("postfix: {0}", onp.WyrazeniePostfixowe);
            Console.WriteLine("wynik: {0}", wynik);
            Console.WriteLine("");
        }
    }
}