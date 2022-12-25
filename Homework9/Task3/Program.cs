// // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// // m = 2, n = 3 -> A(m,n) = 9
// // m = 3, n = 2 -> A(m,n) = 29

int numberM= InputNumber();
Console.WriteLine($"M->{numberM}");
int numberN = InputNumber();
Console.WriteLine($"N->{numberN}");
 Methood();

int GetAckermannFunction (int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    if (numberM > 0 && numberN == 0) 
    {
        return GetAckermannFunction(numberM - 1, 1);
    }
    if (numberM > 0 && numberN > 0) 
    {
        return GetAckermannFunction(numberM - 1, GetAckermannFunction(numberM, numberN - 1));
    }
    else
    {
        return numberN + 1;
    }
}
int InputNumber()
{
    Console.Write("Введите целое  число ");
    while (!int.TryParse(Console.ReadLine(), out numberN))
    {
        Console.Write("Ошибка ввода! Введите целое число ");
    }
    return(numberN);
}
// Console.WriteLine("Введите начальное число M:");
// int numberM = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите начальное число N:");
// int numberN = int.Parse(Console.ReadLine());

// ///Метод вычисления функции Аккермана:
// int AckermannFunction (int numberM, int numberN)
// {
//     if (numberM == 0) return numberN + 1;
//     if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
//     if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
// return AckermannFunction(numberM, numberN);
// }
void Methood()
{
    Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {GetAckermannFunction(numberM, numberN)}");
}