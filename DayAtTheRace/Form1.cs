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
        private Guy curGuy;
        private Greyhound[] dogs = new Greyhound[4];

        public Form1()
        {
            InitializeComponent();
            guys[0] = new Guy( "Joe" );
            guys[1] = new Guy( "Bob" );
            guys[2] = new Guy( "Al" );

            labelBetterName.Text = guys[0].name;
        }

        private void radioButtonBetter1_CheckedChanged( object sender, EventArgs e )
        {
            labelBetterName.Text = guys[0].name;
            curGuy = new Guy( guys[0].name );
        }

        private void radioButtonBetter2_CheckedChanged( object sender, EventArgs e )
        {
            labelBetterName.Text = guys[1].name;
            curGuy = new Guy( guys[1].name );
        }

        private void radioButtonBetter3_CheckedChanged( object sender, EventArgs e )
        {
            labelBetterName.Text = guys[2].name;
            curGuy = new Guy( guys[2].name );
        }

        private void numericUpDownCash_ValueChanged( object sender, EventArgs e )
        {

            labelMinimumBet.Text = "Minimum bet: " + numericUpDownCash.Value  + " Bucks";
        }

        private void buttonRace_Click( object sender, EventArgs e )
        {

        }

        private void buttonBets_Click( object sender, EventArgs e )
        {
            
        }

        private void numericUpDownDogNum_ValueChanged( object sender, EventArgs e )
        {
            curGuy.bet.dogNum = numericUpDownDogNum.Value;
        }
    }
}
