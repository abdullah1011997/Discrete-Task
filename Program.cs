using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The First Number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Second Number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            for(int x = n1; x <= n2; x++)
            {
                if(x%2 != 0)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
