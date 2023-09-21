string inputStringLine;
var concatStringResult = "";

var maxNumberOfPiles = 13;
var maxNumberOfCardsInAPile = 4;

try
{
    do
    {
        inputStringLine = Console.ReadLine().Trim();

        if (inputStringLine == "#") break;

        concatStringResult = String.Concat(concatStringResult, " ", inputStringLine);
    } while (true);

    var reversedCardsInputList = concatStringResult.Split(" ").Reverse().ToList();
    reversedCardsInputList.Remove("");

    var totalCardsInDeck = maxNumberOfPiles * maxNumberOfCardsInAPile;

    Console.WriteLine(reversedCardsInputList.Count);

    if (reversedCardsInputList.Count != totalCardsInDeck) throw new NotImplementedException("Invalid number of cards provided.");
}
catch (Exception e)
{
    throw;
}