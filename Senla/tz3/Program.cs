using System;
using System.Text;

namespace tz3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ввведите предложение.");
			StringBuilder sent = new StringBuilder(Console.ReadLine());
			NumberOf(sent);
			Sorting(sent);
			FirstToUp(sent);

			Console.ReadLine();
		}
		public static string[] NumberOf(StringBuilder a)
		{
			int count = 0;
			char[] separator = { ' ' };
			for (int i = 0; i < a.Length; i++)
			{

				if (char.IsPunctuation(a[i]))
					a.Remove(i, 1);
			}
			string[] wordarr = a.ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
			count = wordarr.Length;
			Console.WriteLine("\nКоличество слов в предложении - {0}.", count);
			return wordarr;
		}
		static void FirstToUp(StringBuilder a)
		{
			char[] separator = { ' ' };
			string[] wordarr = a.ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < wordarr.Length; i++)
			{
				if (wordarr[i].Length > 1)
					wordarr[i] = wordarr[i].Substring(0, 1).ToUpper() + wordarr[i].Substring(1, wordarr[i].Length - 1);
				else wordarr[i] = wordarr[i].ToUpper();
			}
			Console.WriteLine("\nПредложение с первой заглавной буквой в каждом слове:");
			foreach (string w in wordarr)
			{
				Console.Write("{0} ", w);
			}
		}
		static void Sorting(StringBuilder a)
		{
			char[] separator = { ' ' };
			string[] wordarr = a.ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
			Array.Sort(wordarr, (x, y) => x.Length.CompareTo(y.Length));
			Console.WriteLine("Предложение отсортировано по длине слов:");
			foreach (string w in wordarr)
			{
				Console.Write("{0} ", w);
			}
		}
	}
}
