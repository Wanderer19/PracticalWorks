using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Files
{
    public class ProblemDirectorySolver
    {
        public void Solve(string inputDirectoryName, string outputDirectoryName)
        {
            var info = new DirectoryInfo(inputDirectoryName);
            
            Directory.CreateDirectory(outputDirectoryName);
            foreach (var file in info.EnumerateFiles())
            {
                //идем по всем файлам из входной папки
                var output = outputDirectoryName + "\\" + file.Name;
                var numbers = GetNumbersFromFile(file).Where(number => number >= 0).ToList();
                using (var writer = new StreamWriter(new FileStream(output, FileMode.OpenOrCreate)))
                {
                    foreach (var number in numbers)
                    {
                        writer.WriteLine(Math.Sqrt(number));
                    }
                }
            }
        }

        private IEnumerable<int> GetNumbersFromFile(FileInfo file)
        {
            var fileFullName = file.DirectoryName + "\\" + file.Name;
            var text = File.ReadAllText(fileFullName);

            //регулярнфм выражением заменяем большую последовательность пробельных символов на 1 пробел
            return Regex.Replace(text, @"\s+", " ")
                        .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries) //разбиваем слова на пробелы и удаляем пустые
                        .Select(int.Parse); //преобразовываем строку в число. Осторожно! если число не корреткное, то будет выброшено исключение. По умолчанию в задаче все числа в файлах корректные.
        } 
    }
}
