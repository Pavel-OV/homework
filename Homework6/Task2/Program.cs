// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Найдём точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2"); 
Console.WriteLine("Значения b1, k1, b2 и k2 задаются пользователем.");

// double b1 = Convert.ToDouble(Console.ReadLine());

double b1; double k1; double b2; double k2;
Console.Write("Введите целое число b1=");
while (!double.TryParse(Console.ReadLine(), out b1))
{
    Console.Write("Ошибка ввода! Введите целое число b1=");
}
Console.Write("Введите целое число k1=");
while (!double.TryParse(Console.ReadLine(), out k1))
{
    Console.WriteLine("Ошибка ввода! Введите целое число k1=");
}
Console.Write("Введите целое число b2=");
while (!double.TryParse(Console.ReadLine(), out b2))
{
    Console.WriteLine("Ошибка ввода! Введите целое число b2=");
}
Console.Write("Введите целое число k2=");
while (!double.TryParse(Console.ReadLine(), out k2))
{
    Console.WriteLine("Ошибка ввода! Введите целое число k2=");
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
// double k1 = Convert.ToDouble(Console.ReadLine());
// double b2 = Convert.ToDouble(Console.ReadLine());
// double k2 = Convert.ToDouble(Console.ReadLine());

// y = k1 * x + b1, y = k2 * x + b2
// k1 * x + b1 = k2 * x + b2
// (k1 - k2) * x = b2 - b1
double  x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"x={x}, y={y}");

