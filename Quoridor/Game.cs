using quoridor_v2.GameAI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace quoridor_v2
{
    public class Game : ICloneable
    {
        public List<Player> players;
        public int currentPlayerId;
        public Board board;
        public List<Wall> walls;
        public bool IsGameWithAI { get; private set; }
        public object LastAction { get; set; }

        public Game(bool is_game_with_ai)
        {
            IsGameWithAI = is_game_with_ai;
            board = new Board();
            walls = new List<Wall>();

            AddPlayers();

            currentPlayerId = 0;
        }

        private void AddPlayers()
        {
            players =
            [
                new Player(new Point(board.width / 2, board.height - 1), 0),
                new Player(new Point(board.width / 2, 0),board.height - 1),
            ];

            board.tiles[board.width / 2, board.height - 1] = TileState.player;
            board.tiles[board.width / 2, 0] = TileState.player;
        }

        public void Move(Point point)
        {
            MoveController moveValidator = new MoveController(this); 
            moveValidator.ValidateMove(point);

            
            Point currentPosition = players[currentPlayerId].position;

            players[currentPlayerId].position = point;

            board.tiles[currentPosition.X, currentPosition.Y] = TileState.empty;
            board.tiles[point.X, point.Y] = TileState.player;

            LastAction = point;

            currentPlayerId = (currentPlayerId == 0) ? 1 : 0;//change current player
        }

        public void PlaceWall(Point start, Point end)
        {
            WallController wallValidator = new WallController(this);

            if (start.Y % 2 != 0)//If wall is horizontal
            {
                wallValidator.ValidateWall(start, end);
                for (int i = start.X; i <= end.X; i++)
                {
                    board.tiles[i, start.Y] = TileState.wall;
                }
            }
            else
            {
                wallValidator.ValidateWall(start, end);
                for (int i = start.Y; i <= end.Y; i++)
                {
                    board.tiles[start.X, i] = TileState.wall;
                }
            }

            walls.Add(new Wall(start, end));
            players[currentPlayerId].wallCounter--;

            LastAction = new Wall(start, end);

            currentPlayerId = (currentPlayerId == 0) ? 1 : 0;//change current player
        }

        public object Clone()
        {
            Game clone = new Game(IsGameWithAI);

            clone.players[0] = (Player)players[0].Clone();
            clone.players[1] = (Player)players[1].Clone();
            clone.currentPlayerId = currentPlayerId;
            clone.board = (Board)board.Clone();
            clone.board.tiles[players[0].position.X, players[0].position.Y] = TileState.player;
            clone.board.tiles[players[1].position.X, players[1].position.Y] = TileState.player;

            for(int i = 0; i < walls.Count; i++)
            {
                clone.walls.Add(walls[i]);
                if (walls[i].start.Y % 2 != 0)//If wall is horizontal
                {
                    for (int j = walls[i].start.X; j <= walls[i].end.X; j++)
                    {
                        clone.board.tiles[j, walls[i].start.Y] = TileState.wall;
                    }
                }
                else
                {
                    for (int j = walls[i].start.Y; j <= walls[i].end.Y; j++)
                    {
                        clone.board.tiles[walls[i].start.X, j] = TileState.wall;
                    }
                }
            }

            /*if(LastAction is Point)
            {
                Point point = (Point)LastAction;
                clone.LastAction = new Point(point.X,point.Y);
            }
            else
            {
                Wall wall = (Wall)LastAction;
                Wall cloneWall = new Wall(new Point(wall.start.X,wall.start.Y),
                    new Point(wall.end.X, wall.end.Y));
                clone.LastAction = cloneWall;
            }*/


            return clone;
        }

        public (bool,int) IsGameOver()
        {
            if(players[0].position.Y == players[0].goal)
            {
                return (true, 0);
            }

            if(players[1].position.Y == players[1].goal)
            {
                return (true, 1);
            }
            return (false,-1);
        }

        

        public void Ramdomize(AI ai)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                while (!IsGameOver().Item1)
                {
                    ai.MakeAction(this);
                    List<object> actions = ai.GetPossibleActions(this);

                    int index = random.Next(actions.Count);
                    object action = actions[index];

                    if (action is Point)
                    {
                        //Point currPos = game.players[game.currentPlayerId].position;
                        Point move = (Point)action;
                        this.Move(move);
                        //Program.main.DrawMove(currPos,move);
                        //Console.WriteLine($"Random: Chosen a move [{move.X};{move.Y}]\n\n\n");
                    }
                    else
                    {
                        Wall wall = (Wall)action;
                        this.PlaceWall(wall.start, wall.end);
                        //Program.main.DrawWall(wall.start, Color.Orange);
                        //Console.WriteLine($"Random: Chosen a wall [ [{wall.start.X};{wall.start.Y}], [{wall.end.X};{wall.end.Y}] ]\n\n\n");
                    }
                }

                int winnerId = (currentPlayerId == 0) ? 1 : 0;
                Console.WriteLine($"\n\nWinner is {winnerId + 1}\n");
            }
        }
    }
}
