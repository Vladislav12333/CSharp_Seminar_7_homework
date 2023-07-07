// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Создаем двумерный массив
int[,] array = {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4}
        };

// Получаем позиции элемента от пользователя
Console.Write("Введите номер строки: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int col = int.Parse(Console.ReadLine());

// Получаем значение элемента, если он существует
int value = GetElement(array, row, col);

if (value == int.MinValue)
    Console.WriteLine("Элемент с указанными позициями не существует");
else
    Console.WriteLine($"Значение элемента: {value}");

Console.ReadLine();


int GetElement(int[,] array, int row, int col)
{
    int numRows = array.GetLength(0);
    int numCols = array.GetLength(1);

    // Проверяем, что позиции элемента находятся в пределах допустимого диапазона
    if (row >= 0 && row < numRows && col >= 0 && col < numCols)
    {
        // Возвращаем значение элемента, если он существует
        return array[row, col];
    }

    // Возвращаем специальное значение, если элемента с указанными позициями нет
    return int.MinValue;
}