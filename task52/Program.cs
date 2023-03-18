/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

//  Задаем двумерный массив параметрами от пользователя
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

int a = GetParameterArray("Enter the number of rows in the array: ");
int b = GetParameterArray("Enter the number of colums in the array: ");

Console.WriteLine();

//  Declaring and initializing a two-dimensional array
int[,] array = new int[a, b];

//  Declaring and initializing a variable Random
Random rnd = new Random();

//  Filling an array with random numbers (-10, 10)
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = Convert.ToInt32(rnd.Next(0, 11));
}

//  Outputting an array to the console
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j]}\t");
    Console.WriteLine();
}
Console.WriteLine();



//  Find the arithmetic mean of the elements in each column.

int n = 0;
for (int j = 0; j < array.GetLength(1); j++)
{

    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    n++;
    Console.WriteLine($"Average column {n} = {sum / array.GetLength(0): #.##};");

}
Console.WriteLine();