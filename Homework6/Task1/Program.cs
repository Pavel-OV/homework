// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

//usinq  Common;

Console.WriteLine("Введите  c клавиатуры 5 чисел");
int [] array = InputArray();

int [] InputArray(){
    int [] array = new int [5];
    for(int i=0; i<array.Length; i++ )
        {
        bool isParsed = int.TryParse(Console.ReadLine(), out int number );
        if(!isParsed)
        {
            Console.WriteLine("Вы ввели неправильно! Остановимся на этом.");
            break;
        }
     array[i] = number;
    }
 return(array);
}

    
PrintArr(array);








int [] PrintArr(int [] array){
    int count=0;
    Console.Write("[");
    for(int i=0; i<array.Length;i++){
         Console.Write($"{array[i]},");
    if(array[i] > 0)  
    {
        count=count+1;
    }
    }
    Console.Write("]-> ");
    Console.WriteLine(count);
return (array);
}
