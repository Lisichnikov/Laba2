using System;
using System.Linq;

namespace Лаба2
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int max14 = 0;
            int max2 = 0;
            int max7 = 0;
            Random randm = new Random();
            int[] array = new int[1000];
            for (int i = 0; i <= array.Length; i++)
                array[i] = randm.Next(1, 10000);
            for (int i = 0; i <= array.Length; i++)
            {
                if (array[i] % 14 == 0 && array[i] > max14) max14 = array[i];

                if (array[i] % 2 == 0 && array[i] > max2) max2 = array[i];

                if (array[i] % 7 == 0 && array[i] > max7) max7 = array[i];

                if (array[i] > max) max = array[i];
            }
            if (max14 > max7 && max14 > max2 && max14 > max &&
                max2 > max14 && max2 > max7 && max2 > max &&
                max7 > max14 && max7 > max2 && max7 > max &&
                max > max14 && max > max2 && max > max7)
            {
                Console.WriteLine("есть");
            }
            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}
