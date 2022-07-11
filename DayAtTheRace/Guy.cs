using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace DayAtTheRace
{
    public class Guy
    {
        public class Bet
        {
            public Bet(int AmountIn, int DogNumIn, Guy BetterIn)
            {
                Amount = AmountIn;
                DogNum = DogNumIn;
                Better = BetterIn;
            }
            public string GetDescription()
            {
                // Return a string that says
                // who placed the CurBet,
                // how much Cash was CurBet,
                // and which dog he CurBet on
                // If the Amount is zero, no CurBet was placed

                if( Amount == 0)
                {
                    return Better.Name + " hasn't placed a CurBet";
                }
                return Better.Name + " CurBets "+ Amount +" on dog #" + (DogNum + 1);
            }
            public int PayOut( int DogWinner )
            {
                // The parameter is the winner of the race.
                // If the dog won, return the Amount CurBet.
                // else return the negative of the Amount CurBet
                if( DogWinner == DogNum)
                {
                    return Amount;
                }
                return -Amount;
            }

            // Memeber vars
            public int Amount = 0;
            public int DogNum = 0;
            public Guy Better = null;
        }

        public Guy( string NameIn, int CashIn, RadioButton RadioButtonIn, Label LabelIn )
        {
            Name = NameIn;
            Cash = CashIn;
            RadioButton = RadioButtonIn;
            Label = LabelIn;
            ClearBet();
            UpdateLabels();
        }

        // Memeber Funcs
        public void UpdateLabels()
        {
            // Set Label to my CurBet's description
            // and the Label on my radio button to show my Cash
            Label.Text = CurBet.GetDescription();
            RadioButton.Text = Name + " has " + Cash + " bucks";
        }

        public bool PlaceBet(int AmountIn, int DogNumIn)
        {
            Debug.Assert( DogNumIn >= minDogNum && DogNumIn <= maxDogNum );

            // Place a new CurBet and store it in my CurBet field
            // Return true if the guy has enough money to CurBet
            CurBet = new Bet( AmountIn, DogNumIn, this );

            return (Cash >= AmountIn) ? true : false;
        }

        public void ClearBet()
        {
            // reset CurBet
            CurBet = new Bet( 0, 0, this );
        }

        public void Collect(int winner)
        {
            // ask my CurBet to pay out
            Cash += CurBet.PayOut( winner );
            ClearBet();
            UpdateLabels();
        }


        // Member vars
        private readonly int minDogNum = 0;
        private readonly int maxDogNum = 4;

        public string Name = null;
        public Bet CurBet = null;
        public int Cash = 0;
        public RadioButton RadioButton = null;
        public Label Label = null;
    }
}
