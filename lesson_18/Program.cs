//await File.ReadAllLinesAsync("///", CancellationToken.None);

/*
using StreamReader sr = new StreamReader("text.txt");
using StreamWriter sw = new StreamWriter("output.txt");
while (sr.EndOfStream is false)
{
    var r = sr.ReadLine();
    //обработка r
    sw.WriteLine(r);
} */

DirectoryInfo di = new DirectoryInfo(".");  //Enviroment.CurrentDirectory  //Enviroment.NewLine 
var a =  di.Parent.Parent.Parent.GetDirectories();
var b = di.Parent.Parent.Parent.GetFiles();
Console.WriteLine(b);
/*
 *
 *
 * 
*/