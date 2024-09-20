using quoridor_v2.GameAI;
using System.Diagnostics;
using System.Numerics;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace quoridor_v2
{
    public partial class Main : Form
    {
        public Game game;
        public AI ai;
        private MoveController moveController;
        private List<Point> previousPlayerPossibleMoves;
        private List<Point> currentPlayerPossibleMoves;
        public double aiTime;
        public double aiActions;
        public Main()
        {
            InitializeComponent();
            InitializeBoard();
            previousPlayerPossibleMoves = new List<Point>();
            currentPlayerPossibleMoves = new List<Point>();
        }

        public void DrawGame()
        {
            ClearBoard();

            moveController = new MoveController(game);
            currentPlayerPossibleMoves = moveController.AllPossibleDirections;
            PreviewAvailibleMoves();

            DrawPlayers();
            Board.Refresh();
            PlayerTurnChange();
        }

        private void StartWindow()
        {
            Start start = new Start();
            start.ShowDialog();

            if (game == null)
            {
                this.Close();
            }
        }
        private void InitializeBoard()
        {
            for (int i = 0; i < Board.RowCount; i++)
            {
                for (int j = 0; j < Board.ColumnCount; j++)
                {
                    Control cell = Board.GetControlFromPosition(i, j);
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        cell.BackColor = Color.Peru;
                        cell.BackgroundImage = null;
                        cell.Click += Cell_Click;
                        cell.Refresh();
                    }

                    if (((i % 2 != 0 && j % 2 == 0) && j != Board.ColumnCount - 1) ||
                        ((i % 2 == 0 && j % 2 != 0) && i != Board.RowCount - 1))
                    {
                        cell.BackColor = Color.SaddleBrown;
                        cell.MouseEnter += wall_MouseEnter;
                        cell.MouseLeave += wall_MouseLeave;
                        cell.Click += wall_placing;
                    }

                    if (i % 2 != 0 && j % 2 != 0)
                    {
                        cell.BackColor = Color.SaddleBrown;
                    }
                }
            }
            //Board.Refresh();
        }

        private void ClearBoard()
        {
            for (int i = 0; i < Board.RowCount; i++)
            {
                for (int j = 0; j < Board.ColumnCount; j++)
                {
                    Control cell = Board.GetControlFromPosition(i, j);
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        cell.BackColor = Color.Peru;
                        cell.BackgroundImage = null;
                    }
                    else
                    {
                        cell.BackColor = Color.SaddleBrown;
                    }

                    if (((i % 2 != 0 && j % 2 == 0) && j != Board.ColumnCount - 1) ||
                        ((i % 2 == 0 && j % 2 != 0) && i != Board.RowCount - 1))
                    {
                        cell.BackColor = Color.SaddleBrown;
                    }

                    if (i % 2 != 0 && j % 2 != 0)
                    {
                        cell.BackColor = Color.SaddleBrown;
                    }
                }
            }
        }

        private void wall_placing(object? sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            TableLayoutPanelCellPosition pos = Board.GetCellPosition(pictureBox);

            if (!(game.IsGameWithAI && game.currentPlayerId != 0))
            {
                try
                {
                    moveController = new MoveController(game);
                    previousPlayerPossibleMoves = moveController.AllPossibleDirections;

                    Point wall_start;
                    Point wall_end;

                    if (IsWallHorizontal(pictureBox.Size))
                    {
                        wall_start = new Point(pos.Column, pos.Row);
                        wall_end = new Point(pos.Column + 2, pos.Row);
                    }
                    else
                    {
                        wall_start = new Point(pos.Column, pos.Row);
                        wall_end = new Point(pos.Column, pos.Row + 2);
                    }
                    game.PlaceWall(wall_start, wall_end);
                    DrawWall(new Point(pos.Column, pos.Row), Color.Orange);

                    moveController = new MoveController(game);
                    currentPlayerPossibleMoves = moveController.AllPossibleDirections;

                    PlayerTurnChange();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void wall_MouseLeave(object? sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            TableLayoutPanelCellPosition pos = Board.GetCellPosition(pictureBox);
            WallController wallController = new WallController(game);

            if (!(game.IsGameWithAI && game.currentPlayerId != 0))
            {
                if (!wallController.IsWallInterceptWithOtherWall(new Point(pos.Column, pos.Row)))
                {
                    DrawWall(new Point(pos.Column, pos.Row), Color.SaddleBrown);
                }
            }
        }

        private void wall_MouseEnter(object? sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            TableLayoutPanelCellPosition pos = Board.GetCellPosition(pictureBox);
            WallController wallController = new WallController(game);

            if (!(game.IsGameWithAI && game.currentPlayerId != 0))
            {
                if (!wallController.IsWallInterceptWithOtherWall(new Point(pos.Column, pos.Row)))
                {
                    DrawWall(new Point(pos.Column, pos.Row), Color.FromArgb(120, Color.Orange));
                }
            }

        }

        private void DrawPlayers()
        {
            Point player1pos = game.players[0].position;
            Point player2pos = game.players[1].position;

            Control player1Cell = Board.GetControlFromPosition(player1pos.X, player1pos.Y);
            Control player2Cell = Board.GetControlFromPosition(player2pos.X, player2pos.Y);

            player1Cell.BackgroundImage = Properties.Resources.avatar_red;
            player1Cell.BackgroundImageLayout = ImageLayout.Center;

            player2Cell.BackgroundImage = Properties.Resources.avatar_blue;
            player2Cell.BackgroundImageLayout = ImageLayout.Center;
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            if (!(game.IsGameWithAI && game.currentPlayerId != 0))
            {
                if (sender is PictureBox clickedPcBox)
                {
                    TableLayoutPanelCellPosition newPos = Board.GetPositionFromControl(clickedPcBox);
                    try
                    {
                        moveController = new MoveController(game);
                        previousPlayerPossibleMoves = moveController.AllPossibleDirections;

                        Point currPos = game.players[game.currentPlayerId].position;
                        game.Move(new Point(newPos.Column, newPos.Row));

                        DrawMove(currPos, new Point(newPos.Column, newPos.Row));

                        moveController = new MoveController(game);
                        currentPlayerPossibleMoves = moveController.AllPossibleDirections;
                        PlayerTurnChange();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        public void DrawMove(Point currentPos, Point newPos)
        {
            PictureBox newBox = (PictureBox)Board.GetControlFromPosition(newPos.X, newPos.Y);
            Control currentBox = Board.GetControlFromPosition(currentPos.X, currentPos.Y);

            currentBox.BackgroundImage = null;
            currentBox.Refresh();

            if (game.currentPlayerId == 0)
            {
                newBox.BackgroundImage = Properties.Resources.avatar_blue;
            }
            else
            {
                newBox.BackgroundImage = Properties.Resources.avatar_red;
            }
            newBox.BackgroundImageLayout = ImageLayout.Center;
            newBox.Refresh();

            Board.Refresh();
        }



        public void DrawWall(Point position, Color color)
        {
            Control control = Board.GetControlFromPosition(position.X, position.Y);
            if (position.Y % 2 != 0)
            {
                for (int i = position.X; i < position.X + 3; i++)
                {
                    Control PartOfWall = Board.GetControlFromPosition(i, position.Y);
                    PartOfWall.BackColor = color;

                    if (i == position.X)
                    {
                        PartOfWall.Margin = new Padding(4, 4, 0, 4);
                    }
                    else if (i == position.X + 1)
                    {
                        PartOfWall.Margin = new Padding(0, 4, 0, 4);
                    }
                    else if (i == position.X + 2)
                    {
                        PartOfWall.Margin = new Padding(0, 4, 4, 4);
                    }
                }
            }
            else
            {
                for (int i = position.Y; i < position.Y + 3; i++)
                {
                    Control PartOfWall = Board.GetControlFromPosition(position.X, i);
                    PartOfWall.BackColor = color;
                    if (i == position.Y)
                    {
                        PartOfWall.Margin = new Padding(4, 4, 4, 0);
                    }
                    else if (i == position.Y + 1)
                    {
                        PartOfWall.Margin = new Padding(4, 0, 4, 0);
                    }
                    else if (i == position.Y + 2)
                    {
                        PartOfWall.Margin = new Padding(4, 0, 4, 4);
                    }
                }
            }
        }



        private bool IsWallHorizontal(Size size)
        {
            return size.Width > size.Height;
        }

        private bool IsWallVertical(Size size)
        {
            return size.Width < size.Height;
        }

        private void PreviewAvailibleMoves()
        {
            foreach (Point point in currentPlayerPossibleMoves)
            {
                Control control = Board.GetControlFromPosition(point.X, point.Y);
                control.BackColor = Color.RosyBrown;
            }
        }

        private void RemovePreviewAvailibleMoves()
        {
            foreach (Point point in previousPlayerPossibleMoves)
            {
                Control control = Board.GetControlFromPosition(point.X, point.Y);
                control.BackColor = Color.Peru;
            }
        }

        private void GameOverHandler()
        {
            if (game.IsGameOver().Item1)
            {
                string winner = (game.IsGameOver().Item2 == 0) ? "Red player" : "Blue player";
                winner = (game.IsGameWithAI && game.IsGameOver().Item2 == 0) ? "You" : "AI";
                var result = MessageBox.Show($"Game over! {winner} won.\nPlay again?",
                    "Game over", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    game = new Game(game.IsGameWithAI);
                    DrawGame();
                }
            }
        }
        private void PlayerTurnChange()
        {
            GameOverHandler();

            RemovePreviewAvailibleMoves();
            PlayerTurnLabel.Text = "Player turn";
            CurrentPlayerPic.BackgroundImage = (game.currentPlayerId == 0) ? Properties.Resources.avatar_red : Properties.Resources.avatar_blue;
            CurrentPlayerPic.Refresh();
            string text = "Walls left: " + game.players[game.currentPlayerId].wallCounter;
            WallsCountLabel.Text = text;
            WallsCountLabel.Refresh();

            Board.Refresh();
            if (game.IsGameWithAI)
            {
                if (game.currentPlayerId == 0)
                {
                    PlayerTurnLabel.Text = "Your turn";
                }
                else
                {
                    PlayerTurnLabel.Text = "AI turn";
                    //Stopwatch stopwatch = new Stopwatch();

                    //stopwatch.Start();
                    ai.MakeAction(game);

                    //stopwatch.Stop();

                    //TimeSpan elapsedTime = stopwatch.Elapsed;
                    //aiTime += elapsedTime.TotalSeconds;
                    //aiActions++;
                    //Console.WriteLine($"AI action time: {elapsedTime.TotalSeconds}");
                    //Console.WriteLine($"AI mean time: {aiTime/aiActions}");

                    PlayerTurnChange();
                }
            }

            if (!(game.IsGameWithAI))
            {
                PreviewAvailibleMoves();
            }
            else if(game.IsGameWithAI && game.currentPlayerId == 0)
            {
                moveController = new MoveController(game);
                currentPlayerPossibleMoves = moveController.AllPossibleDirections;
                PreviewAvailibleMoves();
            }

        }

        private void Board_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox219_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            StartWindow();

        }

        private void PlayerTurnLabel_Click(object sender, EventArgs e)
        {

        }

        private void NewGameItem_Click(object sender, EventArgs e)
        {
            StartWindow();
        }

        private void Main_Load_1(object sender, EventArgs e)
        {

        }
    }
}
