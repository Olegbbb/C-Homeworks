Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 0)
    Console.WriteLine("Введите положительное число");
if (a == 0 || a == 1)
    Console.WriteLine("Введите число больше 1");
for (int i = 2; i <= a; i = i + 2)
    Console.Write(i + "  ");