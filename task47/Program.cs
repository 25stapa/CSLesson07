/*Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    m = 3, n = 4.
    0,5 7 -2 -0,2
    1 -3,3 8 -9,9
    8 7,8 -7,1 9
*/

//   Метод получения двумерного массива с рандомными числами

void FillTwoDimentionalArray(float[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().NextSingle()*20-10;  // Expanded the range
        }
    }
}

//  Метод вывода в консоль двумерного массива

void PrintTwoDimentionalArray(float[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            
	        Console.Write($"{array[m, n].ToString("F" +1)}; ");  // .ToString("F" +1) Округление до 1 знака после запятой
        }
        Console.WriteLine();
    }

}

//  Объявляение и инициализация двумерного массива с количеством строк 3, столбцов 4.

int m = 3;
int n = 4;
float[,] array = new float[m, n];

//  Получение двумерного массива с рандомными числами

FillTwoDimentionalArray(array);

//  Вывод на консоль массива 

PrintTwoDimentionalArray(array);

