var cat_1 = new Cat("Anya", 30, Gender.Female);
var cat_2 = new Cat("Vadim", 4, Gender.Male);
var cat_3 = new Cat("Vadim", 70, Gender.Male);
Console.WriteLine(cat_1.ToString());
Console.WriteLine(cat_2.ToString());
Console.WriteLine(cat_3.ToString());

public class Cat
{
    
    private static long _lastId = 0;
    private long _id;
    private string _name;
    private byte _age;
    private Gender _gender;

    public Cat(string name = "None", byte age = 0, Gender gender = Gender.Unknown)
    {
        _id = _lastId;
        _lastId += 1;
        if (name.Length >= 3 && name.Length <= 10)
        {
            _name = name;
        }

        if (age >= 0 && age <= 20)
        {
            _age = age;
        }

        _gender = gender;
    }


    public override string ToString()
    {
        return $"{base.ToString()} ( ID:{_id}, Name:{_name}, Age:{_age}, Gender:{_gender} )";
    }
}
public enum Gender
{
    Unknown,
    Male,
    Female
}



