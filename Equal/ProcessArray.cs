using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Equal
{
    /// <summary>
    /// Обработка данных
    /// </summary>
    internal class ProcessArray
    {  
        public ulong equalSum { get; set; } 
        /// <summary>
        /// Получение суммы индексов
        /// </summary>
        /// <param name="filePath">путь к файлу с данными</param>
        internal void GetSum(string filePath)
        {
            ReadFile rf = new ReadFile();
            int[] array = rf.GetArr(filePath);                
            int arrLenght = array.Length;

            #region подсчёт сумм слева от индекса
            int[] leftSum = new int[arrLenght];
            for (int i = 1; i < arrLenght; i++)
            {               
                leftSum[i] = array[i - 1] + leftSum[i-1];
            }
            #endregion

            #region подсчёт сумм справа от индекса
            int[] rightSum = new int[arrLenght];
            for (int i = arrLenght - 2;  i >= 0; i--)
            {  
                rightSum[i] = array[i + 1] + rightSum[i + 1];
            }
            #endregion

            #region подсчёт суммы индексов
            for (int i = 0; i < arrLenght; i++)
            {
                if (leftSum[i] == rightSum[i])
                    equalSum += Convert.ToUInt64(i);
            }
            #endregion

        }

    }

}
