using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Logic;

namespace UI {
    public class GameRow
    {
        internal List<Button> m_GuessButtons;
        internal List<Button> m_ResultButtons;
        internal Button m_PointerToAccuracy;
        private List<Color> m_colorsGenerated;
        internal int m_RowNumber;
        public GameButtons m_Game;
        public GameForm m_GameForm;
        internal GameRow(int i_RowLocation,int i_RowNumber)
        {
            m_RowNumber = i_RowNumber + 1;
            m_PointerToAccuracy = new Button();
            PointerToAccuracyGenerator(i_RowLocation, m_PointerToAccuracy);
            m_ResultButtons = new List<Button>();
            m_GuessButtons = new List<Button>();
            for (int i = 0; i < 4; i++)
            {
                guessButtonGenerator(i_RowLocation, i, new Button());   
                ResultButtonGenerator(i_RowLocation, i, new Button());
            }
            
        }

        public List<Color> ColorsGenerated
        {
            get{ return m_colorsGenerated;}
            set{ m_colorsGenerated = value;}
        }

        private void ResultButtonGenerator(int i_RowLocation, int i, Button i_ResultButton)
        {
            i_ResultButton.BackColor = System.Drawing.SystemColors.Control;
            if (i == 1)
            {
                i_ResultButton.Location = new System.Drawing.Point(326, 4 + i_RowLocation);
            }
            else if(i==0)
            {
                i_ResultButton.Location = new System.Drawing.Point(300, 4 + i_RowLocation);
            }
            else if(i == 2){
                i_ResultButton.Location = new System.Drawing.Point(300, 27 + i_RowLocation);
            }
            else
            {
                i_ResultButton.Location = new System.Drawing.Point(326, 27 + i_RowLocation);
            }
            i_ResultButton.Name = "button24";
            i_ResultButton.Size = new System.Drawing.Size(20, 18);
            i_ResultButton.TabIndex = 27;
            i_ResultButton.Text = " ";
            i_ResultButton.UseVisualStyleBackColor = false;
            i_ResultButton.Enabled = false;
            m_ResultButtons.Add(i_ResultButton);
            
        }

        private void guessButtonGenerator(int i_RowLocation, int i, Button i_GuessButton)
        {

            i_GuessButton.BackColor = SystemColors.Control;
            i_GuessButton.Location = new Point(14 + (54 * i), i_RowLocation);
            i_GuessButton.Width = 50;
            i_GuessButton.Height = 50;
            i_GuessButton.Click += new System.EventHandler(this.guessButton_Click);
            m_GuessButtons.Add(i_GuessButton);
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            Button Buttonclicked = sender as Button;
            ButtonColorForm buttonColorForm = new ButtonColorForm();
            buttonColorForm.ShowDialog();

            if (!colorWasChosen(buttonColorForm))
            {
                Buttonclicked.BackColor = buttonColorForm.color;
                Buttonclicked.Name = buttonColorForm.Name;
                if (Checker.GrayButtonChecker(m_GuessButtons))
                {
                    m_PointerToAccuracy.ForeColor = Color.Black;
                    m_PointerToAccuracy.Enabled = true;
                }
            }
            
        }

        private bool colorWasChosen(ButtonColorForm buttonColorForm)
        {
            bool check = false;
            foreach (Button button in m_GuessButtons)
            {
                if (button.BackColor == buttonColorForm.color)
                {
                    return true;
                }
            }
            
            return check;
        }

        private void PointerToAccuracyGenerator(int i_RowLocation, Button i_PointerToAccuracy)
        {
            this.m_PointerToAccuracy.BackColor = System.Drawing.SystemColors.Control;
            this.m_PointerToAccuracy.ForeColor = System.Drawing.Color.Silver;
            this.m_PointerToAccuracy.Location = new System.Drawing.Point(237, i_RowLocation+10);
            this.m_PointerToAccuracy.Name = "PointerToAccuracy";
            this.m_PointerToAccuracy.Size = new System.Drawing.Size(55, 29);
            this.m_PointerToAccuracy.TabIndex = 23;
            this.m_PointerToAccuracy.Text = " -->>";
            this.m_PointerToAccuracy.UseVisualStyleBackColor = false;
            i_PointerToAccuracy.Click += new System.EventHandler(this.pointerToAccuracy_Click);
            i_PointerToAccuracy.Enabled = false;
        }

        private void pointerToAccuracy_Click(object sender, EventArgs e)
        {
            int[] AccuracyCount = new int[2];
            AccuracyCount = Checker.compareGuess(m_GuessButtons, ColorsGenerated);
            for (int  i = 0;  i < AccuracyCount[0];  i++)
            {
                m_ResultButtons[i].BackColor = Color.Black;
                m_ResultButtons[i].Name = "Black";
            }

            for (int j = 0; j < AccuracyCount[1]; j++)
            {
                m_ResultButtons[j + AccuracyCount[0]].BackColor = Color.Yellow;
                m_ResultButtons[j + AccuracyCount[0]].Name = "Yellow";
            }
            if (Checker.AllTrueGuesses(m_ResultButtons))
            {
                WinningForm WinningForm = new WinningForm();
                showSequence(m_GameForm);
                WinningForm.ShowDialog();
            }
            else { 
                if (Checker.NoMoreGuesses(m_RowNumber, m_Game.m_GameRows.Count))
                {
                    LosingForm losingForm = new LosingForm();
                    Enabler.disableRow(this.m_GuessButtons);
                    showSequence(m_GameForm);
                    losingForm.ShowDialog();
                }
                else {
                    this.m_GameForm.m_GameButtons.NextRow(m_RowNumber);         //disable this row and enable next row
                }
            }
        }

        private void showSequence(GameForm i_gameForm)
        {
            for (int i = 0; i < m_GameForm.m_SequenceColors.Count; i++)
            {
                m_GameForm.m_SequenceColors[i].BackColor = m_GameForm.m_Board.colorSequence[i];
            }
        }
    }
}
