/*
https://gb.ru/lessons/245131

Задайте массив из 12 элементов, заполненный случайными числами из 
промежутка [-9, 9]. Найдите сумму положительных элементов массива.
*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

/*int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    Console.WriteLine("Creating array here: ");
    for (int i = 0; i < size; i++)
    {
        System.Console.Write($"Input {i + 1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    System.Console.WriteLine();
    return newArray;
}
*/
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
/*
int FindePosiriveSum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            sum += array[i];

    return sum;
}


Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min posible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min posible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());


/*
int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
int sumOfPositive = FindePosiriveSum(array);
Console.WriteLine("Sum of positve elements in current array is" + sumOfPositive);

*/

/*
Напишите программу замена элементов массива: положительные элементы 
замените на соответствующие отрицательные, и наоборот.
______________________________________________________________________
*/
/*
int[] InvertPositive(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}
*/





/*
Задайте одномерный массив из 20 случайных чисел. Найдите количество 
элементов массива, значения которых лежат в отрезке [10,99].
________________________________________________________________________
*/
int findTwoDigit(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] >= 10 && array[i] <= 99) count++;

    return count;
}



Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min posible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min posible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.WriteLine("Count of digit ilevtnts is " + findTwoDigit (array));
