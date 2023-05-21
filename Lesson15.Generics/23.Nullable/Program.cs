int? a = null;
int? b = -5;
   
if (a >= b)
{
    Console.WriteLine("a >= b");
}
else
{
    Console.WriteLine("a < b");
}

b = null;

if (a == b)
{
    Console.WriteLine("a == b");
}
else
{
    Console.WriteLine("a != b");
}