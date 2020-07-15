using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.SetBufferSize(80, 25);

			Walls walls = new Walls(79, 24);
			walls.Draw();
	
			Point p = new Point(4, 5, '*');
			Snake snake = new Snake(p, 4, Direction.RIGHT);
			snake.Draw();

			FoodCreator foodCreator = new FoodCreator(79, 24, '$');
			Point food = foodCreator.CreateFood();
			food.Draw();

			while (true)
			{
				if (walls.IsHit(snake) || snake.IsHitTail())
				{
					snake.Clear();
					Console.ForegroundColor = ConsoleColor.Red;
					Console.SetCursorPosition(40, 12);
					Console.Write("GAME OVER.");
					break;
				}
				if (snake.Eat(food))
				{
					food = foodCreator.CreateFood();
					food.Draw();
				}
				else
				{
					snake.Move();
				}

				Thread.Sleep(100);
				if (Console.KeyAvailable)
				{
					Console.SetCursorPosition(snake.GetNextPoint().x, snake.GetNextPoint().y);
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
				//walls.Draw();
				Console.SetCursorPosition(1, 1);
				Console.Write($"Счет: {snake.eatedFoodCount}");
			}
			Console.ReadLine();
		}
	}
    
}