// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] array = {
            { 1, 4, 7, 2},
            { 5, 9, 2, 3},
            { 8, 4, 2, 4}
        };

int rows = array.GetLength(0);
int columns = array.GetLength(1);

double[] averages = new double[columns];

for (int j = 0; j < columns; j++)
{
    int sum = 0;

    for (int i = 0; i < rows; i++)
    {
        sum += array[i, j];
    }

    averages[j] = (double)sum / rows;
}

Console.WriteLine("Средние арифметические элементов в каждом столбце:");

for (int j = 0; j < columns; j++)
{
    Console.WriteLine("Столбец {0}: {1}", j, averages[j]);
}