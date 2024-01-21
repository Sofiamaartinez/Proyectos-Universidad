// See https://aka.ms/new-console-template for more information
using System;

public class Divisas

{
    public static void Main(string[] args)
    {
        //--Convertir Pesos MX a 4 divisas--

        Console.WriteLine("Elije la moneda a la que quieras convertir tus pesos: ");
        int opcionMenu;
        double dolares, won, riyal, dolaresCan, pesos;
        Console.WriteLine("1-. Dolares (EUA) ");
        Console.WriteLine("2-. Wones (KR) ");
        Console.WriteLine("3-. Riyal  (SAU)");
        Console.WriteLine("4-. Dolares (CAN) ");
        opcionMenu = int.Parse(Console.ReadLine());


        if (opcionMenu == 1)
        {
            Console.WriteLine(" --Dolares EUA-- ");
            Console.WriteLine(" Ingrese la cantidad a convertir  ");
            pesos = Single.Parse(Console.ReadLine());
            dolares = pesos * 0.054;
            Console.WriteLine("{0} pesos mexicanos equivale a {1} dolar estadounidense ", pesos, dolares);
            Console.ReadKey();
        }
    
        if (opcionMenu == 2)
        {
            Console.WriteLine(" --Wones KR-- ");
            Console.WriteLine(" Ingrese la cantidad a convertir ");
            pesos = Single.Parse(Console.ReadLine());
            won = pesos * 68.677;
            Console.WriteLine("{0} pesos mexicanos equivale a {1} won surcoreano ", pesos, won);
            Console.ReadKey();
        }

        if (opcionMenu == 3)
        {
            Console.WriteLine(" --Riyal Arabia Saudita-- ");
            Console.WriteLine(" Ingrese la cantidad a convertir ");
            pesos = Single.Parse(Console.ReadLine());
            riyal = pesos * 0.187;
            Console.WriteLine("{0} pesos mexicanos equivale a {1} riyal de Arabia Saudita ", pesos, riyal);
            Console.ReadKey();
        }

        if (opcionMenu == 4)
        {
            Console.WriteLine(" --Dolar Canadiense-- ");
            Console.WriteLine(" Ingrese la cantidad a convertir ");
            pesos = Single.Parse(Console.ReadLine());
            dolares = pesos * 0.065;
            Console.WriteLine("{0} pesos mexicanos equivale a {1} dolar canadiense ", pesos, dolares);
            Console.ReadKey();
        }

    }
}
