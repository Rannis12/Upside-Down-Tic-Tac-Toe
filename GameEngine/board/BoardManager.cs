using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameEngine.utils;

namespace GameEngine.board
{
    class BoardManager
    {
        public static readonly char sr_EMPTY = '\0';
        public int m_BoardSize { get; }
        private char[][] m_Board { get; }

        public event Action<int, int, char> m_CellChangedEventListeners;

        public BoardManager(int i_BoardSize)
        {
            this.m_BoardSize = i_BoardSize;
            m_Board = new char[this.m_BoardSize][];
            
            for(int i = 0; i < m_BoardSize; i++)
            {
                m_Board[i] = new char[m_BoardSize];
            }
        }

        public bool IsCellEmpty(Point i_PlayerCellChoice)
        {
            return m_Board[i_PlayerCellChoice.x][i_PlayerCellChoice.y] == sr_EMPTY;
        }

        public char GetCell(Point i_CellPoint)
        {
            return this.m_Board[i_CellPoint.x][i_CellPoint.y];
        }

        public void FillCell(Point i_CellPoint, char i_PlayerSymnol)
        {
            this.m_Board[i_CellPoint.x][i_CellPoint.y] = i_PlayerSymnol;
            this.m_CellChangedEventListeners.Invoke(i_CellPoint.x, i_CellPoint.y, i_PlayerSymnol);
        }

        public void ResetSettingsOnRematch()
        {
            for(int i = 0; i < this.m_BoardSize; i++)
            {
                for(int j = 0; j < this.m_BoardSize; j++)
                {
                    FillCell(new Point(i,j), sr_EMPTY);
                }
            }
        }
    }
}
