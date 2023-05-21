Person<string> person1 = new Person<string>("34");
Person<int> person3 = new UniversalPerson<int>(45);
UniversalPerson<int> person2 = new UniversalPerson<int>(33);
Console.WriteLine(person1.Id);
Console.WriteLine(person2.Id);
Console.WriteLine(person3.Id);

Console.WriteLine(new string('-', 80));

StringPerson person4 = new StringPerson("438767");
Person<string> person5 = new StringPerson("43875");
// Belə yazmaq olmaz
//Person<int> person6 = new StringPerson("45545");
Console.WriteLine(person4.Id);
Console.WriteLine(person5.Id);

Console.WriteLine(new string('-', 80));

IntPerson<string> person7 = new IntPerson<string>(5, "r4556");
Person<int> person8 = new IntPerson<long>(7, 4587);
Console.WriteLine(person7.Id);
Console.WriteLine(person8.Id);

Console.WriteLine(new string('-', 80));

MixedPerson<string, int> person9 = new MixedPerson<string, int>("456", 356);
Person<string> person10 = new MixedPerson<string, int>("9867", 35678);
Console.WriteLine(person9.Id);
Console.WriteLine(person10.Id);

class Person<T>
{
    public T Id { get; }
    public Person(T id)
    {
        Id = id;
    }
}

// Birinci variant
class UniversalPerson<T> : Person<T>
{
    public UniversalPerson(T id) : base(id) { }
}

// Və ya birbaşa base tipini verməliyik, amma StringPerson klası özü generik olmur
class StringPerson : Person<string>
{
    public StringPerson(string id) : base(id) { }
}

// Və ya base klas və törəyən klas hər ikisi generic olur
class IntPerson<T> : Person<int>
{
    public T Code { get; set; }
    public IntPerson(int id, T code) : base(id)
    {
        Code = code;
    }
}

// Törəyən klasa ikinci generic tip veririk
class MixedPerson<T, K> : Person<T> where K : struct
{
    public K Code { get; set; }
    public MixedPerson(T id, K code) : base(id)
    {
        Code = code;
    }
}