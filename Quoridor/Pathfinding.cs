using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace quoridor_v2
{
    internal class Pathfinding
    {
        private Game game;
        private MoveController moveController;
        private bool[,] visited;

        public Pathfinding(Game game)
        {
            this.game = game;
            moveController = new MoveController(game);
            visited = new bool[game.board.width, game.board.height];
        }

        private bool DFS(Point current, int goal)
        {
            visited[current.X, current.Y] = true;

            if (current.Y == goal)
            {
                return true;
            }

            
            foreach (Point dir in moveController.InitiallizeMovesToAllDirections(current))
            {
                Point next = dir;
                
                if (!visited[next.X, next.Y])
                {
                    if (DFS(next,goal))
                    {
                        return true; // Found a path
                    }

                }
               
            }

            return false; // No path found
        }


        public List<Point> GetReachableSquares(int playerId)
        {
            Point pos = game.players[playerId].position;
            int oppoId = (playerId == 0) ? 1 : 0;
            Point oppoPos= game.players[oppoId].position;
            game.board.tiles[oppoPos.X,oppoPos.Y] = TileState.empty;
            moveController = new MoveController(game);
            var reachable = new List<Point>();
            var queue = new Queue<Point>();
            var SquaresVisited = new HashSet<Point>();

            queue.Enqueue(pos);
            SquaresVisited.Add(pos);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                reachable.Add(current);

                foreach (var neighbor in moveController.InitiallizeMovesToAllDirections(current))
                {
                    if (!SquaresVisited.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        SquaresVisited.Add(neighbor);
                    }
                }
            }
            game.board.tiles[oppoPos.X, oppoPos.Y] = TileState.player;

            return reachable;
        }

        public Dictionary<Point, double> Dijkstra(int playerId, Point start)
        {
            Dictionary<Point, double> distances = new Dictionary<Point, double>();
            HashSet<Point> visited = new HashSet<Point>();
            PriorityQueue<Point, double> priorityQueue = new PriorityQueue<Point, double>();
            int oppoId = (playerId == 0) ? 1 : 0;
            Point oppoPos = game.players[oppoId].position;
            game.board.tiles[oppoPos.X, oppoPos.Y] = TileState.empty;

            for (int i = 0; i< 17; i += 2)
            {
                for (int j = 0; j < 17; j += 2)
                {
                    distances[new Point(i,j)] = double.MaxValue;
                }
            }

            distances[start] = 0;
            priorityQueue.Enqueue(start, 0);

            while (priorityQueue.Count > 0)
            {
                Point current = priorityQueue.Dequeue();

                if (visited.Contains(current))
                {
                    continue;
                }

                visited.Add(current);

                foreach (Point neighbor in moveController.InitiallizeMovesToAllDirections(current))
                {
                    if (!visited.Contains(neighbor))
                    {
                        double tentativeDistance = distances[current] + 1;

                        if (tentativeDistance < distances[neighbor])
                        {
                            distances[neighbor] = tentativeDistance;
                            priorityQueue.Enqueue(neighbor, tentativeDistance);
                        }
                    }
                }
            }
            game.board.tiles[oppoPos.X, oppoPos.Y] = TileState.player;

            return distances;
        }
        public bool IsPathForPlayersExist()
        {
            game.board.tiles[game.players[0].position.X, game.players[0].position.Y] = TileState.empty;
            if(!DFS(game.players[0].position, game.players[0].goal))
            {
                return false;
            }
            game.board.tiles[game.players[0].position.X, game.players[0].position.Y] = TileState.player;
            visited = new bool[game.board.width, game.board.height];

            game.board.tiles[game.players[1].position.X, game.players[1].position.Y] = TileState.empty;
            if (!DFS(game.players[1].position, game.players[1].goal))
            {
                return false;
            }
            game.board.tiles[game.players[1].position.X, game.players[1].position.Y] = TileState.player;

            return true;
        }

        private int BFS(Point start, int goal)
        {
            Queue<Point> queue = new Queue<Point>();
            Dictionary<Point, int> distances = new Dictionary<Point, int>();

            distances[start] = 0;
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                Point current = queue.Dequeue();

                if (current.Y == goal)
                {
                    return distances[current];
                }

                foreach (Point dir in moveController.InitiallizeMovesToAllDirections(current))
                {
                    Point next = dir;

                    if (!distances.ContainsKey(next))
                    {
                        distances[next] = distances[current] + 1;
                        queue.Enqueue(next);
                    }
                }
            }

            return -1;
        }

        private int BFS(Point start, Point target)
        {
            Queue<Point> queue = new Queue<Point>();
            Dictionary<Point, int> distances = new Dictionary<Point, int>();

            distances[start] = 0;
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                Point current = queue.Dequeue();

                if (current == target)
                {
                    return distances[current];
                }

                foreach (Point dir in moveController.InitiallizeMovesToAllDirections(current))
                {
                    Point next = dir;

                    if (!distances.ContainsKey(next))
                    {
                        distances[next] = distances[current] + 1;
                        queue.Enqueue(next);
                    }
                }
            }

            return -1;
        }

        public int ShortestPathLengthToGoal(int playerId)
        {
            visited = new bool[game.board.width, game.board.height];

            return BFS(game.players[playerId].position, game.players[playerId].goal);
        }

        public int DistanceToOpponent(Point currPlayerPos,Point opponentPos)
        {
            visited = new bool[game.board.width, game.board.height];
            game.board.tiles[opponentPos.X, opponentPos.Y] = TileState.empty;

            int distance = BFS(currPlayerPos, opponentPos);

            game.board.tiles[opponentPos.X, opponentPos.Y] = TileState.player;

            return distance;
        }
    }
}
