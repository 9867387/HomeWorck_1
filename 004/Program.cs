//Найти максимальное из трех чисел
Console.Write(" Введите первое чесло: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write(" Введите второе чесло: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write(" Введите третье чесло: ");
double c = Convert.ToDouble(Console.ReadLine());
double max = 0;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine(max + " это самое большое число ");