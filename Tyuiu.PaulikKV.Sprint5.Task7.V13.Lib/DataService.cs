using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PaulikKV.Sprint5.Task7.V13.Lib
{
    public class DataService : ISprint5Task7V13
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7V23.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (((line[i] != 'Э')&&(line[i] != 'П') && (line[i] != 'Р') && (line[i] != 'И') && (line[i] != 'В') && (line[i] != 'Е') && (line[i] != 'Т') && (line[i] != 'М') && (line[i] != 'О') && (line[i] != 'Я') && (line[i] != 'А') && (line[i] != 'Ш') && (line[i] != 'Щ')&& (line[i] != 'У') && (line[i] != 'С') && (line[i] != 'К') && (line[i] != 'Ч') && (line[i] != 'Н') && (line[i] != 'Ж') && (line[i] != 'Д') && (line[i] != 'Ц') && (line[i] != 'Л') && (line[i] != 'Ф') && (line[i] != 'Б') && (line[i] != 'Ю')) && ((line[i] != 'Q') && (line[i] != 'W') && (line[i] != 'E') && (line[i] != 'R') && (line[i] != 'T') && (line[i] != 'Y') && (line[i] != 'U') && (line[i] != 'I') && (line[i] != 'O') && (line[i] != 'P') && (line[i] != 'A') && (line[i] != 'S') && (line[i] != 'D') && (line[i] != 'F') && (line[i] != 'G') && (line[i] != 'H') && (line[i] != 'J') && (line[i] != 'K') && (line[i] != 'L') && (line[i] != 'Z') && (line[i] != 'X') && (line[i] != 'C') && (line[i] != 'V') && (line[i] != 'B') && (line[i] != 'N') && (line[i] != 'M')))
                        {
                            strLine += line[i];
                        }
                    }
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;
        }
    }
}
