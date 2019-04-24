using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworl
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            int f = 0;
            while (x)
            {
                int nn = Convert.ToInt32(Console.ReadLine());
                f++;
                int n = nn;
                if (f == 10)
                {
                    x = false;

                }
                bool flag = true;
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        flag = false;
                       
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not Prime");
                }
            }
            Console.ReadKey();
        }
    }
}
