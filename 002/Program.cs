
Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());
if (a > b)
{
    Console.WriteLine(a + " больше " + b);
}

if (a < b)
{
    Console.WriteLine(a + " меньше " + b);
}

if (a == b)
{
    Console.WriteLine(a + " равно " + b);
}
