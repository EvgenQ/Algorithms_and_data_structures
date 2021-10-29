using System;

namespace HW_1
{
	class Program
	{
		public static ulong Fibbonachi(ulong number)
		{
			if (number == 0) return 0;
			else if (number == 1) return 1;
			else { return Fibbonachi(number - 1) + Fibbonachi(number - 2); }
		}
		public static void SimpleOrNotSimpleNumber(int number) 
		{
			int d = 0;
			int i = 2;
			while (i < number)
			{
				if (number % i == 0)
				{
					d++;
				}
				i++;
			}
			if (d == 0)
			{
				Console.WriteLine($"{number} простое число");
			}
			else
			{
				Console.WriteLine($"{number} Не простое число");
			}
		}
		static void Main(string[] args)
		{
			/*Задание 1
			 Требуется реализовать на C# функцию согласно блок-схеме. Блок-схема описывает алгоритм проверки, простое число или нет.
					Написать консольное приложение.
					Алгоритм реализовать отдельно в функции согласно блок-схеме.
					Написать проверочный код в main функции .
					Код выложить на GitHub

			 */
			{
				int n;
				Console.Write($"Ввдеите любое число: ");
				n = int.Parse(Console.ReadLine());
				SimpleOrNotSimpleNumber(n);
			}
			/*Задание 2
			 * Вычислите асимптотическую сложность функции из примера ниже.
			 */
			{
				static int StrangeSum(int[] inputArray)
				{
					int sum = 0; // O(1)
					for (int i = 0; i < inputArray.Length; i++) // O(N)
					{
						for (int j = 0; j < inputArray.Length; j++) // O(N^2)
						{
							for (int k = 0; k < inputArray.Length; k++) // O(N^3)
							{
								int y = 0; // O(1)

								if (j != 0)// O(N)
								{
									y = k / j; // O(1)
								}

								sum += inputArray[i] + i + k + j + y; // O(1)
							}
						}
					}

					return sum;
				}// ответ O(N^3)
			}
			/*
			 * Задание 3
			 * Требуется реализовать рекурсивную версию и версию без рекурсии (через цикл).
			 */
			{
				Console.WriteLine("Рекурсивный метод");
				Console.Write("Введите проядковый номер числа Фиббоначи: ");
				ulong fibbonachiNumber = ulong.Parse(Console.ReadLine());
				Console.WriteLine(Fibbonachi(fibbonachiNumber));

				Console.WriteLine();

				Console.WriteLine("Метод с циклом");
				Console.Write("Введите проядковый номер числа Фиббоначи: ");
				ulong fibbonachiNumber2 = ulong.Parse(Console.ReadLine());
				ulong f0 = 0;
				ulong f1 = 1;
				while (fibbonachiNumber2 != 1)
				{
					ulong res = f0 + f1;
					f0 = f1;
					f1 = res;
					fibbonachiNumber2--;
					if (fibbonachiNumber2 == 1)
						Console.WriteLine($"{res}");
				}

				Console.WriteLine();
				Console.WriteLine("TESTS");

				TestCase test1 = new()
				{
					X = 20,
					Expected = 6765,
					ExpectedException = null
				};
				TestCase test2 = new()
				{
					X = 20,
					Expected = 21321321,
					ExpectedException = new Exception("Error")
				};
				TestCase test3 = new()
				{
					X = 20,
					Expected = 15454354,
					ExpectedException = new Exception("Error")
				};

				TestCase tests = new()
				{
					X = fibbonachiNumber,
					Expected = Fibbonachi(fibbonachiNumber),
					ExpectedException = null
				};

				Console.WriteLine("1 test");
				tests.TestSum(test1);
				Console.WriteLine("2 test");
				tests.TestSum(test2);
				Console.WriteLine("3 test");
				tests.TestSum(test3);

			}
		}

	}
}
