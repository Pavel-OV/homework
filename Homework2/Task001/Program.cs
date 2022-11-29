/*Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1




*/

Console.WriteLine("Введите трёхзначное число");

int number = int.Parse(Console.ReadLine());

int number_a = number % 1000;
Console.WriteLine(number_a);
int number_b = number_a % 10;
Console.WriteLine(number_b);

