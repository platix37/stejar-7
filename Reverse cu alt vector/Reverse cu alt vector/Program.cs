using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_cu_alt_vector
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;
            Console.Write("n= ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] v = new int[n];
            int[] w = new int[n];

            for (i = 0; i < n; i++)
                v[i] = i;
        
            Console.WriteLine("Vectorul v: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", v[i]);
            }

            for(i=0;i<n;i++)
            {
                w[n-i-1] = v[i];
            }

            Console.WriteLine("Vectorul w: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", w[i]);
            }
        }
    }
}
