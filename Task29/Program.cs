Console.Clear();
int i = 0;
int[] array = new int[8];
for(i = 0; i < 8; i++)
{
    Console.WriteLine("Введите число массива");
    int n = Convert.ToInt32(Console.ReadLine());
    array [i] = n;
}
Console.WriteLine($"[{string.Join(", ", array)}]");