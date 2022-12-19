// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет
Console.WriteLine("Двумерный массив.Укажите сколько рядов и столбцов");
int i = EnteringPointCoordinate();
int j=EnteringPointCoordinate();
Console.Write("Укажите искомое число ");
int number =EnteringPointCoordinate();
int [,] array = CreateRandom2DArray(i,j);
Print2DArray(array);
string gh = SearchNumber2DArray();
Console.WriteLine($"{number}-> {gh}");


string SearchNumber2DArray()
    {
        for(int z=0; z<array.GetLength(0); z++)
        {
            for(int x=0; x<array.GetLength(1); x++)
            {
            if (number==(array[z,x]))
            {
                
                 return("есть такая цифра в массиве");
                 
            }
           // Console.Write($"{array[ i, j]} ");
            }
         // Console.WriteLine();
        }
     return("нет такого числа в массиве") ;
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
int [,] CreateRandom2DArray(int countRows, int  countColums)
{
    Random random = new Random();
    int [,] array = new int [countRows,countColums];
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = random.Next(30);
            //if(number==(array[i,j]) )
            //{
               // Console.WriteLine($"{number} в массиве существует");
            //}
            // else
            // {
            //     Console.WriteLine($"{number} не существует");
            // }
           
        }
   
    }
    return  array;
}
int EnteringPointCoordinate()
{
    Console.Write("Введите целое число ");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Ошибка ввода! Введите целое число ");
    }
    return(number);
}

// interface IMyTest
// {
//     void TestFunc1(int, int);  // CS1001
//     // Use the following line instead:
//     // void TestFunc1(int a, int b);
// }

// class CMyTest : IMyTest
// {
//     void IMyTest.TestFunc1(int a, int b)
//     {
//     }
// }