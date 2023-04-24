// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int ReadNum (string argument)
{
    int num;
    Console.WriteLine($"Input {argument}");
    while (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("It,s not a number");
    }
    return num;
}

int AckermanFunction (int m, int n)
{
    if (m == 0) return (n + 1);
    else if (m != 0 && n == 0) return AckermanFunction(m-1, 1);
    else return AckermanFunction(m-1, AckermanFunction(m, n-1));
}

int M = ReadNum("M");
int N = ReadNum("N");
Console.WriteLine($"Ackerman function result is {AckermanFunction(M, N)}");
