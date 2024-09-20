using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quoridor_v2.Exceptions;

namespace quoridor_v2
{
    internal class MoveController
    {
        public List<Point> AllPossibleDirections;
        private Point MoveDown;
        private Point MoveLeft;
        private Point MoveRight;
        private Point MoveUp;
        private Point playerPos;
        public Point PlayerPos {
            get { return playerPos; } 
            set { playerPos = value; } 
        }

        private Game game;

        public MoveController(Game game)
        {
            this.game = game;
            PlayerPos = this.game.players[game.currentPlayerId].position;

            AllPossibleDirections = InitiallizeMovesToAllDirections(PlayerPos);
        }

        public MoveController() { }

        public List<Point> InitiallizeMovesToAllDirections(Point position)
        {
            List<Point> availableDirections = new List<Point>();

            MoveUp = InitiallizeMove(position,0,-2);
            MoveDown = InitiallizeMove(position, 0, 2);
            MoveLeft = InitiallizeMove(position,-2, 0);
            MoveRight = InitiallizeMove(position,2, 0);

            if(!IsOutOfBoard(MoveUp)) availableDirections.Add(MoveUp);
            if (!IsOutOfBoard(MoveLeft)) availableDirections.Add(MoveLeft);
            if (!IsOutOfBoard(MoveRight)) availableDirections.Add(MoveRight);
            if (!IsOutOfBoard(MoveDown)) availableDirections.Add(MoveDown);

            return availableDirections;
        }

        private Point InitiallizeMove(Point position,int diffX,int diffY)
        {
            Point move = new Point(position.X + diffX, position.Y + diffY);

            if (!IsOutOfBoard(move) && !IsWall(new Point(move.X - diffX/2, move.Y - diffY/2)))
            {
                if (game.board.tiles[move.X, move.Y] == TileState.player)
                {
                    if (!IsOutOfBoard(new Point(move.X + diffX, move.Y + diffY)) && 
                        !IsWall(new Point(move.X + diffX - diffX / 2, move.Y + diffY - diffY/2)))
                    {
                        move = new Point(move.X + diffX, move.Y + diffY);
                    }
                    else
                    {
                        move = new Point(-1, -1);
                    }
                }
            }
            else
            {
                move = new Point(-1, -1);
            }

            return move;
        }
        
        private bool IsOutOfBoard(Point move)
        {
            return (move.X < 0 || move.X >= game.board.width) || (move.Y < 0 || move.Y >= game.board.width);
        }

        private bool IsWall(Point point)
        {
            return !IsOutOfBoard(point) && game.board.tiles[point.X, point.Y] == TileState.wall;
        }
        private bool IsBehindWall(Point point)
        {
            if (point == MoveUp && (IsWall(new Point(MoveUp.X, MoveUp.Y + 1)) ||
                IsWall(new Point(playerPos.X, playerPos.Y - 1))))
            {
                return true;
            }

            if (point == MoveDown && (IsWall(new Point(MoveDown.X, MoveDown.Y - 1)) ||
                IsWall(new Point(playerPos.X, playerPos.Y + 1))))
            {
                return true;
            }

            if (point == MoveLeft && (IsWall(new Point(MoveLeft.X + 1, MoveLeft.Y)) ||
                IsWall(new Point(playerPos.X - 1, playerPos.Y))))
            {
                return true;
            }

            if (point == MoveRight && (IsWall(new Point(MoveRight.X - 1, MoveRight.Y)) ||
                IsWall(new Point(playerPos.X + 1, playerPos.Y))))
            {
                return true;
            }
            return false;
        }

        private bool IsPossibleMove(Point point)
        {
            return AllPossibleDirections.Contains(point);
        }

        private bool IsOtherPlayer(Point point)
        {
            return game.board.tiles[point.X, point.Y] == TileState.player;
        }

        public bool IsMoveValid(Point source,Point destination)
        {
            PlayerPos = source;
            AllPossibleDirections = InitiallizeMovesToAllDirections(source);
            return !IsOutOfBoard(destination) && IsPossibleMove(destination) && !IsBehindWall(destination);
        }

        public void ValidateMove(Point point)
        {
            if (IsOutOfBoard(point))
            {
                throw new MoveBeyondBoardException();
            }

            if (!IsPossibleMove(point))
            {
                throw new NotPossibleMoveException();
            }

            if(IsBehindWall(point))
            {
                throw new WallOnTheWayException();
            }

            if (IsOtherPlayer(point))
            {
                throw new OtherPlayerPositionException();
            }

        }
    }
}
