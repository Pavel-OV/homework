// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива. 
//Не использовать готовые методы Min и Max

// [3 7 22 2 78] -> 76
Console.WriteLine("Задайте массив вещественных чисел");
Console.WriteLine("Найдите разницу между максимальным и минимальным элементов массива.");
int [] arrayOfRandomNumbers = GeneratingArrayOfRandomNumbers();
int differenceMaximumMinimumElements = FindDiferenceMaximumMinimumElements();
Console.WriteLine("Разница между максимальным и минимальным элементов массива");
Console.WriteLine(differenceMaximumMinimumElements);







int [] GeneratingArrayOfRandomNumbers(){
int [] arrayOfRandomNumbers = new int [10];
for (int index=0; index<arrayOfRandomNumbers.Length;index++) {
Random random = new Random();
int rnd=random.Next(100,1000);
arrayOfRandomNumbers[index]=rnd;
Console.Write($"{index}={rnd} ");
}
Console.WriteLine(" ");
return(arrayOfRandomNumbers);
}

int FindDiferenceMaximumMinimumElements(){
int minArray=0;
int maxArray =0;
if(arrayOfRandomNumbers[0]<arrayOfRandomNumbers[1]){
    minArray =arrayOfRandomNumbers[0];
    maxArray=arrayOfRandomNumbers[1];
    }
else{
    minArray=arrayOfRandomNumbers[1];
    maxArray=arrayOfRandomNumbers[0];
}
for(int i=2; i<arrayOfRandomNumbers.Length; i++){

    if (minArray > arrayOfRandomNumbers[i]){
        minArray=arrayOfRandomNumbers[i];
       }
    if(arrayOfRandomNumbers[i]>maxArray){
        maxArray=arrayOfRandomNumbers[i];
      }
}
return(maxArray - minArray);
}
// Console.WriteLine($"Минимальное значение массива={minArray},Максимальное значение массива={maxArray}");
// Console.WriteLine($"Разница между мин и мах {maxArray-minArray}");
// Console.WriteLine($"{minArray},{maxArray}");
// dotnet new classlib --name Common
// dotnet add reference /Users/a2/Lessons/Common/Common.csproj
// dotnet add reference путь до csproj проекта который вы добавили
