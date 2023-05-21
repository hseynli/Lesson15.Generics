int? a = null;
int? b;

b = a ?? 10; // b = 10
Console.WriteLine(b);

a = 3;
b = a ?? 10; // b = 3
Console.WriteLine(b);