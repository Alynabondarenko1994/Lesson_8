//Задача 62: Заполните спирально массив 4 на 4.



void PrintArray(int[,] arr)
{
    Console.WriteLine("Заполненный спирально массив 4 на 4 имеет следующий вид:");
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

void SpiralElements(int[,] arr)
{
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= arr.GetLength(0) * arr.GetLength(1))
    {
        arr[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < arr.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= arr.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > arr.GetLength(1) - 1)
            j--;
        else
            i--;
    }

    PrintArray(arr);

}


int line = 4;
int column = 4;
int[,] arr = new int[line, column];
SpiralElements(arr);



