using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Условные_операторы_4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите значени х");
                var x = int.Parse(Console.ReadLine());
                if (Math.Abs(Math.Sin(x)) > x)
                {
                    var y = (Math.Sin(x));
                    Console.WriteLine("Значение функции равно {0}", y + "\n");
                }
                if (-Math.Abs(Math.Sin(x)) < x)
                {
                    var y = (-Math.Sin(x));
                    Console.WriteLine("Значение функции равно {0}", y + "\n");
                }
                if (Math.Abs(Math.Sin(x)) == x)
                {
                    var y = 0;
                    Console.WriteLine("Значение функции равно {0}", y + "\n");
                }
            }
        }
    }
}
