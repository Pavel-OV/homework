// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Задайте две матрицы");
Console.WriteLine("Hайти произведение двух матриц");
Console.WriteLine("Первая матрица. Введите количество строк");
int rowsFirst = InputNumber();
Console.WriteLine("Введите количество столбцов. ");
Console.WriteLine("Вторая матрица. Введите количество строк.");
int rowsFirstColumSecond = InputNumber();
Console.WriteLine("Введите количество столбцов. ");
int columSecond = InputNumber();
Console.WriteLine("Первая матрица.");
int[,] firstMatrix = new int[rowsFirst, rowsFirstColumSecond];
firstMatrix = CreateRandom2DArray(rowsFirst, rowsFirstColumSecond);
Print2DArray(firstMatrix);
Console.WriteLine("Вторая матрица.");
int[,] secondMatrix = new int[rowsFirstColumSecond, columSecond];
secondMatrix = CreateRandom2DArray(rowsFirstColumSecond, columSecond);
Print2DArray(secondMatrix);
int[,] resultMatrix = new int[rowsFirst, columSecond];
resultMatrix =MatrixMultiplication(resultMatrix);






int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix(0); i++)
    {
        for (int j = 0; j < resultMatrix(1); j++)
            int sum = 0;
        for (int v = 0; v < firstMatrix(1); v++)
        {
            sum = sum + firstMartrix[i, v] * secondMartrix[v, j];
        }
        resultMatrix[i, j] = sum;

    }
return resultMatrix;
}







int InputNumber()
{
    Console.Write("Введите  число ");
    while (!int.TryParse(Console.ReadLine(), out columSecond))
    {
        Console.Write("Ошибка ввода! Введите целое число ");
    }
    return (columSecond);

}

int[,] CreateRandom2DArray(int countOfRows, int countOfColums)
{
    Random random = new Random();
    int[,] array = new int[countOfRows, countOfColums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }

    }
    return array;
}
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
// Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
// int m = InputNumbers("Введите число строк 1-й матрицы: ");
// int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
// int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
// int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

// int[,] firstMartrix = new int[m, n];
// CreateArray(firstMartrix);
// Console.WriteLine($"Первая матрица:");
// WriteArray(firstMartrix);

// int[,] secomdMartrix = new int[n, p];
// CreateArray(secomdMartrix);
// Console.WriteLine($"Вторая матрица:");
// WriteArray(secomdMartrix);

// int[,] resultMatrix = new int[m,p];

// MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
// Console.WriteLine($"Произведение первой и второй матриц:");
// WriteArray(resultMatrix);

// void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secomdMartrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }