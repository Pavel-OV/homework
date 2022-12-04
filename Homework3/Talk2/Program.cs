
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Задача 23
Console.WriteLine("Принимает на вход координаты двух точек и находит расстояние между ними");
Console.WriteLine("Координаты первой точки");
double ax=InputCoords();
double ay=InputCoords();
double az=InputCoords();
Console.WriteLine("Координаты Второй точки");
double bx=InputCoords();
double by=InputCoords();
double bz=InputCoords();

double lengthSegment = Math.Sqrt(Math.Sqrt(ax-bx)*(ax-bx)+(ay-by)*(ay-by)+(az-bz)*(az-bz));
Console.WriteLine($"Длина отрезка ={lengthSegment}");




    


double InputCoords()
{
bool isParsedAX = double.TryParse(Console.ReadLine(), out double q);
if(isParsedAX)
{
   return (q);
}
else
{
    Console.WriteLine("Ошибка ввода координат");
    return-1;
}
}