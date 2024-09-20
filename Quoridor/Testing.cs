using quoridor_v2.GameAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quoridor_v2
{
    public class Testing
    {
        public static void SimulateGame(AI ai1, AI ai2)
        {
            for (int i = 0; i < 10; i++)
            {
                Game game = new Game(true);
                while (!game.IsGameOver().Item1)
                {
                    ai1.MakeAction(game);
                    ai2.MakeAction(game);
                }

                int winnerId = (game.currentPlayerId == 0) ? 1 : 0;
                Console.WriteLine($"\n\nWinner is {winnerId + 1}\n");
            }
        }

        public static void Ramdomize(AI ai)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Game game = new Game(true);
                while (!game.IsGameOver().Item1)
                {
                    ai.MakeAction(game);
                    List<object> actions = ai.GetPossibleActions(game);

                    int index = random.Next(actions.Count);
                    object action = actions[index];

                    if (action is Point)
                    {
                        //Point currPos = game.players[game.currentPlayerId].position;
                        Point move = (Point)action;
                        game.Move(move);
                        //Program.main.DrawMove(currPos,move);
                        //Console.WriteLine($"Random: Chosen a move [{move.X};{move.Y}]\n\n\n");
                    }
                    else
                    {
                        Wall wall = (Wall)action;
                        game.PlaceWall(wall.start, wall.end);
                        //Program.main.DrawWall(wall.start, Color.Orange);
                        //Console.WriteLine($"Random: Chosen a wall [ [{wall.start.X};{wall.start.Y}], [{wall.end.X};{wall.end.Y}] ]\n\n\n");
                    }
                }

                int winnerId = (game.currentPlayerId == 0) ? 1 : 0;
                Console.WriteLine($"\n\nWinner is {winnerId + 1}\n");
            }
        }
    }
}
