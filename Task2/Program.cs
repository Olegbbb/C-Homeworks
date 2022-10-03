Console.WriteLine("Введите первое число: ");
double m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double n = Convert.ToInt32(Console.ReadLine());
if(m > n)
{
    Console.WriteLine("max = " + m);
}
else if (m < n)
{
    Console.WriteLine("max = " + n);
}
else if (m == n)
{
    Console.WriteLine("Числа равны");
}