using System;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			while(true)
			{
				Console.Write("Введите длину стороны равностороннего треугольника: ");
				int length = int.Parse(Console.ReadLine());
				Console.WriteLine();

				for(int i = 1; i <= length / 2 - 1; i++)
				{
					for(int j = 1; j <= i; j++)
					{
						Console.Write("*");
					}
					Console.WriteLine();
				}
				for(int i = length / 2; i >= 1; i--)
				{
					for(int j = i; j >= 1; j--)
					{
						Console.Write("*");
					}
					Console.WriteLine();
				}
			}
		}
	}
}
