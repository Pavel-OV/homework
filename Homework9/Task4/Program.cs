
// string [] array =new string[4] {"hello","2","world",":-)"};
// PrintArr(array);
string [] array =new string [3] {"Russia","Denmark","Kazan"};
PrintArr(array);
// string [] array = new string [3];

// string[] array = Gettext(array);
// string[] Gettext(string text)
// {
    for (int i=0; i<array.Length; i++)
    {
        
        // for(int j=0; j<text[i].Length; j++)
        // {
        //     if(j>text[i][3])
        //      {
        //             text[i][j]=text[i].Length;

        //      }
        if(array[i].Length<=3){

        
     //Console.WriteLine(text[i].Length);
     Console.Write($"[  {array[i]}]");
        }
       //
      //return array;
    }
//}


string [] PrintArr(string [] array)
    {
        Console.Write("[");
        for(int i=0; i<array.Length;i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.Write("] ->");
        return (array);
    }
