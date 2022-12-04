 // Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
 //является ли оно палиндромом. Задание должно быть выполнено в методе. 
 //В методе не должно быть вывода в консоль. Не использовать String!
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число и проверим, является ли оно палиндромом.");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if(!isParsed){
    Console.WriteLine("Вы ввели что-то некорректное, надо числа согласно условию задачи.");
      
}
Console.WriteLine(number);
//d2= (х2— х1)2+ (y2— y1)2.
//Для отрезка AB в трехмерном пространстве она имеет вид: d = x b - x a 2 + y b - y a 2 + z b - z a 2
// dooble GetLengthSsegment()
// {



    
// }
   
//     //int number_a = number;
//     // while(number >10){
//     //     number =number/10;
//     //     Console.WriteLine(number);

//      // for(int i=0; i<array.Length;i++){
//     //     i = number/10;
//     //     Console.WriteLine(i);  
//     // }

int [] array =  {2,3,8,989,};
Console.WriteLine(array[2]);
///int [] array = new int[number];
    for(int i =0; array.Length < 0;i++){       
        number=number/10;
        Console.WriteLine(i);
        int number_a = number%10;
        
        Console.WriteLine(number);
    }
// Console.WriteLine(array.[3]);
    
//int[] Palindrome = SplittingNumberDigits 


//  int[] SplittingNumberDigits(number);
//  int [] array = new int[SplittingNumberDigits] {
//     for (int i=0; i<array.Length; i++){
//         i
//     }
//  }




//Console.WriteLine(number);