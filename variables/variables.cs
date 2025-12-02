//Utilizing variables
var firstName = "Bob";
var numberOfMessages = 3;
var temperature = 34.4;

string templateMessage =
    $"Hello, {firstName}! You have {numberOfMessages} messages in your inbox. The temperature is {temperature} celsius.";
Console.WriteLine(templateMessage);

string verbatimString =
    @"This is a verbatim string('@' prefix),
next lines, illegal sequences (escape '\s') etc. are printed, verbatim";
Console.WriteLine(verbatimString);

Console.Write("This is a string with \\u escape sequence to generate UTF-16 unicode: ");
var unicodeEscSequenceString = "\u3053\u3093\u306B\u3061\u306F World!";
Console.WriteLine(unicodeEscSequenceString);

Console.WriteLine(@"Verbatim:\u3053\u3093\u306B\u3061\u306F World!");

var ko = "\u3053";
var n = "\u3093";
var ba = "\u3070";
var wa = "\u306F";

//\r is carriage return, a control character that moves the cursor to the beginning of the current line without advancing to the next line
Console.WriteLine($"String interpolation with $ eg: {ko}{n}{ba}{n}{wa} \r STRING");
Console.WriteLine($@"String interpolation with $@ eg: {ko}{n}{ba}{n}{wa} \r STRING");

//Challenge:
string projectName = "ACME";

string russianMessage =
    "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine(
    $@"
View English Output:
    c:\Exercise\{projectName}\data.txt
{russianMessage}:
    c:\Exercise\{projectName}\ru-RU\data.txt"
);
