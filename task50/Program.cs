/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

//  Задаем двумерный массив

Console.Write("Enter the number of rows in the array: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the number of colums in the array: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array2D = new int[m, n];

Random rnd = new Random();
for (int i = 0; i < array2D.GetLength(0); i++)
{
    for (int j = 0; j < array2D.GetLength(1); j++)
        array2D[i, j] = Convert.ToInt32(rnd.Next(-15, 16));
}

for (int i = 0; i < array2D.GetLength(0); i++)
{
    for (int j = 0; j < array2D.GetLength(1); j++)
        Console.Write($"{array2D[i, j]}, ");
    Console.WriteLine();
}

Console.Write("Enter the line number of the number you are looking for: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the column number of the number you are looking for: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > m && b > n)
    Console.WriteLine("There is no such number in the array");
else
{
    object c = array2D.GetValue(a-1, b-1);
    Console.WriteLine($"The number you are looking for: {c}");
}