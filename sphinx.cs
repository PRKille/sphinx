using System;

class Sphinx
{
	static void Main()
	{
		Console.WriteLine("You stumbled upon the lair of the Sphinx!");
		Console.WriteLine("It's glowing yellow eyes fall upon you.");
		Console.WriteLine("Answer my riddle or PERISH!");
		Console.WriteLine("Type 'Hint' for help.");
		TheRiddles();
		}

	static void TheRiddles()
	{
		string[][] riddles = 
		{
		new string[] {"A stone as pale as the moon, break it open and reveal the sun, what am I.", "egg", "gotta crack a few..."},
		new string[] {"What can travel around the world and stay in a corner?", "stamp", "Don't go postal thinking about this."},
		new string[] {"What can you add to a barrel to make it lighter?", "hole", "Drill this in to your head."},
		new string[] {"During which month do people sleep the least?", "february", "Leap for the answer."},
		new string[] {"What walks on four legs in the morning, two at noon, and three in the evening?", "man", "Of Wolf, and..."},
		new string[] {"I'm tall when I'm young and I'm short when I'm old. What am I?", "candle", "The answer will illuminate."},
		new string[] {"What has hands but can not clap?", "clock", "Time is running out."},
		new string[] {"What has a head and a tail, but no body?", "coin", "Don't flip your lid."},
		new string[] {"What has an eye but can not see?", "needle", "To thread ever so gently."},
		new string[] {"What gets wetter the more it dries?", "towel", "Don't forget this."}
		};
				for (int i = 0; i < 3; i++)
		{
			int index = RandomNum();
			Console.WriteLine(riddles[index][0]);
			string answer = Console.ReadLine();
			if (answer.ToLower().Contains("hint"))
			{
				Console.WriteLine(riddles[index][2]);
				string answer2 = Console.ReadLine();
				if (!answer2.ToLower().Contains(riddles[index][1]))
				{
					Console.WriteLine("With a roar the Sphinx swallows you whole!");
					return;
				}
			}
			else if (!answer.ToLower().Contains(riddles[index][1]))
			{
				Console.WriteLine("With a roar the Sphinx swallows you whole!");
				return;
			}
		}
		Console.WriteLine("The Sphinx allows you to pass!");
	}

	static int RandomNum()
	{
		Random rnd = new Random();
		int index = rnd.Next(10);
		return index;
	}
}