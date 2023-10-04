/* swap */
using System;

namespace CSharp001
{
    class Program
    {

        static void Main(string[] args)
        {
            int a = 30, b = 20, tmp;

            tmp = a;
            a = b;
            b = tmp;

            Console.Write("a={0}  b={1}\n", a, b);

            Console.ReadKey();
        }
    }
}
