using System;

namespace homework_1
{
    internal class Prime
    {
        static void Main(string[] args)
        {
            int least;
            int most;
            int cnt = 0;

            bool isPrime(int n)
            {
                if (n < 2) return false;
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                        return false;
                }
                return true;
            }

            Console.WriteLine("请输入下限：");
            least = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入上限：");
            most = int.Parse(Console.ReadLine());

            for (int i = least; i <= most; i++)
            {
                if (isPrime(i))
                {
                    Console.Write(i + "\t");
                    cnt++;
                    if (cnt % 10 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine();
        }
    }
}