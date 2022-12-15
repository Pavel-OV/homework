namespace Common;
public static class Class1
{

    static int [] PrintArr(int [] array)
    {
        Console.Write("[");
        for(int i=0; i<array.Length;i++)
        {
            Console.Write($"{array[i]},");
        }
        Console.Write("]");
        return (array);
    }

    public static void Print2DArray(int [,] array)
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

        public static int [,] CreateRandom2DArray(int countRows, int  countColums)
    {
        Random random = new Random();
        int [,] array = new int [countRows,countColums];
        for(int i=0; i<array.GetLength(0); i++)
        {
            for(int j=0; j<array.GetLength(1); j++)
            {
                array[i,j] = random.Next(-10,30);
            }
   
        }
        return  array;
    }

}
// while (true)
// {
//     Console.Write("Введите число: ");
//     string text = Console.ReadLine();
//     if (double.TryParse(text, out double b1))
//     {
//         Console.WriteLine($"Вы ввели число {b1}", b1);
//         break;
//     }
//     Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
// }