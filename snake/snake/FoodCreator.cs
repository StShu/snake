using System;

namespace snake
{
	class FoodCreator
	{
		int x;
		int y;
		char sym;

		Random random = new Random();

		public FoodCreator(int x, int y, char sym)
		{
			this.x = x;
			this.y = y;
			this.sym = sym;
		}

		public Point CreateFood()
		{
			int x = random.Next(2, this.x - 2);
			int y = random.Next(2, this.y - 2);
			return new Point(x, y, sym);
		}
	}
}