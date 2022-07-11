/*Напишите программу, которая принимает на вход число (А) и 
выдаёт сумму чисел от 1 до А.
*/
/*
int FindSum(int a)
{
    int sum = 0;

    for (int curent = 1; curent <= a; curent++)
        sum += curent;

    return sum;
}

Console.WriteLine("Inputpositive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of numbers from 1 to {num} is {FindSum(num)}");

/*
____________________________________________________________________________
Напишите программу, которая принимает на вход число и выдаёт 
количество цифр в числе.
*/
/*
int FindDigit(int a)
{
    int current = 0;

    for (current = 0; a > 0; current++)
    {
        a /= 10;
    }
    return current;
}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(FindDigit(num));

/*
___________________________________________________________________________
Напишите программу, которая принимает на вход число N и выдаёт 
произведение чисел от 1 до N.
*/
/*
int Proizvedenie(int N)
{
    int sum = 0;
    int current = 0;
    while (current <= N)
    {
        sum = sum + current * current;
        current++;
    }
    return sum;
}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Proizvedenie(num));



/*
____________________________________________________________________________
Напишите программу, которая принимает на вход два числа (A и B) 
и возводит число A возведенное в натуральную степень B
*/

int Step(int a, int b)
{
    int sum = 1;
    for (int current = 0; current <= b; current++)
    {
        sum = sum * a;
    }
    return sum;
}

System.Console.WriteLine("Input number a: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number b: ");
int b = Convert.ToInt32(Console.ReadLine());
int num = Step(a, b);
System.Console.WriteLine("Is a from dergee b " + num);