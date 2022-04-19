// Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек этой четверти (x и y) 

// Чтобы выделить сразу весь текст - использовать /* и */ без // на каждой строке

/*Console.Write("Enter quater from 1 to 4: ");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter == 1)
{
    Console.WriteLine("range of coordinates for X from 0 to +infinity");
    Console.WriteLine("range of coordinates for Y from 0 to +infinity");
}
if (quarter == 2)
{
    Console.WriteLine("range of coordinates for X from -infinity to 0");
    Console.WriteLine("range of coordinates for Y from 0 to +infinity");
}
if (quarter == 3)
{
    Console.WriteLine("range of coordinates for X from -infinity to 0");
    Console.WriteLine("range of coordinates for Y from -infinity to 0");
}
if (quarter == 4)
{
    Console.WriteLine("range of coordinates for X from 0 to +infinity");
    Console.WriteLine("range of coordinates for Y from -infinity to 0");
}
if (quarter < 1 || quarter > 4)
{
    Console.WriteLine("Enter correct number of quarter");
}
*/

//решение 2
Console.Write("Enter quater from 1 to 4: ");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter < 1 || quarter > 4)
{
    Console.WriteLine("Enter correct number of quarter");
    return;
}
GetCoordinates(quarter);
//метод
void GetCoordinates(int quater)
{
    if (quarter == 1)
    {
        Console.WriteLine($"X = from 1 to + {Int64.MaxValue} \nY = from 1 to +{Int64.MaxValue}"); //\nY - это перенос на новую строку. вместо Y можно указать любое значение
        Console.WriteLine("range of coordinates for Y from 0 to +infinity");
    }
    if (quarter == 2)
    {
        Console.WriteLine($"X = from -{Int64.MaxValue} to 0 \nY = from 0 to +{Int64.MaxValue}");
    }
    if (quarter == 3)
    {
        Console.WriteLine($"X = from {Int64.MaxValue} to 0 \nY = from -{Int64.MaxValue} to 0");
    }
    if (quarter == 4)
    {
        Console.WriteLine($"X = from 0 to +{Int64.MaxValue} \nY = -{Int64.MaxValue} to 0");
    }
}