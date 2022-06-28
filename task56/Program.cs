//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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

void MinimalAmountElements(int[,] arr)
{

    int[] sum = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)

    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum[i] += arr[i, j];

        }
        Console.WriteLine($"Сумма элементов  {i + 1} строки: {sum[i]}");


    }
    int min = sum[0];
    int l = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if (sum[i] <= min)
        {
            min = sum[i];
            l = i;
        }

    }

    Console.WriteLine($"Наименьшая сумма элементов в строке: {l + 1}");


}


int line = GetNumber("Задайте число строк m двумерного массива : ");
int column = GetNumber("Задайте число столбцов n двумерного массива : ");
int[,] rnd = ArrayRandom(line, column);
PrintArray(rnd);
MinimalAmountElements(rnd);