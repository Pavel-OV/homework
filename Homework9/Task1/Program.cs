// Задача 64: Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа 
//  в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Задайте значение N.");
Console.WriteLine("Bыведеm все натуральные числа в промежутке от N до 1.");
int number = InputNumber();
Methood(number);

void Methood(int number)
{
   
    if(number == 0)
    {
        return;
    }
    Console.Write($"{number} ");
    Methood(number-1);

}




int InputNumber()
{
    Console.Write("Введите целое число ");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Ошибка ввода! Введите целое число ");
    }
    return(number);
}