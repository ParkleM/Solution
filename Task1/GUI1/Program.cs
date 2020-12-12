using Implementation1;
using System;

namespace GUI1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            if (rows <= 0) return;

            Console.WriteLine("\nВведите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            if (columns <= 0) return;

            int[,] array = new int[rows, columns];
            Console.WriteLine("\nВведите массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine($"\nМассив содержит {ArrayUtils.GetStringCount(array)} строк(у/и)," +
                "содержащих арифметическую прогрессию");

            Console.WriteLine("\nНажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}
