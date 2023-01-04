/* Задача 2: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


Console.Write("Введите меньшее число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите большее число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumRec(int N)
{
    if(N == M) return M;
    else return N + SumRec(N-1);
}

Console.WriteLine(SumRec(N));

