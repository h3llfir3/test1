using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Prueba
{
    class Ejercicios
    {
        // Ejercicio 1: Hacer una función que imprima por 
        // pantalla los números del 0 al 99.
        
        public static void Ejercicio1()
        {
            int contador = 0;
            while (contador <= 99)
            {
                System.Console.WriteLine(contador);
                // contador = contador +1;
                // contador += 1;
                contador++;
            }
        }

        // Ejercicio 2: Hacer una función que imprima todos los números pares de 0 a n

        public static void Ejercicio2(int n)
        {
            int i = 0;
            while (i < n)
            {
                if (Misc.IsEven(i))
                    System.Console.WriteLine(i);
                i++;
            }
        }

        // Ejercicio 3: Hacer un programa que imprima si un número es primo o no

        public static void Ejercicio3(int number)
        {
            if (Misc.IsPrime(number) == true)
                System.Console.WriteLine("El número " + number + " es primo.");
            else
                System.Console.WriteLine("El número " + number + " no es primo");
        }

        // Ejercicio 4: Hacer un programa que imprima del 5 a -2...
        public static void Ejercicio4()
        {
            int i = 0;
            while (i < 85)
            {
                System.Console.WriteLine(5 - i);
                i++;
            }
        }

        // Ejercicio 5:
        
        public static void Ejercicio5()
        {
            for (int i = 0; i < 90; i++)
            {
                if (Misc.IsEven(i) == true)
                    System.Console.WriteLine(-i);
                else
                    System.Console.WriteLine(i);
            }
            
        }

        // Método Román
        public static void Ejercicio6()
        {
            int number1 = 0;
            int number2 = 1;
            System.Console.WriteLine(number1);
            System.Console.WriteLine(number2);
            for (int i = 0; i < 90; i++)
            {
                System.Console.WriteLine(number1 + number2);
                number2 = number1 + number2;
                number1 = number2 - number1;
            }
        }

        // Alt
        public static void Ejercicio7()
        {
            int number1 = 0;
            int number2 = 1;
            int aux = 0;
            System.Console.WriteLine(number1);
            System.Console.WriteLine(number2);
            for (int i = 0; i < 90; i++)
            {
                aux = number1 + number2;
                System.Console.WriteLine(aux);
                
                
            }
        }
    }
}
