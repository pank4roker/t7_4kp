using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace pr4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 2(9 вариант)
            //Дана строка, в которой содержится осмысленное текстовое сообщение.
            //Слова сообщения разделяются пробелами и знаками препинания.
            //Вывести слова сообщения в алфавитном порядке.
            /*Write("Введите предложение: ");
            string text = ReadLine();
            string[] words = text.Split();
            Array.Sort(words); // Отсортировать слова в алфавитном порядке.
            StringBuilder result = new StringBuilder();
            foreach (var word in words)
            {
                result.Append(word).Append(' ');
            }
            WriteLine($"Слова в алфавитном порядке: {result}");*/
            //Задание 1(9 вариант)
            // Разработать программу с использованием класса StringBuilder,
            // которая для заданной строки s:удаляет из строки все подстроки, состоящие из цифр;
            Write("Ввести предложение: ");
            StringBuilder sent = new StringBuilder(ReadLine());
            string emp = "";
            foreach (char c in sent.ToString())
            {
                if (!char.IsDigit(c))//Данный метод делает так,что если символ является буквой, то она его записывает в память, а если цафрой то заменяет его на пустоту(emp), т.е char.IsDigit(c) = true, то !char.IsDigit(c) = falce
                {
                    emp += c;
                }
            }
            WriteLine($"Предложение без цифр: {emp}");
            ReadKey();
        }
    }
}
