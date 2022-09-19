Console.Clear();

Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine());

if(N % 2 == 0)
{
    Console.WriteLine($"{N} является четным" );
}
else
{
    Console.WriteLine($"{N} является не четным" );
}
