/*
Задача1.
Написать программу которая принимает на вход номер четверти и отображает
диапозон координат которые могут принимать точки в этой четверти.
*/
/*
void ShowQuarter(int quart)
{
    if(quart >= 1 && quart <= 4)
    {
        if(quart == 1) Console.WriteLine("In this quard x > 0 and y > 0");
        if(quart == 2) Console.WriteLine("In this quard x < 0 and y > 0");
        if(quart == 3) Console.WriteLine("In this quard x < 0 and y < 0");
        if(quart == 4) Console.WriteLine("In this quard x > 0 and y < 0");
    }
    else
        System.Console.WriteLine("This number is uncorrect!");
}

Console.WriteLine("Input number of quard: ");
int numQuard = Convert.ToInt32(Console.ReadLine());

ShowQuarter(numQuard);


*/
/*____________________________________________________________________________
Написать программу которая принимает координаты точек и
 выдает номер четверти в которой эта точка находится.
 */

int ShowQuart(int x, int y)
{
    int quart = 0;
    if (x != 0 && y != 0)
    {
        if (x > 0 && y > 0) quart = 1;
        if (x > 0 && y < 0) quart = 2;
        if (x < 0 && y < 0) quart = 3;
        if (x < 0 && y > 0) quart = 4;
    }
    return quart;
}
Console.WriteLine("Input num x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input num y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ShowQuart(x, y));



/*
_____________________________________________________________________________
Задача3. Написать программу которая принимает число N и возвращает
квадраты всех чисел до N
*/
/*
void Quad(int n)
{
    int quad;
    int curent = 1;
    if (n == 0) Console.Write(-1);
    while (curent <= n)
    {
        quad = curent * curent;
        Console.Write(quad + " ");
        curent++;
    }
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

QuadNum(n);
*/
