/*int num1, num2, quad;

Console.Write("Input a first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

quad = num2 * num2;

if(quad == num1)
{
    Console.WriteLine("First number is quad of second number");
}
else
{
    Console.WriteLine("First number is not second number");
}

/*
Задача1. Напишите програмиму которая выдает название дня недели
по заданному номеру.

 int day;

Console.Write("Input number: ");
day = Convert.ToInt32(Console.ReadLine()); 

if (day == 1)
    System.Console.WriteLine("Понедельник ");
if (day == 2)
    System.Console.WriteLine("Вторник ");
if (day == 3)
    System.Console.WriteLine("Среда ");
if (day == 4)
    System.Console.WriteLine("Четверг ");
if (day == 5)
    System.Console.WriteLine("Пятница ");
if (day == 6)
    System.Console.WriteLine("Субота ");    
if (day == 7)
    System.Console.WriteLine("Воскресенье ");

Задача2. Напишите программу которая принимает число и 
выдает квадрат этого числа


int a;

Console.Write("Input number: ");
a = Convert.ToInt32(Console.ReadLine()); 

int quad = a * a;
System.Console.WriteLine(quad);

Задача3. Написать программу которая принимает на вход одно число а на 
выходе показывает все целые числа в промежутке от -n до n
*/

int n, Current;
Console.Write("Input number: ");
n= Convert.ToInt32(Console.ReadLine());

Current = n * (-1);
while(Current <= n)
{


System.Console.Write(Current +" ");
Current++;
}