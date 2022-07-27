/*
Задайте значение N. Напишите программу, которая выведет все натуральные 
числа в промежутке от 1 до N.
*/
/*
void ShowNums(int n)
{
    if (n > 1)
    {
        Console.Write(n + " ");
        ShowNums(n - 1);

    }
    Console.Write(n + " ");  // Принцип матрешки, сперва разобрать, 
}                            // потом собрать

ShowNums(5);
*/

/*
Напишите программу, которая будет принимать на вход число и 
возвращать сумму его цифр.
*/

/*
int SumOfDigit(int n)
{
    if(n >= 10)
    {
        return n % 10 + SumOfDigit(n / 10);
    }
    return n;
}
// 12345 -> 1234 ->123 -> 12 -> 1
// 5 + 4 + 3 + 2 + 1
ShowNums(5);
System.Console.WriteLine();
*/

/*
Задайте значения M и N. Напишите программу, которая выведет все 
натуральные числа в промежутке от M до N.
*/
/*
void ShowNums(int n, int m)
{
    if(n> m)
        ShowNums(n -1, m);
    Console.Write(n + " ");    
}
ShowNums(10, 5);
Console.WriteLine();
*/

/*
Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.

*/

int SumOfDigits(int a, int b)
{
    if (b > 1)
    {
        return a * SumOfDigits(a, b - 1);
    }
    return a;

}
Console.WriteLine("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());
int res = SumOfDigits(a, b);
Console.WriteLine(res);

