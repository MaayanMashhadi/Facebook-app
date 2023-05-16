using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BasicFacebookFeatures;
using Game4InARowLogic;
using FacebookWrapper.ObjectModel;
using Logic.GameBuilder;

namespace Game4InARow
{
    public class Game4InARowForm : Form
    {
        private PictureBox m_Player1PictureProfile;
        private PictureBox m_Player2PictureProfile;
        private const int k_TimeDelayInMilliSec = 700;
        private const int k_ButtonSize = 25;
        private const int k_DefaultSmallDist = 10;
        private const int k_DoubleButtonSize = k_ButtonSize * 2;
        private const int k_ButtonDistHorizontal = ((k_ButtonSize / 2) * 3);
        private const string k_GameNameTxt = "4 In A Row!";
        private const string k_PlayAgainTxt = "Do you want to play again?";
        private const string k_TieTxt = "Tie!";
        private readonly Button[,] r_Buttons;
        private readonly Label r_PlayersScore;
        private readonly int[] r_Score = { 0, 0 };
        private GameLogic m_Game;
        private readonly Button[] r_NumberButtons;
        private bool m_IsANewGame = true;
        private readonly GameBuilderProduct m_GameBuilderProduct;


        public Game4InARowForm(string i_Player1Name, string i_Player2Name,
                                 int i_Rows, int i_Cols, bool i_ComputerPlayer, SignInForm i_signIn)
        {
            BoardGameDirector director = new BoardGameDirector(new GameBuilder());

            m_GameBuilderProduct = director.Constract(i_Rows, i_Cols, i_Player1Name, i_Player2Name, i_ComputerPlayer);
            r_PlayersScore = new Label();
            r_Buttons = new Button[m_GameBuilderProduct.Col, m_GameBuilderProduct.Row];
            r_NumberButtons = new Button[m_GameBuilderProduct.Col];
            firstRowSetting();
            settingButtons();
            initPlayersScore();
            initFormWindow();
            createProfliePictures(i_signIn);
            r_PlayersScore.Left = ClientSize.Width / 2 - r_PlayersScore.Width / 2;
        }

        public void StartGame()
        {
            m_Game = new GameLogic(m_GameBuilderProduct);
            m_Game.Win += game_Win;
            m_Game.Tie += game_Tie;
            ShowDialog();
        }


        public void ApplyMoveToButton(char i_PlayerSign, int i_Rows, int i_Cols)
        {
            r_Buttons[i_Cols, i_Rows].Text = i_PlayerSign.ToString();
        }

        private void createProfliePictures(SignInForm i_SignInForm)
        {
            m_Player1PictureProfile = new PictureBox();
            m_Player2PictureProfile = new PictureBox();
            m_Player1PictureProfile.Size = new Size(35, 35);
            m_Player2PictureProfile.Size = new Size(35, 35);

            m_Player1PictureProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            m_Player2PictureProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            setPictureBoxLocation();
            Controls.Add(m_Player1PictureProfile);
            Controls.Add(m_Player2PictureProfile);
            m_Player1PictureProfile.Image = SingeltonUserInfo.StaticInstance.LoggedInUser.ImageNormal;
            if (!m_GameBuilderProduct.IsComputerPlaying)
            {
                User selectedFriend = i_SignInForm.GetChosenFriendToPlay();

                if (selectedFriend != null)
                {
                    m_Player2PictureProfile.Image = selectedFriend.ImageNormal;
                }
                else
                {
                    m_Player2PictureProfile.Image = BasicFacebookFeatures.Properties.Resources.mickey3;
                }
            }
            else
            {
                m_Player2PictureProfile.Image = BasicFacebookFeatures.Properties.Resources.mickey3;

            }
        }

        private void firstRowSetting()
        {
            for (int i = 1; i <= m_GameBuilderProduct.Col; i++)
            {
                setFirstRowButtonSettings(i);
            }
        }

        private void setFirstRowButtonSettings(int i_Index)
        {
            r_NumberButtons[i_Index - 1] = new Button();
            setFirstRowButtonParams(i_Index);
            Controls.Add(r_NumberButtons[i_Index - 1]);
            r_NumberButtons[i_Index - 1].Click += button_OnClick;
            r_NumberButtons[i_Index - 1].Click += button_AfterClick;
        }

        private void setFirstRowButtonParams(int i_Index)
        {
            int leftPosition = k_ButtonDistHorizontal * i_Index;

            r_NumberButtons[i_Index - 1].Location = new Point(leftPosition, k_DefaultSmallDist);
            r_NumberButtons[i_Index - 1].Size = new Size(k_ButtonSize, k_ButtonSize);
            r_NumberButtons[i_Index - 1].Text = i_Index.ToString();
        }

        private void initFormWindow()
        {
            int formDists = (3 * k_ButtonSize + k_DefaultSmallDist);
            int formWidth = (r_Buttons[(m_GameBuilderProduct.Col - 1), 0].Location.X) + formDists;
            int formHeight = r_PlayersScore.Location.Y + formDists;

            this.Size = new Size(formWidth, formHeight);
            this.Text = k_GameNameTxt;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void initPlayersScore()
        {
            addingTheScoreLabel();
            setPlayersScoreToPlace();
            Controls.Add(r_PlayersScore);
        }

        private void setPlayersScoreToPlace()
        {
            r_PlayersScore.AutoSize = true;
            r_PlayersScore.Top = r_Buttons[0, (m_GameBuilderProduct.Row - 1)].Location.Y + r_PlayersScore.Height * 2;
        }

        private void setPictureBoxLocation()
        {
            m_Player1PictureProfile.Location = new Point(r_PlayersScore.Location.X, r_PlayersScore.Location.Y);
            m_Player2PictureProfile.Location = new Point(ClientSize.Width - 40, r_PlayersScore.Location.Y);
        }

        private void button_AfterClick(object i_Sender, EventArgs i_EventArgs)
        {
            if (m_GameBuilderProduct.IsComputerPlaying && !m_IsANewGame)
            {
                m_Game.ChangeCurrentPlayer();
                wait(k_TimeDelayInMilliSec); // Simulates computer thinking time
                int playersChoice = playComputerMove(m_Game.CurrentPlayer);

                handleFullCol(r_NumberButtons[playersChoice - 1], playersChoice);
            }
        }

        private void button_OnClick(object i_Sender, EventArgs i_EventArgs)
        {
            m_Game.ChangeCurrentPlayer();
            m_IsANewGame = false;
            int playersChoice = playHumanMove(m_Game.CurrentPlayer, (Button)i_Sender);

            handleFullCol(i_Sender as Button, playersChoice);
        }

        private void handleFullCol(Button i_Button, int i_PlayersChoice)
        {
            if (m_Game.CheckIfTheColIsFull(i_PlayersChoice))
            {
                i_Button.Enabled = false;
            }
        }

        private int playComputerMove(char i_CurrentPlayer)
        {
            m_Game.GetMoveFromComputer(out int computerChosenColumn, m_Game.GameProduct.Col);
            executeMoveAndCheckForAWin(computerChosenColumn, i_CurrentPlayer);

            return computerChosenColumn;
        }

        private void executeMoveAndCheckForAWin(int i_ChosenColumn, char i_CurrentPlayer)
        {
            int columnChoiceInBoard = i_ChosenColumn - 1;
            int rowChoiceInBoard = m_Game.GameProduct.Row - m_Game.NumOfCoinsInCol(columnChoiceInBoard) - 1;
            char sign = m_Game.ExecuteMove(i_CurrentPlayer, rowChoiceInBoard, columnChoiceInBoard);

            ApplyMoveToButton(sign, rowChoiceInBoard, columnChoiceInBoard);
            m_Game.IncreaseTheNumberOfCoinsInAColumn(i_ChosenColumn);
            m_Game.CheckForAWin(rowChoiceInBoard, columnChoiceInBoard, sign);
        }

        private int playHumanMove(char i_CurrentPlayer, Button i_Sender)
        {
            int playerChosenColumn = int.Parse(i_Sender.Text);

            executeMoveAndCheckForAWin(playerChosenColumn, i_CurrentPlayer);

            return playerChosenColumn;
        }

        private void settingButtons()
        {
            for (int i = 1; i <= m_GameBuilderProduct.Col; i++)
            {
                for (int j = 1; j <= m_GameBuilderProduct.Row; j++)
                {
                    setButtonSettings(i, j);
                }
            }
        }

        private void setButtonSettings(int i_Col, int i_Row)
        {
            Button button = new Button();
            int leftPosition = k_ButtonDistHorizontal * i_Col;
            int topPosition = (i_Row * k_ButtonSize) + k_DefaultSmallDist;

            button.Location = new Point(leftPosition, topPosition);
            button.Size = new Size(k_ButtonSize, k_ButtonSize);
            button.Enabled = false;
            r_Buttons[i_Col - 1, i_Row - 1] = button;
            Controls.Add(button);
        }

        private void addingTheScoreLabel()
        {
            StringBuilder stringToInput = new StringBuilder();

            stringToInput.AppendFormat("{0}: {1}        {2}: {3}", m_GameBuilderProduct.Player1Name,
                r_Score[0], m_GameBuilderProduct.Player2Name, r_Score[1]);
            r_PlayersScore.Text = stringToInput.ToString();
        }

        private static void wait(int i_Millisec)
        {
            Timer timer1 = new Timer();

            if (!(i_Millisec == 0 || i_Millisec < 0))
            {
                timer1.Interval = i_Millisec;
                timer1.Enabled = true;
                timer1.Start();
                timer1.Tick += (s, e) =>
                     {
                         timer1.Enabled = false;
                         timer1.Stop();
                     };
                while (timer1.Enabled)
                {
                    Application.DoEvents();
                }
            }
        }


        private void game_Win(object i_Sender, EventArgs i_EventArgs)
        {
            string winnerName = (m_Game.CurrentPlayer == GameLogic.k_Player1)
                                    ? m_GameBuilderProduct.Player1Name : m_GameBuilderProduct.Player2Name;
            string message = string.Format("The Winner is {0}!", winnerName);
            int winnerInInteger = int.Parse(m_Game.CurrentPlayer.ToString());

            r_Score[winnerInInteger - 1]++;
            askPlayAgain(message);
        }

        private void game_Tie(object i_Sender, EventArgs i_EventArgs)
        {
            askPlayAgain(k_TieTxt);
        }

        private void askPlayAgain(string i_WinnerState)
        {
            DialogResult dialogPlayAgainResult = buildAndShowMessageBox(i_WinnerState);

            if (dialogPlayAgainResult == DialogResult.Yes)
            {
                m_Game.GetReadyForANewGame();
                restartGameForm();
            }
            else
            {
                Close();
            }
        }

        private static DialogResult buildAndShowMessageBox(string i_WinnerState)
        {
            StringBuilder messageToPlayer = new StringBuilder();

            messageToPlayer.AppendLine(i_WinnerState);
            messageToPlayer.AppendLine(k_PlayAgainTxt);
            return MessageBox.Show(messageToPlayer.ToString(),
                 i_WinnerState, MessageBoxButtons.YesNo);
        }

        private void restartGameForm()
        {
            addingTheScoreLabel();
            resetButtons();
            m_IsANewGame = true;
        }

        private void resetButtons()
        {
            for (int i = 1; i <= m_GameBuilderProduct.Col; i++)
            {
                r_NumberButtons[i - 1].Enabled = true;
                for (int j = 1; j <= m_GameBuilderProduct.Row; j++)
                {
                    r_Buttons[i - 1, j - 1].Text = String.Empty;
                }
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Game4InARowForm
            // 
            this.ClientSize = new System.Drawing.Size(539, 314);
            this.Name = "Game4InARowForm";
            this.ResumeLayout(false);

        }
    }
}
