//По заданному номеру дня недели вывести его название
Console.Write("Введите день недели ");
double a = Convert.ToDouble(Console.ReadLine());
if(a==1)
{
    Console.WriteLine( "понедельник");
}
if(a==2)
{
    Console.WriteLine( "вторник");
}
if(a==3)
{
    Console.WriteLine("Среда");
}
if(a==4)
{
    Console.WriteLine("Четвер");
}
if(a==5)
{
    Console.WriteLine("Ух это же Пятница");
}
if(a==6)
{
    Console.WriteLine("Субота после пятницы блевота!");
}
if(a==7)
{
    Console.WriteLine("Воскресение");
}
if(a>7)
{
    Console.WriteLine("Ты тупой? Я сказал день недели!");
}