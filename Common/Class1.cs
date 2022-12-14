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
