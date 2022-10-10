Console.WriteLine("Введите число");
int m = Convert.ToInt32(Console.ReadLine());
m = Math.Abs(m);
for (int i = 1; i <= m; i++)
{
    Console.Write(Math.Pow(i,3) + ", ");
}