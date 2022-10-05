Console.WriteLine("Введите данные первой прямой: ");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите данные второй прямой: ");
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());

double X (double x1, double y1, double x2, double y2)
{
    double x = (x2-x1)/(y1-y2);
    return x;
}
Console.WriteLine($"Прямые пересeкаются в точке ({X(b1,k1,b2,k2)};{k2*X(b1,k1,b2,k2)+b2})");
