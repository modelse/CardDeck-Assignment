namespace DeckofCards
{

    public class Card
        {
            public string stringVal{
                get{
                    if(val>1 && val<11)
                    {
                        return val.ToString();
                    }
                    else if(val==11)
                    {
                        return "Jack";
                    }
                    else if(val==12)
                    {
                        return "Queen";
                    }
                    else if (val==13)
                    {
                        return "King";
                    }
                    else if(val==1)
                    {
                        return "Ace";
                    }
                    else{
                        return "Go Fish";
                    }
                }
            }
            public string suit;
            public int val;
            public Card( string suitVal, int numVal)
            {
                suit=suitVal;
                val=numVal;
                
            }
            public override string ToString(){
                return stringVal + " of " + suit;
            }
        }
}