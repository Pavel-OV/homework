// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//f Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Выдаёт таблицу кубов чисел от 1 до N.");
int number = InputNumber();
int[] tableCubeNumber = CalculateCubesNumber(number);
PrintArr(tableCubeNumber);

 int[] CalculateCubesNumber(int number)
 {
    int[] array = new int[number];
    for ( int i = 0; i < array.Length; i++)
    {
        array [i] = (int)(Math.Pow(i+1,3));
    }
return array;
}
void PrintArr(int[] array){
    for(int i=0; i<array.Length;i++)
    {
        Console.WriteLine($"{i+1}={array[i]}");
    }
}


int InputNumber()
{
    Console.WriteLine("Введите число");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if(isParsed)
{
   return (number);
}
else
{
    Console.WriteLine("Ошибка ввода");
    return -1;
}
}
