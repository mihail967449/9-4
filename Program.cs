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

            //3.Определить количество отрицательных, положительных и нулевых элементов одномерного массива, заполненного случайным образом 15 целыми числами в интервале[-10; 10]. 

            Random random = new Random();
            Console.Write("Размер массива: ");
            int[] array = Enumerable.Repeat(1, int.Parse(Console.ReadLine())).Select(x => random.Next(-10, 2)).ToArray();
            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine($"Количество отрицательных: " + array.Count(x => x < 0));
            Console.WriteLine($"Количество положительных: " + array.Count(x => x > 0));
            Console.ReadLine();

        }
    }
}
