using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, n;
            Console.Write("Enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");
            for (i = 2; i < n; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            Console.ReadLine();
        }
    }
}
