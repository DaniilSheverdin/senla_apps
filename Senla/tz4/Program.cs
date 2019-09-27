using System;
using System.Text;

namespace tz4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите текст.");
			StringBuilder sent = new StringBuilder(Console.ReadLine());
			Word_count(sent, How_often_Word());
			Console.ReadKey();
		}
		static void Word_count(StringBuilder a, string b)
		{
			char[] separator = { ' ' };
			int count = 0;
			for (int i = 0; i < a.Length; i++)
			{
				if (char.IsPunctuation(a[i]))
					a.Remove(i, 1);
			}
			string[] wordarr = a.ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
			for (int j = 0; j < wordarr.Length; j++)
			{
				wordarr[j] = wordarr[j].ToLower();
				if (wordarr[j] == b)
				{
					count++;
				}
			}
			Console.WriteLine("Слово ''{0}'' встречается в тексте {1} раз(а).", b, count);
		}
		static string How_often_Word()
		{
			Console.WriteLine("Введите слово.");
			string[] how_oft_word = { Console.ReadLine() };
			for (int j = 0; j < how_oft_word.Length; j++)
			{
				how_oft_word[j] = how_oft_word[j].ToLower();
			}

			return string.Join(", ", how_oft_word);
		}
	}
}
