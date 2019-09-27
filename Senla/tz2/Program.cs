using System;

namespace tz2
{
	class Program
	{
		static void Main(string[] args)
		{
			do
			{
				double a, b;
				Console.Write("Введите первое число: ");
				a = Convert.ToDouble(Console.ReadLine());
				if (a != Math.Truncate(a))
				{
					Console.WriteLine("Ошибка. Нецелое число.");
					break;
				}
				Console.Write("Введите второе число: ");
				b = Convert.ToDouble(Console.ReadLine());
				if (b != Math.Truncate(b))
				{
					Console.WriteLine("Ошибка. Нецелое число.");
					break;
				}
				Console.WriteLine("НОД={0}", Find.nod(a, b));
				Console.WriteLine("НОК={0}", Find.nok(a, b));
			} while (true);
			Console.ReadKey();
		}
	}
	static class Find
	{
		public static double nod(double a, double b)
		{

			if (b < 0)
				b = -b;
			if (a < 0)
				a = -a;
			while (b > 0)
			{
				double temp = b;
				b = a % b;
				a = temp;
			}
			return a;
		}
		public static double nok(double a, double b)
		{
			return Math.Abs(a * b) / nod(a, b);
		}
	}
}
