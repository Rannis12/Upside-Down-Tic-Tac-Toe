using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine.enums;

namespace GameEngine.player
{
    class PlayerManager
    {
        private Player[] m_PlayersArray;
        private readonly int r_NumOfParticipants = 2;
        private int m_PlayerTurn = 0;

        public PlayerManager(ePlayerType i_RivalType)
        {
            this.m_PlayersArray = new Player[r_NumOfParticipants];
            this.m_PlayersArray[0] = new Player(ePlayerType.OfflinePlayer, 'X');
            this.m_PlayersArray[1] = new Player(i_RivalType, 'O');
        }

        public void ChangePlayerTurn()
        {
            this.m_PlayerTurn = 1 - m_PlayerTurn;
        }

        public int GetWinnerId()
        {
            return (m_PlayerTurn == 0) ? 1 : 0;
        }

        public Player GetCurrentPlayer()
        {
            return this.m_PlayersArray[this.m_PlayerTurn];
        }

        public Player GetOtherPlayer()
        {
            return this.m_PlayersArray[1 - m_PlayerTurn];
        }

        public Player GetPlayerById(int i_PlayerId)
        {
            return this.m_PlayersArray[i_PlayerId];
        }

        public void ResetPlayersTurn()
        {
            this.m_PlayerTurn = 0;
        }
    }
}
