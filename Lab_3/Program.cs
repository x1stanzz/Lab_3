using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть координати точки");
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть координати лівої верхньої вершини");
            Console.Write("x1 = ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть координати правої нижньої вершини");
            Console.Write("x2 = ");
            int x2 = int.Parse(Console.ReadLine());
            if (x1 >= x2)
            {
                Console.WriteLine("Не коректні дані! Спробуйте знову.");
                Console.Write("x2 = ");
                x2 = int.Parse(Console.ReadLine());
            }
            Console.Write("y2 = ");
            int y2 = int.Parse(Console.ReadLine());
            if (y1 <= y2)
            {
                Console.WriteLine("Не коректні дані! Спробуйте знову.");
                Console.Write("y2 = ");
                y2 = int.Parse(Console.ReadLine());
            }

            bool result;
            if ((x >= x1 && x <= x2) && (y <= y1 && y >= y2))
                result = true;
            else
                result = false;
            Console.WriteLine(result);

            Console.Read();
        }
    }
}
