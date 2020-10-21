using System;
using System.Collections.Generic;
using System.Text;
using Generate;
using System.Drawing;
namespace Boardcreator
{
    public class Board
    {
        public List<Color> colorSequence;
        public int NumRows;
        public Board(int io_NumRows)
        {
            this.NumRows = io_NumRows;
            this.colorSequence = Generator.GenerateSequence();
        }

    }
}