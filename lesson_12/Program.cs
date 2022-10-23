using System.Data.SqlTypes;
using System.Text.Json;
using lesson_12;

Box<int> box1 = new Box<int>(new List<int> { 1, 2, 3 });
Box<int> box2 = new Box<int>(new List<int> { 1, 2, 4, 5 });
box1.AddItem(1);
var itemFromBox = box1[3];
Console.WriteLine(box1);
Console.WriteLine(itemFromBox);
Console.WriteLine(box1 + box2);


//if (box1)

/*
Range range1 = new Range(
    new Index(0, false), new Index(10, false));
Range range2 = 0..10;
Console.WriteLine(Equals(range1,range2));
*/

/*
var l = new int[] { 0, 1, 2, 3 };
foreach (var item in l[2..4])   l[2..]    l[1..^1] синтаксическое дерево
{
    Console.WriteLine(item);
}*/


Shape s = new Rectangle();
var area = s.Area;
var rand = s.GetRandom;
Console.WriteLine(area);