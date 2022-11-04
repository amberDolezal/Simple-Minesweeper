using System.IO;

namespace adolezalMinesweeper
{
    public partial class Form1 : Form
    {  
        Cell[,] board = new Cell[10, 10];
        Random random = new Random();
        int numberOfWins = 0;
        int numberOfGames = 0;
        int addedTime = 0;
        float averageTime = 0;
        int elapsedTime = 0;
        int numberOfMines = 0;
        int totalPossibleNumOfMines = 70;

        public Form1()
        {
            InitializeComponent();
            LoadRecords();
            UpdateWinsLabel();  
            UpdateGamesLabel();
            UpdateAverageTimeLabel();
            Fillboard();
            this.Size = new System.Drawing.Size(630, 755);
        }

        //Fills game board with cells and randomly places mines
        public void Fillboard()
        {
            for(int col = 0; col < board.GetLength(0); col++)
            {
                for(int row = 0; row < board.GetLength(1); row++)
                {
                    board[col, row] = new Cell();
                    board[col, row].X = col;
                    board[col, row].Y = row;
                    if(numberOfMines < totalPossibleNumOfMines)
                    { 
                        board[col, row].PanelText = (random.Next(2) % 2 == 0) ? "" : "M"; //Randomly set mines on board
                        numberOfMines++;
                    }
                    else
                    {
                        board[col, row].PanelText = "";
                    }
                    board[col, row].Location = new Point(col * board[col, row].CellSize.Width, row * board[col, row].CellSize.Height + theMenuStrip.Size.Height);
                    board[col, row].CellClick += OnCellClick;
                    this.Controls.Add(board[col, row]);
                }
            }
        }
        /// <summary>
        /// When a cell is clicked checks if its the first click, if player won or lost and then checks surrounding spaces if the game is not over
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e">CellClickEventArgs that pass coordinates of click</param>
        public void OnCellClick(object ?sender, CellClickEventArgs e)
        {
            String targetText = "";
            bool playerWon = false;

            CheckIfFirstClick(e);

            if (!playerWon)
            {
                String spaceClickedText = board[e.X, e.Y].PanelText;

                if (spaceClickedText.Equals(""))
                {
                    CheckRight(e, targetText);
                    CheckLeft(e, targetText);
                    CheckRowAbove(e, targetText);
                    CheckRowBelow(e, targetText);

                    for (int i = 0; i < 8; i++)
                    {
                        targetText = ((char)(i + 49)).ToString();
                        CheckRight(e, targetText);
                        CheckLeft(e, targetText);
                        CheckRowAbove(e, targetText);
                        CheckRowBelow(e, targetText);
                    }
                }
                else if(((int)spaceClickedText[0] > 48 && (int)spaceClickedText[0] < 57))
                {

                    board[e.X, e.Y].PerformClick();

                } 
                else
                {
                    MessageBox.Show("YOU HIT A MINE!");
                    WriteRecords();
                    Application.Restart();
                }
            }
            else
            {
                MessageBox.Show("YOU WIN!");
                numberOfWins++;
                WriteRecords();
                Application.Restart();
            }
        }
        /// <summary>
        /// Checks the board to see if it was the first click, if the first click was a mine it is replaced and then the spaces touching
        /// the mines will be labeled with the corresponding number
        /// Timer will be started if it is the first click
        /// </summary>
        /// <param name="e">CellClickEventArgs that pass coordinates of click</param>
        private void CheckIfFirstClick(CellClickEventArgs e)
        {
            int buttonsNotVisible = 0;

            //Check if this is first click
            for (int col = 0; col < board.GetLength(0); col++)
            {
                for (int row = 0; row < board.GetLength(1); row++)
                {
                    if (board[col, row].buttonVisibility == false)
                    {
                        buttonsNotVisible++;
                    }
                }
            }
            if (buttonsNotVisible == 1)
            {
                numberOfGames++;
                gameTimer.Enabled = true;

                if (board[e.X, e.Y].PanelText.Equals("M"))
                {
                    board[e.X, e.Y].PanelText = "";
                }
                //Label number spaces
                for (int col = 0; col < board.GetLength(0); col++)
                {
                    for (int row = 0; row < board.GetLength(1); row++)
                    {
                        if (board[col, row].PanelText.Equals("M"))
                        {
                            CheckLeftOfMine(col, row);
                            CheckUpAndLeftOfMine(col, row);
                            CheckUpOfMine(col, row);
                            CheckUpAndRightOfMine(col, row);
                            CheckRightOfMine(col, row);
                            CheckDownAndRightOfMine(col, row);
                            CheckDownOfMine(col, row);
                            CheckDownAndLeftOfMine(col, row);
                        }
                    }
                }
            }
        }
        private bool CheckIfPlayerWon(CellClickEventArgs e)
        {
            bool playerWon = false;
            int numberOfMines = 0;

            for (int col = 0; col < board.GetLength(0); col++)
            {
                for (int row = 0; row < board.GetLength(1); row++)
                {
                    if (board[col, row].PanelText.Equals("M"))
                    {
                        numberOfMines++;
                    }
                }
            }
            if (numberOfMines == 0)
            {
                playerWon = true;   
            }
            return playerWon;
        }
        //If space is touching mine then label or update number with corresponding number
        private void CheckDownAndLeftOfMine(int col, int row)
        {
            if (col > 0 && row < board.GetLength(1) - 1)
            {
                //Check one y space down and left 
                if (board[col - 1, row + 1].PanelText.Equals(""))
                {
                    board[col - 1, row + 1].PanelText = "1";
                }
                else if ((int)board[col - 1, row + 1].PanelText[0] > 48 && (int)board[col - 1, row + 1].PanelText[0] < 57)
                {
                    int updatedNum = (int)board[col - 1, row + 1].PanelText[0] + 1;
                    board[col - 1, row + 1].PanelText = ((char)updatedNum).ToString();
                }
            }
        }
        //If space is touching mine then label or update number with corresponding number
        private void CheckDownOfMine(int col, int row)
        {
            if (row < board.GetLength(1) - 1)
            {
                //Check one y space down
                if (board[col, row + 1].PanelText.Equals(""))
                {
                    board[col, row + 1].PanelText = "1";
                }
                else if ((int)board[col, row + 1].PanelText[0] > 48 && (int)board[col, row + 1].PanelText[0] < 57)
                {
                    int updatedNum = (int)board[col, row + 1].PanelText[0] + 1;
                    board[col, row + 1].PanelText = ((char)updatedNum).ToString();
                }
            }
        }
        //If space is touching mine then label or update number with corresponding number
        private void CheckDownAndRightOfMine(int col, int row)
        {
            if (col < board.GetLength(0) - 1 && row < board.GetLength(1) - 1)
            {
                //Check one y space down and right
                if (board[col + 1, row + 1].PanelText.Equals(""))
                {
                    board[col + 1, row + 1].PanelText = "1";
                }
                else if ((int)board[col + 1, row + 1].PanelText[0] > 48 && (int)board[col + 1, row + 1].PanelText[0] < 57)
                {
                    int updatedNum = (int)board[col + 1, row + 1].PanelText[0] + 1;
                    board[col + 1, row + 1].PanelText = ((char)updatedNum).ToString();
                }
            }
        }
        //If space is touching mine then label or update number with corresponding number
        private void CheckRightOfMine(int col, int row)
        {
            if (col < board.GetLength(0) - 1)
            {
                //Check space to right
                if (board[col + 1, row].PanelText.Equals(""))
                {
                    board[col + 1, row].PanelText = "1";
                }
                else if ((int)board[col + 1, row].PanelText[0] > 48 && (int)board[col + 1, row].PanelText[0] < 57)
                {
                    int updatedNum = (int)board[col + 1, row].PanelText[0] + 1;
                    board[col + 1, row].PanelText = ((char)updatedNum).ToString();
                }
            }
        }
        //If space is touching mine then label or update number with corresponding number
        private void CheckUpAndRightOfMine(int col, int row)
        {
            if (col < board.GetLength(0) - 1 && row > 0)
            {
                //Check one y space up and right
                if (board[col + 1, row - 1].PanelText.Equals(""))
                {
                    board[col + 1, row - 1].PanelText = "1";
                }
                else if ((int)board[col + 1, row - 1].PanelText[0] > 48 && (int)board[col + 1, row - 1].PanelText[0] < 57)
                {
                    int updatedNum = (int)board[col + 1, row - 1].PanelText[0] + 1;
                    board[col + 1, row - 1].PanelText = ((char)updatedNum).ToString();
                }
            }
        }
        //if space is touching mine then label or update number with corresponding number
        private void CheckUpOfMine(int col, int row)
        {
            if (row > 0)
            {
                //check one y space up
                if (board[col, row - 1].PanelText.Equals(""))
                {
                    board[col, row - 1].PanelText = "1";
                }
                else if ((int)board[col, row - 1].PanelText[0] > 48 && (int)board[col, row - 1].PanelText[0] < 57)
                {
                    int updatedNum = (int)board[col, row - 1].PanelText[0] + 1;
                    board[col, row - 1].PanelText = ((char)updatedNum).ToString();
                }
            }
        }
        //if space is touching mine then label or update number with corresponding number
        private void CheckUpAndLeftOfMine(int col, int row)
        {
            if (col > 0 && row > 0)
            {
                //check one y space up and left
                if (board[col - 1, row - 1].PanelText.Equals(""))
                {
                    board[col - 1, row - 1].PanelText = "1";
                }
                else if ((int)board[col - 1, row - 1].PanelText[0] > 48 && (int)board[col - 1, row - 1].PanelText[0] < 57)
                {
                    int updatedNum = (int)board[col - 1, row - 1].PanelText[0] + 1;
                    board[col - 1, row - 1].PanelText = ((char)updatedNum).ToString();
                }
            }
        }
        //If space is touching mine then label or update number with corresponding number
        private void CheckLeftOfMine(int col, int row)
        {
            if (col > 0)
            {
                //Check space to left
                if (board[col - 1, row].PanelText.Equals(""))
                {
                    board[col - 1, row].PanelText = "1";
                }
                else if ((int)board[col - 1, row].PanelText[0] > 48 && (int)board[col - 1, row].PanelText[0] < 57)
                {
                    int updatedNum = (char)((int)board[col - 1, row].PanelText[0] + 1);
                    board[col - 1, row].PanelText = ((char)updatedNum).ToString();
                }
            }
        }

        /// <summary>
        /// Check the row below the Cell that was clicked, including diagonals if applicable
        /// </summary>
        /// <param name="e">EventArgs that pass coordinates of click</param>
        /// <param name="targetColor">The label text of the cell that was clicked</param>
        private void CheckRowBelow(CellClickEventArgs e, String targetText)
        {
            CheckLeft(e, targetText);
            //Down check 
            if (e.Y < board.GetLength(1) - 1)
            {
                if (board[e.X, e.Y + 1].PanelText.Equals(targetText))
                {
                    board[e.X, e.Y + 1].PerformClick();
                }
            }
            CheckRight(e, targetText);
        }
        /// <summary>
        /// Check the row above the Cell that was clicked, including diagonals if applicable
        /// </summary>
        /// <param name="e">EventArgs that pass coordinates of click</param>
        /// <param name="targetColor">The label text of the cell that was clicked</param>
        private void CheckRowAbove(CellClickEventArgs e, String targetText)
        {
            //up check 
            CheckLeft(e, targetText);
            if (e.Y > 0)
            {
                if (board[e.X, e.Y - 1].PanelText.Equals(targetText))
                {
                    board[e.X, e.Y - 1].PerformClick();
                }
            }
            CheckRight(e, targetText);
        }
        /// <summary>
        /// Checks the cells to the left
        /// </summary>
        /// <param name="e">EventArgs that pass coordinates of click</param>
        /// <param name="targetText">The label text of the cell that was clicked</param>
        private void CheckLeft(CellClickEventArgs e, String targetText)
        {
            //To the left
            if (e.X > 0)
            {
                if (board[e.X - 1, e.Y].PanelText.Equals(targetText))
                {
                    board[e.X - 1, e.Y].PerformClick();
                }
            }
        }
        /// <summary>
        /// Checks the cells to the right
        /// </summary>
        /// <param name="e">EventArgs that pass coordinates of click</param>
        /// <param name="targetText">The label text of the cell that was clicked</param>
        private void CheckRight(CellClickEventArgs e, String targetText)
        {
            //To the right
            if (e.X < board.GetLength(0) - 1)
            {
                if (board[e.X + 1, e.Y].PanelText.Equals(targetText))
                {
                    board[e.X + 1, e.Y].PerformClick();
                }
            }
        }
        //Reads Records.txt to get number of games played, number of wins, and the total time played for every game
        private void LoadRecords()
        {
            try
            {
                StreamReader reader = new StreamReader("Records.txt");
                if (!reader.EndOfStream)
                {
                    numberOfGames = int.Parse(reader.ReadLine());
                }
                if (!reader.EndOfStream)
                {
                    numberOfWins = int.Parse(reader.ReadLine());
                }
                if (!reader.EndOfStream)
                {
                    addedTime = int.Parse(reader.ReadLine());
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            } 
        }
        //Saves the number of games played, number of wins, and total time played to Records.txt
        private void WriteRecords()
        {
            try
            {
                StreamWriter writer = new StreamWriter("Records.txt");
                writer.WriteLine(numberOfGames.ToString()); 
                writer.WriteLine(numberOfWins.ToString());
                writer.WriteLine(addedTime.ToString()); 
                writer.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Updates wins in menu strip
        private void UpdateWinsLabel()
        {
            wins0ToolStripMenuItem.Text = $"Wins: {numberOfWins}";
        }
        //Updates number of games in menu strip
        private void UpdateGamesLabel()
        {
            games0ToolStripMenuItem.Text = $"Games: {numberOfGames}";
        }
        //Updates the average time to complete a game in menu strip
        private void UpdateAverageTimeLabel()
        {
            if(numberOfGames != 0)
            {
                averageTime = (float)(addedTime / numberOfGames);
            }
            averageTime0ToolStripMenuItem.Text = $"Average Time: {averageTime} sec";
        }
        //Updates timer
        private void gameTimer_Tick(object ?sender, EventArgs e)
        {
            elapsedTime++;
            addedTime = elapsedTime;
            timerLabel.Text = $"Time: {elapsedTime} sec";
        }
        //If restart is selected, Records.txt will be updated and game will be restarted 
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteRecords();
            Application.Restart();
        }
        //If exit is selected, Records.txt will be updated and game will quit 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteRecords(); 
            Application.Exit();

        }
        //If instructions is selected, a message box will appear with the instructions
        private void instructionsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Minesweeper Instructions:\n\nThe goal is to clear out the board of buttons trying to " +
               "avoiding the mines that are randomly placed around the board. There will be numbers on the board " +
               "corresponding to the number of mines that are bordering that particular cell. If you click on a button " +
               "that has no mines bordering it, it clears all adjacent buttons until it reaches cells that have mines " +
               "on their borders. \nThere is no time limit to complete this game.\n\nGood luck! ");
        }
    }
}