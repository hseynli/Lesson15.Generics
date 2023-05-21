MyClass<Empty> instance = new MyClass<Empty>();

MyClass<int> instance2 = new MyClass<int>();

// XƏTA
//MyClass<Temp> instance3 = new MyClass<Temp>();

class Empty { }
class Temp
{
    private Temp() { }
}

// Generic parameter mütləq default konstruktoru olan tip olmalıdır.
class MyClass<T> where T : new()
{

}