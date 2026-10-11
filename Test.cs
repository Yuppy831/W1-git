Console.WriteLine("Сколько тебе лет?");
int a=int.Parse(Console.ReadLine());
if (a > 120)
{
    Console.WriteLine("Ты врешь");
}
else
{
    Console.WriteLine($"Через 10 лет тебе будет {a+10}");
}
