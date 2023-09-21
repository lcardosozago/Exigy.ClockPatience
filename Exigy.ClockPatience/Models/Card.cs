using Exigy.ClockPatience.Enums;

namespace Exigy.ClockPatience.Models
{
    public class Card
    {
        private readonly Dictionary<char, CardRankEnum> acceptedRankCharactersMap = new Dictionary<char, CardRankEnum>()
        {
            { 'A', CardRankEnum.ACE },
            { '2', CardRankEnum.TWO },
            { '3', CardRankEnum.THREE },
            { '4', CardRankEnum.FOUR },
            { '5', CardRankEnum.FIVE },
            { '6', CardRankEnum.SIX },
            { '7', CardRankEnum.SEVEN },
            { '8', CardRankEnum.EIGHT },
            { '9', CardRankEnum.NINE },
            { 'T', CardRankEnum.TEN },
            { 'J', CardRankEnum.JACK },
            { 'Q', CardRankEnum.QUEEN },
            { 'K', CardRankEnum.KING }
        };

        private readonly Dictionary<char, CardSuitEnum> acceptedSuitCharactersMap = new Dictionary<char, CardSuitEnum>()
        {
            { 'H', CardSuitEnum.HEARTS },
            { 'D', CardSuitEnum.DIAMONDS },
            { 'C', CardSuitEnum.CLUBS },
            { 'S', CardSuitEnum.SPADES }
        };

        public CardRankEnum Rank { get; private set; }
        public CardSuitEnum Suit { get; private set; }

        public Card(char rank, char suit)
        {
            SetRank(rank);
            SetSuit(suit);
        }

        private void SetRank(char rank)
        {
            if (!acceptedRankCharactersMap.ContainsKey(rank)) throw new NotImplementedException($"Unexpected character \"{rank}\" for card rank.\n");

            Rank = acceptedRankCharactersMap[rank];
        }
        private void SetSuit(char suit)
        {
            if (!acceptedSuitCharactersMap.ContainsKey(suit)) throw new NotImplementedException($"Unexpected character \"{suit}\" for card suit.\n");

            Suit = acceptedSuitCharactersMap[suit];
        }
    }
}
