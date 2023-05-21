Person<int>.Code = new Random().Next(100, 1000);

Person<int> person1 = new Person<int>();
person1.Id = 1;

Person<string> person2 = new Person<string>();
person2.Id = "1";

class Person<T>
{
    // Static field generic ola bilər.
    public static T Code;
    public T Id { get; set; }
    public string Name { get; set; }
    public Person(T id, string name)
    {
        Id = id;
        Name = name;
    }

    public Person() { }
}