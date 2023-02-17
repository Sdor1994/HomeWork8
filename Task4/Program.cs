/// Сформировать трехмерный массив не повторяющимися двузначными числами
/// показать его построчно на экран выводя индексы соответствующего элемента


Console.WriteLine("Введите размеры трехмерного массива");
int a = int.Parse(Console.ReadLine() ?? "");
int b = int.Parse(Console.ReadLine() ?? "");
int c = int.Parse(Console.ReadLine() ?? "");

int[,,] Matrix = new int[a, b, c];


void PrintMatrix(int[,,] newNumbers)
{
    Random random = new Random();
    for (int i = 0; i < newNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < newNumbers.GetLength(1); j++)
        {
            for (int k = 0; k < newNumbers.GetLength(2); k++)
            {
                newNumbers[i, j, k] = random.Next( 10, 99);
             Console.Write($"{newNumbers[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}
Console.WriteLine();
PrintMatrix(Matrix);
Console.WriteLine();