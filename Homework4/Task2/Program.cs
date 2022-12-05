// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.WriteLine("Введите число. Узнаем сумму цифр введёного числа");
int number = CheckingInputOfNumbers();
int sum = 0;
for(sum = 0; number<10;sum++){
    sum  = sum + number%10;
Console.WriteLine(sum);
}



int CheckingInputOfNumbers(){
 bool isNumberA = int.TryParse(Console.ReadLine(), out int numberA);
if(!isNumberA){
    Console.WriteLine("Ведено не корректное число!");
    return;
}
if (numberA<-1){
    Console.WriteLine("Нужны натуральные числа от 0 и выше.");
   
}
return (numberA);
}