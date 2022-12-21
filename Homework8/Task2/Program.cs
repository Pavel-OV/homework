﻿// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
// находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:
// 1 строка

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

int j= InputNumber();
int i =InputNumber();
int[,] array = CreateRandom2DArray(i,j);
Print2DArray(array);

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
            int sum=0;
            for(int j=0; j<array.GetLength(1); j++)

            {
                array[i,j] = random.Next(1,31);
                sum = sum+array[i,j];
            }
             Console.WriteLine(sum);
   
        }
        return  array;
    }


int InputNumber()
{
    Console.Write("Введите  число ");
    while (!int.TryParse(Console.ReadLine(), out i))
    {
        Console.Write("Ошибка ввода! Введите целое число ");
    }
    return(i);
}