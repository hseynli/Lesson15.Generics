Console.OutputEncoding = System.Text.Encoding.UTF8;
MyClass instance = new MyClass();

instance.Method<string>("Hello world!");

instance.Method("Salam, dünya!");

class MyClass
{
    public void Method<T>(T argument)
    {
        T variable = argument;

        Console.WriteLine(variable);
    }
}