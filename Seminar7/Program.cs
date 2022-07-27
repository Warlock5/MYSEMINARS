/*
Задача1:
Задать двумерный массив размером m на n заполненый 
случайными целыми числами
*/

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

/*
Задача1:
Задать двумерный массив М на N каждый элемент в массиве находиться по
формуле А= (i+j) равен cумме этих индексов i + j
*/

int[,] CreateSumMass(int rows, int columns)
{
    
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 1; j < columns; j++)
        {
            newArray[i,j] = i + j;
        }
    return newArray;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());




int[,] arraySum = CreateSumMass(m, n);
Show2dArray(arraySum);

/*
Задача2:
Задать двумерный массив. Найти элементы у которых оба индекса четные и 
заменить эти элементы на их квадраты.
*/
/*
int[,] Quat(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 1; j < array.GetLength(1); j++)
            if (i % 2 == 0 && j % 2 == 0)array[i, j] = array[i, j] * array[i, j];

    return array;
}
 Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2dArray(m, n, minValue, maxValue);
Show2dArray(myArray);
Quat(myArray);
Show2dArray(Quat(myArray));
/*
Задача3
Задать двухмерный массив. Найти сумму элементов находящихся на главной диагонали.
(Матрица должна быть квадратной- иметь диагональ)
*/
int FindDiagSum(int[,] array)
{
    int sum = 0;
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == j) sum += array[i, j];
            }
        }
    }
    return sum;
}
/*
То же самое решение коротким путем - не проходим весь массив а 
обращаемся к конкретным элементам
*/
int FindDiag1Sum(int[,] array)
{
    int sum = 0;
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i, i];
    }
    return sum;
}

/*
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, minValue, maxValue);
Show2dArray(myArray);
Console.WriteLine("Sum of main diagonal is; " + FindDiag1Sum(myArray));
*/


