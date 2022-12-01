/*Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Выделим из трёхзначного числа вторую цифру");
Console.WriteLine("Введите число");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if (!isParsed){
    Console.WriteLine("Параметры введены не корректно. Надо числа.");
 }
if (number >0 & number < 100  ) Console.WriteLine($"Надо ввести трёхзначное число, а вы ввели {number}");
if (number<0) Console.WriteLine($"Надо ввести положительное число, вы ввели {number}, отрицательное.");
if (100 <= number & number < 1000)
{
int number_a = number % 100;
int number_b = number_a / 10;
Console.WriteLine($"Вторая цифра = {number_b} ");
}
if (number >1000 ) Console.WriteLine($"Надо ввести трёхзначное число, а вы ввели {number}");
