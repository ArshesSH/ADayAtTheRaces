using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DayAtTheRace
{
    public class Greyhound
    {
        public Greyhound(Random RandomIn, PictureBox PicturBoxIn, int RaceTrackLengthIn)
        {
            randomizer = RandomIn;
            pictureBox = PicturBoxIn;
            raceTrackLength = RaceTrackLengthIn;
            startPos = pictureBox.Location.X;
            curPos = startPos;
        }

        // Member funcs
        public bool Run()
        {
            // Move forward either 1, 2, 3, or 4 space at random
            curPos += randomizer.Next( 1, 5 );

            // Update the position of pictureBox on the form
            UpdatePicturBoxAsCurPos();
            pictureBox.Update();

            // Return true if This won the race
            if(curPos >= raceTrackLength - pictureBox.Width - raceFinPos)
            {
                return true;
            }
            return false;
        }

        public void ResetStartPos()
        {
            // Reset Location to start line
            curPos = startPos;
            UpdatePicturBoxAsCurPos();
            pictureBox.Update();
        }

        private void UpdatePicturBoxAsCurPos()
        {
            Point p = pictureBox.Location;
            p.X = curPos;
            pictureBox.Location = p;
        }


        // Memeber vars
        private readonly int raceFinPos = 30;
        public PictureBox pictureBox = null;
        public Random randomizer = null;
        public int startPos;
        public int raceTrackLength;
        public int curPos;
    }
}
