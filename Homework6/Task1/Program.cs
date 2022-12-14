// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

//usinq  Common;

Console.WriteLine("Введите  c клавиатуры 5 чисел");
int [] array = new int [5];
int count=0;
for(int i=0; i<array.Length; i++ )
{
    bool isParsed = int.TryParse(Console.ReadLine(), out int number );
    if(!isParsed)
    {
        Console.WriteLine("Вы ввели неправильно! Остановимся на этом.");
        break;
    }
    array[i] = number;
    if(number > 0)  
    {
        count=count+1;
    }
}
PrintArr(array);
Console.Write($"-> {count}");








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
