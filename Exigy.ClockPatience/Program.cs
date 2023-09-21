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

    var reversedCardsInputList = concatStringResult.Split(" ").Reverse().ToList();
    reversedCardsInputList.Remove("");

    Console.WriteLine(reversedCardsInputList.Count);
}
catch (Exception e)
{
    throw;
}