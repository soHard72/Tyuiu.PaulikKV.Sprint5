using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PaulikKV.Sprint5.Task1.V26.Lib
{
    public class DataService : ISprint5Task0V28
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double z = Math.Round(x * Math.Sqrt(x + 3),3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
