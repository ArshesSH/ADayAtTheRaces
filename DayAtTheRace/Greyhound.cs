using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DayAtTheRace
{
    class Greyhound
    {
        // Member funcs
        public bool Run()
        {
            // Move forward either 1, 2, 3, or 4 space at random
            curPos += randomizer.Next( 1, 4 );

            // Update the position of pictureBox on the form
            Point p = pictureBox.Location;
            p.X = curPos;
            pictureBox.Location = p;

            // Return true if This won the race
            if(curPos >= raceTrackLength)
            {
                return true;
            }
            return false;
        }

        public void ResetStartPos()
        {
            // Reset Location to start line
            curPos = startPos;
        }


        // Memeber vars
        public PictureBox pictureBox = null;
        public Random randomizer = null;
        public int startPos = 0;
        public int raceTrackLength = 0;
        public int curPos = 0;
    }
}
