using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public class GameButtons
    {
        
        internal List<GameRow> m_GameRows;
        public GameButtons(List<GameRow> i_gameRows)
        {
            m_GameRows = new List<GameRow>();
            m_GameRows = i_gameRows;
        }

        public void NextRow(int i_RowNumber)
        {
            Enabler.disableRow(this.m_GameRows[i_RowNumber-1].m_GuessButtons);
            Enabler.enableRow(this.m_GameRows[i_RowNumber].m_GuessButtons);
        }
    }
}
