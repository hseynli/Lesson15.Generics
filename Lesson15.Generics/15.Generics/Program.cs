// XƏTA
//MyClass<Empty> instance = new MyClass<Empty>();

MyClass<int> instance2 = new MyClass<int>();

class Empty { }

class MyClass<T> where T : struct
{

}