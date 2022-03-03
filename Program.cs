using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberRepresentations
{
    class Program
    {
        static void Main(string[] args)
        {
            // получим строку из цифр
            string s = Console.ReadLine();
            // разделяем
            string[] words = s.Split(' ');

            string num = "";

            //проверка значений массива
            for (int i = 0; i < words.Length; i++)
            {
                // игнорируем если не начинается с цифра
                if (!Char.IsDigit(words[i][0]))
                    continue;
                // для 10
                if (words[i] == "10")
                {
                    words[i] =
                        words[i].Remove(0, 2);
                    words[i] =
                      words[i].Insert(0, "ten");
                    continue;
                }
                // преобразование если от 1 до 9
                switch (words[i])
                {
                    case "1": num += "one"; break;
                    case "2": num += "two"; break;
                    case "3":
                        num += "three";
                        break;
                    case "4": num += "four"; break;
                    case "5": num += "five"; break;
                    case "6": num += "six"; break;
                    case "7": num += "seven"; break;
                    case "8": num += "eight"; break;
                    case "9": num += "nine"; break;
                    default: continue;
                }
                words[i] =
                    words[i].Remove(0, 1);
                words[i] =
                    words[i].Insert(0, num);
                num = num.Remove(0);
            }
            // вывод
            foreach (string x in words)
                Console.Write(x + " ");
        }//main
    }//prog
}//namespace