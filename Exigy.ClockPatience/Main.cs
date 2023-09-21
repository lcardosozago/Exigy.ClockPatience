using Exigy.ClockPatience.Helpers;

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

            Console.WriteLine(inputList.Count);
        }
    }
}
