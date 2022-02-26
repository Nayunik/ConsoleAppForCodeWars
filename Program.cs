using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForCodeWars
{
    class Program
    {
        /// <summary>
        ///Данный метод сверяет концовку строки 
        /// </summary>
        /// <param name="str">Входная строка, где проверять</param>
        /// <param name="ending">Предполанаемая концовка</param>
        /// <returns>Булевое значение</returns>
        private static bool CheckEnding(string str, string ending)
        {
            // TODO: complete
            int lenStr = str.Length, lenEnding = ending.Length, index = lenStr - 1;
            bool check = true;

            if (lenEnding <= lenStr)
            {
                for (int i = lenEnding - 1; i >= 0; i--)
                {
                    if (ending[i] != str[index])
                    {
                        check = false;
                        break;
                    }
                    index--;
                }
                return check;
            }
            else
            {
                return false;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Это задание с Codewars 27.02.22!");
           
            Console.WriteLine(CheckEnding("afahfjweeerr", "eerr"));
            Console.ReadLine();
        }
    }
}

