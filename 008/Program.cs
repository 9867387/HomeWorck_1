// Показать четные числа от 1 до N
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int count = 2;
while(count<=a)
{
    Console.WriteLine(count);
    count = count+2;
}