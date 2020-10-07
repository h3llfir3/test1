using System;
using System.Security.Cryptography;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicios.Ejercicio1();
            //Ejercicios.Ejercicio2(60);
            //Ejercicios.Ejercicio3(50);
            //jercicios.Ejercicio4();
            //Ejercicios.Ejercicio5();
            //Ejercicios.Ejercicio7();
            Student s1, s2;
            s1 = new Student();
            s2 = new Student();

            s1.Name = "Abel";
            s2.Name = "Alex";

            string ss = s1.GetNameTwice();


        }
    }
}
