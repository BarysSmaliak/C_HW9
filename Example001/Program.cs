// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

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

void PrintNum(int n)
{
    if (n>=1) 
    {     
        Console.Write(n);
        PrintNum(n-1); 
    } 
} 

int N = ReadNum("N");
PrintNum(N);