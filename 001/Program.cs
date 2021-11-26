//По двум заданным числам проверять является ли первое квадратом второго
Console.Write("введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());
if (a == b * b)
{
    Console.WriteLine(a + " является квадратом " + b);
}
else
{
    Console.WriteLine(a + " не является квадратом " + b);
}


