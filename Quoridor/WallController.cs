using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quoridor_v2.Exceptions;
using System.Drawing;

namespace quoridor_v2
{
    internal class WallController
    {
        private Game game;
        public WallController(Game game)
        {
            this.game = game;
        }
        
        public bool IsWallInterceptWithOtherWall(Point start, Point end)
        {
            if (start.Y % 2 != 0)//If wall is horizontal
            {
                for (int i = start.X; i <= end.X; i++)
                {
                    if(game.board.tiles[i, start.Y] == TileState.wall) return true;
                }
            }
            else
            {
                for (int i = start.Y; i <= end.Y; i++)
                {
                    if(game.board.tiles[start.X, i] == TileState.wall) return true;
                }
            }
            return false;
        }

        public bool IsWallInterceptWithOtherWall(Point start)
        {
            if (start.Y % 2 != 0)//If wall is horizontal
            {
                for (int i = start.X; i <= start.X +2; i++)
                {
                    if (game.board.tiles[i, start.Y] == TileState.wall) return true;
                }
            }
            else
            {
                for (int i = start.Y; i <= start.Y +2; i++)
                {
                    if (game.board.tiles[start.X, i] == TileState.wall) return true;
                }
            }
            return false;
        }

        private bool IsNoLeftWalls()
        {
            return game.players[game.currentPlayerId].wallCounter == 0;
        }

        private bool IsPathForPlayers(Point start, Point end)
        {
            bool pathExist;

            //Simulate wall and check if all players has path to goal
            if (start.Y % 2 != 0)//If wall is horizontal
            {
                for (int i = start.X; i <= end.X; i++)
                {
                    game.board.tiles[i, start.Y] = TileState.wall;
                }
            }
            else
            {
                for (int i = start.Y; i <= end.Y; i++)
                {
                    game.board.tiles[start.X, i] = TileState.wall;
                }
            }

            Pathfinding pathfinding = new Pathfinding(game);
            pathExist = pathfinding.IsPathForPlayersExist();

            if (start.Y % 2 != 0)//If wall is horizontal
            {
                for (int i = start.X; i <= end.X; i++)
                {
                    game.board.tiles[i, start.Y] = TileState.empty;
                }
            }
            else
            {
                for (int i = start.Y; i <= end.Y; i++)
                {
                    game.board.tiles[start.X, i] = TileState.empty;
                }
            }

            return pathExist;
        }

        public bool IsWallValid(Point start, Point end)
        {
            return !IsNoLeftWalls() && !IsWallInterceptWithOtherWall(start, end) && IsPathForPlayers(start, end);
        }

        public void ValidateWall(Point start, Point end)
        {
            if (IsNoLeftWalls())
            {
                throw new PlayerUsedWallsException();
            }

            if(IsWallInterceptWithOtherWall(start,end))
            {
                throw new WallInterceptsWithOtherWallException();
            }

            if(!IsPathForPlayers(start,end))
            {
                throw new NoPathForPlayerException();
            }
        }
    }
}
