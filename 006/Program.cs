// Выяснить является ли число чётным
Console.WriteLine(" Введите число ");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine( a + " целое число");
}
else
{
    Console.WriteLine(a + " число не четное");
}