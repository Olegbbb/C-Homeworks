Console.Clear();
Console.WriteLine("Введите любое число");
int n = Convert.ToInt32(Console.ReadLine());
n = Math.Abs(n);
int digit = 0;
int sum = 0;
while(n > 0)
{
    digit = n % 10;
    sum = sum + digit;
    n = n / 10;
}
Console.WriteLine(sum);