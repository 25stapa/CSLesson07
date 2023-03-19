/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

//  Задаем двумерный массив

int GetParameterArray(string message)
{
    int number = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out number) && number > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("You entered not a number, or a number less than or equal to zero, please try again...");
        }
    }
    return number;
}

int m = GetParameterArray("Enter the number of rows in the array:\t\t");
int n = GetParameterArray("Enter the number of colums in the array:\t");

Console.WriteLine();

int[,] array2D = new int[m, n];

for (int i = 0; i < array2D.GetLength(0); i++)
{
    for (int j = 0; j < array2D.GetLength(1); j++)
        array2D[i, j] = new Random().Next(-15, 16);
}

for (int i = 0; i < array2D.GetLength(0); i++)
{
    for (int j = 0; j < array2D.GetLength(1); j++)
        Console.Write($"{array2D[i, j]}\t");
    Console.WriteLine();
}

int a = GetParameterArray("\nEnter the line number of the number you are looking for: ");
int b = GetParameterArray("Enter the column number of the number you are looking for: ");

if (a > m && b > n)
    Console.WriteLine("\nThere is no such number in the array");
else
{
    object c = array2D.GetValue(a - 1, b - 1);
    Console.WriteLine($"\nThe number you are looking for: {c}");
}
