Console.Clear();

Console.Write("Введите трехзначное число: ");
int N = Math.Abs(int.Parse(Console.ReadLine()));

if(N < 99 || N > 999 )
{
    Console.WriteLine("Вы ввели не трехзначное число" );
    return;
}
int division = N % 10;
Console.WriteLine($"{division} Последняя цифра числа {N}" );
