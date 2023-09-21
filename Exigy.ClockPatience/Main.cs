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

            var piles = PileHelper.FillPilesWithInputList(inputList, MaxNumberOfPiles);

            foreach( var pile in piles )
            {
                foreach( var card in pile.Cards )
                {
                    Console.WriteLine(card);
                }
            }
        }
    }
}
