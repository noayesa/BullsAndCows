using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class ButtonColorForm : Form
    {
        public Color color;
        public ButtonColorForm()
        {
            
            InitializeComponent();
        }

        private void purple_Click(object sender, EventArgs e)
        {
            this.color = Color.Purple;
            this.Name = "Purple";
            this.Hide();
                
        }

        private void ButtonColorForm_Load(object sender, EventArgs e)
        {

        }

        private void red_Click(object sender, EventArgs e)
        {
            this.color = Color.Red;
            this.Name = "Red";
            this.Hide();
        }

        private void green_Click(object sender, EventArgs e)
        {
            this.color = Color.Lime;
            this.Name = "Lime";
            this.Hide();
        }

        private void aqua_Click(object sender, EventArgs e)
        {
            this.color = Color.Aqua;
            this.Name = "Aqua";
            this.Hide();
        }

        private void blue_Click(object sender, EventArgs e)
        {
            this.color = Color.Blue;
            this.Name = "Blue";
            this.Hide();
        }

        private void yellow_Click(object sender, EventArgs e)
        {
            this.color = Color.Yellow;
            this.Name = "Yellow";
            this.Hide();
        }

        private void brown_Click(object sender, EventArgs e)
        {
            this.color = Color.Brown;
            this.Name = "Brown";
            this.Hide();
        }

        private void white_Click(object sender, EventArgs e)
        {
            this.color = Color.White;
            this.Name = "White";
            this.Hide();
        }
    }
}
