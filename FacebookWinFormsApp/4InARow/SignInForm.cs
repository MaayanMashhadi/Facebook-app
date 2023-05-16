using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BasicFacebookFeatures;
using static BasicFacebookFeatures.Colores;
using FacebookWrapper.ObjectModel;

namespace Game4InARow
{
    public class SignInForm : Form
    {
        private const string k_ComputerName = "Computer";
        private const int k_WindowWidth = 864;
        private const int k_WindowHeight = 501;
        private const int k_MinRowsAndCols = 4;
        private const int k_MaxRowsAndCols = 10;
        private const string k_Player2Txt = "Player 2:";
        private const string k_PlayersTxt = "Players:";
        private const string k_Player1Txt = "Player 1:";
        private const string k_BoardSizeTxt = "Board Size:";
        private const string k_RowsTxt = "Rows:";
        private const string k_ColsTxt = "Cols:";
        private const string k_StartTxt = "Start!";
        private const string k_GameSettingsTxt = "Game Settings";
        private const string k_NoNameErrorTxt = "You must enter the players name to play!";
        private const string k_NoNameErrorCaption = "No name Error";
        private const int k_DefaultDistance = 40;
        private const int k_DefaultSmallDistance = 10;
        private readonly Label r_LblPlayers;
        private readonly Label r_LblPlayer1;
        private readonly Label r_LblBoardSize;
        private readonly Label r_LblRows;
        private readonly Label r_LblCols;
        private readonly CheckBox r_CbComputerPlayer;
        private readonly TextBox r_TbPlayerOneName;
        private readonly TextBox r_TbPlayerTwoName;
        private readonly NumericUpDown r_NudNumberOfRows;
        private readonly NumericUpDown r_NudNumberOfCols;
        private readonly Button r_BtnStart;
        private readonly ListBox r_FriendList;

        public string Player1Name
        {
            get
            {
                return r_TbPlayerOneName.Text;
            }
        }

        public string Player2Name
        {
            get
            {
                return r_TbPlayerTwoName.Text;
            }
        }

        public int Rows
        {
            get
            {
                return (int)r_NudNumberOfRows.Value;
            }
        }

        public int Cols
        {
            get
            {
                return (int)r_NudNumberOfCols.Value;
            }
        }

        public bool ComputerPlayer
        {
            get
            {
                return !r_CbComputerPlayer.Checked;
            }
        }

        public SignInForm()
        {
            setFormWindowParams();
            r_LblPlayers = new Label();
            r_LblPlayer1 = new Label();
            r_LblBoardSize = new Label();
            r_LblRows = new Label();
            r_LblCols = new Label();
            r_CbComputerPlayer = new CheckBox();
            r_TbPlayerOneName = new TextBox();
            r_TbPlayerTwoName = new TextBox();
            r_NudNumberOfRows = new NumericUpDown();
            r_NudNumberOfCols = new NumericUpDown();
            r_BtnStart = new Button();
            r_FriendList = new ListBox();
            initFriendListBox();
            initMinMaxRowsCols();
            setStartingPhase();
            initListeners();
            initSignInWindowText();
            setObjectsToPlaces();
            AddingButtonsToForm();

        }

        public void InitColors()
        {
            r_LblPlayers.ForeColor = Colores.PrimeryColor;
            r_LblPlayer1.ForeColor = Colores.PrimeryColor;
            r_LblBoardSize.ForeColor = Colores.PrimeryColor;
            r_LblRows.ForeColor = Colores.SeconderyColor;
            r_LblCols.ForeColor = Colores.SeconderyColor;
            r_BtnStart.BackColor = Colores.PrimeryColor;
            r_BtnStart.ForeColor = Colores.SeconderyColor;
            r_CbComputerPlayer.ForeColor = Colores.PrimeryColor;
        }

        private void setFormWindowParams()
        {
            Text = k_GameSettingsTxt;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Size = new Size(k_WindowWidth, k_WindowHeight);
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void initSignInWindowText()
        {
            r_LblPlayers.Text = k_PlayersTxt;
            r_LblPlayer1.Text = k_Player1Txt;
            r_LblBoardSize.Text = k_BoardSizeTxt;
            r_LblRows.Text = k_RowsTxt;
            r_LblCols.Text = k_ColsTxt;
            r_TbPlayerOneName.Text = SingeltonUserInfo.StaticInstance.LoggedInUser.Name;
            r_TbPlayerTwoName.Text = k_ComputerName;
            r_BtnStart.Text = k_StartTxt;
        }

        private void initFriendListBox()
        {
            r_FriendList.Size = new Size(559, 142);
            r_FriendList.Location = new Point(50, 230);
            r_FriendList.Visible = false;
        }

        private void initListeners()
        {
            r_CbComputerPlayer.Click += checkBox_Click;
            r_BtnStart.Click += btnStart_Click;
            r_FriendList.SelectedIndexChanged += friendsList_SelectedIndexChanged;
        }

        private void initMinMaxRowsCols()
        {
            r_NudNumberOfRows.Minimum = k_MinRowsAndCols;
            r_NudNumberOfRows.Maximum = k_MaxRowsAndCols;
            r_NudNumberOfCols.Minimum = k_MinRowsAndCols;
            r_NudNumberOfCols.Maximum = k_MaxRowsAndCols;
        }

        private void setStartingPhase()
        {
            r_TbPlayerTwoName.Enabled = false;
            r_CbComputerPlayer.Checked = false;
        }

        private void btnStart_Click(object i_Sender, EventArgs i_EventArgs)
        {
            bool namesFull = (r_TbPlayerOneName.Text != String.Empty) && (r_TbPlayerTwoName.Text != String.Empty);

            if(namesFull)
            {
                DialogResult = DialogResult.OK;
                if(DialogResult == DialogResult.OK)
                {
                    Game4InARowForm game = new Game4InARowForm(
                        Player1Name,
                        Player2Name,
                        Rows,
                        Cols,
                        ComputerPlayer,
                        this);

                    game.StartGame();
                }
            }
            else
            {
                MessageBox.Show(k_NoNameErrorTxt, k_NoNameErrorCaption, MessageBoxButtons.OK);
            }
        }

        public void AddingButtonsToForm()
        {
            this.Controls.Add(r_LblPlayers);
            this.Controls.Add(r_LblPlayer1);
            this.Controls.Add(r_LblBoardSize);
            this.Controls.Add(r_LblRows);
            this.Controls.Add(r_LblCols);
            this.Controls.Add(r_CbComputerPlayer);
            this.Controls.Add(r_TbPlayerOneName);
            this.Controls.Add(r_TbPlayerTwoName);
            this.Controls.Add(r_NudNumberOfRows);
            this.Controls.Add(r_NudNumberOfCols);
            this.Controls.Add(r_BtnStart);
            this.Controls.Add(r_FriendList);
        }

        private void checkBox_Click(object i_Sender, EventArgs i_EventArgs)
        {
            if((i_Sender as CheckBox).Checked)
            {
                setCheckboxAsChecked();
            }
            else
            {
                setCheckboxAsNotChecked();
            }
        }

        private void setCheckboxAsChecked()
        {
            r_TbPlayerTwoName.Enabled = true;
            r_TbPlayerTwoName.Text = String.Empty;
            initFriendsList();
            r_FriendList.Visible = true;
        }

        private void initFriendsList()
        {
            SingeltonUserInfo.StaticInstance.FetchFriendsList(r_FriendList);
        }

        private void friendsList_SelectedIndexChanged(object i_Sender, EventArgs i_e)
        {
            changePlayerTwoTBToFriendsName();
        }

        private void changePlayerTwoTBToFriendsName()
        {
            User selectedFriend = null;

            if(r_FriendList.SelectedItem != null && !r_FriendList.SelectedItem.Equals("No friends here sorry..."))
            {
                selectedFriend = (User)r_FriendList.SelectedItem;
                if(selectedFriend != null)
                {
                    r_TbPlayerTwoName.Text = selectedFriend.Name;
                }
            }
        }

        public User GetChosenFriendToPlay()
        {
            User selectedFriend = null;

            if(r_FriendList.Items.Count > 0)
            {
                if(r_FriendList.Enabled)
                {
                    if(r_FriendList.SelectedItem != null)
                    {
                        selectedFriend = r_FriendList.SelectedItem as User;
                        r_TbPlayerTwoName.Text = selectedFriend.Name;
                    }
                }
            }

            return selectedFriend;
        }

        private void setCheckboxAsNotChecked()
        {
            r_TbPlayerTwoName.Enabled = false;
            r_TbPlayerTwoName.Text = k_ComputerName;
            r_FriendList.Visible = false;
        }

        public void StartGame()
        {
            ShowDialog();
            if(DialogResult == DialogResult.OK)
            {
                Game4InARowForm game = new Game4InARowForm(
                    Player1Name,
                    Player2Name,
                    Rows,
                    Cols,
                    ComputerPlayer,
                    this);

                game.StartGame();
            }
        }

        private void setObjectsToPlaces()
        {
            setPlayersLabelToPlace();
            setPlayer1ToPlace();
            setPlayer2ToPlace();
            setLabelBoardSizeToPlace();
            setRowsColsLabelsToPlace();
            setNamesTextBoxesToPlaces();
            setRowsAndColsNudToPlaces();
            setStartBtnToPlace();
        }

        private void setPlayer1ToPlace()
        {
            r_LblPlayer1.Left = r_LblPlayers.Left + k_DefaultSmallDistance;
            r_LblPlayer1.Top = r_LblPlayers.Top + 2 * k_DefaultSmallDistance;
            r_LblPlayer1.AutoSize = true;
        }

        private void setPlayersLabelToPlace()
        {
            r_LblPlayers.Top = k_DefaultSmallDistance;
            r_LblPlayers.Left = k_DefaultSmallDistance * 2;
            r_LblPlayers.AutoSize = true;
        }

        private void setPlayer2ToPlace()
        {
            r_CbComputerPlayer.Text = k_Player2Txt;
            r_CbComputerPlayer.AutoSize = true;
            r_CbComputerPlayer.Top = r_LblPlayer1.Top + k_DefaultSmallDistance * 3;
            r_CbComputerPlayer.Left = r_LblPlayer1.Left - r_LblPlayer1.Width / 6;
        }

        private void setLabelBoardSizeToPlace()
        {
            r_LblBoardSize.AutoSize = true;
            r_LblBoardSize.Left = r_LblPlayers.Left;
            r_LblBoardSize.Top = r_LblPlayer1.Top + 3 * k_DefaultSmallDistance + k_DefaultDistance;
        }

        private void setRowsColsLabelsToPlace()
        {
            setRowsLabelToPlace();
            setColsToPlaces();
        }

        private void setRowsLabelToPlace()
        {
            r_LblRows.AutoSize = true;
            r_LblRows.Left = r_LblPlayer1.Left;
            r_LblRows.Top = r_LblBoardSize.Top + 3 * k_DefaultSmallDistance;
        }

        private void setColsToPlaces()
        {
            r_LblCols.AutoSize = true;
            r_LblCols.Left = r_LblRows.Left + r_LblRows.Width;
            r_LblCols.Top = r_LblRows.Top;
        }

        private void setNamesTextBoxesToPlaces()
        {
            r_TbPlayerOneName.Top = r_LblPlayer1.Top - r_TbPlayerOneName.Top / 2;
            r_TbPlayerOneName.Left = r_LblPlayer1.Left + 3 * (k_DefaultDistance / 2);
            r_TbPlayerTwoName.Left = r_TbPlayerOneName.Left;
            r_TbPlayerTwoName.Top = r_CbComputerPlayer.Top;
        }

        private void setRowsAndColsNudToPlaces()
        {
            setRowsNudToPlace();
            setColsNudToPlace();
        }

        private void setRowsNudToPlace()
        {
            r_NudNumberOfRows.Width = k_DefaultDistance;
            r_NudNumberOfRows.Top = r_LblRows.Top + r_NudNumberOfRows.Height / 2 - r_LblRows.Height / 2;
            r_NudNumberOfRows.Left = r_LblRows.Left + k_DefaultDistance;
        }

        private void setColsNudToPlace()
        {
            r_NudNumberOfCols.Top = r_NudNumberOfRows.Top;
            r_NudNumberOfCols.Width = k_DefaultDistance;
            r_NudNumberOfCols.Left = r_LblCols.Left + k_DefaultDistance;
        }

        private void setStartBtnToPlace()
        {
            r_BtnStart.Width = this.ClientSize.Width - k_DefaultDistance;
            r_BtnStart.Top = r_LblRows.Top + k_DefaultDistance + k_DefaultSmallDistance;
            r_BtnStart.Left = ClientSize.Width / 2 - r_BtnStart.Width / 2;
        }
    }
}
