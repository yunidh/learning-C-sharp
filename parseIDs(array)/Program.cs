string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderArray = orderStream.Split(",");

List<string> incorrectIDs = new();
List<string> correctIDs = [];
foreach (string id in orderArray)
{
    if (id.Length == 4)
    {
        correctIDs.Add(id);
    }
    else
    {
        incorrectIDs.Add(id);
    }
}

Array.ForEach(correctIDs.ToArray(), Console.WriteLine);
foreach (var id in incorrectIDs)
{
    Console.WriteLine(id + "-error");
}
