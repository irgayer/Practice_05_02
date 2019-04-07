using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_05_02
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 10;
            const int MAX_VALUE = 100;
            Random random = new Random();

            ArrayList array = new ArrayList();
            int sum = 0;
            double average;

            Console.WriteLine($"ArrayList размером: {SIZE}");
            for(int i = 0; i < SIZE; i++)
            {
                array.Add(random.Next(MAX_VALUE));
                Console.WriteLine(array[i]);
            }

            for(int i = 0; i < array.Count; i++)
            {
               if(Convert.ToInt32(array[i]) % 2 == 1)
               {
                    array.RemoveAt(i);
               } 
            }

            Console.WriteLine("\nБез нечетных элементов:");
            for(int i = 0; i < array.Count; i++)
            {
                sum += Convert.ToInt32(array[i]);
                Console.WriteLine(array[i]);
            }

            average = (double)sum / array.Count;

            Console.WriteLine($"\nСредняя арифметическая = {average}");
            Console.WriteLine("Элементы больше средней арифметической");
            for(int i = 0; i < array.Count; i++)
            {
                if(Convert.ToInt32(array[i]) > average)
                {
                    Console.WriteLine(array[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
