while (true)
{
    Console.Write("What is your level?: ");
    if (int.TryParse(Console.ReadLine(), out int employeeLvl))
    {
        string employeeName = "Chad Thundercock";
        string title;
        switch (employeeLvl)
        {
            case 25:
            case 100:
            case 50:
                title = "Noob";
                break;
            case 200:
                title = "Junior";
                break;
            case 300:
                title = "Medior";
                break;
            case 400:
                title = "Senior";
                break;
            default:
                title = "npc";
                break;
        }

        Console.WriteLine($"{employeeName} is a {title}");
        break;
    }
    else
    {
        Console.WriteLine("Error, enter a valid number.\n");
    }
}
;

//switch expression format makes switch case more readable and shorter to write
// string title = employeeLvl switch
// {
//     25 or 100 or 50 => "Noob",
//     200 => "Junior",
//     300 => "Medior",
//     400 => "Senior",
//     _ => "npc",
// };

string sku = "01-MN-L";

// string sku = "bleh-bleh-s";

string product = sku.Split('-');
Array.ForEach(product, Console.WriteLine);
string type = product[0] switch
{
    "01" => "sweatshirt",
    "02" => "shirt",
    "03" => "pants",
    _ => "loincloth",
};
string color = product[1] switch
{
    "BL" => "black",
    "MN" => "maroon",
    _ => "white",
};
string size = product[2].ToLower() switch
{
    "s" => "small",
    "m" => "medium",
    "l" => "large",
    _ => "fluid",
};

Console.WriteLine($"I want a {size} {type} in {color} color,");
