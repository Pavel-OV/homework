// // Задача 25: Напишите программу, которая принимает на вход два числа (A и B)
//  и метод который возводит число A в натуральную степень B.
//   Задание должно быть выполнено в методе. 
//   В методе не должно быть вывода в консоль. Не использовать Math.Pow()




Console.WriteLine("Принимает на вход два числа A и B и возводит число A в натуральную степень B");
int numberA = CheckingInputOfNumbers();
int numberB = CheckingInputOfNumbers();
int resultNumberDegree = RaisesNumberDegree();
Method();

int RaisesNumberDegree()
{
int result =1;
for(int i =1; i <=numberB;  i++){
    result= numberA*result;
   }
   
return (result);
}

 void Method()
{
 
 Console.WriteLine($" Число {numberA} в степени {numberB} ={resultNumberDegree}");
    
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
