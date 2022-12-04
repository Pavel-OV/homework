
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Задача 23




// Задача 21: Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21
// 

// тип_возвращаемый_данных(int, dooble) НазваниеМетода() (всегда с большой буквы)
// {
    //   тело метода
    //   return 1 // оператор return возвращает их метода значение и оставляет его 
Console.WriteLine("Принимает на вход координаты двух точек и находит расстояние между ними");
Console.WriteLine("Координаты первой точки");
double ax=InputCoords();
double ay=InputCoords();
double az=InputCoords();
Console.WriteLine("Координаты Второй точки");
double bx=InputCoords();
double by=InputCoords();
double bz=InputCoords();
//Для отрезка AB в трехмерном пространстве она имеет вид: d = x b - x a 2 + y b - y a 2 + z b - z a 2
double GetLengthSegment = Math.Sqrt(Math.Sqrt(ax-bx)*(ax-bx)+(ay-by)*(ay-by)+(az-bz)*(az-bz));
Console.WriteLine($"Длина отрезка в пространстве = {GetLengthSegment}");
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
    return -1;
}
}