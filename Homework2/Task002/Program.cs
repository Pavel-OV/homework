// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать string[]

//645 -> 5  
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Задайте любое число");
int number = int.Parse(Console.ReadLine());
if (number >0 & number < 100  ) Console.WriteLine($"Надо ввести трёхзначное число, а вы ввели {number}");
if (number > 100 & number <=1000) Console.WriteLine($"Третья цифра={number % 10} от введённого пользоватем");
int number_a =0;
while ( number > 1000)
{
   
  number = (number-1) /10;
  //Console.WriteLine(number);
  if(number < 1000) Console.WriteLine( $"Третья цифра={number % 10} от введённого пользователем");
  number = number +1;
  //return (number_a);
 
}

