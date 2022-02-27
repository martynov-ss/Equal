using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Equal
{
    class Program
    {

static void Main(string[] args)
        {
            string fileDir = Directory.GetCurrentDirectory(); //путь к каталогу с файлом            
            string fileName = "data.txt"; // имя файла c данными
            string fullFilePath = Path.Combine(fileDir, fileName); // полный путь к файлу с данными
            DateTime startTime = DateTime.Now; // Время запуска программы

            if (File.Exists(fullFilePath))
            {
                ProcessArray pa = new ProcessArray();
                pa.GetSum(fullFilePath);

                Console.WriteLine($"Сумма индексов = {pa.equalSum}");
                TimeSpan spanTime = DateTime.Now - startTime; // время выполнения программы
                Console.WriteLine($"Программа обработала файл за: {spanTime.TotalSeconds} сек.");
            }
            else
                Console.WriteLine($"Файл \"{fileName}\" не найден в каталоге {fileDir}");
            Console.ReadKey();
        }
    }
}
