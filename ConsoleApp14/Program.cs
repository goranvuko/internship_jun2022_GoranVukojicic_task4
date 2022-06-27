using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] check = new int[] { 3, 10, 2, 9 };
            int k = 1;
            int b = 12;
            
            Console.WriteLine(Bill.bonAppetite(check,k,b));
        }
    }
}
