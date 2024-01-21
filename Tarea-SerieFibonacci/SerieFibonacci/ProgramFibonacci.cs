// See https://aka.ms/new-console-template for more information
using System;

public class Tarea

{
    public static void Main(string[] args)
    {
        int num1;
        int num2;

        Console.WriteLine(" --Problema Serie Fibonacci-- ");
        Console.WriteLine("Escribe el primer valor: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Escribe el segundo valor: ");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine(">El resultado es el siguiente:");

        //Se genera en 20 sucesiones del código Fibonacci.
        for (int i = 0; i < 20; i++)
        {
            
            int temp = num1;
            num1 = num2;
            num2 = temp + num1; 
            Console.WriteLine(num1);
        }
    }
}