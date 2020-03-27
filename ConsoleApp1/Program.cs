using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double a, b;
            Console.WriteLine("Введите x");
            //x = Convert.ToDouble(Console.ReadLine());
            double.TryParse(Console.ReadLine(), out x);
            a = (Math.Pow(x, 2) + 2 * x - 3 + (x + 1) * Math.Sqrt(Math.Pow(x, 2) - 9)) / (Math.Pow(x, 2) - 2 * x - 3 + (x - 1) * Math.Sqrt(Math.Pow(x, 2) - 9));
            b = Math.Sqrt((x + 3) / (x - 3));
            Console.WriteLine("Первая переменная: "); Console.WriteLine(a);
            Console.WriteLine("Вторая переменная: "); Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
