// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать string[]

//645 -> 5  
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Задайте любое положительное число");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if (!isParsed){
    Console.WriteLine("Параметры введены не корректно, надо числа");
 }
//int number = int.Parse(Console.ReadLine());
if (number >0 & number < 100  ) Console.WriteLine($"Надо ввести трёхзначное число, а вы ввели {number}");
if (number > 99 & number <=1000) Console.WriteLine($"Третья цифра={number % 10} от введённого пользоватем");
if (number < 0) Console.WriteLine($"Вы ввели отрицательнле число ={number}. Надо положительное!");
while ( number > 1000)
{
   number = (number-1) /10;
  //Console.WriteLine(number);
  if(number < 1000) Console.WriteLine( $"Третья цифра={number % 10} от введённого пользователем числа");
  number = number +1;
  //return (number_a);
 
}

