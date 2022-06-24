
int day;

Console.Write("Input number day: ");
day = Convert.ToInt32(Console.ReadLine());

if(day == 1)
  {
      Console.WriteLine("Today is monday");
  }
  if(day == 2)
  {
      Console.Write("Today is tuesday");
  }
  if(day == 3)
  {
      Console.Write("Today is wednesday");
  }
  if(day == 4)
  {
      Console.Write("Today is thursday");
  }
  if(day == 5)
  {
      Console.Write("Today is friday");
  }
  if(day == 6)
  {
      Console.Write("Today is saturday");
  }
  if(day == 7)
  {
      Console.Write("Today is sunday");
  }
  if(day > 7)
   {
     Console.Write("Not Found");
   }