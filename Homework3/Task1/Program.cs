 // Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
 //является ли оно палиндромом. Задание должно быть выполнено в методе. 
 //В методе не должно быть вывода в консоль. Не использовать String!
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число и проверим, является ли оно палиндромом.");
int number = InputNumber();
String palindrom = CalculatePalindromicNumber(number);
PrintArr();



String  CalculatePalindromicNumber(int number){
  if (number<10000){
       return ("Число меньше пяти цифр");
    }
   if(number>100000){
    return("В числе больше пяти цифр");

   } 
int number_a = 0;
int i=0;
int[] arr = new int[5];
while (number > 10)
{
    number_a = number%10;
    number = number/10;
    arr[i]= number_a;
        if(number <10){
        arr[i+1]=number;
    }
    i=i+1;
}
if(arr[0]==arr[4] &&arr[1]==arr[3]) {
    return ("число является палиндромом");
    
}
else{
    return ("Число не является палиндромом");
}
}


 void PrintArr()
{
     Console.WriteLine(palindrom);  
}
int InputNumber()
{
    Console.WriteLine("Введите число");
bool isParsedAX = int.TryParse(Console.ReadLine(), out int number);
if(isParsedAX)
{
   return (number);
}
 else
{
    Console.WriteLine("Ошибка ввода, надо цифры");
    return -1;
}
}