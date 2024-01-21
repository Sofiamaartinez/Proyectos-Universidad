// See https://aka.ms/new-console-template for more information
using System;

public class Division
{
    public static void Main(string[] args)
    {
        
        int num1;
        int num2;
        int div;
        int div2;
        Console.WriteLine("Problema de division y residuo.");

        Console.WriteLine("Escribe el primer valor: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escribe el segundo valor: ");
        num2 = int.Parse(Console.ReadLine());

        div = num1 / num2;
        div2 = num2 / num1;

        Console.WriteLine("La division es: " + div);
        Console.WriteLine("El residuo es: " + div2);

    }
}
