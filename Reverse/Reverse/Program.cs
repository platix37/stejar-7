using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        private static void Reverse()
        {
            //reverse fara vectori aditionali

            int n, i, aux;
            Console.Write("n= ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] v = new int[n];

            for (i = 0; i < n; i++)
                v[i] = i;

            Console.WriteLine("Vectorul initial: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", v[i]);
            }

            for(i=0; i<n; i++)
            {
                aux = v[n - i-1];
                v[n - i-1] = v[i];
                v[i] = aux;
                if (i >= n / 2)
                    break;
            }

            Console.WriteLine("Vectorul final: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", v[i]);
            }
        }
        static void Main(string[] args)
        {
            Reverse();
        }
    }
}
