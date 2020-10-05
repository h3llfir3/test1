﻿
namespace Prueba
{
    class Maths
    {
        public static Equation2Solution SolveEquation(double a, double b, double c)
        {
            double aux1, aux2;
            Equation2Solution result;

            result = new Equation2Solution();
            
            aux1 = b * b - 4 * a * c;
            aux2 = System.Math.Sqrt(aux1);
            result.solution1 = (-b + aux2) / 2.0 * a;
            result.solution2 = (-b - aux2) / 2.0 * a;

            return result;
        }
    }
}
