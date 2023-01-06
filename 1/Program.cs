/* Задача 1: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"  */

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

void NumberRec(int N)
{
    if(N > 0)
    {
        Console.Write(N);
        if(N > 1)
        {
            Console.Write(", ");
        }
        NumberRec(N-1); 
    }
}

NumberRec(N);

