using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{/// <summary>
/// Задача 5. Дан признак транспортного средства: a – автомобиль, в – велосипед, м - мотоцикл, с – самолет, п – поезд. Вывести на экран максимальную скорость транспортного средства в зависимости от введенного признака.
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string transport = Input("первая буква транспорта:");
            string transport1 = Value(transport);
            Console.Write($"Это: {transport1}");
            Console.ReadKey();
        }
        public static string Input(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        public static string Value(string transport)
        {
            switch (transport)
            {
                case "а": return "автомобиль - 250 км/ч";
                case "в": return "велосипед - 40 км/ч";
                case "м": return "мотоцикл - 190 км/ч";
                case "с": return "самолет - 600 км/ч";
                case "п": return "поезд - 400 км/ч";
                default: return "Не верное условие";
            }
        }
        
    }
}
