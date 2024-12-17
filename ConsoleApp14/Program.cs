using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{/// <summary>
/// Задача 6. Дан признак геометрической фигуры на плоскости: к – круг, п – прямоугольник, т - треугольник. Вывести на экран периметр и площадь заданной фигуры (данные, необходимые для расчетов, запросить у пользователя).
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string f = Input("Первая буква геометрической фигуры: ");

            switch (f)
            {
                case "к":
                    Console.WriteLine("Введите радиус круга: ");
                    double radius = double.Parse(Console.ReadLine());
                    double Perimeter1 = 2 * Math.PI * radius;
                    double Ploshad1 = Math.PI * Math.Pow(radius, 2);
                    Console.WriteLine($"Периметр круга:\t{Perimeter1:f2}");
                    Console.WriteLine($"Площадь круга:\t{Ploshad1:f2}");
                    break;
                case "т":
                    Console.Write("Введите длину первой стороны треугольника: ");
                    double side1 = double.Parse(Console.ReadLine());
                    Console.Write("Введите длину второй стороны треугольника: ");
                    double side2 = double.Parse(Console.ReadLine());
                    Console.Write("Введите длину третьей стороны треугольника: ");
                    double side3 = double.Parse(Console.ReadLine());
                    double Perimeter3 = side1 + side2 + side3;
                    double s = (side1 + side2 + side3) / 2;
                    double Ploshad3 = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
                    Console.WriteLine($"Периметр треугольника:\t{Perimeter3:f2}");
                    Console.WriteLine($"Площадь треугольника:\t{Ploshad3:f2}");
                    break;
                case "п":
                    Console.Write("Введите длину прямоугольника: ");
                    double sidex = double.Parse(Console.ReadLine());
                    Console.Write("Введите ширину прямоугольника: ");
                    double sidey = double.Parse(Console.ReadLine());
                    double Perimeter2 = 2 * (sidex + sidey);
                    double Ploshad2 = sidex * sidey;
                    Console.WriteLine($"Периметр прямоугольника:\t{Perimeter2:f2}");
                    Console.WriteLine($"Площадь прямоугольника:\t{Ploshad2:f2}");
                    break;
                default:
                    Console.WriteLine("Некорректный ввод.");
                    break;
            }
            Console.Read();
        }
        public static string Input(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}   

