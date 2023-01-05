// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
// находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:
// 1 строка

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7
int columsNumber = InputNumber();
int rowsNumber = InputNumber();

int[,] array = CreateRandom2DArray(rowsNumber, columsNumber);
Print2DArray(array);
int rowsMin = 0;
int sumRowsMin = GetSumRows(array, 0);


for (int i = 1; i < array.GetLength(0); i++)
{
    int sumRows = GetSumRows(array, i);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (sumRows < sumRowsMin)
        {
            sumRowsMin = sumRows;
            rowsMin = i;
        }
    }


}
Console.WriteLine($"Номер строки{rowsMin + 1}-> с минимальной суммой {sumRowsMin}");



int GetSumRows(int[,] array, int i)
{
    int rows = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        rows = rows + array[i, j];

    }

    return rows;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < 10)
            {
                Console.Write($"0{array[i, j]} ");
            }
            else
            {
                Console.Write($"{array[i, j]} ");
            }
        Console.WriteLine();
    }
}


int[,] CreateRandom2DArray(int rowsNumber, int countColums)
{
    Random random = new Random();

    int[,] array = new int[rowsNumber, countColums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            array[i, j] = random.Next(1, 30);

        }


    }
    return array;
}


int InputNumber()
{
    Console.Write("Введите  число ");
    while (!int.TryParse(Console.ReadLine(), out rowsNumber))
    {
        Console.Write("Ошибка ввода! Введите целое число ");
    }
    return (rowsNumber);
}

