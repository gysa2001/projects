using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quoridor_v2.GameAI
{
    public class Heuristic
    {
        public List<double> weights { get; set; }
        private double[] features;
        public Heuristic()
        {
            weights = [ 0.5, -0.5, 0.9, -0.4, 0.3, -0.2];
        }
        private int ManhattanDistanceToGoal(Point playerPosition, int goal)
        {
            return Math.Abs((playerPosition.Y/2 + 1) - (goal/2+1));
        }

        public double Evaluate(Game game)
        {
            //Console.WriteLine($"Evaluation of '{game.players[1].position.X};{game.players[1].position.Y}':");
            Pathfinding pathfinding = new Pathfinding(game);

            int opponentId = (game.currentPlayerId == 0) ? 1 : 0;
            int pathToGoal = pathfinding.ShortestPathLengthToGoal(game.currentPlayerId);
            int oppoPathToGoal = pathfinding.ShortestPathLengthToGoal(opponentId);
            MarkovChain markovChain = new MarkovChain(game);

            double currMarkovChainValue = markovChain.EvaluateBoardState(game.currentPlayerId);
            double oppoMarkovChainValue = markovChain.EvaluateBoardState(opponentId);

            features = new double[6];
            features[0] = (double)(9 - ManhattanDistanceToGoal(game.players[game.currentPlayerId].position, game.players[game.currentPlayerId].goal)) / 9;
            //Console.WriteLine($"features[0]: {features[0]}");
            features[1] = (double)(9 - ManhattanDistanceToGoal(game.players[opponentId].position, game.players[opponentId].goal)) / 9;
            //Console.WriteLine($"features[1]: {features[1]}");
            features[2] = (double)(81 - pathToGoal) / 81;
            //Console.WriteLine($"features[3]: {features[3]}");
            features[3] = (double)(81 - oppoPathToGoal) / 81;
            //Console.WriteLine($"features[4]: {features[4]}");
            features[4] = currMarkovChainValue;
            //Console.WriteLine($"features[5]: {features[5]}");
            features[5] = oppoMarkovChainValue;
            //Console.WriteLine($"features[6]: {features[6]}");

            double evaluation = 0.0;
            for (int i = 0; i < features.Length; i++)
            {
                evaluation += weights[i] * features[i];
            }
            //Console.WriteLine($"Total evaluation: {evaluation}\n\n");

            return evaluation;
        }
    }
}
