using System.Net.NetworkInformation;

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

        public static void Ejercicio3(int n)
        {
            Misc.IsPrime(700);
                
        }
    }
}
