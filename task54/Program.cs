//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива


int GetNumber(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        string num = Console.ReadLine();
        if (int.TryParse(num, out int number) == false)
            Console.WriteLine("Введено не число");
        else
        {
            if (number <= 0)
                Console.WriteLine("Задайте число больше 0");
            else
                return number;
        }
    }
}

int[,] ArrayRandom(int line, int column)
{
    int[,] arr = new int[line, column];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 100);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    Console.WriteLine("Двумерный массив имеет следующий вид:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] / 10 <= 0)
                Console.Write($" {arr[i, j]} ");
            else Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }

}

void DecreasingElements(int[,] arr)
{
    Console.Write("Строки массива упорядочены по убыванию.");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int k = 0; k < arr.GetLength(1); k++)

        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                if (arr[i, j + 1] > arr[i, j])
                {
                    int min = arr[i, j];
                    arr[i, j] = arr[i, j + 1];
                    arr[i, j + 1] = min;
                }
            }
        }
    }

    PrintArray(arr);
}

int line = GetNumber("Задайте число строк m двумерного массива : ");
int column = GetNumber("Задайте число столбцов n двумерного массива : ");
int[,] rnd = ArrayRandom(line, column);
PrintArray(rnd);
DecreasingElements(rnd);