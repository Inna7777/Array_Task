//Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

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
int[,] TowArray1(int rows, int columns) //создание матрицы
{  
        int[,] arr1 = new int[rows, columns];
         
    Random rnd = new Random();
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            arr1[i,j] = rnd.Next(0,5);
            
        }
    } 
    return arr1;
}
 int[,] MultArr(int[,] arr1, int[,] arr2, int[,] resularr) // новая матрица -произведение матриц
{
   
  for (int i = 0; i < resularr.GetLength(0); i++)
  {
    for (int j = 0; j < resularr.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < arr1.GetLength(1); k++)
      {
        sum += arr1[i,k] * arr2[k,j];
      }
      
      for (int l = 0; l < resularr.GetLength(0); l++)
      {
        for (int n = 0; n < resularr.GetLength(1); n++)
        {
          resularr[i,j] = sum;
        }
         
      }
    }
      
  } 
  return resularr;
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

int rows = GetNumber("Введите размер матрицы");
int columns = rows;
int[,] arr1 = TowArray1(rows, columns);
PrintArray(arr1);
int[,] arr2 = TowArray1(rows, columns);
int[,] resularr = new int[rows,columns];
PrintArray(arr2);
int[,] result = MultArr(arr1, arr2, resularr);
PrintArray(result);
Console.WriteLine();