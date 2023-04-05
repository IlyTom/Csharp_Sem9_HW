// Задача 64: Выполнить с помощью рекурсии.Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string numbers(int N, int C)
{
    if (N==C) return C.ToString();
    return (N + " " + numbers(N-1,C));
}

System.Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(numbers(N,1));