using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRace
{
    public partial class Form1 : Form
    {
        private Guy[] guys = new Guy[3];
        private int curGuyNum = 0;
        private Greyhound[] dogs = new Greyhound[4];
        private readonly int startCash = 10;

        public Form1()
        {
            InitializeComponent();
            guys[0] = new Guy( "Joe", startCash, radioButtonBetter1, labelInform1 );
            guys[1] = new Guy( "Bob", startCash, radioButtonBetter2, labelInform2 );
            guys[2] = new Guy( "Al", startCash, radioButtonBetter3, labelInform3 );

            Random random = new Random();
            dogs[0] = new Greyhound( random, pictureBoxDog1, raceTrack.Width );
            dogs[1] = new Greyhound( random, pictureBoxDog2, raceTrack.Width );
            dogs[2] = new Greyhound( random, pictureBoxDog3, raceTrack.Width );
            dogs[3] = new Greyhound( random, pictureBoxDog4, raceTrack.Width );

            // Set Default label to first guys Name
            labelBetterName.Text = guys[0].Name;
        }

        private void radioButtonBetter1_CheckedChanged( object sender, EventArgs e )
        {
            labelBetterName.Text = guys[0].Name;
            curGuyNum = 0;
        }

        private void radioButtonBetter2_CheckedChanged( object sender, EventArgs e )
        {
            labelBetterName.Text = guys[1].Name;
            curGuyNum = 1;
        }

        private void radioButtonBetter3_CheckedChanged( object sender, EventArgs e )
        {
            labelBetterName.Text = guys[2].Name;
            curGuyNum = 2;
        }

        private void numericUpDownCash_ValueChanged( object sender, EventArgs e )
        {
            labelMinimumBet.Text = "Minimum bet: " + numericUpDownCash.Value  + " Bucks";

        }

        private void buttonRace_Click( object sender, EventArgs e )
        {
            bool isRaceFinished = false;
            while ( !isRaceFinished )
            {
                for ( int i = 0; i < dogs.Length; ++i )
                {
                    if ( dogs[i].Run() )
                    {
                        foreach(Guy guy in guys)
                        {
                            guy.Collect( i );
                        }
                        System.Windows.Forms.MessageBox.Show( "We have a winner - dog #" + (i + 1) + "!" );

                        isRaceFinished = true;
                        break;
                    }
                    raceTrack.Update();
                }
            }

            foreach(Greyhound dog in dogs)
            {
                dog.ResetStartPos();
            }
        }

        private void buttonBets_Click( object sender, EventArgs e )
        {
            if (guys[curGuyNum].PlaceBet( (int)numericUpDownCash.Value, (int)numericUpDownDogNum.Value - 1 ))
            {
                guys[curGuyNum].UpdateLabels();
            }
        }

    }
}
