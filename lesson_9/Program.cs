// Наследование

var Marusya = new Cat();
var animal1 = (Animal)Marusya;
Animal animal2 = new Cat();
Cat Loh = (Cat)animal2;
Console.WriteLine(Loh.status);
//Cat Vasya = new Animal();           exeption
//var Bobik = Marusya as Dog;         NULL
//var Bobik = (Dog)Marusya;           exeption
Console.WriteLine(Marusya.s);
Console.WriteLine("_________________");

var cat1 = new Cat();
Console.WriteLine(cat1.status);
var ani1 = (Animal)cat1;
Console.WriteLine(ani1.status);

public class Animal //:Object
{
    public string s = "ABOBA";
    public string status = "I am an animal";
}

public class Cat : Animal
{
    public string status = "I am a cat";
}

public class Dog : Animal
{
}