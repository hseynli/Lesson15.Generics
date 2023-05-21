// int ilə doldurulmuş MyClass tipinin instance-nı yaradırıq.
MyClass<int> instance1 = new MyClass<int>();
instance1.Method();

// long ilə doldurulmuş MyClass tipinin instance-nı yaradırıq.
MyClass<long> instance2 = new MyClass<long>();
instance2.Method();

// string ilə doldurulmuş MyClass tipinin instance-nı yaradırıq.
MyClass<string> instance3 = new MyClass<string>();
instance3.field = "ABC";
instance3.Method();


class MyClass<T>
{
    public T field;

    public void Method()
    {
        Console.WriteLine(field.GetType());
    }
}