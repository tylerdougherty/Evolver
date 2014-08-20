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
		public int X { get; private set; }
		public int Y { get; private set; }

		//WorldObject indexer
		public WorldObject this[int x, int y]
		{
			get { return grid[x, y]; }
		}

		public World(int xSize, int ySize)
		{
			//terrain = new GroundTile.TerrainType[xSize, ySize];
			//foreach ()

			X = xSize;
			Y = ySize;

			grid = new WorldObject[X, Y];

			Random rand = new Random();
			for (int q = 0; q < X; q++)
				for (int r = 0; r < Y; r++)
					if (rand.Next(100) < 30)
						grid[q, r] = new WorldObject();
		}
	}
}
