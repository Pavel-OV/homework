// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Найдём точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2"); 
Console.WriteLine("Значения b1, k1, b2 и k2 задаются пользователем.");
double b1 = EnteringPointCoordinate();
double k1 = EnteringPointCoordinate();
double b2 = EnteringPointCoordinate();
double k2 = EnteringPointCoordinate();
double x= CalculatingIntersectionPointOfLinesX();
double y =CalculatingIntersectionPointOfLinesY();
Method();

void Method()
{
Console.WriteLine($"Точка пересечения прямых x={x}, y={y}");
}




double EnteringPointCoordinate(){
    Console.Write("Введите целое число ");
    while (!double.TryParse(Console.ReadLine(), out k2))
    {
        Console.Write("Ошибка ввода! Введите целое число ");
    }
    return(k2);
}
double CalculatingIntersectionPointOfLinesX(){
    double  x = (b2 - b1) / (k1 - k2);
    return(x);

}
double CalculatingIntersectionPointOfLinesY(){
    
    double y = k1 * x + b1;

    return(y);

}



