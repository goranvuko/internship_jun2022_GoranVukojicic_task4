using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Bill
    {
        int[] check = new int[] { 3, 10, 2, 9 };
        int k = 1;
        int b = 12;
        public static string bonAppetite(int[] check,int k, int b)
        {
            int anns = 0;
            string bon = "bon appetite";

            for (int i = 0; i < check.Length; i++)
            {
                if (i != k) anns += check[i];
            }

            if (anns == b)
                return bon; 

            else 
            {
                int razlika = anns - b;
                return razlika.ToString();
            }
        }

    }
}

