using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Logic;

namespace UI
{
    internal class Enabler
    {
        internal static void disableRow(List<Button> i_CurrentRow)
        {

            foreach (Button button in i_CurrentRow) 
            {
                button.Enabled = false; // disable
            }
        }

        internal static void enableRow(List<Button> i_CurrentRow)
        {
            foreach (Button button in i_CurrentRow)
            {
                button.Enabled = true; // enable
            }
        }
    }
}
