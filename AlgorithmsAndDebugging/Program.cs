using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace AlgorithmsAndDebugging
{
    class Program
    {
        static int SimpleSumIntegerUpToLimit(int limit)
        {
            int sum = 0;
            for (int count = 1; count <= limit; count++)
            {
                sum += count;
            }
            return sum;
        }

        static int CleverSumIntegerUpToLimit(int limit)
        {
            return (limit * (limit + 1)) >> 1;
        }

        static int EuclideanAlgorithm(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            if (a == 0)
                return b;
            else
                return a;
        }

        
        static void Main(string[] args)
        {
            int limit;
            int result;
            Stopwatch stopWatch = new Stopwatch();

            limit = 10;
            stopWatch.Start();
            result = SimpleSumIntegerUpToLimit(limit);
            stopWatch.Stop();
            Console.WriteLine("\nSimple algoritm to " + limit + " is: " + result);
            Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
            stopWatch.Reset();

            stopWatch.Start();
            result = CleverSumIntegerUpToLimit(limit);
            stopWatch.Stop();
            Console.WriteLine("\nClever algorithm to " + limit + " is: " + result);
            Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
            stopWatch.Reset();

            limit = 10;
            stopWatch.Start();
            result = SimpleSumIntegerUpToLimit(limit);
            stopWatch.Stop();
            Console.WriteLine("\nSimple algorithm to " + limit + " is: " + result);
            Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
            stopWatch.Reset();

            stopWatch.Start();
            result = CleverSumIntegerUpToLimit(limit);
            stopWatch.Stop();
            Console.WriteLine("\nClever algorithm to " + limit + " is: " + result);
            Console.WriteLine("Ticks" + stopWatch.ElapsedTicks);
            stopWatch.Reset();

            limit = 1000;
            stopWatch.Start();
            result = SimpleSumIntegerUpToLimit(limit);
            stopWatch.Stop();
            Console.WriteLine("\nSimple algorithm to " + limit + " is: " + result);
            Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
            stopWatch.Reset();

            stopWatch.Start();
            result = CleverSumIntegerUpToLimit(limit);
            stopWatch.Stop();
            Console.WriteLine("\nClever algorithm to " + limit + " is: " + result);
            Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
            stopWatch.Reset();

            List<int> nonPrimes = new List<int>();

            int max = 100;

            for (int x = 2; x * x <= max; x++)
            {
                for (int y = x * 2 ; y < max; y += x)
                {
                    if (!nonPrimes.Contains(y))
                    {
                        nonPrimes.Add(y);
                    }
                }
            }

            for (int x = 2; x < max; x++)
            {
                if (!nonPrimes.Contains(x))
                {
                    Console.WriteLine(x);
                }    
            }

            int val1 = 252;
            int val2 = 105;
            int gcd = EuclideanAlgorithm(val1, val2);
            Console.WriteLine("The GCD of {0} and {1} is {2}.", val1, val2, gcd);

            int [] numbers = { 45, 72, 38, 62, 33, 87, 99, 11, 31, 15};
            bool flag = true;
            int temp;

            for (int i = 1; (i <= (numbers.Length - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numbers.Length -1); j++)
                {
                    if (numbers[j + 1] > numbers[j])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        flag = true;
                    }
                }
            }

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

               
        }
    }
}