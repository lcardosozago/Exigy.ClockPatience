using Exigy.ClockPatience.Enums;
using Exigy.ClockPatience.Models;

namespace Exigy.ClockPatience.Helpers
{
    public static class PileHelper
    {
        public static List<Pile> FillPilesWithInputList(
            List<string> inputList,
            int maxNumberOfPiles
        )
        {
            var piles = new List<Pile>();

            var pilePosition = 1;
            var cardPilePosition = 1;

            foreach (var inputCardString in inputList)
            {
                if (pilePosition - 1 == maxNumberOfPiles)
                {
                    pilePosition = 1;
                }

                if (inputCardString.Length != 2) throw new NotImplementedException("Unexpected value in array.\n");

                if (piles.Count < maxNumberOfPiles)
                {
                    piles.Add(new Pile(pilePosition));
                }

                var rank = inputCardString[0];
                var suit = inputCardString[1];

                var card = new Card(rank, suit);

                var pile = piles.Find(p => p.PositionId == pilePosition) ?? throw new NotImplementedException($"Could not find pile at \"{pilePosition}\" position.\n");

                pile.Cards.Add(card);

                pilePosition++;
            }

            return piles;
        }

        public static void StartExposingCards(List<Pile> piles, int maxNumberOfPiles, int maxNumberOfCardsInAPile)
        {
            var exposedCards = 0;
            var exposedKings = 0;

            var nextPilePosition = maxNumberOfPiles;

            while (true)
            {
                var pile = piles.Find(p => p.PositionId == nextPilePosition) ?? throw new NotImplementedException($"Could not find pile at \"{nextPilePosition}\" position.\n");
                var topCardFromPile = pile.Cards.Last();
                pile.Cards.Remove(topCardFromPile);

                nextPilePosition = piles.Find(p => p.PositionId == topCardFromPile.Rank.GetHashCode()).PositionId;

                exposedCards++;
                if (topCardFromPile.Rank == CardRankEnum.KING)
                {
                    exposedKings++;
                    if (exposedKings == maxNumberOfCardsInAPile)
                    {
                        var formattedExposedCards = exposedCards switch
                        {
                            >= 0 and < 10 => "0" + exposedCards,
                            _ => exposedCards.ToString()
                        };

                        PrintResult(formattedExposedCards, topCardFromPile.MapToString());

                        return;
                    }
                }
            }
        }

        private static void PrintResult(string numberOfExposedCardsString, string cardString)
        {
            Console.WriteLine($"{numberOfExposedCardsString},{cardString}");
        }
    }
}
