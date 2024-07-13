using System;
using System.Windows.Forms;
using GameEngine.board;
using GameEngine.enums;
using GameEngine.player;
using GameEngine.utils;

namespace GameEngine
{
    public class GameManager
    {
        private BoardManager m_BoardManager;
        private PlayerManager m_PlayerManager;
        private bool m_IsGameOver;

        public bool IsGameOver
        {
            get
            {
                return this.m_IsGameOver;
            }
        }

        public int m_CellsAvaiable { get; set; }
        public bool m_DoRematch { get; set; }

        public GameManager(int i_BoardSize, ePlayerType i_RivalType)
        {
            this.m_BoardManager = new BoardManager(i_BoardSize);
            this.m_PlayerManager = new PlayerManager(i_RivalType);
            this.m_IsGameOver = false;
            this.m_DoRematch = true;
            this.m_CellsAvaiable = i_BoardSize*i_BoardSize;
        }

        public void PlayMove(Point i_PlayerCellChoice)
        {
            if(!this.m_IsGameOver)
            {
                this.m_BoardManager.FillCell(i_PlayerCellChoice, m_PlayerManager.GetCurrentPlayer().r_PlayerCellSymbol);

                this.m_CellsAvaiable -= 1;

                bool isPlayerLose = this.playerLose(i_PlayerCellChoice);
                bool isGameTie = (this.m_CellsAvaiable == 0);

                if (isPlayerLose || isGameTie)
                {
                    this.m_IsGameOver = true;

                    if(isPlayerLose)
                    {
                        this.m_PlayerManager.GetOtherPlayer().m_PlayerScore += 1;
                    }
                }
                else
                {
                    this.m_PlayerManager.ChangePlayerTurn();

                    if(this.isMachineTurn())
                    {
                        this.playAsMachine();
                    }
                }
            }
        }

        public bool IsPlayable(Point i_PlayerCellChoice)
        {
            return this.m_BoardManager.IsCellEmpty(i_PlayerCellChoice);
        }

        public int GetBoardSize()
        {
            return this.m_BoardManager.m_BoardSize;
        }

        public char GetCell(Point i_CellPoint)
        {
            return this.m_BoardManager.GetCell(i_CellPoint);
        }

        private bool playerLose(Point i_PlayerCellChoice)
        {
            return checkBoardRow(i_PlayerCellChoice.x)
                    || checkBoardCol(i_PlayerCellChoice.y)
                        || checkBoardOblique();
        }

        private bool checkBoardRow(int i_RowIndex)
        {
            int countCells = 0;

            // Check same row as point.
            for (int i = 0; i < this.GetBoardSize(); i++)
            {
                if (this.m_BoardManager.GetCell(new Point(i_RowIndex, i))
                    == this.m_PlayerManager.GetCurrentPlayer().r_PlayerCellSymbol)
                {
                    countCells += 1;
                }
            }

            return countCells == this.GetBoardSize();
        }

        private bool checkBoardCol(int i_ColIndex)
        {
            int countCells = 0;

            // Check same row as point.
            for (int i = 0; i < this.GetBoardSize(); i++)
            {
                if (this.m_BoardManager.GetCell(new Point(i, i_ColIndex))
                    == this.m_PlayerManager.GetCurrentPlayer().r_PlayerCellSymbol)
                {
                    countCells += 1;
                }
            }

            return countCells == this.GetBoardSize();
        }

        private bool checkBoardOblique()
        {
            int leftOblique = 0;
            int rightOblique = 0;

            Point checkPoint = new Point(0,0);

            for (int i = 0; i < this.GetBoardSize(); i++)
            {
                checkPoint.x = i;
                checkPoint.y = i;

                if (this.m_BoardManager.GetCell(checkPoint)
                    == this.m_PlayerManager.GetCurrentPlayer().r_PlayerCellSymbol)
                {
                    leftOblique += 1;
                }
            }

            checkPoint = new Point(0, this.GetBoardSize() - 1);

            for (int i = 0; i < this.GetBoardSize(); i++)
            {
                checkPoint.x = i;
                checkPoint.y = this.GetBoardSize() - 1 - i;

                if (this.m_BoardManager.GetCell(checkPoint)
                    == this.m_PlayerManager.GetCurrentPlayer().r_PlayerCellSymbol)
                {
                    rightOblique += 1;
                }
            }

            return leftOblique == this.GetBoardSize() 
                    || rightOblique == this.GetBoardSize();
        }

        public void RestartGame()
        {
            this.m_BoardManager.ResetSettingsOnRematch();
            this.m_CellsAvaiable = GetBoardSize() * GetBoardSize();
            this.m_IsGameOver = false;
            this.m_DoRematch = true;
            this.m_PlayerManager.ResetPlayersTurn();
        }

        public int GetPlayerScoreById(int i_PlayerId)
        {
            return this.m_PlayerManager.GetPlayerById(i_PlayerId).m_PlayerScore;
        }

        public char GetCurrentPlayerSymbol()
        {
            return m_PlayerManager.GetCurrentPlayer().r_PlayerCellSymbol;
        }

        public int GetWinnerId()
        {
            return this.m_PlayerManager.GetWinnerId();
        }
        
        public void AddCellEventListener(Action<int, int, char> i_EventListener)
        {
            this.m_BoardManager.m_CellChangedEventListeners += i_EventListener;
        }

        public bool IsGameStatusTie()
        {
            return (this.m_CellsAvaiable == 0);
        }

        public void CancelRematch()
        {
            this.m_DoRematch = false;
        }

        private void playAsMachine()
        {
            Point machineChoice = this.generateMachineChoice();

            this.PlayMove(machineChoice);
        }

        private Point generateMachineChoice()
        {
            Point machineChoice = new Point(0,0);

            do
            {
                int randomUpperBound = this.GetBoardSize() - 1;

                Random rand = new Random();
                int x = rand.Next(0, randomUpperBound + 1);
                int y = rand.Next(0, randomUpperBound + 1);

                machineChoice.x = x;
                machineChoice.y = y;

            } while (!this.IsPlayable(machineChoice));

            return machineChoice;
        }

        private bool isMachineTurn()
        {
            return (this.m_PlayerManager.GetCurrentPlayer().IsMachine());
        }
    }
}