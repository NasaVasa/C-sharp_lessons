//var s = File.ReadLines("file.txt");
//var sAsync=await File.ReadAllBytesAsync("file.txt"); // await - подожди

using HttpClient client = new HttpClient();

var responses = Enumerable
    .Range(0, 10000)
    .Select(async (x, i) =>
        {
            Console.WriteLine($"{i} requests sended");
            var res0 = await client.GetAsync("http://ya.ru");
            Console.WriteLine($"{i} response received {res0.StatusCode}");
        }
    );  
Task.WaitAll(responses.ToArray());


var res = client.GetAsync("http://google.com");
var res2 = client.GetAsync("http://ya.ru");
var res3 = client.GetAsync("http://mail.ru");
var (res_1, res_2, res_3) =
    (await res, await res2, await res3);
Console.WriteLine(res_1);
var cts = new CancellationTokenSource(TimeSpan.FromSeconds(2));
var ct = cts.Token;
await Task.Delay(2000, ct);

var str = await res_1.Content.ReadAsStringAsync();
//Console.WriteLine(str);


return 228;

/*
public static async Task<string> InnerMain()
{
    return null;
}*/