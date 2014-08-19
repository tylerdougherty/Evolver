using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolver.Base
{
	class App
	{
		static void Main(string[] args)
		{
			World world = new World(20, 20);

			string s;
			do
			{
				Console.Clear();
				PrintWorld(world);

				//Wait
				Console.WriteLine("\nPress enter to step the program, type q to quit.");
				Console.Write("--> ");
				s = Console.ReadLine();
			} while (s != null && !s.Trim().Equals("q"));
			

			
		}

		static void PrintWorld(World w)
		{
			for (int i = 0; i < w.X; i++)
			{
				for (int j = 0; j < w.Y; j++)
					if (w[i, j] == null)
						Console.Write("0");
					else
						Console.Write("-");

				Console.WriteLine();
			}
		}
	}
}
