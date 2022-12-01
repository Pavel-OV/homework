// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Сегодня выходной?");
Console.WriteLine("Ведите число от 1 до 7");
bool isParsed = int.TryParse(Console.ReadLine(), out int day);
if(!isParsed){
    Console.WriteLine("Вы ввели буквы или что-то ещё, надо числа");
}
if ( day==6 | day ==7){
        Console.WriteLine("Поздравляю! Выходной!");
    }
if (day < 0 | day > 7){
    Console.WriteLine($"Вы ввели число = {day} не корретно, надо от 1 до 7!");
}

if ( day> 0 & day < 6){
Console.WriteLine("Это день не выходной");
}
