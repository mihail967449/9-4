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
            // 2.Известен рост каждого студента 212 группы.Найти средний рост студентов.
            int[] array = { 160, 165, 173, 164, 185 };
            int summ = 0;
            for (int i = 0; i < array.Length; i++)
                summ += array[i];
            int mid = summ / array.Length;
            Console.WriteLine($"средний рост студента 212 группы будет {mid}");
            Console.ReadLine();

        }
    }
}
