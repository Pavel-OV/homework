
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int columsNumber= InputNumber();
int rowsNumber = InputNumber();
int[,] array = CreateRandom2DArray(rowsNumber,columsNumber);
Print2DArray(array);
  int[] row = new int[columsNumber];
  for(int i=0; i<rowsNumber; i++){
    for(int j=0; j<columsNumber;j++)
    row[j] =array[i,j];
   
    BubbleSort(row);
    Insert(true,i,row,array);
  }
  Print2DArray(array);



            
 void Insert(bool  isRow, int dim, int[] source, int[,] dest)
 {
     for (int k = 0; k < source.Length; k++)
     {
         if (isRow)
             dest[dim, k] = source[k];
         else
             dest[k, dim] = source[k];
     }
 }
// int[] arrayCopied =  ArrayCopy(array);


// int[] ArrayCopy(int[] array)
// {
//     int[] arrayCopied= new int[array.GetLength(0)];
//     for(int i=0; i<array.GetLength(0); i++)
//     {
//         arrayCopied[i]=array[i];
//     }
//     return arrayCopied;
// }

// for (int i = 0; i < array.Length; i++)
//     for (int j = 0; j < array.Length - 1; j++)
//      if (array[j] < array[j + 1])
//      {
//       int t = array[j];
//       array[j] = array[j+1];
//       array[j+1] = t;
//      }


//Print2DArray(arrayCopied);

int [,] CreateRandom2DArray(int countRows, int  countColums)
    {
        Random random = new Random();
        int [,] array = new int [countRows,countColums];
        for(int i=0; i<array.GetLength(0); i++)
        {
            for(int j=0; j<array.GetLength(1); j++)
            {
                array[i,j] = random.Next(0,30);
                
            }
   
        }
        return  array;
    }

void Print2DArray(int [,] array)
    {
        for(int i=0; i<array.GetLength(0); i++)
        {
            for(int j=0; j<array.GetLength(1); j++)
            {
            Console.Write($"{array[ i, j]} ");
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
    return(rowsNumber);
}
  void BubbleSort(int[] array)
  {
   for (int i = 0; i < array.Length; i++)
    for (int j = 0; j < array.Length - 1; j++)
     if (array[j] < array[j + 1])
     {
      int t = array[j];
      array[j] = array[j+1];
      array[j+1] = t;
     }
  }
 
 