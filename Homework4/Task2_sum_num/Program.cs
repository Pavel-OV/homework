// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число. Узнаем сумму цифр введёного числа");
int numberA = CheckingInputOfNumbers();
int sumDigitsNumber = CalculateSumOfDigitsOfNumber();

Console.WriteLine($"Сумма цифр числа = { sumDigitsNumber}");







int CalculateSumOfDigitsOfNumber(){
    int count=0;
    int sum=0;
for(count = 0; numberA!=0;count++){
    sum  = sum + numberA%10;
    numberA=numberA/10;
}
return sum;
}


int CheckingInputOfNumbers(){
 bool isNumberA = int.TryParse(Console.ReadLine(), out int numberA);
if(!isNumberA){
    Console.WriteLine("Ведено не корректное число!");
   return 0;
}
if (numberA<-1){
    Console.WriteLine("Нужны натуральные числа от 0 и выше.");
    return 0;
  
}
return (numberA);
}
