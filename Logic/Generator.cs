using System;
using System.Collections.Generic;
using System.Text;
using Boardcreator;
//using GameImplement;
using System.Drawing;
namespace Generate
{
    public class Generator
    {
        public static List<Color> GenerateSequence()
        {
            Random rnd = new Random();
            List<Color> Sequence = new List<Color>();
            List<Color> LettersList = new List<Color>(new Color[] { Color.Purple, Color.Red, Color.Lime,
                Color.Aqua, Color.Blue,Color.Yellow, Color.Brown, Color.White });       //allowed colors
            for (int i = 0; i < 4; i++)
            {
                int mIndex = rnd.Next(LettersList.Count);
                Sequence.Add(LettersList[mIndex]);
                LettersList.Remove(LettersList[mIndex]);
            }
            return Sequence;
        }



    }
}
