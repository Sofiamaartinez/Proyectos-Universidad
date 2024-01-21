// See https://aka.ms/new-console-template for more information


using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int opcionMenu;
        int lado1;
        double resultado, basee, altura, radio;
        Console.WriteLine("-OpcionMenu-");
        Console.WriteLine(" 1-. Cuadrado ");
        Console.WriteLine(" 2-. Rectangulo ");
        Console.WriteLine(" 3-. Circulo ");
        Console.WriteLine(" 4-. Rombo ");
        Console.WriteLine(" Elije una opcion; ");
        opcionMenu = int.Parse(Console.ReadLine());

        if (opcionMenu == 1)
        {
            Console.WriteLine("Cuadrado");
            Console.WriteLine("Ingresa dos numeros:  ");
            lado1 = int.Parse(Console.ReadLine());
            resultado = int.Parse(Console.ReadLine());
            Console.WriteLine("El area del cuadrado es: " + resultado);
        }


        else if (opcionMenu == 2)
        {
            Console.WriteLine("Rectangulo");
            Console.WriteLine("Ingresa la base: ");
            basee = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la altura: ");
            altura = int.Parse(Console.ReadLine());
            resultado = basee * altura;
            Console.WriteLine("el area del rectangulo es: " + resultado);



        }

        else if (opcionMenu == 3)

        {
            Console.WriteLine("Circulo");
            Console.WriteLine("Ingresa el radio: ");
            radio = int.Parse(Console.ReadLine());
            resultado = int.Parse(Console.ReadLine());
            Console.WriteLine("el area del circulo es: " + resultado);

        }

        else if (opcionMenu == 4)

        {
            Console.WriteLine("Rombo");
            Console.WriteLine("Ingresa el radio: ");
            radio = int.Parse(Console.ReadLine());
            resultado = int.Parse(Console.ReadLine());
            Console.WriteLine("el area del rombo es: " + resultado);

        }

    }

}


