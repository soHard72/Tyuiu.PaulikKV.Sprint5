using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PaulikKV.Sprint5.Task1.V26.Lib;

namespace Tyuiu.PaulikKV.Sprint5.Task1.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Паулик К.В. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Паулик Кирилл Владимирович | АСОиУб-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая производит табулирование функции:           *");
            Console.WriteLine("* F(x) = (2x + 6 / cos(x) + x) - 3 на заданном диапазоне                  *");
            Console.WriteLine("* [-5; 5] с шагом 1. Произвести проверку деления на на ноль. При делении  *");
            Console.WriteLine("* на ноль вернуть значение 0. Результат сохранить в текстовый файл        *");
            Console.WriteLine("* OutPutFileTask0.txt и вывести на консоль в таблицу.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

           

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл:  " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
