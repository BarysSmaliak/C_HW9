// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

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

(int m, int n) GreaterOfTwoNumbers (int m, int n)
{
    if (m > n)
    {
        int temp = m;
        m = n;
        n = temp;
    }
    return (m, n);
}

int sum =0;

int PrintNum(int m, int n) 
{      
    if (m<=n) 
    {     
        sum += m;
        PrintNum(m+1, n); 
    } 
    return sum;
} 

int M = ReadNum("M");
int N = ReadNum("N");
(int m, int n) = GreaterOfTwoNumbers(M, N);
Console.Write(PrintNum(m, n));