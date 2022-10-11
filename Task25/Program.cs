Console.Clear();
Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int i = a;
while(b > 1)
{
    a = a * i;
    b = b - 1;
}
Console.WriteLine(a);