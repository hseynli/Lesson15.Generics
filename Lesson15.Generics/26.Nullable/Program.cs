Nullable<int> a = 1;

if (a.HasValue == true)
{
    Console.WriteLine("a is {0}.", a.Value);
}

// Nullable tipin qısa yazılışı - "?"
int? b = 1;

if (b.HasValue == true)
{
    Console.WriteLine("b is {0}", b.Value);
}

// var ilə yaratdığımız dəyişənlər null ola bilməz.
// var? c = null;        