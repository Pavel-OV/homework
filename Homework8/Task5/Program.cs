// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int number = 16;
int rowsNumber= InputNumber();
int columsNumber=rowsNumber;
//int [,] array = CreateRandom2DArray(rowsNumber,columsNumber);
int[,] array = new int[4,4];
for(int i=1; i<=number; i++)
            {
              
    for(int j=0; j<array.GetLength(0); j++)
    {
            for(int a =0; a<array.GetLength(1); a++)
             {
                array[j,a]=i;
                // Console.Write(i);
            }

    }

}
   


Print2DArray(array);

// int [,] CreateRandom2DArray(int rowsNumber, int  columsNumber)
//     {
//         Random random = new Random();
//         int [,] array = new int [rowsNumber,columsNumber];
//         for(int i=0; i<array.GetLength(0); i++)
//         {
//             for(int j=0; j<array.GetLength(1); j++)
//             {
//                 array[i,j] = random.Next(0,30);
                
//             }
   
//         }
//         return  array;
//     }





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