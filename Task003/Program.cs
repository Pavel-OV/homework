// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Сегодня выходной?");
Console.WriteLine("Ведите число от 1 до 7");
int day = int.Parse(Console.ReadLine());
if ( day==6 | day ==7){
        Console.WriteLine("Поздравляю! Выходной!");
    }
if (day < 0 | day > 7){
    Console.WriteLine("Вы ввели число не корретно");
}

if ( day> 0 & day < 6){
Console.WriteLine("Это день не выходной");
}
