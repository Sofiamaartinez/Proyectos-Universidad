// See https://aka.ms/new-console-template for more information
using System;

namespace RaizCuadradaCubica
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            Console.WriteLine("Escribe un numero para sacar su raiz: ");
            num1= int.Parse(Console.ReadLine());
            double raizCuadrada = Math.Sqrt(num1);
            Console.WriteLine("La raíz cuadrada de {0} es {1}", num1, raizCuadrada);
        }
    }
}
