MyClass<int> my = new MyClass<int>();
int sum = my.Add(2, 3);

Console.WriteLine(sum);

// Pis kod nümunəsi
class MyClass<T>
{
    // Normal koda çevirmək!
    public T Add(T a, T b)
    {
        if (typeof(T) == typeof(int))
            return (T)(object)((int)(object)a + (int)(object)b);

        if (typeof(T) == typeof(double))
            return (T)(object)((double)(object)a + (double)(object)b);

        return (T)(object)0;
    }
}