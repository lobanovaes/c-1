Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

for (int B = 1; B <= N; B++ )
     if(B % 2 == 0)
        Console.WriteLine(B);
