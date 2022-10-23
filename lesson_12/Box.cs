using System.Text.Json;

namespace lesson_12;

public class Box<T>
{
    private List<T> _items { get; }

    public Box(List<T> items)
    {
        _items = items
            .Select(x => x)
            .ToList();
    }

    public Box(int capacity)
    {
        _items = new List<T>(capacity);
    }

    public void AddItem(T item)
    {
        _items.Add(item);
    }

    public override string ToString()
    {
        return JsonSerializer.Serialize(_items);
    }

    public T?[] this[Range range]
    {
        get => _items.ToArray()[range];
    }

    public T this[int index] //[object o]
    {
        get => _items[index];
        set => _items[index] = value;
    }

    public static bool operator ==(Box<T> a, Box<T> b) //(Box<T> a, Box<string> b)
    {
        return Equals(a, b);
    }

    public static bool operator !=(Box<T> a, Box<T> b)
    {
        return !(a == b);
    }

    public static Box<T> operator +(Box<T> a, Box<T> b)
    {
        /*a._items.AddRange((b._items));
        return a;*/
        return new Box<T>(
            a._items
                .Union(b._items) //.Concat(b._items)
                .ToList());
    }

    public static bool operator true(Box<T> a)
    {
        return a._items.Count > 0;
    }

    public static bool operator false(Box<T> a)
    {
        return !a;
    }

    public static bool operator !(Box<T> a)
    {
        return a ? false : true;
    }
}