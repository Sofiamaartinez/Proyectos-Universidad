// See https://aka.ms/new-console-template for more information
using System;

  class Calculadora
{
    public static void Main(string[] args)
    {
       double n1 = 0, n2 = 0, suma = 0, resta = 0, multi = 0, div = 0;

       Console.WriteLine("Ingrese un numero ");
       n1 = int.Parse(Console.ReadLine());
       Console.WriteLine("Ingrese otro  numero ");
       n2 = int.Parse(Console.ReadLine());

       suma = n1 + n2;
       resta = n1 - n2;
       multi = n1 * n2;
       div = n1 / n2;

       Console.WriteLine("La suma de {0} + {1} es: {2}", n1, n2, suma);
       Console.WriteLine("La resta de {0} - {1} es: {2}", n1, n2, resta);
       Console.WriteLine("La multiplicacion de {0} * {1} es:  {2}", n1, n2, multi);
       Console.WriteLine("La division de {0} / {1} es: {2}", n1, n2, div);
       Console.Write($"{Environment.NewLine} Presione cualquier boton para salir...");
       Console.ReadKey(true);
    }
}

