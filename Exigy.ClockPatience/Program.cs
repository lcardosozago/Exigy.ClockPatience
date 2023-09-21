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

    Console.WriteLine(concatStringResult);
}
catch (Exception e)
{
    throw;
}