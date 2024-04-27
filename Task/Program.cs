using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double k = double.MinValue;
            Console.WriteLine("Введите коэфф. k и b для решения линейного уравнения:");
            do
            {
                Console.Write("k= ");
                k = double.Parse(Console.ReadLine());
                if (k == 0)
                {
                    Console.WriteLine("k не может быть равно 0!. Повтооите ввод.");
                }
            }
            while (k == 0);
            Console.Write("b= ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{k}x{b:+0;-0;0}=0");
            Equations equations = new Equations(k, b);
            Console.WriteLine($"x={equations.Root():f2}");
            Console.ReadKey();


        }
    }
}
