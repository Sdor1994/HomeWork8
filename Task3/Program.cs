/// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
    }
}
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}


int length= ReadInt("Введите колличество строк: ");
int width= ReadInt("Введите колличество столбцов: ");
int left= ReadInt("Введите левый предел чисел: ");
int right= ReadInt("Введите правый предел чисел: ");

int[,] matrix1 = new int[length, width];

Console.WriteLine();

Console.WriteLine("Первая матрица: ");
Random random = new Random();
for (int i = 0; i < length; i++)
{
    for (int j = 0; j < width; j++)
    {
        matrix1[i, j] = random.Next(left,right);
    }
  
}
Print(matrix1);
int min=matrix1[ 0 ,0 ];
int A=0;
int Y=0;
for (int i = 0; i < length; i++)
{
    for (int j = 0; j < width; j++)
    {
         if (matrix1[i,j]<min) 
         {
            min=matrix1[i,j];
            A=i;
            Y=j;
         }
    }
}
Console.WriteLine();
int num1 = length-1;
int num2 = width-1;
int[,] matrix2 = new int[num1, num2];
Console.WriteLine("Матрица без мин. элемента : ");
for (int i = 0; i < num1; i++)
{
    
    for (int j = 0; j < num2; j++)
    {
        if (i==A) matrix2[i,j]=matrix1[i, j+1];
        if (j==Y) matrix2[i,j]=matrix1[i+1, j];
        else matrix2[i,j]=matrix1[i, j];
    }
}

Print(matrix2);
