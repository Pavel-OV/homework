// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Method();
// int [] arrayOfRandomNumbers = GeneratingArrayOfRandomNumbers();
// PrintArr(arrayOfRandomNumbers);
// int counterOfEvenNumbers= CountingEvenNumbers();
// Console.WriteLine($"Количество чётных чисел в массиве = {counterOfEvenNumbers}");


// void Method(){
// Console.WriteLine("Задайть массив заполненный случайными положительными трёхзначными числами.");
// Console.WriteLine(" Посчитать количество чётных чисел в массиве.");

// }


// int CountingEvenNumbers(){
// int counterOfEvenNumbers=0;
// for(int i=0;i<arrayOfRandomNumbers.Length;i++){
//     if (arrayOfRandomNumbers[i]%2 == 0){
//         counterOfEvenNumbers=counterOfEvenNumbers+1;
//     }
// }
// return(counterOfEvenNumbers);
// }    


// int [] GeneratingArrayOfRandomNumbers(){
// int [] arrayOfRandomNumbers = new int [9];
// for (int index=0; index<arrayOfRandomNumbers.Length;index++) {
// Random random = new Random();
// int rnd=random.Next(100,1000);
// arrayOfRandomNumbers[index]=rnd;
// //Console.Write($"{index}={rnd} ");
// //Console.WriteLine(array[index]);
// }
// return(arrayOfRandomNumbers);
// }
// void PrintArr(int [] arrayOfRandomNumbers){
//     Console.Write("Массив сгенированный генератором случайный чисел [");
//     for(int i =0; i<arrayOfRandomNumbers.Length; i++){
//         Console.Write($" {i}={arrayOfRandomNumbers[i]}");
   
//     }
//     Console.WriteLine("]");
//  return;
// }

bool  isParsed = int.TryParse(Console.ReadLine(), out int number);
if(!isParsed ){
    Console.WriteLine("Вы ввели не то что надо!");
}