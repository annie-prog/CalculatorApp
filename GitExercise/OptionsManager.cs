﻿using System;

namespace GitExercise
{
    public static class OptionsManager
    {
        public static string[] OptionsList = {
            "a - Add",
            "s - Subtract",
            "m - Multiply", 
            "pow - Power",
            "log - Logarithm", 
            "fact - Sum of 2 factorials"
        };

        public static void Power(double a, double b)
        {
            Console.WriteLine($"{a}^{b} = {Math.Pow(a,b)}");
        }
        public static void Log(double a, double b)
        {
            Console.WriteLine($"Log of {a} with base {b} = {Math.Log(a, b)}");
        }
        public static void Factorial(double a, double b)
        {
            long factA = CalculateFactorial((int)a);
            long factB = CalculateFactorial((int)b);
            Console.WriteLine($"{a}! + {b}! = {(int)a}! + {(int)b}! = {factA + factB}");
        }

        private static long CalculateFactorial(int a)
        {
            long p = 1;
            for (int i = 1; i <= a; i++)
            {
                p = p * i;
            }
            return p;
        }

        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"{a} x {b} = {a * b}");
        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
    }
}
