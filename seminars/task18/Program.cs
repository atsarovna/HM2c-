// Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек этой четверти (x и y)

/* Решение через string (строку)
Console.Write("Enter quadrant: ");
int a = Convert.ToInt32(Console.ReadLine()); //a - номер четверти/квадранта

string result = getCoordinates(a);
Console.WriteLine("This point is in coordinates: " + result);

if (a == 0 && a > 4) {
   Console.WriteLine("Enter quadrant from 1 to 4");
} else {
  Console.WriteLine("This point is in coordinates: " + c);
}

string getCoordinates(int a)
{
   if (a == 1)
       return "x > 0, y > 0";
 if (a == 2)
       return "x < 0, y > 0";
  if (a == 3)
       return "x < 0, y < 0";
  if (a == 4)
      return "x > 0, y < 0";

  return "Enter quadrant from 1 to 4";
} */

// через void, но с int. Функция ничего не возвращает, поэтому return не нужен
Console.Write("Enter quadrant: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 0 && a < 5)
    Console.Write("This point is in coordinates: ");
else
    Console.Write("Enter quadrant from 1 to 4");

getCoordinates(a);
void getCoordinates(int a)
{
    if (a == 1)
    {
        Console.WriteLine("x > 0, y > 0");
    }
    else if (a == 2)
    {
        Console.WriteLine("x > 0, y > 0");
    }
    else if (a == 3)
    {
        Console.WriteLine("x < 0, y < 0");
    }
    else if (a == 4)
    {
        Console.WriteLine("x > 0, y < 0");
    }
}