using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolver.Base
{
	class World
	{
		//private GroundTile.TerrainType[,] terrain;
		private WorldObject[,] grid;
		
		//Sizes
		private int x, y;
		public int X { get { return x; }}
		public int Y { get { return y; }}

		//WorldObject indexer
		public WorldObject this[int x, int y]
		{
			get { return grid[x, y]; }
		}

		public World(int xSize, int ySize)
		{
			//terrain = new GroundTile.TerrainType[xSize, ySize];
			//foreach ()

			x = xSize;
			y = ySize;

			grid = new WorldObject[x, y];

			Random rand = new Random();
			for (int q = 0; q < x; q++)
				for (int r = 0; r < y; r++)
					if (rand.Next(100) < 30)
						grid[q, r] = new WorldObject();
		}
	}
}
