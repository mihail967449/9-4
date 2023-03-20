using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4 Подсчитать количество четных элементов в одномерном массиве, заполненном с использованием явной инициализации.
            short[] kol = { 2, 9, 5, 90, 12, 56, 76, 17, 81, 22 };
            short che = 0;
            foreach(short num in kol)
            {
                if (num % 2 == 0)
                {
                    che++;
                }
            }
            Console.WriteLine($"Кол-во четных элементов = {che}");
            Console.ReadLine();
        }
    }
}
