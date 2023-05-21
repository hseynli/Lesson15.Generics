Worker<BaseClass> instance1 = new Worker<BaseClass>();
Worker<DerivedClass> instance2 = new Worker<DerivedClass>();

// XƏTA
//Worker<Temp> instance3 = new Worker<Temp>();

class BaseClass { }
class DerivedClass : BaseClass { }

class Worker<T> where T : BaseClass, new() { }

class Temp 
{
    public Temp() { }
}