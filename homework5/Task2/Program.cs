// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных индексах.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Одномерный массив, заполненный случайными числами.");
Console.WriteLine("Найдите сумму элементов, стоящих на нечётных индексах");
int [] arrayOfRandomNumbers = GeneratingArrayOfRandomNumbers();
int sumElementsOddIndexes =CountSumOfElementsOfOddIndexes();
Method();
PrintArr(arrayOfRandomNumbers);




void Method()
{
 
 Console.WriteLine($"Сумма нечётных элементов = {sumElementsOddIndexes}");
}




int [] GeneratingArrayOfRandomNumbers(){
int [] array = new int [6];
for( int i=0; i<array.Length; i++){
    Random random = new Random();
    int rnd = random.Next(0,100);
    array[i]= rnd;
    }
  return(array);
}

void PrintArr(int [] arrayOfRandomNumbers){
    Console.Write("Массив сгенированный генератором случайный чисел [");
    for(int i=0; i<arrayOfRandomNumbers.Length;i++){
         Console.Write($"{i}={arrayOfRandomNumbers[i]} ");
    }
    Console.Write("]");
return ;
}

int CountSumOfElementsOfOddIndexes(){
   int sumOfElementsOfOddIndexes=0;
for(int i=1; i<arrayOfRandomNumbers.Length; i=i+2){
    sumOfElementsOfOddIndexes =sumOfElementsOfOddIndexes +arrayOfRandomNumbers[i];
 }
return(sumOfElementsOfOddIndexes);
}
