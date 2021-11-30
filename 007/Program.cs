// Показать числа от -N до N
Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
int count = -a;
while (count <= a)
{
Console.WriteLine(count);
count++;
}
