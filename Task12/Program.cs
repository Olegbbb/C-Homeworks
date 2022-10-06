Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int p = n / 10;
int k = p % 10;
if (k < 0)
    k = k * (-1);
Console.WriteLine(k);