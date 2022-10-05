int Metod(int x)
{
    if (x > 0) return 1;
    else return 0;
}
Console.Write("Укажите сколько чисел будет: ");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];
int i = 0 ;
int result = 0;
while (i <count)
{
    Console.Write("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    result = result + Metod(array[i]);
    i++;
}
Console.WriteLine($"Положительных чисел было: {result}");