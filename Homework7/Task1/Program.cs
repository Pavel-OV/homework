// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9




// int[] array = new int[3] { 1, 3, 4 };

// string str = string.Join(", ", array);
// Console.WriteLine(str);

double [,] array = CreateRandom2DArray(3,4);
Print2DArray(array);


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
   double [,] array = new double [countRows,countColums];
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            array[i,j] = random.NextDouble();
        }
   
    }
    return (double array);
}