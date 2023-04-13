Console.WriteLine("Ввдедите размер квадратных матриц");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] matrix1 = new int[N, N];
int[,] matrix2 = new int[N, N];
int[,] matrix3 = new int[N, N];

Console.WriteLine("Введите диапазон чисел от:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("до:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int rows = matrix1.GetUpperBound(0) + 1;         // количество строк
int columns = matrix1.Length / rows;             // количество столбцов
Random random = new Random();

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix1[i, j] = random.Next(min, max);
        matrix2[i, j] = random.Next(min, max);
    }
}

Console.WriteLine("Первая матрица:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{matrix1[i, j]}   ");
    }
    Console.WriteLine("\n");
}

Console.WriteLine("Вторая матрица:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{matrix2[i, j]}   ");
    }
    Console.WriteLine("\n");
}

Console.WriteLine("Выберите операцию, которая будет производиться над матрицами (напишите + или -):");
string operation = Console.ReadLine();

Console.WriteLine("\nОтвет:");
switch (operation)
{
    case ("+"):
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                Console.Write($"{matrix3[i, j]}   ");
            }
            Console.WriteLine("\n");
        }
        break;
    case ("-"):
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix3[i, j] = matrix1[i, j] - matrix2[i, j];
                Console.Write($"{matrix3[i, j]}   ");
            }
            Console.WriteLine("\n");
        }
        break;
    default:
        Console.WriteLine("Ошибка! Попробуйте ещё раз");
        break;
}