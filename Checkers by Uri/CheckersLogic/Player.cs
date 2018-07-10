using System;
using System.Collections.Generic;
using System.Text;

namespace CheckersLogic
{
    public class Player
    {
        private string m_PlayerName;
        private int m_PlayerScore;
        private bool m_IsComputer;

        public Player(string i_Name)
        {
            m_PlayerName = i_Name;
            m_PlayerScore = 0;
            m_IsComputer = false;
        }

        public Player()
        {
            m_PlayerName = "Computer";
            m_PlayerScore = 0;
            m_IsComputer = true;
        }

        public string Name
        {
            get
            {
                return m_PlayerName;
            }
        }

        public int Score
        {
            get
            {
                return m_PlayerScore;
            }

            set
            {
                m_PlayerScore += value;
            }
        }

        public bool IsComputer
        {
            get { return m_IsComputer; }
        }
    }
}

