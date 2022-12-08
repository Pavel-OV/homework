// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Задаёт массив из 8 элементов и выводит их на экран");
int[] array = new int [8] ; 
for(int i=0; i<array.Length; i++){
    array[i] = CheckingInputOfNumbers();
    }
PrintArray(array);
 
int CheckingInputOfNumbers(){
 bool isNumberA = int.TryParse(Console.ReadLine(), out int numberA);
if(!isNumberA){
    Console.WriteLine("Ведено не корректное число! Запишем как (-1)");
   return -1;
}
  
return (numberA);
}

void PrintArray(int[] array){
    Console.Write("Выведим на экран введёные числа [ ");
    for(int i=0; i<array.Length;i++)
    {
    Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
return;
}

