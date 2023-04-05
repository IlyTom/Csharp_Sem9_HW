// Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int numbers(int M, int N)
{
    if (M == N) return N;
    return M + (numbers(M + 1, N));
}

System.Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
System.Console.WriteLine($"Сумма чисел между {M} и {N} равна {numbers(M, N)}");