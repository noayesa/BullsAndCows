using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Boardcreator;
namespace UI
{
    public partial class GameForm : Form
    {
        public List<Button> m_SequenceColors;
        public GameButtons m_GameButtons;
        public Board m_Board;

        public GameForm(GameButtons i_gameButtons,Board i_board)
        {
            
            this.m_Board = i_board;
            m_GameButtons = i_gameButtons;
            m_SequenceColors = new List<Button>();
            sequenceColorButtonGenerator();
            for (int i = 0; i < m_GameButtons.m_GameRows.Count; i++)
            {
                m_GameButtons.m_GameRows[i].ColorsGenerated = m_Board.colorSequence;
                this.Controls.Add(m_GameButtons.m_GameRows[i].m_PointerToAccuracy);
                for (int j = 0; j < 4; j++)
                {
                    if (i == 0)
                    {
                        this.Controls.Add(m_GameButtons.m_GameRows[i].m_GuessButtons[j]); // to enable only the first row of guesses
                        this.Controls.Add(m_GameButtons.m_GameRows[i].m_ResultButtons[j]);
                    }
                    else
                    {
                        m_GameButtons.m_GameRows[i].m_GuessButtons[j].Enabled = false;  //disable all rows that are not 0
                        this.Controls.Add(m_GameButtons.m_GameRows[i].m_GuessButtons[j]);
                        this.Controls.Add(m_GameButtons.m_GameRows[i].m_ResultButtons[j]);
                        
                    }
                }
            }
            InitializeComponent();
            
        }

        private void sequenceColorButtonGenerator()
        {
            for (int i = 0; i < 4; i++)
            {
                Button SequenceColor = new Button();
                SequenceColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
                SequenceColor.Location = new System.Drawing.Point(17 + (53*i), 10);
                SequenceColor.Name = "i";
                SequenceColor.Size = new System.Drawing.Size(49, 44);
                SequenceColor.TabIndex = 0;
                SequenceColor.Text = " ";
                SequenceColor.UseVisualStyleBackColor = false;
                SequenceColor.Enabled = false;
                m_SequenceColors.Add(SequenceColor);
                this.Controls.Add(SequenceColor);
            }
        }

        ButtonColorForm buttonColorForm = new ButtonColorForm();

        private void gameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
