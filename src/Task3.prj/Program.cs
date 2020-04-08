using System;

namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();
			int countOdd = 0; // Счетчик нечетных.

			Console.Write("Введите длину массива: ");
			int lengthArray = int.Parse(Console.ReadLine());
			int[] array = new int[lengthArray];

			for(int i = 0; i < lengthArray; i++)
			{
				array[i] = random.Next(100);
				if(array[i] % 2 != 0)
				{
					countOdd++;
				}
			}

			Console.WriteLine("Рандомный массив: ");
			foreach(int el in array)
			{
				Console.Write(el + " ");
			}

			Console.WriteLine();
			Console.WriteLine("Количество нечетных элементов: " + countOdd);
			Console.WriteLine("Количество нечетных элементов: " + (lengthArray - countOdd));
		}
	}
}
