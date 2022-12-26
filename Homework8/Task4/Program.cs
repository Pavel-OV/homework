// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int countColums =InputNumber();
int rowsNumber =InputNumber();
int verticalColumn =InputNumber();
Console.WriteLine("Первое число массива");
int[,,] array = CreateRandom2DArray( rowsNumber, countColums,verticalColumn);
Print2DArray(array);
int [,,] array3D = new int [rowsNumber,countColums,verticalColumn];
        
        for(int i=0; i<array.GetLength(0); i++)
        {
            for(int j=0; j<array.GetLength(1); j++)
            {
                for(int v=0; v<array.GetLength(2); v++)
                    {
                       array3D[i,j,v]=array[i,j,v];
                                                                         

                    }
            }
        }

Console.WriteLine();

for(int i=0; i<array3D.GetLength(0); i++)
        {
            for(int j=0; j<array3D.GetLength(1); j++)
            {
                for(int v=0; v<array3D.GetLength(2); v++)
                    {
                        int tempNumber=array3D[i,j,1];
                        
                        for(int q=0; q<array.GetLength(0); q++)
                            {
                               
                                for(int w=0; w<array.GetLength(1);w++)
                                {
                                    int numberA= array[q,w,e];
                                            if(tempNumber==numberA){
                                                tempNumber= numberA+1;
                                                array3D[i,j,v]=tempNumber;
                                            }

                                   
                                   
                                    for(int e=0; e<array.GetLength(2); e++);
                                    //     {
                                            
                                    //             //array3D[i,j,v]=array3D[0,0,0];
                                                
                                    //         }
                                    //     }
                                }
                            }
                   

                    }
            }
        }


Print2DArray(array3D);


int [,,] CreateRandom2DArray(int countRows, int  countColums, int verticalColumn)
    {
        Random random = new Random();
        int [,,] array = new int [countRows,countColums,verticalColumn];
        for(int i=0; i<array.GetLength(0); i++)
        {
            for(int j=0; j<array.GetLength(1); j++)
            {
                for(int v=0; v<array.GetLength(2); v++)
                    {
                        array[i,j,v] = random.Next(10,30);
                         

                    }
            }
        }
        return  array;
    }
 
          


    void Print2DArray(int [,,] array)
    {
        for(int i=0; i<array.GetLength(0); i++)
        {
            for(int j=0; j<array.GetLength(1); j++)
            {
                for(int v=0; v<array.GetLength(2); v++)
                    {
                        Console.Write($"{array[ i, j,v]}({i},{j},{v}) ");
                    }
               
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