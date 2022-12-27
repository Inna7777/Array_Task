//Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] Spiral(int[] arr, int M, int N)
{
    
    int [, ] mat = new int [M,N]; //строим матрицу
    int top = 0, bottom = M-1;
    int left = 0, right = N-1;
    int index = 0;
    while (true)
    {
        if (left > right)
        {
            break;
        }
        for (int i = left; i<= right; i++) //печатаем верхнюю строчку
        {
            mat [top,i] = arr[index++];
        }
        top++;
        if (top > bottom)
        {
            break;
        }
        for (int i = top; i <= bottom; i++)// печатаем правый столбик
        {
            mat[i,right] = arr[index++];
        }
        right--;
        if (left > right)
        {
            break;
        }
        for (int i = right; i >= left; i--)//печатаем нижнюю строчку
        {
            mat[bottom,i] = arr[index++];
        }
        bottom--;
        if (top > bottom)
        {
            break;
        }
        for (int i = bottom; i >= top; i--)//печатаем левый столбец
        {
            mat[i,left] = arr[index++];
        }
        left++;
    } 
    return mat;  
}

    int M = 4, N = 4;
    int[] array = {11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26};
     
     int[,] mat = Spiral(array, M, N);
 
    for (int i = 0; i < M; i++) 
    {
      for (int j = 0; j < N; j++) 
      {
        Console.Write(mat[i, j] + " ");
      }
      Console.WriteLine();
     
}
 