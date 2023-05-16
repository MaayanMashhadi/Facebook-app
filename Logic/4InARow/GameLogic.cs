using System;
using Logic.GameBuilder;

namespace Game4InARowLogic
{
    public class GameLogic
    {
        public const char k_Player1 = '1';
        public const char k_Player2 = '2';
        public const char k_Tie = '3';
        public const char k_Player1Sign = 'X';
        public const char k_Player2Sign = 'O';
        public const string k_QuitGame = "Q";
        public const int k_InvalidMoveUninitialized = -1;
        private readonly GameBuilderProduct r_GameProduct;
        private readonly char r_MaxTurns;
        private char m_TurnNumber = (char)0;
        private bool m_IsQuitPressed;
        private char m_CurrentPlayer;
        private bool m_IsWin;
        private char? m_Winner;
        private readonly int[] r_NumberOfCoinsInACol;
        private readonly Board r_Board;
        public event EventHandler Win;
        public event EventHandler Tie;
        public event EventHandler Quit;

        public char MaxTurns
        {
            get
            {
                return r_MaxTurns;
            }
        }

        public char TurnNumber
        {
            get
            {
                return m_TurnNumber;
            }
        }

        public bool IsQuitPressed
        {
            get
            {
                return m_IsQuitPressed;
            }
            set
            {
                m_IsQuitPressed = value;
            }
        }

        public char CurrentPlayer
        {
            get
            {
                return m_CurrentPlayer;
            }
            set
            {
                m_CurrentPlayer = value;
            }
        }

        public bool IsWin
        {
            get
            {
                return m_IsWin;
            }
            set
            {
                m_IsWin = value;
            }
        }

        public char Winner
        {
            get
            {
                return m_Winner.Value;
            }
            set
            {
                m_Winner = value;
            }
        }

        public GameBuilderProduct GameProduct
        {
            get 
            {
                return r_GameProduct;
            }
        }

          public int NumOfCoinsInCol(int i_Col) 
          {
               return r_NumberOfCoinsInACol[i_Col];
          }

          
          public virtual void OnWin(EventArgs i_EventArgs)
          {
               if (Win != null)
               {
                    Win.Invoke(this, i_EventArgs);
               }
          }

          public virtual void OnTie(EventArgs i_EventArgs)
          {
               if (Tie != null)
               {
                    Tie.Invoke(this, i_EventArgs);
               }
          }

          public virtual void OnQuit(EventArgs i_EventArgs)
          {
               if (Quit != null)
               {
                    Quit.Invoke(this, i_EventArgs);
               }
          }

        public GameLogic(GameBuilderProduct i_GameProduct)
        {
            r_GameProduct = i_GameProduct;
            this.r_MaxTurns = (char)(i_GameProduct.Col * i_GameProduct.Row);
            this.m_CurrentPlayer = (char)0;
            this.r_NumberOfCoinsInACol = new int[i_GameProduct.Col];
            this.r_Board = new Board(i_GameProduct);
        }

          public void GetReadyForANewGame()
          {
               m_CurrentPlayer = k_Player1;
               m_Winner = null;
               m_IsQuitPressed = false;
               m_IsWin = false;
               m_TurnNumber = (char)0;
               Array.Clear(this.r_NumberOfCoinsInACol, 0, this.r_NumberOfCoinsInACol.Length);
               clearBoard();
          }

          private void clearBoard()
          {

            r_Board.ClearBoard();
               //for (int i = 0; i < r_GameProduct.Row; i++)
               //{
               //     for (int j = 0; j < r_GameProduct.Col; j++)
               //     {
               //          r_Board[i, j] = ' ';
               //     }
               //}
          }

          public void UpdateLastWinner()
          {
               if (m_IsWin)
               {
                    m_Winner = m_CurrentPlayer;
                    OnWin(EventArgs.Empty);
               }
               else if (m_IsQuitPressed)
               {
                    m_Winner = (char)((m_CurrentPlayer) % 2 + '1');
                    OnQuit(EventArgs.Empty);
               }
               else if (r_MaxTurns == m_TurnNumber)
               {
                    m_Winner = k_Tie;
                    OnTie(EventArgs.Empty);
               }
          }

          public bool CheckIfTheColIsFull(int i_PlayersChoice)
          {
               return !(r_NumberOfCoinsInACol[i_PlayersChoice - 1] < r_GameProduct.Row);
          }

          public void IncreaseTheNumberOfCoinsInAColumn(int i_PlayersChoice)
          {
               r_NumberOfCoinsInACol[i_PlayersChoice - 1]++;
          }

          public bool IsNumberInColsRange(int i_PlayersMove)
          {
               return (i_PlayersMove > 0) && (i_PlayersMove < (r_GameProduct.Col + 1));
          }

          public void GetMoveFromComputer(out int i_ComputerMoveChoice, int i_Cols)
          {
               bool isTheChoiceGood = false;
               Random random = new Random();

               i_ComputerMoveChoice = 0; // zero because the loop will always have at least one entry.
               while (!isTheChoiceGood)
               {
                    i_ComputerMoveChoice = random.Next(1, (i_Cols + 1));
                    isTheChoiceGood = !CheckIfTheColIsFull(i_ComputerMoveChoice);
               }
          }

          public char ExecuteMove(char i_Player, int i_Row, int i_Col)
          {
               char sign = (i_Player == k_Player1) ? k_Player1Sign : k_Player2Sign;

               r_Board.GetCell(i_Row, i_Col).CharCell = sign;

               return sign;
          }

          private void increaseSeriesIfMatch(int i_Row, int i_Col, char i_Sign,
                                             ref int io_NumOfCoinsInARow, ref bool io_IsDifferentSign)
          {
               if (r_Board.GetCell(i_Row, i_Col).CharCell == i_Sign)
               {
                    io_NumOfCoinsInARow++;
               }
               else
               {
                    io_IsDifferentSign = true;
               }
          }

          public void CheckForAWin(int i_Row, int i_Col, char i_Sign)
          {
               m_IsWin = winCol(i_Row, i_Col, i_Sign) || winRow(i_Row, i_Col, i_Sign)
                                                      || winDiagonal(i_Row, i_Col, i_Sign) || winReversedDiagonal(
                                                           i_Row, i_Col, i_Sign);
               UpdateLastWinner();
          }

          private bool winRow(int i_Row, int i_Col, char i_Sign)
          {
               int chosenColumn = i_Col;
               int numOfCoinsInARow = 0;
               bool isDifferentSign = false;

               for (int i = chosenColumn; (i < r_GameProduct.Col) && (!isDifferentSign); i++)
               {
                    increaseSeriesIfMatch(i_Row, i, i_Sign, ref numOfCoinsInARow, ref isDifferentSign);
               }

               isDifferentSign = false;
               for (int i = chosenColumn - 1; (i >= 0) && (!isDifferentSign); i--)
               {
                    increaseSeriesIfMatch(i_Row, i, i_Sign, ref numOfCoinsInARow, ref isDifferentSign);
               }

               return (numOfCoinsInARow >= 4);
          }

          private bool winDiagonal(int i_Row, int i_Col, char i_Sign)
          {
               int chosenColumn = i_Col;
               int numOfCoinsInARow = 0;
               bool isDifferentSign = false;
               int chosenRow = i_Row;

               for (int i = chosenColumn; (i < r_GameProduct.Col) && (!isDifferentSign) && (i_Row >= 0); i++)
               {
                    increaseSeriesIfMatch(i_Row, i, i_Sign, ref numOfCoinsInARow, ref isDifferentSign);
                    i_Row--;
               }

               i_Row = chosenRow + 1;
               for (int i = chosenColumn - 1; (i >= 0) && (!isDifferentSign) && (i_Row < r_GameProduct.Row); i--)
               {
                    increaseSeriesIfMatch(i_Row, i, i_Sign, ref numOfCoinsInARow, ref isDifferentSign);
                    i_Row++;
               }

               return (numOfCoinsInARow >= 4);
          }

          private bool winReversedDiagonal(int i_Row, int i_Col, char i_Sign)
          {
               int numOfCoinsInARow = 0;
               int chosenColumn = i_Col;
               bool isDifferentSign = false;
               int chosenRow = i_Row;

               for (int i = chosenColumn; (i >= 0) && (!isDifferentSign) && (i_Row >= 0); i--)
               {
                    increaseSeriesIfMatch(i_Row, i, i_Sign, ref numOfCoinsInARow, ref isDifferentSign);
                    i_Row--;
               }

               i_Row = chosenRow + 1;
               for (int i = chosenColumn + 1; (i < r_GameProduct.Col) && (!isDifferentSign) && (i_Row < r_GameProduct.Row); i++)
               {
                    increaseSeriesIfMatch(i_Row, i, i_Sign, ref numOfCoinsInARow, ref isDifferentSign);
                    i_Row++;
               }

               return (numOfCoinsInARow >= 4);
          }

          private bool winCol(int i_Row, int i_Col, char i_Sign)
          {
               int numOfCoinsInARow = 0;
               bool isDifferentSign = false;
               int chosenRow = i_Row;

               for (int i = chosenRow; i < r_GameProduct.Row && (!isDifferentSign); i++)
               {
                    increaseSeriesIfMatch(i, i_Col, i_Sign, ref numOfCoinsInARow, ref isDifferentSign);
               }

               for (int i = chosenRow - 1; i >= 0 && (!isDifferentSign); i--)
               {
                    increaseSeriesIfMatch(i, i_Col, i_Sign, ref numOfCoinsInARow, ref isDifferentSign);
               }

               return (numOfCoinsInARow >= 4);
          }

          private bool isNumberInColsRange(int i_PlayersMove)
          {
               return (i_PlayersMove > 0) && (i_PlayersMove < (r_GameProduct.Row + 1));
          }

          public void ChangeCurrentPlayer()
          {
               m_CurrentPlayer = (char)(((m_TurnNumber) % 2) + '1');
               m_TurnNumber++;
          }
     }
}
