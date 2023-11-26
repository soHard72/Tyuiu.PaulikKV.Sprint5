using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.PaulikKV.Sprint5.Task7.V13.Lib;

namespace Tyuiu.PaulikKV.Sprint5.Task7.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Паулик К.В. | АСОиУб-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Паулик Кирилл Владимирович | АСОиУб-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Дан файл С:|DataSprint|InPutDataFileTask7V13.txt, в котором    *");
            Console.WriteLine("* есть набор символьных данных. Удалить все строчные латинские буквы из   *");
            Console.WriteLine("* файла.                                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V13.txt";
            string pathSaveFile = @"C:\Users\User\source\repos\Tyuiu.PaulikKV.Sprint5\Tyuiu.PaulikKV.Sprint5.Task7.V13\bin\Debug\OutPutDataFileTask7V13.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.LoadDataAndSave(path);
            Console.WriteLine(" Строка без строчных букв = " + res);

            Console.ReadKey();
        }
    }
}
