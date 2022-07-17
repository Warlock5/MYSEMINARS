
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        
    }
}

// То же самое с циклом while

int[] ReversArray(int[] array)
{
    
    int i = 0, j = array.Length - 1;
    while(i < j )
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;

        i++;
        j--;
    }
    return array;
}
/*
int[] ReversArray(int[] array)
{

    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
    }
return array;
}
*/
/*
Console.Write("Input size massiv: ");
int size = Convert.ToInt32(System.Console.ReadLine());
Console.Write("Input minValue massiv: ");
int minValue = Convert.ToInt32(System.Console.ReadLine());
Console.Write("Input maxValue massiv: ");
int maxValue = Convert.ToInt32(System.Console.ReadLine());

int[] arrayZ = CreateRandomArray(size, minValue, maxValue);
ShowArray(arrayZ);
System.Console.WriteLine();
int[] array = ReversArray(arrayZ);
ShowArray(array);
*/

//Сиситемы исчисления
//______________________________________________________________
/*
18 / 2 -> 9  0      
9 / 2 -> 4  1
4 / 2 -> 2  0
2 / 2 -> 1  0
1 / 2 -> 0  1
18 = 10010
Итог читаем получив ноль в первом столбце и читаем снизу вверх
*/
/*
string ChangeDigitSystem(int num)
{
    string resultNumber = string.Empty;

    while (num > 0)
    {
        resultNumber = num % 2 + resultNumber;
        num /= 2;
    }
    return resultNumber;
}

System.Console.WriteLine(ChangeDigitSystem(20));
*/


// Задача. Написать программу которая принимает на вход три числа и 
//проверяет может ли существовать треугольник со сторонами такой длинны
//_____________________________________________________________________
/*
void TriaglePossible(int a, int b, int c)
{
    if (a + b >= c && a + c >= b && b + c >= a)
        Console.WriteLine("Triangle possible");
    else
        Console.WriteLine("Triangle impossible"); 
}

System.Console.WriteLine("Input side a: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input side b: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input side c: ");
int c = Convert.ToInt32(Console.ReadLine());

TriaglePossible(a, b, c);
*/
//Без использования рекурсии вывести первые N чисел фибоначи 
//учитывая что первые два из них ноль и единица.
//_____________________________________________________________________

int[] Fibonacci(int n)
{
    int[] newArray = new int[n];
    Console.WriteLine("Create array here: ");
    newArray[0] = 0;
    newArray[1] = 1;
    for (int i = 2; i < n; i++)
    {
        newArray[i] = newArray[i - 1] + newArray[i - 2];
        
    }
    return newArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        
    }
}
Console.Write("Input number Fibonacci: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowArray(Fibonacci(num));

