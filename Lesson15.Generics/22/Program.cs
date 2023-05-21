// 1. Riyazi əməllərdə əgər bir operand null-dırsa, onda nəticə null olacaq
// 2. Məntiqi əməllərdə əgər bir operand null-dırsa, onda nəticə false olacaq
// 3. Nullable tiplərin default dəyəri null olur
int? a = null;
int? b = a + 4; // b = null
int? c = a * 5; // c = null

Console.WriteLine("->{0}<-", a);