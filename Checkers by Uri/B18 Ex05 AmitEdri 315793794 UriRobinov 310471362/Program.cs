using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace B18_Ex05_AmitEdri_315793794_UriRobinov_310471362
{
    class Program
    {
        public static void Main()
        {
            FormGameSettings formStart = new FormGameSettings();
            FormBoard formBoard;

            formStart.ShowDialog();
            if (formStart.DialogResult == DialogResult.OK)
            {
                do
                {
                    formBoard = new FormBoard(formStart);
                    formBoard.ShowDialog();
                }
                while (formBoard.DialogResult == DialogResult.Yes);
            }
        }
    }
}
