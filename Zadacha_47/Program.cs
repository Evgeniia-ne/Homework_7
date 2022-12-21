// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
void ShowArray(double[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
}

double[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    Random rand = new Random();
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(rand.NextDouble() + rand.Next(leftRange, rightRange), 1);
        }
    }
    return array;
}

int DataEntry(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}


//Получить от пользователя числа m и n
int m = DataEntry("Введите число m: ");
int n = DataEntry("Введите число n: ");

//Создать двухмерный массив и заполнить
double[,] matrix = CreateRandomArray(m, n, -10, 10);

//Вывести на экран
ShowArray(matrix);