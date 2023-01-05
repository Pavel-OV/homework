// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int rowsNumber = InputNumber();
int columsNumber = rowsNumber;
//int [,] array = CreateRandom2DArray(rowsNumber,columsNumber);
int[,] spiral = new int[rowsNumber, columsNumber];

int number = 1;
int rows = 0;
int colums = 0;


while (number <= spiral.GetLength(0) * spiral.GetLongLength(1))
{
    spiral[rows, colums] = number;
    if (rows < colums && rows + colums < spiral.GetLength(0) - 1) colums++;
    else if (rows >= colums && rows + colums < spiral.GetLength(1) - 1)
    {
        rows = rows + 1;
    }
     else if (rows >= colums && rows + colums < spiral.GetLength(0) - 1)
    {
        colums--;
    }
    else

    {
        rows = rows - 1;
    }


    number = number + 1;
}

Print2DArray(spiral);

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
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