Console.Clear();
Console.WriteLine("Введите номер дня недели");
int n = Convert.ToInt32(Console.ReadLine());
int p = 6;
int k = 7;
while (n < 1 || n > 7)
{
    Console.WriteLine("Вы ввели неверный номер");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == p || n == k)
    Console.WriteLine("Выходной");
else
    Console.WriteLine("Не выходной");


