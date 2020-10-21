using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Logic
{
    public class Checker
    {
        public static int[] compareGuess(List<Button> i_CurrentGuess, List<Color> i_Sequence)
        {
            int[] o_accuracy = new int[2];
            for (int i = 0; i < 4; i++) // length of the row
            {
                for(int j = 0; j < 4; j++)
                {
                    if(i_CurrentGuess[i].Name == i_Sequence[j].Name)
                    {
                        if(i == j)
                        {
                            o_accuracy[0]++; // same color and same position
                        }
                        else
                        {
                            o_accuracy[1]++; // same color but different position in row
                        }
                        
                    }
                }
            }
            return o_accuracy;
        }



        public static bool colorDuplicationChecker(List<Button> i_CurrentGuess)
        {
            if(i_CurrentGuess[0].BackColor != SystemColors.Control ) // since they are all gray in the beginning, we want to ignore them both being gray
            {
                if (i_CurrentGuess[0].BackColor == i_CurrentGuess[1].BackColor)
                {
                    return false;
                }
                if (i_CurrentGuess[0].BackColor == i_CurrentGuess[2].BackColor)
                {
                    return false;
                }
                if (i_CurrentGuess[0].BackColor == i_CurrentGuess[3].BackColor)
                {
                    return false;
                }


            }

            if (i_CurrentGuess[1].BackColor != SystemColors.Control) // since they are all gray in the beginning, we want to ignore them both being gray
            {
                if (i_CurrentGuess[1].BackColor == i_CurrentGuess[2].BackColor)
                {
                    return false;
                }
                if (i_CurrentGuess[1].BackColor == i_CurrentGuess[3].BackColor)
                {
                    return false;
                }
                                
            }
            if (i_CurrentGuess[1].BackColor != SystemColors.Control && i_CurrentGuess[2].BackColor == i_CurrentGuess[3].BackColor)// since they are all gray in the beginning, we want to ignore them both being gray
            {
                return false;
            }
            
             return true;
        }


        public static bool GrayButtonChecker(List<Button> i_CurrentGuess) // returns true if they are NOT gray
        {
            for (int i = 0; i < 4; i++)
            {
                if(i_CurrentGuess[i].BackColor == SystemColors.Control)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool AllTrueGuesses(List<Button> resultButtons)
        {
            int count = 0;
            foreach (Button button in resultButtons)
            {
                if (button.Name == "Black")
                {
                    count++;
                }
            }
            if (count == resultButtons.Count)
            {
                return true;
            }
            return false;
        }
        public static bool NoMoreGuesses(int rownumber,int gamesize)
        {
            if(rownumber < gamesize) { 
                return false;
            }
            return true;
        }

    }
}
