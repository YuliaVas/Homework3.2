using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3._2
{
    internal class Program
    {
        static void Main(string[] args)
        { while(true)
                {
                Console.WriteLine("Введите 2 числа");
                int A = Convert.ToInt32(Console.ReadLine());
                int B = Convert.ToInt32(Console.ReadLine());
                if (A > B)
                { Console.WriteLine(A + " больше " + B);
                }
                if (B > A) 
                { Console.WriteLine(A + " меньше " + B);
                }
                if (A == B) 
                { Console.WriteLine(A + " равно " + B);
                } }

        }
    }
}
