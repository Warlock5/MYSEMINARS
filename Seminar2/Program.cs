/*
Задача1. Написать программу которая выводит случайное трехзначное число
и удаляет вторую цифру этого цисла



int CutNumbr()
{
    int num = new Random().Next(100, 1000);
    System.Console.WriteLine("Curent random number is " + num);

    int digit1 = num / 100;
    int digit3 = num % 10;
    int result = digit1 * 10+ digit3;
    return result;
}

int number = CutNumbr();
System.Console.WriteLine("Result number is " + number);
*/

//______________________________________________________________________

/*
void CutNumbr()
{
    int num = new Random().Next(100, 1000);
    System.Console.WriteLine("Curent random number is " + num);

    int digit1 = num / 100;
    int digit3 = num % 10;
    int result = digit1 * 10+ digit3;
    Console.WriteLine("Result number is " + result);
}
CutNumbr();
*/
/* Задача1. Написать  программу которая выводит случайное число из отрезка
 от 10 до 99 и показывает наибольшую цифру из этого числа. (int)
*/
/*
int RandomDigit()
{
    int result;
    int chislo = new Random().Next(10, 100);
    System.Console.WriteLine("Random number: " + chislo );

    int digit1 = chislo % 10; 
    int digit2 = chislo / 10;

    if(digit1 == digit2)
    {
        result = -1;
        return result;
    }
    if(digit1 < digit2 )
    { 
         result = digit2;
         return result;
    }
    else
    {  
         result = digit1;
         return result;
    }
}
int number = RandomDigit();
System.Console.WriteLine("max random number" + number); 
*/
/*
 Задача2. Написать программу которая принимает на вход число и проверяет
 кратно ли оно 7 и 23. (void)

void DigitMultipe()
{
    int num;
    System.Console.WriteLine("Input number: ");
    num = Convert.ToInt32(Console.ReadLine());

    if (num % 7 == 0 && num % 23 == 0)
    System.Console.WriteLine("Is number multiple 7 and 23");
    else
    System.Console.WriteLine("Number is not multiple 7 and 23"); 
}
DigitMultipe();

 Задача3. Написать программу котая принимает на вход два числа и проверяет
 является ли первое число квадратом второго.
 */
  
void NumQuad()
{
int a, b, quad;
 
Console.WriteLine("Input number a: "); 
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number b: "); 
b = Convert.ToInt32(Console.ReadLine());
 quad = b * b;
 if(a == quad)
 Console.WriteLine("Number a is quad number b ");
else
System.Console.WriteLine("Number a is not quad number b ");
}
NumQuad();