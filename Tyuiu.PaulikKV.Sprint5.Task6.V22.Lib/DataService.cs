using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PaulikKV.Sprint5.Task6.V22.Lib
{
    public class DataService : ISprint5Task6V22
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string str = line.Replace(" ","");
                    for (int i = 0; i < str.Length-1; i++)
                    {
                        if ((str[i] == 'м' ) && (str[i+1] == 'м'))
                        {
                            count ++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
