using Exigy.ClockPatience.Helpers;
using Exigy.ClockPatience.Models;

namespace Exigy.ClockPatience
{
    public static class Main
    {
        private const int MaxNumberOfPiles = 13;
        private const int MaxNumberOfCardsInAPile = 4;

        public static void Run()
        {
            var inputString = InputHelper.ReadAllInputLinesFromConsole();

            var inputList = InputHelper.MapInputStringToReversedList(inputString);

            InputHelper.ValidateInputListSize(inputList, MaxNumberOfPiles, MaxNumberOfCardsInAPile);

            var piles = new List<Pile>();

            var pilePosition = 1;
            var cardPilePosition = 1;

            foreach (var inputCardString in inputList)
            {
                if (pilePosition - 1 == MaxNumberOfPiles)
                {
                    pilePosition = 1;
                }

                if (inputCardString.Length != 2) throw new NotImplementedException("Unexpected value in array.\n");

                if (piles.Count < MaxNumberOfPiles)
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

            foreach(var pile in piles)
            {
                foreach(var card in pile.Cards)
                {
                    Console.WriteLine(card);
                }
            }
        }
    }
}
