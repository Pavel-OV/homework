//using Common;

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int i = InputNumber();
int j = InputNumber();
int [,] array = CreateRandom2DArray(i,j);
Print2DArray(array);
Console.Write("Среднее арифметическое столбца");
for(int q=0; q<array.GetLength(1); q++)
   {   double sumArithmeticMean =0;
        
       for(int g=0; g<array.GetLength(0); g++)
            {
                sumArithmeticMean=(array[g,q]+sumArithmeticMean);
            }
        Console.Write($" {q}={sumArithmeticMean/2}");
    }
// int[] array2= new int[3]{1,8,4};
// string str = string.Join(",",array2);
// Console.WriteLine(str);
// string strFormat =  string.Format("Это означает {0}ровно{1}что-то{2}",1,2,3);
// string str2= $"{GetSomethinq().Item1}";
// int[] array = new int[3] { 1, 3, 4 };

// string str = string.Join(", ", array);
// Console.WriteLine(str);


// (int,int) GetSomethinq()
//  {
//     int a=5;
//     int b=4;
//     return(a,b);
//  }
//  (int, int) coordinates = GetSomethinq();
//  Console.WriteLine(coordinates.Item1);
//  Console.WriteLine(coordinates.Item2);

int InputNumber()
{
    Console.Write("Введите  число ");
    while (!int.TryParse(Console.ReadLine(), out j))
    {
        Console.Write("Ошибка ввода! Введите целое число ");
    }
    return(j);
}

void Print2DArray(int [,] array){
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write($"{array[ i, j]} ");
        }
         Console.WriteLine();
        }
}
int [,] CreateRandom2DArray(int countRows, int  countColums){
    Random random = new Random();
 int [,] array = new int [countRows,countColums];
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            array[i,j] = random.Next(10);
        }
   
    }
    return  array;
}
// dotnet new classlib --name Common
// dotnet add reference /Users/a2/Lessons/Common/Common.csproj
// dotnet add reference путь до csproj проекта который вы добавили