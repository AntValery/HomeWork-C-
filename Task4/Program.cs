Console.Write("Введите число a = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b = ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число c = ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c && a != b && a != c) Console.Write(a);
else if (b > a && b > c && b != a && b != c) Console.Write(b);
else if (c > a && c > b && c != a && c != b) Console.Write(c);