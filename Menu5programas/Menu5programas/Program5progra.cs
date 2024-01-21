// See https://aka.ms/new-console-template for more information

public class Programas
{
    public static void Main(string[] args)
    {
        String op = "";

        {
                do
                {
                    int opcionMenu;
                    double División, Areas, Raíz, Serie, Calculadora;
                    Console.WriteLine(" ¿Que ejercicio desea utilizar? ");
                    Console.WriteLine("A. Áreas de figuras simples ");
                    Console.WriteLine("B. Residuo de División ");
                    Console.WriteLine("C. La raiz de un número ");
                    Console.WriteLine("D. Serie Fibonacci ");
                    Console.WriteLine("E. Calculadora de 4 divisas ");
                    op = op.ToUpper();
                    String ej = Console.ReadLine();


                    //codigo areas
                    if (ej == "a")
                    {
                        int opcionMenu2;
                        int lado1;
                        double resultado, basee, altura, radio;
                        Console.WriteLine(" Sacar area de las siguientes figuras:  ");
                        Console.WriteLine(" 1-. Cuadrado ");
                        Console.WriteLine(" 2-. Rectangulo ");
                        Console.WriteLine(" 3-. Circulo ");
                        Console.WriteLine(" 4-. Rombo ");
                        Console.WriteLine(" Elije una opcion; ");
                        opcionMenu2 = int.Parse(Console.ReadLine());

                        if (opcionMenu2 == 0)
                        {
                            Console.WriteLine("Cuadrado");
                            Console.WriteLine("Ingresa dos numeros:  ");
                            lado1 = int.Parse(Console.ReadLine());
                            resultado = int.Parse(Console.ReadLine());
                            Console.WriteLine("El area del cuadrado es: " + resultado);
                        }


                        else if (opcionMenu2 == 2)
                        {
                            Console.WriteLine("Rectangulo");
                            Console.WriteLine("Ingresa la base: ");
                            basee = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa la altura: ");
                            altura = int.Parse(Console.ReadLine());
                            resultado = basee * altura;
                            Console.WriteLine("el area del rectangulo es: " + resultado);



                        }

                        else if (opcionMenu2 == 3)

                        {
                            Console.WriteLine("Circulo");
                            Console.WriteLine("Ingresa el radio: ");
                            radio = int.Parse(Console.ReadLine());
                            resultado = int.Parse(Console.ReadLine());
                            Console.WriteLine("el area del circulo es: " + resultado);

                        }

                        else if (opcionMenu2 == 4)

                        {
                            Console.WriteLine("Rombo");
                            Console.WriteLine("Ingresa el radio: ");
                            radio = int.Parse(Console.ReadLine());
                            resultado = int.Parse(Console.ReadLine());
                            Console.WriteLine("el area del rombo es: " + resultado);

                        }
                    }

                    // division
                    else if (ej == "b")
                    {
                        Console.WriteLine(" Residuo de división ");
                        {

                            int num1;
                            int num2;
                            int div;
                            int div2;

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

                    //codigo raiz
                    else if (ej == "c")
                    {
                        Console.WriteLine(" Sacar la raiz de un número ");
                        {
                            double num1;
                            Console.WriteLine("Escribe un numero para sacar su raiz: ");
                            num1 = int.Parse(Console.ReadLine());
                            double raizCuadrada = Math.Sqrt(num1);
                            Console.WriteLine("La raíz cuadrada de {0} es {1}", num1, raizCuadrada);
                        }
                    }

                    // codigo fibonacci
                    else if (ej == "d")
                    {
                        Console.WriteLine(" Serie fibonacci ");

                        int num1;
                        int num2;

                        Console.WriteLine("Escribe el primer valor: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el segundo valor: ");
                        num2 = int.Parse(Console.ReadLine());

                        Console.WriteLine(">El resultado es el siguiente:");

                        //Se genera en 20 sucesiones el código Fibonacci.
                        for (int i = 0; i < 20; i++)
                        {

                            int temp = num1;
                            num1 = num2;
                            num2 = temp + num1;
                            Console.WriteLine(num1);
                        }
                    }

                    //divisas
                    else if (ej == "e")
                    {
                        Console.WriteLine(" Calcular divisas en 4 monedas ");
                        Console.WriteLine("Elije la moneda a la que quieras convertir tus pesos: ");
                        int opcionMenu3;
                        double dolares, won, riyal, dolaresCan, pesos;
                        Console.WriteLine("1-. Dolares (EUA) ");
                        Console.WriteLine("2-. Wones (KR) ");
                        Console.WriteLine("3-. Riyal  (SAU)");
                        Console.WriteLine("4-. Dolares (CAN) ");
                        opcionMenu3 = int.Parse(Console.ReadLine());


                        if (opcionMenu3 == 1)
                        {
                            Console.WriteLine(" --Dolares EUA-- ");
                            Console.WriteLine(" Ingrese la cantidad a convertir  ");
                            pesos = Single.Parse(Console.ReadLine());
                            dolares = pesos * 0.054;
                            Console.WriteLine("{0} pesos mexicanos equivale a {1} dolar estadounidense ", pesos, dolares);
                            Console.ReadKey();
                        }

                        if (opcionMenu3 == 2)
                        {
                            Console.WriteLine(" --Wones KR-- ");
                            Console.WriteLine(" Ingrese la cantidad a convertir ");
                            pesos = Single.Parse(Console.ReadLine());
                            won = pesos * 68.677;
                            Console.WriteLine("{0} pesos mexicanos equivale a {1} won surcoreano ", pesos, won);
                            Console.ReadKey();
                        }

                        if (opcionMenu3 == 3)
                        {
                            Console.WriteLine(" --Riyal Arabia Saudita-- ");
                            Console.WriteLine(" Ingrese la cantidad a convertir ");
                            pesos = Single.Parse(Console.ReadLine());
                            riyal = pesos * 0.187;
                            Console.WriteLine("{0} pesos mexicanos equivale a {1} riyal de Arabia Saudita ", pesos, riyal);
                            Console.ReadKey();
                        }

                        if (opcionMenu3 == 4)
                        {
                            Console.WriteLine(" --Dolar Canadiense-- ");
                            Console.WriteLine(" Ingrese la cantidad a convertir ");
                            pesos = Single.Parse(Console.ReadLine());
                            dolares = pesos * 0.065;
                            Console.WriteLine("{0} pesos mexicanos equivale a {1} dolar canadiense ", pesos, dolares);
                            Console.ReadKey();
                        }
                    }

                    Console.WriteLine("¿Desea regresar al menu? SI/NO");
                    op = Console.ReadLine();
                    op = op.ToUpper();
                }

                while (op == "SI");
            
        }

    }

}