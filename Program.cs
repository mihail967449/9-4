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
            //1 В массиве записана масса каждого из n предметов, загружаемых в автомбиль. Определить общую массу грyза.
            int[] mas = new int[10];
            Random rnd = new Random();
            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(1, 10);
                sum += mas[i];
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
