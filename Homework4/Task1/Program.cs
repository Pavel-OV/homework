// // Задача 25: Напишите программу, которая принимает на вход два числа (A и B)
//  и метод который возводит число A в натуральную степень B.
//   Задание должно быть выполнено в методе. 
//   В методе не должно быть вывода в консоль. Не использовать Math.Pow()




Console.WriteLine("Принимает на вход два числа A и B и возводит число A в натуральную степень B");
int numberA = CheckingInputOfNumbers();
int numberB = CheckingInputOfNumbers();

// 5int index =1;
int result =1;
//  while (index <= numberB){
//     result = numberA*result;
//     index=index+1 ;
//  }
for(int i =1; i <=numberB;  i++){
    result= numberA*result;
    Method();
}
void Method()
{
 
    Console.WriteLine(result);
}




 int CheckingInputOfNumbers(){
 bool isNumberA = int.TryParse(Console.ReadLine(), out int numberA);
if(!isNumberA){
    Console.WriteLine("Ведено не корректное число!");
    
}
if (numberA<1){
    Console.WriteLine("Нужны натуральные числа от 1 и выше.");
   
}
return (numberA);
}