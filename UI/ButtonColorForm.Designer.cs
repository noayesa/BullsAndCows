namespace UI
{
    partial class ButtonColorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.purple = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.Button();
            this.aqua = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.yellow = new System.Windows.Forms.Button();
            this.brown = new System.Windows.Forms.Button();
            this.white = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // purple
            // 
            this.purple.BackColor = System.Drawing.Color.Purple;
            this.purple.Location = new System.Drawing.Point(25, 18);
            this.purple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.purple.Name = "purple";
            this.purple.Size = new System.Drawing.Size(60, 60);
            this.purple.TabIndex = 0;
            this.purple.UseVisualStyleBackColor = false;
            this.purple.Click += new System.EventHandler(this.purple_Click);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.Location = new System.Drawing.Point(91, 18);
            this.red.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(60, 60);
            this.red.TabIndex = 1;
            this.red.UseVisualStyleBackColor = false;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Lime;
            this.green.Location = new System.Drawing.Point(158, 18);
            this.green.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(60, 60);
            this.green.TabIndex = 2;
            this.green.UseVisualStyleBackColor = false;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // aqua
            // 
            this.aqua.BackColor = System.Drawing.Color.Aqua;
            this.aqua.Location = new System.Drawing.Point(223, 18);
            this.aqua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aqua.Name = "aqua";
            this.aqua.Size = new System.Drawing.Size(60, 60);
            this.aqua.TabIndex = 3;
            this.aqua.UseVisualStyleBackColor = false;
            this.aqua.Click += new System.EventHandler(this.aqua_Click);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Blue;
            this.blue.Location = new System.Drawing.Point(25, 84);
            this.blue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(60, 60);
            this.blue.TabIndex = 4;
            this.blue.UseVisualStyleBackColor = false;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Yellow;
            this.yellow.Location = new System.Drawing.Point(91, 84);
            this.yellow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(60, 60);
            this.yellow.TabIndex = 5;
            this.yellow.UseVisualStyleBackColor = false;
            this.yellow.Click += new System.EventHandler(this.yellow_Click);
            // 
            // brown
            // 
            this.brown.BackColor = System.Drawing.Color.Brown;
            this.brown.Location = new System.Drawing.Point(158, 84);
            this.brown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brown.Name = "brown";
            this.brown.Size = new System.Drawing.Size(60, 60);
            this.brown.TabIndex = 6;
            this.brown.UseVisualStyleBackColor = false;
            this.brown.Click += new System.EventHandler(this.brown_Click);
            // 
            // white
            // 
            this.white.BackColor = System.Drawing.Color.White;
            this.white.Location = new System.Drawing.Point(223, 84);
            this.white.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(60, 60);
            this.white.TabIndex = 7;
            this.white.UseVisualStyleBackColor = false;
            this.white.Click += new System.EventHandler(this.white_Click);
            // 
            // ButtonColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 165);
            this.Controls.Add(this.white);
            this.Controls.Add(this.brown);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.aqua);
            this.Controls.Add(this.green);
            this.Controls.Add(this.red);
            this.Controls.Add(this.purple);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ButtonColorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pick A Color:";
            this.Load += new System.EventHandler(this.ButtonColorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button purple;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button green;
        private System.Windows.Forms.Button aqua;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button yellow;
        private System.Windows.Forms.Button brown;
        private System.Windows.Forms.Button white;
    }
}