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
    }
}
