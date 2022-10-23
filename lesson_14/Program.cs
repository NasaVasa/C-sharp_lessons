Func<int> f1 = () => new Random().Next();
var f2 = (int x) => new Random(x);
Action<int, int> f3 = (x, y) => Console.WriteLine(x + y);
/*Operation op = null;
op = A.Sum;
op += A.Substract;
op += A.Sum;
op += A.Substract;
op += A.Sum;
op -= A.Substract;
var num1 = 2;
var num2 = 3;
//var res1 = A.Sum(num1, num2);
//var res2 = op(num1, num2);
var res3 = op.Invoke(num1, num2);
Console.WriteLine(res3);

Operation op2 = delegate(int i, int i1) { return i + i1; }; // устарело
Operation op3 = (i, i1) => i + i1;   // актуально

UnoOperation op4 = i => i + 1;

public delegate int Operation(int a, int b);
public delegate int UnoOperation(int a);

public class A
{
    public static int Sum(int n1, int n2)
    {
        Console.WriteLine("SUM");
        return n1 + n2;
    }

    public static int Substract(int n1, int n2)
    {
        Console.WriteLine("SUB");
        return n1 - n2;
    }

    protected delegate int OperationTwo(int a, int b);
}

public class B : A
{
    Operation qwe;
}*/