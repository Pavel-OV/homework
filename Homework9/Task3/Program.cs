// // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// // m = 2, n = 3 -> A(m,n) = 9
// // m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Bычислениre функции Аккермана с помощью рекурсии");
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

void Methood()
{
    Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {GetAckermannFunction(numberM, numberN)}");
}