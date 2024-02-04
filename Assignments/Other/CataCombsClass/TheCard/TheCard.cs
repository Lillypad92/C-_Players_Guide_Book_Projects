using System.Drawing;

namespace The_C__player_s_guide.Assignments.Other.CataCombsClass.TheCard
{
    public enum CardColors { Red, Green, Blue, Yellow }
    public enum CardType { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Caret, AmperSand }

    
    public class TheCard
    {
        public CardColors Color { get; }
        public CardType Rank { get; }

        public TheCard(CardColors color, CardType rank) 
        {
            Color = color; 
            Rank = rank; 
        }

        public TheCard()
        {
        }

        public bool IsNumber() => Rank <= CardType.Ten;

        public bool IsSymbol() => !IsNumber();

        public void Run() 
        { 
            for (int CardColors = 0; CardColors < 4; CardColors++) 
            {
                for (int CardTypes = 0; CardTypes < 14; CardTypes++) 
                { 
                    TheCard cards = new TheCard((CardColors)CardColors, (CardType)CardTypes);
                    Console.WriteLine($" The {cards.Color} {cards.Rank}");
                }
            }
        }
    }
}
