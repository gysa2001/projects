using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static quoridor_v2.GameAI.AI;

namespace quoridor_v2.GameAI
{
    public class AI
    {
        public int MAX_DEPTH = 2;
        private Game gameCopy;
        public Game previousGameState;

        public AI() { }

        internal class Move
        {
            public Point position { get; set; }

            public Move(Point pos)
            {
                position = pos;
            }
        }

        
        public List<object> FindBestAction()
        {
            double alpha = double.NegativeInfinity;
            double beta = double.PositiveInfinity;
            double bestScore = double.NegativeInfinity;
            List<object> actions = GetPossibleActions(gameCopy);
            Dictionary<object,double> scores = new Dictionary<object,double>();
            List<object> bestActions = new List<object>();
            object bestAction = actions[0];
            actions.Shuffle();
            
            //Console.WriteLine($"Actions count: {actions.Count}");
            foreach (object action in actions)
            {
                Game nextGameState;
                if (action is Point)
                {
                    nextGameState = SimulateMove(gameCopy, (Point)action);
                }
                else
                {
                    Wall wall = (Wall)action;
                    nextGameState = SimulateWallPlace(gameCopy, wall.start, wall.end);
                }

                double score = AlphaBeta(nextGameState, MAX_DEPTH - 1, alpha, beta, false);
                //Console.WriteLine($"Action score: {score}");

                if (score > bestScore)
                {
                    bestScore = score;
                    bestAction = action;
                    bestActions.Clear();
                    bestActions.Add(bestAction);
                }
                else if(score == bestScore)
                {
                    bestActions.Add(bestAction);
                }

                alpha = Math.Max(alpha, bestScore);
                scores.Add(action, score);
            }

            //Console.WriteLine($"\nBest score: {bestScore}");

            return bestActions;
        }

       

        private double AlphaBeta(Game game, int depth, double alpha, double beta, bool maximizingPlayer)
        {
            if (depth == 0 && !game.IsGameOver().Item1)
            {
                return EvaluateGame(game);
            }
            else if (game.IsGameOver().Item1 && game.IsGameOver().Item2==1)
            {
                return EvaluateGame(game) + 1;
            }
            else if (game.IsGameOver().Item1 && game.IsGameOver().Item2 == 0)
            {
                return EvaluateGame(game) - 1;
            }

            if (maximizingPlayer)
            {
                double maxEval = double.NegativeInfinity;
                foreach (object action in GetPossibleActions(game))
                {
                    Game nextGameState;
                    if (action is Point)
                    {
                        nextGameState = SimulateMove(game, (Point)action);
                    }
                    else
                    {
                        Wall wall=(Wall)action;
                        nextGameState = SimulateWallPlace(game,wall.start,wall.end);
                    }

                    double eval = AlphaBeta(nextGameState, depth - 1, alpha, beta, false);
                    maxEval = Math.Max(maxEval, eval);
                    alpha = Math.Max(alpha, eval);
                    if (beta <= alpha)
                    {
                        break;
                    }
                }
                return maxEval;
            }
            else
            {
                Game nextGameState;
                double minEval = double.PositiveInfinity;
                foreach (object action in GetPossibleActions(game))
                {
                    if (action is Point)
                    {
                        nextGameState = SimulateMove(game, (Point)action);
                    }
                    else
                    {
                        Wall wall = (Wall)action;
                        nextGameState = SimulateWallPlace(game, wall.start, wall.end);
                    }

                    double eval = AlphaBeta(nextGameState, depth - 1, alpha, beta, true);
                    minEval = Math.Min(minEval, eval);
                    beta = Math.Min(beta, eval);
                    if (beta <= alpha)
                    {
                        break;
                    }
                }
                return minEval;
            }
        }

        private List<Object> GetPossibleMoves(Game game)
        {
            List<Object> possibleMoves = new List<Object>();

            MoveController moveController = new MoveController(game);
            
            foreach(Object dir in moveController.AllPossibleDirections)
            {
                possibleMoves.Add(dir);
            }

            return possibleMoves;
        }

        public List<Object> GetPossibleWallPlacements(Game game)
        {
            WallController wallController = new WallController(game);
            List<Object> possibleWalls = new List<Object>();
            int opponentId = (game.currentPlayerId == 0) ? 1 : 0;

            //possible horizontal walls
            for (int i = 0; i < game.board.width - 2; i += 2)
            {
                for (int j = 1; j < game.board.height; j += 2)
                {
                    Point start = new Point(i, j);
                    Point end = new Point(i + 2, j);
                    Wall wall = new Wall(start, end);
                    if (wallController.IsWallValid(start, end))
                    {
                        bool IsBlockingCurrPlPath = IsWallOnPlayerPath(game, wall, game.currentPlayerId);
                        bool IsBlockingOpponentPath = IsWallOnPlayerPath(game, wall, opponentId);

                        if (IsBlockingOpponentPath && !IsBlockingCurrPlPath)
                        {
                            possibleWalls.Add(wall);
                        }

                        /*if (IsBlockingCurrPlPath)
                        {
                            start = new Point(i + 1, j - 1);
                            end = new Point(i, j + 1);
                            wall = new Wall(start, end);
                            if (wallController.IsWallValid(start, end))
                            {
                                possibleWalls.Add(wall);
                            }
                        }*/
                    }

                }
            }

            //possible vertical walls
            for (int i = 1; i < game.board.width; i = i + 2)
            {
                for (int j = 0; j < game.board.height - 2; j = j + 2)
                {
                    Point start = new Point(i, j);
                    Point end = new Point(i, j + 2);
                    Wall wall = new Wall(start, end);
                    if (wallController.IsWallValid(start, end))
                    {
                        bool IsBlockingCurrPlPath = IsWallOnPlayerPath(game, wall, game.currentPlayerId);
                        bool IsBlockingOpponentPath = IsWallOnPlayerPath(game, wall, opponentId);
                        if (IsBlockingOpponentPath && !IsBlockingCurrPlPath)
                        {
                            possibleWalls.Add(wall);
                        }

                        /*if (IsBlockingCurrPlPath)
                        {
                            start = new Point(i - 1, j + 1);
                            end = new Point(i + 1, j);
                            wall = new Wall(start, end);
                            if (wallController.IsWallValid(start, end))
                            {
                                possibleWalls.Add(wall);
                            }
                        }*/
                    }
                }
            }

            return possibleWalls;
        }

        public List<object> GetPossibleActions(Game game)
        {
            List<object> PossibleActions = new List<object>();

            List<object> PossibleMoves = GetPossibleMoves(game);
            List<object> PossibleWalls = GetPossibleWallPlacements(game);

            PossibleActions.AddRange(PossibleMoves);
            PossibleActions.AddRange(PossibleWalls);

            return PossibleActions;
        }
        
        private Game SimulateMove(Game game, Point move)
        {
            Game clonedGame = (Game)game.Clone();
            clonedGame.Move(move);
            return clonedGame;
        }

        private Game SimulateWallPlace(Game game, Point start, Point end)
        {
            Game clonedGame = (Game)game.Clone();
            clonedGame.PlaceWall(start, end);
            return clonedGame;
        }

        private double EvaluateGame(Game game)
        {
            return Program.heuristic.Evaluate(game);
        }


        private bool IsWallOnPlayerPath(Game game,Wall wall, int player_id)
        {
            Pathfinding pathfinding = new Pathfinding(game);

            int distanceBeforeWallPlacement = pathfinding.ShortestPathLengthToGoal(player_id);

            SimulateWallPlacementOnBoard(game.board, wall);
            int distanceAfterWallPlacement = pathfinding.ShortestPathLengthToGoal(player_id);
            RemoveWallFromBoard(game.board, wall);

            return distanceAfterWallPlacement > distanceBeforeWallPlacement;
        }

        private void SimulateWallPlacementOnBoard(Board board,Wall wall)
        {
            if (wall.start.Y % 2 != 0)//If wall is horizontal
            {
                for (int i = wall.start.X; i <= wall.end.X; i++)
                {
                    board.tiles[i, wall.start.Y] = TileState.wall;
                }
            }
            else
            {
                for (int i = wall.start.Y; i <= wall.end.Y; i++)
                {
                    board.tiles[wall.start.X, i] = TileState.wall;
                }
            }
        }

        private void RemoveWallFromBoard(Board board, Wall wall)
        {
            if (wall.start.Y % 2 != 0)//If wall is horizontal
            {
                for (int i = wall.start.X; i <= wall.end.X; i++)
                {
                    board.tiles[i, wall.start.Y] = TileState.empty;
                }
            }
            else
            {
                for (int i = wall.start.Y; i <= wall.end.Y; i++)
                {
                    board.tiles[wall.start.X, i] = TileState.empty;
                }
            }
        }

        public object MakeAction(Game game)
        {
            gameCopy = (Game)game.Clone();

            //Dictionary<object,double> actions = FindBestAction();
            //actions = actions.OrderByDescending(a => a.Value).ToDictionary();
            //List<object> actionsList = actions.OrderByDescending(a => a.Value).Select(a => a.Key).ToList();
            List<object> bestActions = FindBestAction();
            Random random = new Random();
            object action;

            if (bestActions.Count > 0)
            {
                int moveNum = random.Next(bestActions.Count);
                action = bestActions[moveNum];
            }
            else
            {
                action = bestActions[0];
            }

            if(action is Point)
            {
                Point currPos = game.players[game.currentPlayerId].position;
                Point move = (Point)action;
                game.Move(move);
                Program.main.DrawMove(currPos,move);
                //Console.WriteLine($"Chosen a move [{move.X};{move.Y}]\n\n\n");
            }
            else
            {
                Wall wall = (Wall)action;
                game.PlaceWall(wall.start, wall.end);
                Program.main.DrawWall(wall.start, Color.Orange);
                //Console.WriteLine($"Chosen a wall [ [{wall.start.X};{wall.start.Y}], [{wall.end.X};{wall.end.Y}] ]\n\n\n");
            }
            return action;
        }

        
        

    }
}
