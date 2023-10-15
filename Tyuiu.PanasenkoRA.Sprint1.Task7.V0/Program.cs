using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PanasenkoRA.Sprint1.Task7.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint1.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Панасенко Р. А. | ПКТб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы с C#                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Панаcенко Роман Анатольевич | ПКТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем. Ответ округлите      *");
            Console.WriteLine("* до 3 знаков после запятой.                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("                  1");
            Console.WriteLine("                  _");
            Console.WriteLine("          2       2");
            Console.WriteLine("    b + (b  + 4ac)            3    -2");
            Console.WriteLine("z = ---------------------- - a c + b"); 
            Console.WriteLine("          2a");
            double a, b, c;
            Console.WriteLine("Введите значение A:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение B:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение C:");
            c = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(a, b, c));
            Console.ReadKey();
        }
    }
}
