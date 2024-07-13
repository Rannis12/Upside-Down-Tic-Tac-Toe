using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine.enums;

namespace GameEngine.player
{
    class Player
    {
        private readonly ePlayerType r_PlayerType;
        public readonly char r_PlayerCellSymbol;
        public int m_PlayerScore { get; set; }

        public Player(ePlayerType i_PlayerType, char i_PlayerCellSymbol)
        {
            this.r_PlayerType = i_PlayerType;
            this.r_PlayerCellSymbol = i_PlayerCellSymbol;
            this.m_PlayerScore = 0;
        }

        public bool IsMachine()
        {
            return this.r_PlayerType == ePlayerType.Machine;
        }
    }
}
