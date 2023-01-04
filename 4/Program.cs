/* Задача 4*. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07   */

void FillArray (int [,] arr)
{
    int i = 0;
    int j = 0;
    int a = 1;
    int direction = 1; // 1 - вправо, 2 - вниз, 3 - влево, 4 - вверх
    int n = arr.GetLength(0);

while(a<=n*n)
{
    arr[i,j]=a;
    switch (direction)

    {
        case 1:
            if(j==n-1 || arr[i,j+1]>0) { direction = 2; i++;}
            else j++;
            break;
        case 2:
            if(i==n-1 || arr[i+1,j]>0) { direction = 3; j--;}
            else i++;
            break;
        case 3:
            if(j==0 || arr[i,j-1]>0) { direction = 4; i--;}
            else j--;
            break;
        case 4:
            if(i==0 || arr[i-1,j]>0) { direction = 1; j++;}
            else i--;
            break;
        default:
            break;
    }
    a++;
}
}

void PrintArray (int [,] arr)
{
    for(int i=0; i < arr.GetLength(0); i++)
    {
        for(int j=0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.Write("Введите число строк и столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());


int [,] arr = new int[n,n];

FillArray(arr);
PrintArray (arr);
