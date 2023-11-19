using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PaulikKV.Sprint5.Task1.V26.Lib
{
    public class DataService : ISprint5Task1V28
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string str;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((Math.Cos(x) / (x - 0.7)) - (Math.Sin(x) * 12 * x) + 2), 2);
                if ((x - 0.7) == 0)
                {
                    y = 0;
                }
                str = Convert.ToString(y);
                if (x != stopValue)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
            }
            return path;
        }
    }
}