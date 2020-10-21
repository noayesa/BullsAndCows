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
    public partial class StartForm : Form
    {
        private Button m_Start;
        private Button m_NumberOfChances;

        public StartForm()
        {
            InitializeComponent();
            m_NumberOfChances = new Button();
            m_Start = new Button();
            initializeStartButton();
            initializeNumberOfChancesButton();
        }

        private void initializeStartButton()
        {
            this.m_Start.Location = new System.Drawing.Point(280, 213);
            this.m_Start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_Start.Name = "Start";
            this.m_Start.Size = new System.Drawing.Size(84, 29);
            this.m_Start.TabIndex = 1;
            this.m_Start.Text = "Start";
            this.m_Start.UseVisualStyleBackColor = true;
            this.m_Start.Click += new System.EventHandler(this.startButton_Click);
            this.Controls.Add(m_Start);
        }

        private void initializeNumberOfChancesButton()
        {
            this.m_NumberOfChances.Location = new System.Drawing.Point(33, 83);
            this.m_NumberOfChances.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_NumberOfChances.Name = "NumberOfChances";
            this.m_NumberOfChances.Size = new System.Drawing.Size(331, 40);
            this.m_NumberOfChances.TabIndex = 0;
            this.m_NumberOfChances.Text = "Number of chances: 4";
            this.m_NumberOfChances.UseVisualStyleBackColor = true;
            this.m_NumberOfChances.Click += new System.EventHandler(this.NumberOfChances_Click);
            this.Controls.Add(m_NumberOfChances);
        }

        private void form1_Load(object sender, EventArgs e)
        {
           
        }

        private static int numberOfChances = 4;
        private void NumberOfChances_Click(object sender, EventArgs e)
        {
            numberOfChances++;
            if (numberOfChances == 11)
            {
                numberOfChances = 4;
            }
            m_NumberOfChances.Text = String.Format("Number of Chances: {0}", numberOfChances.ToString());
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            Board board = new Board(numberOfChances);
            List<GameRow> Rows = new List<GameRow>();
            for (int i = 0; i < board.NumRows; i++)
            {
                GameRow row = new GameRow((82 + 52*i),i);
                Rows.Add(row);
            }
            GameButtons gameButtons = new GameButtons(Rows);
            GameForm gameForm = new GameForm(gameButtons,board);
            foreach(GameRow row in gameForm.m_GameButtons.m_GameRows)
            {
                row.m_Game = gameButtons;
                row.m_GameForm = gameForm;
            }
            gameForm.Owner = this;
            this.Hide();
            gameForm.ShowDialog();
        }
    }
}
