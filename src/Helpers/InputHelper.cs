namespace Exigy.ClockPatience.Helpers
{
    public static class InputHelper
    {
        public static string ReadAllInputLinesFromConsole()
        {
            string inputStringLine;
            var concatStringResult = "";

            try
            {
                do
                {
                    inputStringLine = Console.ReadLine().Trim();

                    if (inputStringLine == "#") break;

                    concatStringResult = String.Concat(concatStringResult, " ", inputStringLine);
                } while (true);

                return concatStringResult;
            } catch (Exception e)
            {
                throw;
            }
        }

        public static List<string> MapInputStringToReversedList(string stringInput)
        {
            var reversedCardsInputList = stringInput.Split(" ").Reverse().ToList();

            SanitizeList(reversedCardsInputList);

            return reversedCardsInputList;
        }

        public static void ValidateInputListSize(List<string> inputList, int maxNumberOfPiles, int maxNumberOfCardsInAPile)
        {
            var totalCardsInDeck = maxNumberOfPiles * maxNumberOfCardsInAPile;

            if (inputList.Count != totalCardsInDeck) throw new NotImplementedException("Invalid number of cards provided.");
        }

        private static void SanitizeList(List<string> cardsInputList)
        {
            cardsInputList.Remove("");
        }
    }
}
