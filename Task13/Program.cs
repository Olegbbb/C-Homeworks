Console.Clear();
Console.WriteLine("Введите любое число");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0)
    n = n * (-1);
if(n > 99)
{
    string ppp = (n).ToString();
    Console.WriteLine(ppp[2]);
}
else 
Console.WriteLine("Третьей цифры нет");
