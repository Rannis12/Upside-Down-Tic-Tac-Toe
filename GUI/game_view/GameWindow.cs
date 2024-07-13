using GameEngine;
using GameEngine.enums;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace B23_Ex05_AmitSwisa_315507723_RanNissan_207523531
{
    public partial class GameWindow : Form
    {
        private int r_ButtonSize;
        private readonly GameManager r_GameManager;
        private readonly string[] r_PlayersNameArray;
        private Button[,] m_ButtonsArray;

        public GameWindow(string i_FirstPlayerName, string i_SecondPlayerName
            , int i_BoardSize, bool i_IsOtherPlayerPlaying)
        {
            ePlayerType playerType;

            if(!i_IsOtherPlayerPlaying)
            {
                playerType = ePlayerType.Machine;
            }
            else
            {
                playerType = ePlayerType.OfflinePlayer;
            }

            r_GameManager = new GameManager(i_BoardSize, playerType);

            r_PlayersNameArray = new string[2] { i_FirstPlayerName, i_SecondPlayerName };

            r_ButtonSize = ((this.ClientSize.Width + this.ClientSize.Height - 120) / i_BoardSize);

            InitializeComponent();

            initialzieFormElements();
        }

        private void initialzieFormElements()
        {
            this.firstPlayerNameLabel.Text = r_PlayersNameArray[0];
            this.secondPlayerNameLabel.Text = r_PlayersNameArray[1];

            int startX = (this.ClientSize.Width - (this.r_GameManager.GetBoardSize() * this.r_ButtonSize)) / 2;
            int startY = (this.ClientSize.Height - playerDataTable.Height - (this.r_GameManager.GetBoardSize() * this.r_ButtonSize)) / 2;

            this.m_ButtonsArray = new Button[r_GameManager.GetBoardSize(), r_GameManager.GetBoardSize()];

            for(int rowIndex = 0; rowIndex < r_GameManager.GetBoardSize(); rowIndex++)
            {
                for (int colIndex = 0; colIndex < r_GameManager.GetBoardSize(); colIndex++)
                {
                    m_ButtonsArray[rowIndex, colIndex] = new Button();
                    m_ButtonsArray[rowIndex, colIndex].Size = new Size(this.r_ButtonSize, r_ButtonSize);
                    m_ButtonsArray[rowIndex, colIndex].Location = new Point(startX + (rowIndex * r_ButtonSize), startY + (colIndex * r_ButtonSize));
                    m_ButtonsArray[rowIndex, colIndex].Tag = new Point(rowIndex, colIndex); // Tag to identify row and col in array when button pressed.
                    m_ButtonsArray[rowIndex, colIndex].TabStop = false;
                    m_ButtonsArray[rowIndex, colIndex].Click += onGameButtonClick;

                    this.Controls.Add(m_ButtonsArray[rowIndex, colIndex]);
                }
            }

            this.r_GameManager.AddCellEventListener(ChangeButtonSettingsWhenPressed);
        }

        private void onGameButtonClick(object sender, EventArgs e)
        {
            if(!this.r_GameManager.IsGameOver)
            {
                Button clickedBtn = (sender as Button);
                Point buttonPointInArray = (Point)clickedBtn.Tag;

                r_GameManager.PlayMove(new GameEngine.utils.Point(buttonPointInArray.X, buttonPointInArray.Y));

                checkGameStatus();
            }
        }

        public void ChangeButtonSettingsWhenPressed(int i_Row, int i_Col, char i_CellSymbol)
        {
            m_ButtonsArray[i_Row, i_Col].Text = i_CellSymbol.ToString();
            m_ButtonsArray[i_Row, i_Col].Enabled = this.r_GameManager.IsGameOver;
        }

        private void checkGameStatus()
        {
            if(this.r_GameManager.IsGameOver)
            {
                DialogResult resultBox;
                if (r_GameManager.IsGameStatusTie())
                {
                    resultBox = MessageBox.Show("It's a Tie!\nWould you like to play another round?", "A Tie!", MessageBoxButtons.YesNo);
                }
                else
                {
                    firstPlayerScoreLabel.Text = r_GameManager.GetPlayerScoreById(0).ToString();
                    secondPlayerScoreLabel.Text = r_GameManager.GetPlayerScoreById(1).ToString();
                    resultBox = MessageBox.Show(r_PlayersNameArray[r_GameManager.GetWinnerId()] + " Won!\nWould you like to play another round?", "A Win!", MessageBoxButtons.YesNo);
                }

                if (resultBox == DialogResult.Yes)
                {
                    firstPlayerNameLabel.Focus(); // Disable last button pressed focus.
                    r_GameManager.RestartGame();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
