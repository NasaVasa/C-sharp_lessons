// Регулярки

using System.Text.RegularExpressions;

var text = "12323432ewfcwe45";
var res1 = Regex.IsMatch(text, "^[a-z0-9]{16}$");
Console.WriteLine(res1);
var res2 = Regex.Matches(text, "[0-9]");
foreach (Match match1 in res2)
{
    Console.WriteLine(match1.Value);
}