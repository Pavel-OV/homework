// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
Console.WriteLine("Задайть массив заполненный случайными положительными трёхзначными числами");
Console.WriteLine(" Посчитать количество чётных чисел в массиве.");
int [] arrayOfRandomNumbers = GeneratingArrayOfRandomNumbers();
PrintArr(arrayOfRandomNumbers);
int counterOfEvenNumbers= CountingEvenNumbers();
Console.WriteLine($"Количество чётных чисел в массиве = {counterOfEvenNumbers}");

int CountingEvenNumbers(){
int counterOfEvenNumbers=0;
for(int i=0;i<arrayOfRandomNumbers.Length;i++){
    if (arrayOfRandomNumbers[i]%2 == 0){
        counterOfEvenNumbers=counterOfEvenNumbers+1;
    }
}
return(counterOfEvenNumbers);
}    


int [] GeneratingArrayOfRandomNumbers(){
int [] arrayOfRandomNumbers = new int [9];
for (int index=0; index<arrayOfRandomNumbers.Length;index++) {
Random random = new Random();
int rnd=random.Next(100,1000);
arrayOfRandomNumbers[index]=rnd;
//Console.Write($"{index}={rnd} ");
//Console.WriteLine(array[index]);
}
return(arrayOfRandomNumbers);
}
void PrintArr(int [] arrayOfRandomNumbers){
    Console.Write("Массив сгенированный генератором случайный чисел [");
    for(int i =0; i<arrayOfRandomNumbers.Length; i++){
        Console.Write($" {i}={arrayOfRandomNumbers[i]}");
   
    }
    Console.WriteLine("]");
 return;
}