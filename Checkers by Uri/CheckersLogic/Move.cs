using System;
using System.Collections.Generic;
using System.Text;

namespace CheckersLogic
{
    public class Move
    {
        private int m_RowCurrentMove;
        private int m_ColCurrentMove;
        private int m_RowNextMove;
        private int m_ColNextMove;

        public Move(int i_RowCurrentMove, int i_ColCurrentMove, int i_RowNextMove, int i_ColNextMove)
        {
            m_RowCurrentMove = i_RowCurrentMove;
            m_ColCurrentMove = i_ColCurrentMove;
            m_RowNextMove = i_RowNextMove;
            m_ColNextMove = i_ColNextMove;
        }

        public int IPreviousMove
        {
            get
            {
                return m_RowCurrentMove;
            }
        }

        public int JPreviousMove
        {
            get
            {
                return m_ColCurrentMove;
            }
        }

        public int INextMove
        {
            get
            {
                return m_RowNextMove;
            }
        }

        public int JNextMove
        {
            get
            {
                return m_ColNextMove;
            }
        }
    }
}
