MyClass<Empty> instance = new MyClass<Empty>();

// XƏTA
//MyClass<int> instance2 = new MyClass<int>();

class Empty { }

class MyClass<T> where T : class
{ 

}