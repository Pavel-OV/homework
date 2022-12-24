// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов
//  в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Найти сумму натуральных элементов в промежутке от M до N.");
int numberA= InputNumber();
int number = InputNumber();
int sum =0;

Methood(sum);
Console.Write($"M ={numberA}; N = {number} -> {sum}");
void Methood(int numberA)
{
    if(numberA > number)
    {
        return;
    }
    sum=sum+numberA;
   
    Methood(numberA+1);

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