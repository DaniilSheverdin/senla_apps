using System;

namespace tz5
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите длину последовательности");
			Palindrome(Convert.ToInt32(Console.ReadLine()));
			Console.ReadKey();
		}
		static int Reverse(int i)
		{
			int res = 0;
			while (i != 0)
			{
				int remaind;
				i = Math.DivRem(i, 10, out remaind);
				res = res * 10 + remaind;
			}
			return res;
		}
		static void Palindrome(int a)
		{
			if (a > 100)
			{
				Console.WriteLine("Ошибка. Дожно быть введено число меньше 100.");
			}
			else
			{
				Console.WriteLine("Числа палиндромы:");
				for (int i = 0; i < a; i++)
				{
					if (i == Reverse(i))
						Console.WriteLine(i);
				}
			}
		}
	}
}
