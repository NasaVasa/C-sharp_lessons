Console.WriteLine("Hello, World!");
int a = 1;
int b = 2;
int sum;
Proj.Sum(ref a, ref b, out sum);
Console.WriteLine(a);

(int x, int y) = Proj.Swap(a, b);
Console.WriteLine(x);
Console.WriteLine(y);


var item1 = new Clothes("T-Shirt", Size.M);
Console.WriteLine(item1);
// .Where( x.Clothes=> LIST.Contains(x.Size)
// .Select
//lambda function
//ValueTuple<int, int>
int[] fe = { 1, 2, 3, 4 };
public class Proj
{
    public static void Sum(ref int x, ref int y, out int su)
    {
        su = x + y;
        Console.WriteLine($"{x}+{y}={su}");
        x += 1;
    }

    public static void Sum(int x, ref int y, out int su)
    {
        su = x + y;
        x += 1;
        Console.WriteLine($"{x}+{y}={su}");
    }

    public static (int, int) Swap(int a, int b)
    {
        return (b, a);
    }
}

public record Clothes(string Name, Size size);

public enum Size
{
    S,
    M,
    L,
    X,
    XL,
    XXL,
    Oversize = 10,
    F = 10
}
