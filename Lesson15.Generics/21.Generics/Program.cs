IPerson<int> instance = new Person();
instance.Id = 1;
Console.WriteLine(instance.Id);

Console.WriteLine(new string('-', 80));

GenericPerson<string> person = new GenericPerson<string>();
person.Id = "100";
Console.WriteLine(person.Id);

interface IPerson<T>
{
    T Id { get; set; }
}

class Person : IPerson<int> 
{
    public int Id { get; set; }
}

class GenericPerson<T> : IPerson<T>
{
    public T Id { get; set; }
}