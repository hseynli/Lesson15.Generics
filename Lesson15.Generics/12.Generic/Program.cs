Point<int> instance = new Point<int>();
Console.WriteLine(instance.Value);

// Strukturlar generic ola bilər.
struct Point<T>
{
    public T Value { get; set; }
}