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