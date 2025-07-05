CardColor[] cardColors = new[] { CardColor.Red, CardColor.Green, CardColor.Blue, CardColor.Yellow };
CardRank[] cardRanks = new[] { CardRank.One, CardRank.Two, CardRank.Three, CardRank.Four, CardRank.Five, CardRank.Six, CardRank.Seven, CardRank.Eight, CardRank.Nine, CardRank.Ten, CardRank.Jack, CardRank.Queen, CardRank.King, CardRank.Ace };

foreach (CardColor color in cardColors)
{
    foreach (CardRank rank in cardRanks)
    {
        Card newCard = new(color, rank);
        Console.WriteLine($"{color}{rank}");
    }
}

public class Card
{
    public CardColor Color { get; }
    public CardRank Rank { get; }

    public Card(CardColor color, CardRank rank)
    {
        Color = color;
        Rank = rank;
    }

    public bool IsFace => Rank == CardRank.Ace || Rank == CardRank.King || Rank == CardRank.Queen || Rank == CardRank.Jack;
    public bool IsNumber => !IsFace;
}

public enum CardColor { Red, Green, Blue, Yellow }
public enum CardRank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }
