
using System;

namespace ConsoleApp
{

    internal class Program
    {

        public static void Main(string[] args)
        {

            int amount = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (IsPerfect(i))
                    amount++;
            }

            Console.WriteLine(amount);
        }

        public static bool IsPerfect(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == num)
            {
                Console.WriteLine(num);
                return true;
            }

            return false;
        }

    }

}