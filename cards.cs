namespace Blackjack
{
    public class Card
    {
        public string val {get
        {
            if(numVal > 1 && numVal < 11)
            {
                return numVal.ToString();
            }
            else if (numVal == 11)
            {
                numVal = 10;
                return "Jack";
            }
            else if (numVal == 12)
            {
                numVal = 10;
                return "Queen";
            }
            else if (numVal == 13)
            {
                numVal = 10;
                return "King";
            }
            else
            {
                numVal = 11;
                return "Ace";
            }
        }
        }
        public int numVal;
        public string suit;
        public Card(string s, int num)
        {
            suit = s;
            numVal = num;
        }
        public override string ToString()
        {
            return val + " of " + suit;
        }
    }
}