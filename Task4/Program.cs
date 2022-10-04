Console.WriteLine("Введите первое число: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
double c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
    Console.WriteLine(a + " max");
if (b > a && b > c)
    Console.WriteLine(b + " max");
if (c > a && c > b)
    Console.WriteLine(c + " max");
if (a == b && b == c)
    Console.WriteLine("Все числа равны " + a);


