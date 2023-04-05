// Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m-1,Akkerman(m,n-1));
}
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

System.Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Akkerman(m,n)}");