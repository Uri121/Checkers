using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace B18_Ex05_AmitEdri_315793794_UriRobinov_310471362
{
    class ButtonCheckers : Button
    {
        private readonly int r_BoardSize;
        private int m_i;
        private int m_j;
        private string m_Mark;

        public Image SetImage(string i_Mark)
        {
            if (i_Mark.Equals("O"))
            {
                this.BackgroundImage = Properties.Resources.red_piece;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (i_Mark.Equals("X"))
            {
                this.BackgroundImage = Properties.Resources.black_piece;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (i_Mark.Equals("K"))
            {
                this.BackgroundImage = Properties.Resources.blackKing_Piece;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (i_Mark.Equals("U"))
            {
                this.BackgroundImage = Properties.Resources.redKing_piece;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                this.BackgroundImage = null;
            }

            return this.BackgroundImage;
        }

        public ButtonCheckers(int i_BoardSize)
        {
            r_BoardSize = i_BoardSize;
        }

        public int i
        {
            get { return m_i; }
            set
            {
                if (value >= 0 && value < r_BoardSize)
                {
                    m_i = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        public int j
        {
            get { return m_j; }
            set
            {
                if (value >= 0 && value < r_BoardSize)
                {
                    m_j = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        public string Mark
        {
            get { return m_Mark; }
            set { m_Mark = value; }
        }

    }
}
