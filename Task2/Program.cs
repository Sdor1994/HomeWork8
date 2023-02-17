//// Найти произведение двух матриц
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

int[,] matrix2 = new int[length, width];
Console.WriteLine();

Console.WriteLine("Вторая матрица: ");
for (int i = 0; i < length; i++)
{
    for (int j = 0; j < width; j++)
    {
        matrix2[i, j] = random.Next(left,right);
    }
}

Print(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц: ");

int[,] matrix3 = new int[length, width];

for (int i = 0; i < length; i++)
{
    for (int j = 0; j < width; j++)
    {
        matrix3[i, j] = matrix1[i, j] * matrix2[i, j] ;
    }
}
Print(matrix3);