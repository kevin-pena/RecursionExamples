using System;

namespace RecursionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recursion Examples");

            // Ejemplo 1: Cálculo factorial iterativo
            Console.WriteLine("Factorial Iterative:");
            int factorialIterative = CalculateFactorialIterative(5);
            Console.WriteLine("Factorial of 5: " + factorialIterative);

            // Ejemplo 2: Cálculo factorial recursivo
            Console.WriteLine("Factorial Recursive:");
            int factorialRecursive = CalculateFactorialRecursive(5);
            Console.WriteLine("Factorial of 5: " + factorialRecursive);

            // Ejemplo 3: Suma iterativa
            Console.WriteLine("Sum Iterative:");
            int sumIterative = CalculateSumIterative(5);
            Console.WriteLine("Sum of numbers up to 5: " + sumIterative);

            // Ejemplo 4: Suma recursiva
            Console.WriteLine("Sum Recursive:");
            int sumRecursive = CalculateSumRecursive(5);
            Console.WriteLine("Sum of numbers up to 5: " + sumRecursive);
        }

        // Cálculo factorial iterativo
        static int CalculateFactorialIterative(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        // Cálculo factorial recursivo
        static int CalculateFactorialRecursive(int n)
        {
            // Segmento recursivo
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * CalculateFactorialRecursive(n - 1);
            }
        }

        // Suma iterativa
        static int CalculateSumIterative(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        // Suma recursiva
        static int CalculateSumRecursive(int n)
        {
            // Segmento recursivo
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n + CalculateSumRecursive(n - 1);
            }
        }
    }
}

