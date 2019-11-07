using System;

namespace xd
{
	class Program
	{
		static void Main(string[] args)
		{
			Audio music = new Audio("xd.mp3");

			Console.WriteLine(music.ToString());
			Console.ReadLine();
		}
	}
}
