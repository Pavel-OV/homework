// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите  c клавиатуры 7 чисел");
int [] array = new int [5];
int count=0;
for(int i=0; i<array.Length; i++ ){
    bool isParsed = int.TryParse(Console.ReadLine(), out int number );
if(!isParsed){
    Console.WriteLine("Вы ввели неправильно!");
}
array[i] = number;
if(number > 0){
    count=count+1;
}

}
PrintArr(array);
Console.WriteLine($"вы ввели больше 0  {count} раза");








int [] PrintArr(int [] array){
    Console.Write("[");
    for(int i=0; i<array.Length;i++){
         Console.Write($"{array[i]},");
    }
    Console.Write("]");
return (array);
}
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