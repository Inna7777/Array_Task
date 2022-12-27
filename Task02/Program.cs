//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}
int[,] TowArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1,6);
        }
    } 
    return array;
}
void SumLines( int [,] array)
{
             int summin = 0;
            for (int i = 0; i<=0; i++)
            {        
                for (int j = 0; j < array.GetLength(1); j++)
            {
                 summin = summin +array[i,j];                                          
            }
           
            } 
            int x = 1;  
         for (int i = 0; i < array.GetLength(0); i++)
    {         int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
            {
                 sum = sum +array[i,j];                                          
            }
                         Console.Write($"{sum};{i}   "); //cумма элементов; номер строки
             if (summin > sum)  
             {   
                summin = sum;
                x = i+1;
             }
    }    
      Console.WriteLine();
Console.WriteLine($"Строка с наименьшой суммой элементов- {x}"); 
}   

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

int rows = GetNumber("Введите количество строк:");
int columns = GetNumber("Введите количество столбцов:");
int[,] array = TowArray(rows, columns);
PrintArray(array);
SumLines(array);
Console.WriteLine();