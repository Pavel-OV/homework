// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
Method();

int i = InputNumber();
int j = InputNumber();
double [,] array = CreateRandom2DArray(i,j);
Print2DArray(array);





void Method()
{
  Console.WriteLine("Задайте двумерный массив размером m на n.");
 Console.WriteLine("Заполненный случайными вещественными числами.");
}



void Print2DArray(double [,] array){
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write($"{array[ i, j]} ");
        }
         Console.WriteLine();
        }
}
double [,] CreateRandom2DArray(double  countRows, double  countColums){
    Random random = new Random();
   double [,] array = new double [i,j];
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = Math.Round((random.NextDouble()-0.4)*10,1);
        }
   
    }
    return ( array);
}
int InputNumber()
{
    Console.Write("Введите  число ");
    while (!int.TryParse(Console.ReadLine(), out j))
    {
        Console.Write("Ошибка ввода! Введите целое число ");
    }
    return(j);
}


// int[] array = new int[3] { 1, 3, 4 };

// string str = string.Join(", ", array);
// Console.WriteLine(str);