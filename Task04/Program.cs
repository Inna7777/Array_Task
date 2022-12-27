//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 //Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.
int[,,] Array3D(int rows, int columns, int lines)
{
    int[,,] array = new int[rows,columns,lines];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = rnd.Next(10,99);
            }
        } 
    }
    return array;
}
void PrintArray(int[, ,] array)
{       
    for (int i= 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        {  
             for (int k = 0; k < array.GetLength(2); k++)
             
            {
                Console.Write($"{array[i,j,k],3}({i},{j},{k})");
                
            }
            
        }
       
        Console.WriteLine();
    }

    Console.WriteLine();
}
int[,,] array = Array3D(2,2,2);
PrintArray(array);

Console.WriteLine();

