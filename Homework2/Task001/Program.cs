/*Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Выделим из трёхзначного числа вторую цифру");
Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine());
int number_a = number % 100;
Console.WriteLine(number_a);
int number_b = number_a / 10;
Console.Write("Вторая цифра = ");
Console.WriteLine(number_b);

