﻿using System;
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

        private static int GetSum(int a, int b)
        {
            //Good Luck!
            int sum = 0, num;
            if (a == b)
            {
                return a;
            }
            else if (a < b)
            {
                num = a;
                while (num<=b)
                {

                    sum += num;
                    num++;
                }
                return sum;
            }
            else
            {
                num = b;
                while (num <= a)
                {

                    sum += num;
                    num++;
                }
                return sum;
            }
        }
        static void Main(string[] args)
        {
            /*Console.WriteLine("Это 1 задание с Codewars 27.02.22!");
            Console.WriteLine(CheckEnding("afahfjweeerr", "eerr"));
*/
            Console.WriteLine("Это 2 задание с Codewars 27.02.22!");
            Console.WriteLine(GetSum(2, -1));
            Console.WriteLine(GetSum(0, 2));

            Console.ReadLine();
        }
    }
}

