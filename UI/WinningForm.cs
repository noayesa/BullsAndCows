using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class WinningForm : Form
    {
        public WinningForm()
        {
            InitializeComponent();
        }

        private void AlertForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void restartWinning_Click(object sender, EventArgs e)
        {
            StartForm start = new StartForm();
            this.Hide();
            start.ShowDialog();
        }

        private void exitWinning_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
