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
        
        private static int ConvertMasToDecimal(int[] mas)
        {
            int result = 0, masLen = mas.Length;

            for(int i = masLen; i >= 0; i-- )
            {
                if(mas[i-1] == 1)
                result += Convert.ToInt32(Math.Pow(2, masLen - i));
            }
            return result;
        }

        private static string ToJadenCase(string phrase)
        {
            string[] mas = phrase.Split(' ');
            string endWord = "";
            phrase = "";
            foreach (string word in mas)
            {
                endWord = word.Substring(1);
                phrase += word[0].ToString().ToUpper() + endWord + " ";
            }
            phrase = phrase.Substring(0, phrase.Length - 1);
            return phrase;
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

