using System;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			while(true)
			{
				Console.Write("Возраст: ");
				int age = int.Parse(Console.ReadLine());

				if(age >= 0 & age <= 99)
				{
					if(age / 10 == 1)
					{
						Console.WriteLine("Мне " + age + " лет");
					}
					else
					{
						if(age % 10 >= 2 & age % 10 <= 4)
						{
							Console.WriteLine("Мне " + age + " года");
						}
						else if(age % 10 == 1)
						{
							Console.WriteLine("Мне " + age + " год");
						}
						else
						{
							Console.WriteLine("Мне " + age + " лет");
						}
					}
				}
				else
				{
					Console.WriteLine("Введите возраст в диапозоне 0-99");
				}

				Console.WriteLine();
			}
		}
	}
}
