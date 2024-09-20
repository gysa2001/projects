using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quoridor_v2.GameAI
{
    public class MarkovChain
    {
        private Game game;
        private List<Point> states;
        private List<Point> absorbingStates;
        private List<Point> nonAbsorbingStates;

        public MarkovChain(Game game)
        {
            this.game = game;
            states = new List<Point>();
            absorbingStates = new List<Point>();
            nonAbsorbingStates = new List<Point>();
        }

        private Matrix<double> CreateTransitionMatrix()
        {
            int n = states.Count;
            var transitionMatrix = DenseMatrix.OfArray(new double[n, n]);

            HashSet<Point> absorbingStateSet = new HashSet<Point>(absorbingStates);

            for (int i = 0; i < n; i++)
            {
                if (absorbingStateSet.Contains(states[i]))
                {
                    transitionMatrix[i, i] = 1.0;
                }
                else
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i != j && AreNeighbors(states[i], states[j]) && !IsWallBetweenPoints(states[i], states[j]))
                        {
                            transitionMatrix[i, j] = 1.0 / GetDegree(states[i]);
                        }
                    }
                }
            }

            return transitionMatrix;
        }

        private Matrix<double> ExtractNonAbsorbingSubMatrix(Matrix<double> P)
        {
            int nonAbsorbingCount = nonAbsorbingStates.Count;
            var nonAbsorbingSubMatrix = DenseMatrix.OfArray(new double[nonAbsorbingCount, nonAbsorbingCount]);
            int indexI = 0;

            for (int i = 0; i < P.RowCount; i++)
            {
                if (!absorbingStates.Contains(states[i]))
                {
                    int indexJ = 0;
                    for (int j = 0; j < P.ColumnCount; j++)
                    {
                        if (!absorbingStates.Contains(states[j]))
                        {
                            nonAbsorbingSubMatrix[indexI, indexJ] = P[i, j];
                            indexJ++;
                        }
                    }
                    indexI++;
                }
            }

            return nonAbsorbingSubMatrix;
        }

        private Matrix<double> ExtractAbsorbingSubMatrix(Matrix<double> P)
        {
            int nonAbsorbingCount = nonAbsorbingStates.Count;
            int absorbingCount = absorbingStates.Count;
            var absorbingSubMatrix = DenseMatrix.OfArray(new double[nonAbsorbingCount, absorbingCount]);
            int indexI = 0;

            for (int i = 0; i < P.RowCount; i++)
            {
                if (!absorbingStates.Contains(states[i]))
                {
                    for (int j = 0; j < absorbingCount; j++)
                    {
                        absorbingSubMatrix[indexI, j] = P[i, states.IndexOf(absorbingStates[j])];
                    }
                    indexI++;
                }
            }

            return absorbingSubMatrix;
        }

        private Matrix<double> CalculateFundamentalMatrix(Matrix<double> Q)
        {
            int size = Q.RowCount;
            Matrix<double> I = DenseMatrix.CreateIdentity(size);

            Matrix<double> A = I - Q;
            double epsilon = 1e-10;
            A = A + epsilon * I;

            return A.Inverse();
        }

        public void DefineStates(int playerId)
        {
            Point playerPos = game.players[playerId].position;
            Pathfinding pathfinding = new Pathfinding(game);
            List<Point> reachableSquares = pathfinding.GetReachableSquares(playerId);

            absorbingStates.Clear();
            nonAbsorbingStates.Clear();
            states.Clear();

            foreach (Point square in reachableSquares)
            {
                if (square.Y == game.players[playerId].goal)
                {
                    absorbingStates.Add(square);
                }
                else
                {
                    nonAbsorbingStates.Add(square);
                }
            }

            absorbingStates.AddRange(GetConceptualAbsorbingStates(playerId));

            states.AddRange(nonAbsorbingStates);
            states.AddRange(absorbingStates);
        }

        public List<Point> GetConceptualAbsorbingStates(int playerId)
        {
            List<Point> conceptualAbsorbingStates = new List<Point>();

            if (playerId == 0) 
            {
                for (int x = 0; x < 17; x += 2)
                {
                    conceptualAbsorbingStates.Add(new Point(x, -1)); 
                }
            }
            else if (playerId == 1) 
            {
                for (int x = 0; x < 17; x += 2)
                {
                    conceptualAbsorbingStates.Add(new Point(x, 17)); 
                }
            }

            return conceptualAbsorbingStates;
        }

        private bool IsWallBetweenPoints(Point p1, Point p2)
        {
            if (p1.X == p2.X && game.board.tiles[p1.X, Math.Min(p1.Y, p2.Y) + 1] == TileState.wall)
            {
                return true;
            }
            if (p1.Y == p2.Y && game.board.tiles[Math.Min(p1.X, p2.X) + 1, p1.Y] == TileState.wall)
            {
                return true;
            }

            return false;
        }

        private int GetDegree(Point state)
        {
            int degree = 0;
            foreach (Point neighbor in states)
            {
                if (AreNeighbors(state, neighbor) && !IsWallBetweenPoints(state, neighbor))
                {
                    degree++;
                }
            }
            return degree;
        }

        private bool AreNeighbors(Point p1, Point p2)
        {
            return Math.Abs(p1.X - p2.X) + Math.Abs(p1.Y - p2.Y) == 2;
        }

        public int GetStateIndex(Point position)
        {
            return states.IndexOf(position);
        }

        public double EvaluateBoardState(int playerId)
        {
            DefineStates(playerId);
            //Point playerPos = game.players[playerId].position;
            //Pathfinding pathfinding = new Pathfinding(game);
            //Dictionary<Point, double> shortestPaths = pathfinding.Dijkstra(playerId, playerPos);

            Matrix<double> P = CreateTransitionMatrix();
            //Console.WriteLine($"P:  {P}");
            //PrintMatrixRowSums("P", P);

            Matrix<double> Q = ExtractNonAbsorbingSubMatrix(P);
            //Console.WriteLine($"Q:  {Q.ToMatrixString()}");
            //PrintMatrixRowSums("Q", Q);
            Matrix<double> R = ExtractAbsorbingSubMatrix(P);
            //Console.WriteLine($"R:  {R.ToMatrixString()}");
            //PrintMatrixRowSums("R", R);

            Matrix<double> N = CalculateFundamentalMatrix(Q);
            //Console.WriteLine($"N:  {N.ToMatrixString()}");
            //PrintMatrixRowSums("N", N);

            Vector<double> absorptionProbabilities = CalculateAbsorptionProbabilities(N, R);
            //PrintVector3(absorptionProbabilities);

            int playerIndex = GetStateIndex(game.players[playerId].position);
            double heuristicValue = absorptionProbabilities[playerIndex];

            return heuristicValue;
        }

        private Vector<double> CalculateAbsorptionProbabilities(Matrix<double> N, Matrix<double> R)
        {
            int totalStates = states.Count;
            int nonAbsorbingCount = nonAbsorbingStates.Count;
            var absorptionProbabilities = DenseVector.OfArray(new double[totalStates]);

            var B = N * R;

            for (int i = 0; i < nonAbsorbingCount; i++)
            {
                absorptionProbabilities[states.IndexOf(nonAbsorbingStates[i])] = B.Row(i).Sum();
            }

            foreach (var absState in absorbingStates)
            {
                absorptionProbabilities[states.IndexOf(absState)] = 1.0;
            }
            var normalizedProbabilities = NormalizeProbabilities(absorptionProbabilities);

            return normalizedProbabilities;
        }

        private Vector<double> NormalizeProbabilities(Vector<double> probabilities)
        {
            double maxProbability = probabilities.Maximum();
            double minProbability = probabilities.Minimum();
            double range = maxProbability - minProbability;

            var normalized = new DenseVector(probabilities.Count);
            for (int i = 0; i < probabilities.Count; i++)
            {
                if (range != 0)
                {
                    normalized[i] = (probabilities[i] - minProbability) / range;
                }
                else
                {
                    normalized[i] = 0.0;
                }
            }

            return normalized;
        }
    }
}
