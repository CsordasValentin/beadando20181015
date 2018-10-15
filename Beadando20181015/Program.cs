using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando20181015
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kérem adjon meg 10 egész számot: ");

            int max = 0;

            int n = 10;
            int[] t = new int[n];

            for (int i = 0; i < n; i++) {
                t[i] = Int32.Parse(Console.ReadLine());
                max = Math.Max(t[i], max);
            }

            Console.WriteLine(max);

            Console.ReadLine();

        }
    }
}
