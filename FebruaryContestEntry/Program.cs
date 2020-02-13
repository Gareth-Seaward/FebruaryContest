using System;

namespace FebruaryContestEntry
{
	class Program
	{
		const char block = '▓';

		static void Main(string[] args)
		{
			ConsoleRectangle.Draw(30, 15, block.ToString());

			Console.ResetColor();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Yay, a colorful shape!");
			Console.ReadLine();
		}
	}
}
