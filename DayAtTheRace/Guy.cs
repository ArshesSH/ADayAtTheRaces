using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DayAtTheRace
{
    public class Guy
    {
        public class Bet
        {
            public string GetDescription()
            {
                // Return a string that says
                // who placed the bet,
                // how much cash was bet,
                // and which dog he bet on
                // If the amount is zero, no bet was placed

                if( amount == 0)
                {
                    return bettor.name + dogNum;
                }

                return bettor.name +" "+ bettor.cash +" " + dogNum;
            }
            public int PayOut( int dogWinner )
            {
                // The parameter is the winner of the race.
                // If the dog won, return the amount bet.
                // else return the negative of the amount bet
                if( dogWinner == dogNum)
                {
                    return amount;
                }
                return -amount;
            }

            public int amount = 0;
            public int dogNum = 0;
            public Guy bettor = null;
        }

        public Guy( string name_in )
        {
            bet = new Bet();
            name = name_in;
        }

        // Memeber Funcs
        public void UpdateLabels()
        {
            // Set label to my bet's description
            // and the label on my radio button to show my cash
            label = new Label();
            label.Text = bet.GetDescription();


        }

        public void ClearBet()
        {
            // reset bet
        }

        public void Collect(int winner)
        {
            // ask my bet to pay out
            bet.PayOut( winner );

        }


        // Member vars
        public string name = null;
        public Bet bet = null;
        public int cash = 0;

        // For windows form
        public RadioButton radioButton = null;
        public Label label = null;
    }
}
