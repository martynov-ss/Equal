using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace Equal
{
    internal class ReadFile
    { 
        /// <summary>
        /// Чтение данных из файла
        /// </summary>
        /// <param name="filePath">путь к файлу с данными</param>
        /// <returns>числовой массив данных int[]</returns>
        public int[] GetArr(string filePath)
        {
            int[] array;           
            using (StreamReader sr = new StreamReader(filePath))
            {             
                array = sr.ReadToEnd().Split(',').Select(x => int.Parse(x)).ToArray();                
            }                       
            return array;
        }
    }
}
