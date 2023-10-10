using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PanasenkoRA.Sprint1.Task3.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint1.Task3.V0
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Панаcенко Роман Анатольевич | ПКТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("*выполняет указанные расчёты и печатает результат на экране.              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            double v1 = 10;
            double v2 = 20;
            double T = 30;
            double S = 2;
            Console.WriteLine("Скорость первого автомобиля - " + v1 + "км/ч");
            Console.WriteLine("Скорость второго автомобиля - " + v2 + "км/ч");
            Console.WriteLine("Время, которое ехали автомобили - " + S + "ч");
            Console.WriteLine("Изначальное расстояние между ними - " + T + "км");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Итоговое расстояние между автомобилями - " + ds.DistanceOverTime(v1, v2, T, S));
            Console.ReadKey();
        }
    }
}
