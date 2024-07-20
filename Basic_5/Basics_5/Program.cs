using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i<1000)
            {
                i++;
                if(i%2!=0)
                {
                    Console.WriteLine(i);
                }
                
            }
            //2
            int max=0,min=0,n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for(int j=0;j<n;j++)
            { Console.Write($"a[{j}]=");
                a[j] = Convert.ToInt32(Console.ReadLine());
               
            }
            max = a[0]; min = a[0];
            for (int j=0;j<n;j++)
            {
                if (a[j] > max)
                { max = a[j]; }
                if (min > a[j])
                { min = a[j]; }
            }
            
            int s = min * max;
            Console.WriteLine(s);
            //3
            int x,fact=1;
            again:
            x = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                for (int i3 = 1; i3 <= x; i3++)
                {
                    fact *= i3;
                }
                Console.WriteLine($"{x}!={fact}");
            }
            else { Console.WriteLine("the system is not negative factorial!"); goto again; }
        }
    }
}
