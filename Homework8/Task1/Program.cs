
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
Console.WriteLine();
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
 
 