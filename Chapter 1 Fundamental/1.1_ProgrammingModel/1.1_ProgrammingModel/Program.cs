using System;

namespace _1._1_ProgrammingModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex09(int.MinValue);
        }

        static int Gcd(int p, int q)
        {
            if (p % q == 0) return q;
            return Gcd(q, p % q);
        }

        static void Ex01()
        {
            // 7
            Console.WriteLine((0 + 15) / 2);
            // 200.0000002
            Console.WriteLine(2.0e-6 * 100000000.1);
            // True
            Console.WriteLine(true && false || true && true);
        }

        static void Ex02()
        {
            // Double 1.618 
            Console.WriteLine((1 + 2.236) / 2);
            // Double 10.0
            Console.WriteLine(1 + 2 + 3 + 4.0);
            // Boolean True
            Console.WriteLine(4.1 >= 4);
            // String 33
            Console.WriteLine(1 + 2 + "3");
        }

        static void Ex03(int a, int b, int c)
        {
            if(a == b && b == c)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");
        }

        static bool Ex05(double x, double y)
        {
            return 0 < x && x < 1 && 0 < y && y < 1;
        }

        static void Ex06()
        {
            int f = 0, g = 1;
            for (int i = 0; i <= 15; i++)
            {
                Console.WriteLine(f);
                f = f + g;
                g = f - g;
            }
        }

        static void Ex07()
        {
            // 3.0 Sqrt
            var t = 9.0;
            while (Math.Abs(t - 9.0 / t) > 0.001)
                t = (9.0 / t + t) / 2.0;
            Console.WriteLine(t);

            // 499,500 Arithmetic
            int sumA = 0;
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < i; j++)
                    sumA++;
            }
            Console.WriteLine(sumA);

            // 10,000
            int sumB = 0;
            for (int i = 1; i < 1000; i *= 2)
            {
                for (int j = 0; j < 1000; j++)
                    sumB++;
            }
            Console.WriteLine(sumB);
        }

        static void Ex08()
        {
            // b
            Console.WriteLine('b');
            // 197
            Console.WriteLine('b' + 'c');
            // e
            Console.WriteLine((char)('a' + 4));
        }

        static void Ex09(int N)
        {
            Console.WriteLine(Convert.ToString(N, 2));
            
            bool neg = N < 0, start = false;
            if (N < 0) N = ~N;
            var digits = new int[32];
            var index = 32;
            while (N != 0)
            {
                digits[--index] = N & 1;
                N >>= 1;
            }
            var res = "";
            for (int i = 0; i < digits.Length; i++)
            {
                if (neg) digits[i] ^= 1;
                if (digits[i] == 1) start = true;
                if (start) res += digits[i];
            }
            if (res == "") res = "0";
            Console.WriteLine(res);
        }
    }
}
